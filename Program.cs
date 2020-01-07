using System;
using System.Threading;
using System.Windows.Forms;
using ClipPurSEditionBuilder.License;
using ClipPurSEditionBuilder.Properties;
using ClipPurSEditionBuilder.Sticks;

namespace ClipPurSEditionBuilder
{
    internal static class Program
    {
        [STAThread]
        public static void Main()
        {
            if (!AntiVM.GetCheckVMBot())
            {
                // Если запущена копия программы, закрываем её!
                if (RunCheck.InstanceCheck())
                {
                    // Запускаем антисниффер 
                    new Thread(() => { AntiSniffer.Inizialize(); }).Start();

                    // Проверяем подключение к интернет ресурсу
                    if (INetConnect.Inizialize(EncryptKey.Decrypt(GlobalPath.UrlCheck, GlobalPath.SecretKey_Public)))
                    {
                        // Проверяем ключ доступа к программе
                        if (!CheckerKeys.CompareKey())
                        {
                            MusicPlay.Inizialize(Resources.Error_Build);
                            Thread.Sleep(500);
                            if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("en", StringComparison.InvariantCultureIgnoreCase))
                            {
                                FileControl.CreateFile("Clip_Key.txt", $"Your key to access the program: {HardwareID.GET_ID}\r\nSend this key to the developer for activation.\r\n");
                            }
                            else
                            {
                                FileControl.CreateFile("Clip_Key.txt", $"Ваш ключ для доступа к программе: {HardwareID.GET_ID}\r\nЭтот ключ скиньте разработчику для активации.\r\n");
                            }
                        }
                        else
                        {
                            CheckerKeys.GetLicenseInfo();
                            Application.Run(new ClipPurseFrm());
                        }
                    }
                    else
                    {
                        MusicPlay.Inizialize(Resources.Error_Build);
                        Thread.Sleep(500);
                        if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("en", StringComparison.InvariantCultureIgnoreCase))
                        {
                            FileControl.CreateFile("Connection_Error.txt", "No Internet connection, check your network connection, and try again.\r\n");
                        }
                        else
                        {
                            FileControl.CreateFile("Connection_Error.txt", "Нет подключения к интернету, проверьте подключения к Вашей сети, и повторите попытку снова.\r\n");
                        }
                    }
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("en", StringComparison.InvariantCultureIgnoreCase))
                {
                    FileControl.CreateFile("VMware.txt", "Virtual machine detected, please run the program outside this environment!");
                }
                else
                {
                    FileControl.CreateFile("VMware.txt", "Обнаружена виртуальная машина, пожалуйста, запустите программу вне этой среды!");
                }
            }
        }
    }
}