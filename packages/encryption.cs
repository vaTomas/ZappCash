using System;
using System.IO;
using System.Security.Cryptography;

namespace ZappCash.packages.encryption
{
    class AdvancedEncryptionStandard
    {
        private static byte[] key = Convert.FromBase64String("35L5Lj6S4Q0mcUlixtEAH+zK9hXr+Oipq4VUl1jLUpU=");
        private static byte[] iv = Convert.FromBase64String("fajALgL6jxPrlGhbjL7xXQ==");

        private static byte[] EncryptStringToBytes_Aes(string plainText)
        {
            byte[] Key = key;
            byte[] IV = iv;
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        private static string DecryptStringFromBytes_Aes(byte[] cipherText)
        {
            byte[] Key = key;
            byte[] IV = iv;

            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }

        public static string Encrypt(string Original)
        {
            //return Original;

            byte[] encryptedObject = EncryptStringToBytes_Aes(Original);
            string encrypted = Convert.ToBase64String(encryptedObject);


            return encrypted;
        }

        public static string Decrypt(string Encrypted)
        {
            //return Encrypted;

            byte[] encryptedObject = Convert.FromBase64String(Encrypted);
            string decrypted = DecryptStringFromBytes_Aes(encryptedObject);


            return decrypted;
        }
    }
}