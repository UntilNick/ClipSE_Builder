using System;
using System.Text;

namespace ClipPurSEditionBuilder
{
    public class EncryptKey
    {
        /// <summary>
        /// Метод для шифрования строки
        /// </summary>
        /// <param name="input">Входные данные</param>
        /// <param name="key">Ключ</param>
        /// <returns>Зашифрованная строка</returns>
        public static string Encrypt(string input, string key)
        {
            string result = string.Empty;
            byte[] bytes = null;
            if (string.IsNullOrWhiteSpace(input))
            {
                return result;
            }

            try
            {
                bytes = Encoding.UTF8.GetBytes(input);
                for (int i = 0; i < bytes.Length; i++)
                {
                    bytes[i] = (byte)(bytes[i] ^ key[i % key.Length]);
                }
                result = $"#{Convert.ToBase64String(bytes)}";
            }
            catch { } return result;
        }

        /// <summary>
        /// Метод для расшифрования строки
        /// </summary>
        /// <param name="input">Входные данные</param>
        /// <param name="key">Ключ</param>
        /// <returns>Расшифрованная строка</returns>
        public static string Decrypt(string input, string key)
        {
            string Result = string.Empty;
            if (!input.StartsWith("#") && string.IsNullOrWhiteSpace(input))
            {
                return Result;
            }

            try
            {
                input = input.Remove(0, 1);
                //input = input.Replace("#", "");
                byte[] bytes = Convert.FromBase64String(input);
                for (int i = 0; i < bytes.Length; i++)
                {
                    bytes[i] = (byte)(bytes[i] ^ key[i % key.Length]);
                }
                Result = Encoding.UTF8.GetString(bytes);
            }
            catch { }
            return Result;
        }
    }
}