using System.IO;
using System.Text;
using ClipPurSEditionBuilder.Sticks;

namespace ClipPurSEditionBuilder.Mod
{
    public static class Project
    {
        private static readonly StringBuilder Builder = new StringBuilder();

        public static void Inizialize(string basedir, string buildname)
        {
            Builder.Clear();
            string combinepath = FileControl.CombinePath(basedir, buildname);

            Builder.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>"); // Задаём параметры для xml разметки
            Builder.AppendLine($@"<project outputDir=""Obfuscated"" baseDir=""{basedir}"" xmlns=""http://confuser.codeplex.com"">"); // Входная папка и выходная
            Builder.AppendLine("  <rule pattern=\"true\" inherit=\"false\">");
            Builder.AppendLine("   <protection id=\"constants\" />");
            Builder.AppendLine("   <protection id=\"ctrl flow\" />");
            Builder.AppendLine("   <protection id=\"ref proxy\" />");
            Builder.AppendLine("   <protection id=\"rename\" />");
            Builder.AppendLine("   <protection id=\"anti ildasm\" />");
            Builder.AppendLine("   <protection id=\"anti debug\" />");
            Builder.AppendLine("   <protection id=\"anti tamper\" />");
            Builder.AppendLine("   <protection id=\"invalid metadata\" />");
            Builder.AppendLine("   <protection id=\"resources\" />");
            Builder.AppendLine("  </rule>");
            Builder.AppendLine($@"  <module path=""{combinepath}"" />"); // Сам модуль файла который нужно шифровать
            Builder.AppendLine("</project>");

            if (FileControl.ExistsDirectory(GlobalPath.ModConfuser))
            {
                FileControl.CreateFile(GlobalPath.Config, Builder.ToString());
                FileControl.HideFile(GlobalPath.Config, FileAttributes.Hidden);
                if (FileControl.ExistsFile(GlobalPath.Config))
                {
                    ProcessControl.RunCLI(GlobalPath.CLI, GlobalPath.Config);
                    Clean(combinepath);
                }
            }
            else
            {
                Clean(combinepath);
            }
        }

        private static void Clean(string inputfile)
        {
            if (FileControl.ExistsDirectory(GlobalPath.Confused))
            {
                FileControl.FileDelete(inputfile);
                if (!FileControl.ExistsFile(GlobalPath.Config))
                {
                    return;
                }
                else
                {
                    FileControl.HideFile(GlobalPath.Config, FileAttributes.Normal);
                    FileControl.FileDelete(GlobalPath.Config);
                    FileControl.FileDelete(GlobalPath.SysbolsMap);
                }
            }
        }
    }
}