using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ZappCash.classes;
using ZappCash.database;

namespace ZappCash
{
    static class FileManager
    {
        public static void OpenFile()
        {
            DatabaseIntegrityCheck();

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "ZappCash Files (*.zappcash)|*.zappcash";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string filePath = dlg.FileName;
                fileRecord accessFile = new fileRecord(filePath);
                db_ZappCash.AccessFile = accessFile; //export to database

                CreateTempFile();
                Read();
            }
        }

        private static void CreateTempFile()
        {
            DatabaseIntegrityCheck();

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
            DatabaseIntegrityCheck();

            string tempFilePath = db_ZappCash.TempFile.Path;

            if (tempFilePath == null)
            {
                SaveAs();
                return;
            }

            List<Account> accounts = db_ZappCash.Accounts;

            string jsonSerialized = JsonConvert.SerializeObject(accounts);

            File.WriteAllText(path: tempFilePath, contents: jsonSerialized);
        }

        public static void Save()
        {
            DatabaseIntegrityCheck();

            string accessFilePath = db_ZappCash.AccessFile.Path; //import from database

            if (accessFilePath == null)
            {
                SaveAs();
                return;
            }

            TempSave();

            string tempFilePath = db_ZappCash.TempFile.Path;
            File.Copy(tempFilePath, accessFilePath, true);
        }

        public static void SaveAs()
        {
            DatabaseIntegrityCheck();

            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "ZappCash Files (*.zappcash)|*.zappcash";
            dlg.DefaultExt = "zappcash";
            dlg.AddExtension = true;

            string tempFilePath = db_ZappCash.TempFile.Path;
            string accessFilePath = null;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                accessFilePath = dlg.FileName;
                db_ZappCash.AccessFile = new fileRecord(accessFilePath);
            }
            else { return; }

            if (db_ZappCash.TempFile.Path != null)
            {
                TempSave();
                File.Copy(tempFilePath, accessFilePath, true);

                return;
            }

            if (db_ZappCash.TempFile.Path == null)
            {
                List<Account> accounts = db_ZappCash.Accounts;
                string jsonSerialized = JsonConvert.SerializeObject(accounts);
                File.WriteAllText(path: tempFilePath, contents: jsonSerialized);
                TempSave();
                return;
            }
        }

        private static void Read()
        {
            string filePath = db_ZappCash.TempFile.Path; //import from database

            List<Account> accounts = JsonConvert.DeserializeObject<List<Account>>(File.ReadAllText(filePath));

            db_ZappCash.Accounts = accounts; //export to database
        }

        private static void DatabaseIntegrityCheck()
        {
            db_ZappCash.CheckIntegrity();
        }

        public static void ReloadDefaults()
        {
            string rootDirectory = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string rootPath = Path.GetDirectoryName(rootDirectory);
            string configPath = @"data\ZappCash.config";
            configPath = System.IO.Path.Combine(rootPath, configPath);

            defaults defaults = JsonConvert.DeserializeObject<defaults>(File.ReadAllText(configPath));

            db_ZappCash.Defaults = defaults; //export to database
        }

    }

}
