using System;
using System.Windows.Forms;
using ClipPurSEditionBuilder.License;

namespace ClipPurSEditionBuilder.ControlsSE
{
    public partial class LicenSE : UserControl
    {
        public LicenSE()
        {
            CheckerKeys.GetLicenseInfo();
            InitializeComponent();
        }

        private void LicenSE_Load(object sender, EventArgs e) => this.UserText.Text = string.Join("\r\n", CheckerKeys.listkey);
    }
}