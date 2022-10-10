using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

using System.IO;
using Newtonsoft.Json;

using ZappCash.database;
using ZappCash.classes;

namespace ZappCash
{
    static class FileManager
    {
        public static void OpenFile()
        {
            string filePath = "";

            {
                OpenFileDialog dlg = new OpenFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    filePath = dlg.FileName;
                }
            }

            fileRecord accessFile = new fileRecord(filePath);
            db_ZappCash.AccessFile = accessFile; //export to database

            CreateTempFile();
            Read();

        }

        private static void CreateTempFile()
        {
            fileRecord accessFile = db_ZappCash.AccessFile; //import from database
            
            string fileName = $"{accessFile.Name}.tmp";
            string fileDirectory = accessFile.Directory;

            string filePath = Path.Combine(fileDirectory, fileName);
            
            fileRecord tempFile = new fileRecord(filePath);

            File.Copy(accessFile.Path, tempFile.Path, true);

            db_ZappCash.TempFile = tempFile; //export to database
        }

        public static void TempSave()
        {
            string tempFilePath = db_ZappCash.TempFile.Path; //import from database
            List<Account> accounts = db_ZappCash.Accounts;

            string jsonSerialized = JsonConvert.SerializeObject(accounts);

            File.WriteAllText(path: tempFilePath, contents: jsonSerialized);
        }

        public static void Save()
        {
            string accessFilePath = db_ZappCash.AccessFile.Path; //import from database
            string tempFilePath = db_ZappCash.TempFile.Path;

            TempSave();

            File.Copy(tempFilePath, accessFilePath, true);
        }

        public static void SaveAs()
        {
            string filePath = "";
            {
                SaveFileDialog dlg = new SaveFileDialog();
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    filePath = dlg.FileName;
                }
            }
            db_ZappCash.AccessFile = new fileRecord(filePath);
            string tempFilePath = db_ZappCash.TempFile.Path;

            File.Copy(tempFilePath, filePath, true);

        }

        private static void Read()
        {
            string filePath = db_ZappCash.TempFile.Path; //import from database

            List<Account> accounts = JsonConvert.DeserializeObject<List<Account>>(File.ReadAllText(filePath));

            db_ZappCash.Accounts = accounts; //export to database
        }
    }
}
