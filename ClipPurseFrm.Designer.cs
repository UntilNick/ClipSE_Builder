namespace ClipPurSEditionBuilder
{
    partial class ClipPurseFrm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClipPurseFrm));
            this.UPanel = new System.Windows.Forms.Panel();
            this.VersionSoft = new System.Windows.Forms.Label();
            this.FastExit = new System.Windows.Forms.Button();
            this.LogoText = new System.Windows.Forms.Label();
            this.ControlCenterPanel = new System.Windows.Forms.Panel();
            this.ShowLogger = new System.Windows.Forms.Button();
            this.ShowUpdater = new System.Windows.Forms.Button();
            this.ShowNewWallets = new System.Windows.Forms.Button();
            this.ShowLicense = new System.Windows.Forms.Button();
            this.ShowInfo = new System.Windows.Forms.Button();
            this.ShowBuilding = new System.Windows.Forms.Button();
            this.ShowWallets = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SalutView = new System.Windows.Forms.Label();
            this.SwitchLanguage = new System.Windows.Forms.LinkLabel();
            this.UPanel.SuspendLayout();
            this.ControlCenterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UPanel
            // 
            resources.ApplyResources(this.UPanel, "UPanel");
            this.UPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.UPanel.Controls.Add(this.VersionSoft);
            this.UPanel.Controls.Add(this.FastExit);
            this.UPanel.Controls.Add(this.LogoText);
            this.UPanel.Name = "UPanel";
            // 
            // VersionSoft
            // 
            resources.ApplyResources(this.VersionSoft, "VersionSoft");
            this.VersionSoft.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VersionSoft.Name = "VersionSoft";
            // 
            // FastExit
            // 
            resources.ApplyResources(this.FastExit, "FastExit");
            this.FastExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.FastExit.FlatAppearance.BorderSize = 0;
            this.FastExit.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.FastExit.Name = "FastExit";
            this.FastExit.TabStop = false;
            this.FastExit.UseVisualStyleBackColor = false;
            this.FastExit.Click += new System.EventHandler(this.FastExit_Click);
            // 
            // LogoText
            // 
            resources.ApplyResources(this.LogoText, "LogoText");
            this.LogoText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogoText.Name = "LogoText";
            // 
            // ControlCenterPanel
            // 
            resources.ApplyResources(this.ControlCenterPanel, "ControlCenterPanel");
            this.ControlCenterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(86)))), ((int)(((byte)(154)))));
            this.ControlCenterPanel.Controls.Add(this.ShowLogger);
            this.ControlCenterPanel.Controls.Add(this.ShowUpdater);
            this.ControlCenterPanel.Controls.Add(this.ShowNewWallets);
            this.ControlCenterPanel.Controls.Add(this.ShowLicense);
            this.ControlCenterPanel.Controls.Add(this.ShowInfo);
            this.ControlCenterPanel.Controls.Add(this.ShowBuilding);
            this.ControlCenterPanel.Controls.Add(this.ShowWallets);
            this.ControlCenterPanel.Name = "ControlCenterPanel";
            // 
            // ShowLogger
            // 
            resources.ApplyResources(this.ShowLogger, "ShowLogger");
            this.ShowLogger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ShowLogger.FlatAppearance.BorderSize = 0;
            this.ShowLogger.ForeColor = System.Drawing.Color.White;
            this.ShowLogger.Name = "ShowLogger";
            this.ShowLogger.TabStop = false;
            this.ShowLogger.UseVisualStyleBackColor = false;
            this.ShowLogger.Click += new System.EventHandler(this.ShowLogger_Click);
            // 
            // ShowUpdater
            // 
            resources.ApplyResources(this.ShowUpdater, "ShowUpdater");
            this.ShowUpdater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ShowUpdater.FlatAppearance.BorderSize = 0;
            this.ShowUpdater.ForeColor = System.Drawing.Color.White;
            this.ShowUpdater.Name = "ShowUpdater";
            this.ShowUpdater.TabStop = false;
            this.ShowUpdater.UseVisualStyleBackColor = false;
            this.ShowUpdater.Click += new System.EventHandler(this.ShowUpdater_Click);
            // 
            // ShowNewWallets
            // 
            resources.ApplyResources(this.ShowNewWallets, "ShowNewWallets");
            this.ShowNewWallets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ShowNewWallets.FlatAppearance.BorderSize = 0;
            this.ShowNewWallets.ForeColor = System.Drawing.Color.White;
            this.ShowNewWallets.Name = "ShowNewWallets";
            this.ShowNewWallets.TabStop = false;
            this.ShowNewWallets.UseVisualStyleBackColor = false;
            this.ShowNewWallets.Click += new System.EventHandler(this.ShowNewWallets_Click);
            // 
            // ShowLicense
            // 
            resources.ApplyResources(this.ShowLicense, "ShowLicense");
            this.ShowLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ShowLicense.FlatAppearance.BorderSize = 0;
            this.ShowLicense.ForeColor = System.Drawing.Color.White;
            this.ShowLicense.Name = "ShowLicense";
            this.ShowLicense.TabStop = false;
            this.ShowLicense.UseVisualStyleBackColor = false;
            this.ShowLicense.Click += new System.EventHandler(this.ShowLicense_Click);
            // 
            // ShowInfo
            // 
            resources.ApplyResources(this.ShowInfo, "ShowInfo");
            this.ShowInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ShowInfo.FlatAppearance.BorderSize = 0;
            this.ShowInfo.ForeColor = System.Drawing.Color.White;
            this.ShowInfo.Name = "ShowInfo";
            this.ShowInfo.TabStop = false;
            this.ShowInfo.UseVisualStyleBackColor = false;
            this.ShowInfo.Click += new System.EventHandler(this.ShowInfo_Click);
            // 
            // ShowBuilding
            // 
            resources.ApplyResources(this.ShowBuilding, "ShowBuilding");
            this.ShowBuilding.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ShowBuilding.FlatAppearance.BorderSize = 0;
            this.ShowBuilding.ForeColor = System.Drawing.Color.White;
            this.ShowBuilding.Name = "ShowBuilding";
            this.ShowBuilding.TabStop = false;
            this.ShowBuilding.UseVisualStyleBackColor = false;
            this.ShowBuilding.Click += new System.EventHandler(this.ShowBuilding_Click);
            // 
            // ShowWallets
            // 
            resources.ApplyResources(this.ShowWallets, "ShowWallets");
            this.ShowWallets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.ShowWallets.FlatAppearance.BorderSize = 0;
            this.ShowWallets.ForeColor = System.Drawing.Color.White;
            this.ShowWallets.Name = "ShowWallets";
            this.ShowWallets.TabStop = false;
            this.ShowWallets.UseVisualStyleBackColor = false;
            this.ShowWallets.Click += new System.EventHandler(this.ShowWallets_Click);
            // 
            // MainPanel
            // 
            resources.ApplyResources(this.MainPanel, "MainPanel");
            this.MainPanel.Name = "MainPanel";
            // 
            // SalutView
            // 
            resources.ApplyResources(this.SalutView, "SalutView");
            this.SalutView.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.SalutView.Name = "SalutView";
            // 
            // SwitchLanguage
            // 
            resources.ApplyResources(this.SwitchLanguage, "SwitchLanguage");
            this.SwitchLanguage.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(86)))), ((int)(((byte)(154)))));
            this.SwitchLanguage.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.SwitchLanguage.LinkColor = System.Drawing.Color.Gray;
            this.SwitchLanguage.Name = "SwitchLanguage";
            this.SwitchLanguage.TabStop = true;
            this.SwitchLanguage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SwitchLanguage_LinkClicked);
            // 
            // ClipPurseFrm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.ControlBox = false;
            this.Controls.Add(this.SwitchLanguage);
            this.Controls.Add(this.SalutView);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ControlCenterPanel);
            this.Controls.Add(this.UPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "ClipPurseFrm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ClipPurseFrm_Load);
            this.UPanel.ResumeLayout(false);
            this.UPanel.PerformLayout();
            this.ControlCenterPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel UPanel;
        private System.Windows.Forms.Label VersionSoft;
        private System.Windows.Forms.Button FastExit;
        private System.Windows.Forms.Label LogoText;
        private System.Windows.Forms.Panel ControlCenterPanel;
        private System.Windows.Forms.Button ShowLicense;
        private System.Windows.Forms.Button ShowInfo;
        private System.Windows.Forms.Button ShowBuilding;
        private System.Windows.Forms.Button ShowWallets;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label SalutView;
        private System.Windows.Forms.Button ShowNewWallets;
        private System.Windows.Forms.Button ShowUpdater;
        private System.Windows.Forms.LinkLabel SwitchLanguage;
        private System.Windows.Forms.Button ShowLogger;
    }
}

