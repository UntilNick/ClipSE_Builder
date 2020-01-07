namespace ClipPurSEditionBuilder.License
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using ClipPurSEditionBuilder.Sticks;

    public static class CheckerKeys
    {
        public static HashSet<string> listkey = new HashSet<string>();

        public static bool CompareKey()
        {
            string MachineKey = HardwareID.GET_ID; // ключ пользователя ( машинный )
            string Url = EncryptKey.Decrypt(GlobalPath.Database, GlobalPath.SecretKey_Public); // ссылка на ключи
            string[] Data = INetConnect.GetOnlineKey(Url).Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries); // Получаем каждый ключ через новую строчку
            for (int i = 0; i < Data.Length; i++) // Проходимся в цикле
            {
                Data[i] = EncryptKey.Decrypt(Data[i], GlobalPath.SecretKey_Public); // Расшифровываем каждую строчку 
            }
            return Data.Contains(MachineKey); // Сверяем ключи
        } 

        public static void GetLicenseInfo()
        {
            listkey.Clear(); // Отчищяем все данные
            if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("ru", StringComparison.InvariantCultureIgnoreCase))
            {
                listkey.Add($"{Language.GlobalMessageStrings_ru_RU.UserName} {Environment.UserName}"); // Заносим имя пользователя
                listkey.Add($"{Language.GlobalMessageStrings_ru_RU.Key} {HardwareID.GET_ID}"); // Заносим ключ пользователя
                // Проверка ключа...
                if (CompareKey()) listkey.Add($"{Language.GlobalMessageStrings_ru_RU.LicenseActivate}");
                else listkey.Add($"{Language.GlobalMessageStrings_ru_RU.LicenseNoActivate}");
            }
            else
            {
                listkey.Add($"{Language.GlobalMessageStrings_en_US.UserName} {Environment.UserName}"); // Заносим имя пользователя
                listkey.Add($"{Language.GlobalMessageStrings_en_US.Key} {HardwareID.GET_ID}"); // Заносим ключ пользователя
                                                                                               // Проверка ключа...
                if (CompareKey()) listkey.Add($"{Language.GlobalMessageStrings_en_US.LicenseActivate}");
                else listkey.Add($"{Language.GlobalMessageStrings_en_US.LicenseActivate}");
            }
        }
    }
}