namespace ClipPurSEditionBuilder.ControlsSE
{
    partial class BuildSE
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildSE));
            this.InfoText = new System.Windows.Forms.Label();
            this.LinePanel = new System.Windows.Forms.Panel();
            this.IconText = new System.Windows.Forms.Label();
            this.IcoPath = new System.Windows.Forms.TextBox();
            this.SelectIcon = new System.Windows.Forms.Button();
            this.BuildText = new System.Windows.Forms.Label();
            this.NameOutput = new System.Windows.Forms.TextBox();
            this.SizeIcon = new System.Windows.Forms.Label();
            this.Generation = new System.Windows.Forms.Button();
            this.ShowMessage = new System.Windows.Forms.Label();
            this.AssVerText = new System.Windows.Forms.Label();
            this.AssVerTextBox = new System.Windows.Forms.TextBox();
            this.AssGuidText = new System.Windows.Forms.Label();
            this.AssGuidTextBox = new System.Windows.Forms.TextBox();
            this.AssCompanyText = new System.Windows.Forms.Label();
            this.AssCompanyTextBox = new System.Windows.Forms.TextBox();
            this.IPLoGGeR = new System.Windows.Forms.Label();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.AssFVText = new System.Windows.Forms.Label();
            this.AssFileVerTextBox = new System.Windows.Forms.TextBox();
            this.AssCopyText = new System.Windows.Forms.Label();
            this.AssCopyrightTextBox = new System.Windows.Forms.TextBox();
            this.AssProdText = new System.Windows.Forms.Label();
            this.AssProductTextBox = new System.Windows.Forms.TextBox();
            this.AssDescText = new System.Windows.Forms.Label();
            this.AssDescriptTextBox = new System.Windows.Forms.TextBox();
            this.AssTitleText = new System.Windows.Forms.Label();
            this.AssTitleTextBox = new System.Windows.Forms.TextBox();
            this.GenAss = new System.Windows.Forms.Button();
            this.IcoViewer = new System.Windows.Forms.PictureBox();
            this.ShowHelperBuildSE = new System.Windows.Forms.ToolTip(this.components);
            this.HelperIPLogger = new System.Windows.Forms.LinkLabel();
            this.ErrorBox = new System.Windows.Forms.TextBox();
            this.FakeCheckBox = new ClipPurSEditionBuilder.Design.PurSEBox();
            this.IPLOGCheckBox = new ClipPurSEditionBuilder.Design.PurSEBox();
            this.AntiVMCheckBox = new ClipPurSEditionBuilder.Design.PurSEBox();
            this.UacOffCheckBox = new ClipPurSEditionBuilder.Design.PurSEBox();
            this.TaskMgrOffCheckBox = new ClipPurSEditionBuilder.Design.PurSEBox();
            this.SmartOffCheckBox = new ClipPurSEditionBuilder.Design.PurSEBox();
            this.AutoRunCheckBox = new ClipPurSEditionBuilder.Design.PurSEBox();
            this.GarbageCheckBox = new ClipPurSEditionBuilder.Design.PurSEBox();
            this.DelayCheckBox = new ClipPurSEditionBuilder.Design.PurSEBox();
            this.AdminCheckBox = new ClipPurSEditionBuilder.Design.PurSEBox();
            this.ShowNewAutoRunLabel = new System.Windows.Forms.Label();
            this.ErrorText = new System.Windows.Forms.Label();
            this.SpisokOut = new System.Windows.Forms.ComboBox();
            this.ExtensionText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IcoViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoText
            // 
            resources.ApplyResources(this.InfoText, "InfoText");
            this.InfoText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InfoText.Name = "InfoText";
            // 
            // LinePanel
            // 
            this.LinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            resources.ApplyResources(this.LinePanel, "LinePanel");
            this.LinePanel.Name = "LinePanel";
            // 
            // IconText
            // 
            resources.ApplyResources(this.IconText, "IconText");
            this.IconText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IconText.Name = "IconText";
            // 
            // IcoPath
            // 
            this.IcoPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.IcoPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IcoPath.ForeColor = System.Drawing.Color.AntiqueWhite;
            resources.ApplyResources(this.IcoPath, "IcoPath");
            this.IcoPath.Name = "IcoPath";
            this.IcoPath.ReadOnly = true;
            this.IcoPath.TabStop = false;
            this.ShowHelperBuildSE.SetToolTip(this.IcoPath, resources.GetString("IcoPath.ToolTip"));
            // 
            // SelectIcon
            // 
            this.SelectIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(86)))), ((int)(((byte)(154)))));
            this.SelectIcon.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.SelectIcon, "SelectIcon");
            this.SelectIcon.ForeColor = System.Drawing.Color.White;
            this.SelectIcon.Name = "SelectIcon";
            this.SelectIcon.TabStop = false;
            this.SelectIcon.UseVisualStyleBackColor = false;
            this.SelectIcon.Click += new System.EventHandler(this.SelectIcon_Click);
            // 
            // BuildText
            // 
            resources.ApplyResources(this.BuildText, "BuildText");
            this.BuildText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BuildText.Name = "BuildText";
            // 
            // NameOutput
            // 
            this.NameOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.NameOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameOutput.ForeColor = System.Drawing.Color.AntiqueWhite;
            resources.ApplyResources(this.NameOutput, "NameOutput");
            this.NameOutput.Name = "NameOutput";
            this.NameOutput.TabStop = false;
            this.ShowHelperBuildSE.SetToolTip(this.NameOutput, resources.GetString("NameOutput.ToolTip"));
            // 
            // SizeIcon
            // 
            resources.ApplyResources(this.SizeIcon, "SizeIcon");
            this.SizeIcon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SizeIcon.Name = "SizeIcon";
            // 
            // Generation
            // 
            this.Generation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(86)))), ((int)(((byte)(154)))));
            this.Generation.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Generation, "Generation");
            this.Generation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Generation.Name = "Generation";
            this.Generation.TabStop = false;
            this.Generation.UseVisualStyleBackColor = false;
            this.Generation.Click += new System.EventHandler(this.Generation_ClickAsync);
            // 
            // ShowMessage
            // 
            resources.ApplyResources(this.ShowMessage, "ShowMessage");
            this.ShowMessage.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ShowMessage.Name = "ShowMessage";
            // 
            // AssVerText
            // 
            resources.ApplyResources(this.AssVerText, "AssVerText");
            this.AssVerText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AssVerText.Name = "AssVerText";
            // 
            // AssVerTextBox
            // 
            this.AssVerTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.AssVerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssVerTextBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            resources.ApplyResources(this.AssVerTextBox, "AssVerTextBox");
            this.AssVerTextBox.Name = "AssVerTextBox";
            this.AssVerTextBox.TabStop = false;
            // 
            // AssGuidText
            // 
            resources.ApplyResources(this.AssGuidText, "AssGuidText");
            this.AssGuidText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AssGuidText.Name = "AssGuidText";
            // 
            // AssGuidTextBox
            // 
            this.AssGuidTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.AssGuidTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssGuidTextBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            resources.ApplyResources(this.AssGuidTextBox, "AssGuidTextBox");
            this.AssGuidTextBox.Name = "AssGuidTextBox";
            this.AssGuidTextBox.TabStop = false;
            // 
            // AssCompanyText
            // 
            resources.ApplyResources(this.AssCompanyText, "AssCompanyText");
            this.AssCompanyText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AssCompanyText.Name = "AssCompanyText";
            // 
            // AssCompanyTextBox
            // 
            this.AssCompanyTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.AssCompanyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssCompanyTextBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            resources.ApplyResources(this.AssCompanyTextBox, "AssCompanyTextBox");
            this.AssCompanyTextBox.Name = "AssCompanyTextBox";
            this.AssCompanyTextBox.TabStop = false;
            // 
            // IPLoGGeR
            // 
            resources.ApplyResources(this.IPLoGGeR, "IPLoGGeR");
            this.IPLoGGeR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IPLoGGeR.Name = "IPLoGGeR";
            // 
            // IPBox
            // 
            this.IPBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.IPBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IPBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            resources.ApplyResources(this.IPBox, "IPBox");
            this.IPBox.Name = "IPBox";
            this.IPBox.TabStop = false;
            this.ShowHelperBuildSE.SetToolTip(this.IPBox, resources.GetString("IPBox.ToolTip"));
            // 
            // AssFVText
            // 
            resources.ApplyResources(this.AssFVText, "AssFVText");
            this.AssFVText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AssFVText.Name = "AssFVText";
            // 
            // AssFileVerTextBox
            // 
            this.AssFileVerTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.AssFileVerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssFileVerTextBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            resources.ApplyResources(this.AssFileVerTextBox, "AssFileVerTextBox");
            this.AssFileVerTextBox.Name = "AssFileVerTextBox";
            this.AssFileVerTextBox.TabStop = false;
            // 
            // AssCopyText
            // 
            resources.ApplyResources(this.AssCopyText, "AssCopyText");
            this.AssCopyText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AssCopyText.Name = "AssCopyText";
            // 
            // AssCopyrightTextBox
            // 
            this.AssCopyrightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.AssCopyrightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssCopyrightTextBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            resources.ApplyResources(this.AssCopyrightTextBox, "AssCopyrightTextBox");
            this.AssCopyrightTextBox.Name = "AssCopyrightTextBox";
            this.AssCopyrightTextBox.TabStop = false;
            // 
            // AssProdText
            // 
            resources.ApplyResources(this.AssProdText, "AssProdText");
            this.AssProdText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AssProdText.Name = "AssProdText";
            // 
            // AssProductTextBox
            // 
            this.AssProductTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.AssProductTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssProductTextBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            resources.ApplyResources(this.AssProductTextBox, "AssProductTextBox");
            this.AssProductTextBox.Name = "AssProductTextBox";
            this.AssProductTextBox.TabStop = false;
            // 
            // AssDescText
            // 
            resources.ApplyResources(this.AssDescText, "AssDescText");
            this.AssDescText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AssDescText.Name = "AssDescText";
            // 
            // AssDescriptTextBox
            // 
            this.AssDescriptTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.AssDescriptTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssDescriptTextBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            resources.ApplyResources(this.AssDescriptTextBox, "AssDescriptTextBox");
            this.AssDescriptTextBox.Name = "AssDescriptTextBox";
            this.AssDescriptTextBox.TabStop = false;
            // 
            // AssTitleText
            // 
            resources.ApplyResources(this.AssTitleText, "AssTitleText");
            this.AssTitleText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AssTitleText.Name = "AssTitleText";
            // 
            // AssTitleTextBox
            // 
            this.AssTitleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.AssTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AssTitleTextBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            resources.ApplyResources(this.AssTitleTextBox, "AssTitleTextBox");
            this.AssTitleTextBox.Name = "AssTitleTextBox";
            this.AssTitleTextBox.TabStop = false;
            // 
            // GenAss
            // 
            this.GenAss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(86)))), ((int)(((byte)(154)))));
            this.GenAss.FlatAppearance.BorderSize = 0;
            this.GenAss.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            resources.ApplyResources(this.GenAss, "GenAss");
            this.GenAss.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GenAss.Name = "GenAss";
            this.GenAss.TabStop = false;
            this.GenAss.UseVisualStyleBackColor = false;
            this.GenAss.Click += new System.EventHandler(this.GenAss_Click);
            // 
            // IcoViewer
            // 
            resources.ApplyResources(this.IcoViewer, "IcoViewer");
            this.IcoViewer.Name = "IcoViewer";
            this.IcoViewer.TabStop = false;
            // 
            // ShowHelperBuildSE
            // 
            this.ShowHelperBuildSE.AutomaticDelay = 100;
            this.ShowHelperBuildSE.AutoPopDelay = 2000;
            this.ShowHelperBuildSE.InitialDelay = 100;
            this.ShowHelperBuildSE.ReshowDelay = 20;
            // 
            // HelperIPLogger
            // 
            this.HelperIPLogger.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(86)))), ((int)(((byte)(154)))));
            resources.ApplyResources(this.HelperIPLogger, "HelperIPLogger");
            this.HelperIPLogger.LinkColor = System.Drawing.Color.DodgerBlue;
            this.HelperIPLogger.Name = "HelperIPLogger";
            this.HelperIPLogger.TabStop = true;
            this.ShowHelperBuildSE.SetToolTip(this.HelperIPLogger, resources.GetString("HelperIPLogger.ToolTip"));
            this.HelperIPLogger.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(86)))), ((int)(((byte)(154)))));
            this.HelperIPLogger.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HelperIPLogger_LinkClicked);
            // 
            // ErrorBox
            // 
            this.ErrorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.ErrorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ErrorBox.ForeColor = System.Drawing.Color.AntiqueWhite;
            resources.ApplyResources(this.ErrorBox, "ErrorBox");
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.TabStop = false;
            this.ShowHelperBuildSE.SetToolTip(this.ErrorBox, resources.GetString("ErrorBox.ToolTip"));
            // 
            // FakeCheckBox
            // 
            resources.ApplyResources(this.FakeCheckBox, "FakeCheckBox");
            this.FakeCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.FakeCheckBox.Name = "FakeCheckBox";
            this.FakeCheckBox.TabStop = false;
            this.ShowHelperBuildSE.SetToolTip(this.FakeCheckBox, resources.GetString("FakeCheckBox.ToolTip"));
            this.FakeCheckBox.UseVisualStyleBackColor = false;
            this.FakeCheckBox.CheckedChanged += new System.EventHandler(this.FakeCheckBox_CheckedChanged);
            // 
            // IPLOGCheckBox
            // 
            resources.ApplyResources(this.IPLOGCheckBox, "IPLOGCheckBox");
            this.IPLOGCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.IPLOGCheckBox.Name = "IPLOGCheckBox";
            this.IPLOGCheckBox.TabStop = false;
            this.ShowHelperBuildSE.SetToolTip(this.IPLOGCheckBox, resources.GetString("IPLOGCheckBox.ToolTip"));
            this.IPLOGCheckBox.UseVisualStyleBackColor = false;
            this.IPLOGCheckBox.CheckedChanged += new System.EventHandler(this.IPLOGCheckBox_CheckedChanged);
            // 
            // AntiVMCheckBox
            // 
            resources.ApplyResources(this.AntiVMCheckBox, "AntiVMCheckBox");
            this.AntiVMCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.AntiVMCheckBox.Name = "AntiVMCheckBox";
            this.AntiVMCheckBox.TabStop = false;
            this.ShowHelperBuildSE.SetToolTip(this.AntiVMCheckBox, resources.GetString("AntiVMCheckBox.ToolTip"));
            this.AntiVMCheckBox.UseVisualStyleBackColor = false;
            // 
            // UacOffCheckBox
            // 
            resources.ApplyResources(this.UacOffCheckBox, "UacOffCheckBox");
            this.UacOffCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.UacOffCheckBox.Name = "UacOffCheckBox";
            this.UacOffCheckBox.TabStop = false;
            this.ShowHelperBuildSE.SetToolTip(this.UacOffCheckBox, resources.GetString("UacOffCheckBox.ToolTip"));
            this.UacOffCheckBox.UseVisualStyleBackColor = false;
            // 
            // TaskMgrOffCheckBox
            // 
            resources.ApplyResources(this.TaskMgrOffCheckBox, "TaskMgrOffCheckBox");
            this.TaskMgrOffCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.TaskMgrOffCheckBox.Name = "TaskMgrOffCheckBox";
            this.TaskMgrOffCheckBox.TabStop = false;
            this.ShowHelperBuildSE.SetToolTip(this.TaskMgrOffCheckBox, resources.GetString("TaskMgrOffCheckBox.ToolTip"));
            this.TaskMgrOffCheckBox.UseVisualStyleBackColor = false;
            // 
            // SmartOffCheckBox
            // 
            resources.ApplyResources(this.SmartOffCheckBox, "SmartOffCheckBox");
            this.SmartOffCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.SmartOffCheckBox.Name = "SmartOffCheckBox";
            this.SmartOffCheckBox.TabStop = false;
            this.ShowHelperBuildSE.SetToolTip(this.SmartOffCheckBox, resources.GetString("SmartOffCheckBox.ToolTip"));
            this.SmartOffCheckBox.UseVisualStyleBackColor = false;
            // 
            // AutoRunCheckBox
            // 
            resources.ApplyResources(this.AutoRunCheckBox, "AutoRunCheckBox");
            this.AutoRunCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.AutoRunCheckBox.Name = "AutoRunCheckBox";
            this.AutoRunCheckBox.TabStop = false;
            this.ShowHelperBuildSE.SetToolTip(this.AutoRunCheckBox, resources.GetString("AutoRunCheckBox.ToolTip"));
            this.AutoRunCheckBox.UseVisualStyleBackColor = false;
            // 
            // GarbageCheckBox
            // 
            resources.ApplyResources(this.GarbageCheckBox, "GarbageCheckBox");
            this.GarbageCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.GarbageCheckBox.Name = "GarbageCheckBox";
            this.GarbageCheckBox.TabStop = false;
            this.ShowHelperBuildSE.SetToolTip(this.GarbageCheckBox, resources.GetString("GarbageCheckBox.ToolTip"));
            this.GarbageCheckBox.UseVisualStyleBackColor = false;
            // 
            // DelayCheckBox
            // 
            resources.ApplyResources(this.DelayCheckBox, "DelayCheckBox");
            this.DelayCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.DelayCheckBox.Name = "DelayCheckBox";
            this.DelayCheckBox.TabStop = false;
            this.ShowHelperBuildSE.SetToolTip(this.DelayCheckBox, resources.GetString("DelayCheckBox.ToolTip"));
            this.DelayCheckBox.UseVisualStyleBackColor = false;
            // 
            // AdminCheckBox
            // 
            resources.ApplyResources(this.AdminCheckBox, "AdminCheckBox");
            this.AdminCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.AdminCheckBox.Name = "AdminCheckBox";
            this.AdminCheckBox.TabStop = false;
            this.ShowHelperBuildSE.SetToolTip(this.AdminCheckBox, resources.GetString("AdminCheckBox.ToolTip"));
            this.AdminCheckBox.UseVisualStyleBackColor = false;
            this.AdminCheckBox.CheckedChanged += new System.EventHandler(this.AdminCheckBox_CheckedChanged);
            // 
            // ShowNewAutoRunLabel
            // 
            resources.ApplyResources(this.ShowNewAutoRunLabel, "ShowNewAutoRunLabel");
            this.ShowNewAutoRunLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ShowNewAutoRunLabel.Name = "ShowNewAutoRunLabel";
            // 
            // ErrorText
            // 
            resources.ApplyResources(this.ErrorText, "ErrorText");
            this.ErrorText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ErrorText.Name = "ErrorText";
            // 
            // SpisokOut
            // 
            this.SpisokOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.SpisokOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.SpisokOut, "SpisokOut");
            this.SpisokOut.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.SpisokOut.FormattingEnabled = true;
            this.SpisokOut.Items.AddRange(new object[] {
            resources.GetString("SpisokOut.Items"),
            resources.GetString("SpisokOut.Items1")});
            this.SpisokOut.Name = "SpisokOut";
            this.SpisokOut.TabStop = false;
            this.SpisokOut.SelectedIndexChanged += new System.EventHandler(this.SpisokOut_SelectedIndexChanged);
            // 
            // ExtensionText
            // 
            resources.ApplyResources(this.ExtensionText, "ExtensionText");
            this.ExtensionText.BackColor = System.Drawing.Color.Transparent;
            this.ExtensionText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExtensionText.Name = "ExtensionText";
            // 
            // BuildSE
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.ExtensionText);
            this.Controls.Add(this.SpisokOut);
            this.Controls.Add(this.ErrorBox);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.FakeCheckBox);
            this.Controls.Add(this.IPLOGCheckBox);
            this.Controls.Add(this.AntiVMCheckBox);
            this.Controls.Add(this.HelperIPLogger);
            this.Controls.Add(this.UacOffCheckBox);
            this.Controls.Add(this.TaskMgrOffCheckBox);
            this.Controls.Add(this.SmartOffCheckBox);
            this.Controls.Add(this.ShowNewAutoRunLabel);
            this.Controls.Add(this.AutoRunCheckBox);
            this.Controls.Add(this.GarbageCheckBox);
            this.Controls.Add(this.DelayCheckBox);
            this.Controls.Add(this.AdminCheckBox);
            this.Controls.Add(this.AssVerText);
            this.Controls.Add(this.AssVerTextBox);
            this.Controls.Add(this.AssGuidText);
            this.Controls.Add(this.AssGuidTextBox);
            this.Controls.Add(this.AssCompanyText);
            this.Controls.Add(this.AssCompanyTextBox);
            this.Controls.Add(this.IPLoGGeR);
            this.Controls.Add(this.IPBox);
            this.Controls.Add(this.AssFVText);
            this.Controls.Add(this.AssFileVerTextBox);
            this.Controls.Add(this.AssCopyText);
            this.Controls.Add(this.AssCopyrightTextBox);
            this.Controls.Add(this.AssProdText);
            this.Controls.Add(this.AssProductTextBox);
            this.Controls.Add(this.AssDescText);
            this.Controls.Add(this.AssDescriptTextBox);
            this.Controls.Add(this.AssTitleText);
            this.Controls.Add(this.AssTitleTextBox);
            this.Controls.Add(this.GenAss);
            this.Controls.Add(this.ShowMessage);
            this.Controls.Add(this.Generation);
            this.Controls.Add(this.SizeIcon);
            this.Controls.Add(this.IcoViewer);
            this.Controls.Add(this.NameOutput);
            this.Controls.Add(this.BuildText);
            this.Controls.Add(this.SelectIcon);
            this.Controls.Add(this.IcoPath);
            this.Controls.Add(this.IconText);
            this.Controls.Add(this.InfoText);
            this.Controls.Add(this.LinePanel);
            this.Name = "BuildSE";
            this.Load += new System.EventHandler(this.BuildSE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IcoViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.Panel LinePanel;
        private System.Windows.Forms.Label IconText;
        private System.Windows.Forms.TextBox IcoPath;
        private System.Windows.Forms.Button SelectIcon;
        private System.Windows.Forms.Label BuildText;
        private System.Windows.Forms.TextBox NameOutput;
        private System.Windows.Forms.PictureBox IcoViewer;
        private System.Windows.Forms.Label SizeIcon;
        private System.Windows.Forms.Button Generation;
        private System.Windows.Forms.Label ShowMessage;
        private System.Windows.Forms.Label AssVerText;
        private System.Windows.Forms.TextBox AssVerTextBox;
        private System.Windows.Forms.Label AssGuidText;
        private System.Windows.Forms.TextBox AssGuidTextBox;
        private System.Windows.Forms.Label AssCompanyText;
        private System.Windows.Forms.TextBox AssCompanyTextBox;
        private System.Windows.Forms.Label IPLoGGeR;
        private System.Windows.Forms.TextBox IPBox;
        private System.Windows.Forms.Label AssFVText;
        private System.Windows.Forms.TextBox AssFileVerTextBox;
        private System.Windows.Forms.Label AssCopyText;
        private System.Windows.Forms.TextBox AssCopyrightTextBox;
        private System.Windows.Forms.Label AssProdText;
        private System.Windows.Forms.TextBox AssProductTextBox;
        private System.Windows.Forms.Label AssDescText;
        private System.Windows.Forms.TextBox AssDescriptTextBox;
        private System.Windows.Forms.Label AssTitleText;
        private System.Windows.Forms.TextBox AssTitleTextBox;
        private System.Windows.Forms.Button GenAss;
        private Design.PurSEBox AdminCheckBox;
        private System.Windows.Forms.ToolTip ShowHelperBuildSE;
        private Design.PurSEBox DelayCheckBox;
        private Design.PurSEBox GarbageCheckBox;
        private Design.PurSEBox AutoRunCheckBox;
        private System.Windows.Forms.Label ShowNewAutoRunLabel;
        private Design.PurSEBox SmartOffCheckBox;
        private Design.PurSEBox TaskMgrOffCheckBox;
        private Design.PurSEBox UacOffCheckBox;
        private System.Windows.Forms.LinkLabel HelperIPLogger;
        private Design.PurSEBox AntiVMCheckBox;
        private Design.PurSEBox IPLOGCheckBox;
        private Design.PurSEBox FakeCheckBox;
        private System.Windows.Forms.Label ErrorText;
        private System.Windows.Forms.TextBox ErrorBox;
        private System.Windows.Forms.ComboBox SpisokOut;
        private System.Windows.Forms.Label ExtensionText;
    }
}
