using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using ZappCash.classes;
using ZappCash.database;
using ZappCash.packages.encryption;

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
                SaveBackup();
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
                //SaveAs();
                return;
            }

            List<Account> accounts = db_ZappCash.Accounts;

            string jsonSerialized = JsonConvert.SerializeObject(accounts);

            File.WriteAllText(path: tempFilePath, contents: AdvancedEncryptionStandard.Encrypt(jsonSerialized));

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
            dlg.FileName = "Untitled";
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
                File.WriteAllText(path: accessFilePath, contents: AdvancedEncryptionStandard.Encrypt(jsonSerialized));
                CreateTempFile();
                return;
            }
        }

        private static void Read()
        {
            string filePath = db_ZappCash.TempFile.Path; //import from database

            string fileContent = File.ReadAllText(filePath);

            List<Account> accounts = JsonConvert.DeserializeObject<List<Account>>(AdvancedEncryptionStandard.Decrypt(fileContent));

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

            zc_Defaults defaults = JsonConvert.DeserializeObject<zc_Defaults>(File.ReadAllText(configPath));

            db_ZappCash.Defaults = defaults; //export to database
        }

        public static void TempDelete()
        {
            db_ZappCash.CheckIntegrity();
            string tempPath = db_ZappCash.TempFile.Path;
            if (File.Exists(tempPath))
            {
                File.Delete(tempPath);
            }
        }

        public static void SaveBackup()
        {
            return;
            
            DatabaseIntegrityCheck();

            string tempFilePath = db_ZappCash.AccessFile.Path; //import from database
            string accessFilePath = db_ZappCash.AccessFile.Path;
            string accessFileExpention = db_ZappCash.AccessFile.Extension;

            string autoSaveDate = $"{DateTime.Now.ToString("yyyyMMddHHmmss")}";

            string autoSavePath = $"{accessFilePath}.{autoSaveDate}{accessFileExpention}";

            File.Copy(tempFilePath, autoSavePath, true);
        }

        public static void ResetDatabase()
        {
            db_ZappCash.Reset();
        }
    }
}
