namespace ClipPurSEditionBuilder.ControlsSE
{
    partial class UpdateSE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSE));
            this.InfoText = new System.Windows.Forms.Label();
            this.LinePanel = new System.Windows.Forms.Panel();
            this.CheckUpdates = new System.Windows.Forms.Button();
            this.VerNow = new System.Windows.Forms.Label();
            this.VerNew = new System.Windows.Forms.Label();
            this.ShowMessage = new System.Windows.Forms.Label();
            this.DownloadUpdates = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Label();
            this.ShowMessageGetSE = new System.Windows.Forms.Label();
            this.ShowMessageDownload = new System.Windows.Forms.Label();
            this.Launch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // CheckUpdates
            // 
            this.CheckUpdates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(86)))), ((int)(((byte)(154)))));
            this.CheckUpdates.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.CheckUpdates, "CheckUpdates");
            this.CheckUpdates.ForeColor = System.Drawing.Color.White;
            this.CheckUpdates.Name = "CheckUpdates";
            this.CheckUpdates.TabStop = false;
            this.CheckUpdates.UseVisualStyleBackColor = false;
            this.CheckUpdates.Click += new System.EventHandler(this.CheckVersionButton_Click);
            // 
            // VerNow
            // 
            resources.ApplyResources(this.VerNow, "VerNow");
            this.VerNow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VerNow.Name = "VerNow";
            // 
            // VerNew
            // 
            resources.ApplyResources(this.VerNew, "VerNew");
            this.VerNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.VerNew.Name = "VerNew";
            // 
            // ShowMessage
            // 
            resources.ApplyResources(this.ShowMessage, "ShowMessage");
            this.ShowMessage.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ShowMessage.Name = "ShowMessage";
            // 
            // DownloadUpdates
            // 
            this.DownloadUpdates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(86)))), ((int)(((byte)(154)))));
            this.DownloadUpdates.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.DownloadUpdates, "DownloadUpdates");
            this.DownloadUpdates.ForeColor = System.Drawing.Color.White;
            this.DownloadUpdates.Name = "DownloadUpdates";
            this.DownloadUpdates.TabStop = false;
            this.DownloadUpdates.UseVisualStyleBackColor = false;
            this.DownloadUpdates.Click += new System.EventHandler(this.DownloadUpdates_ClickAsync);
            // 
            // Info
            // 
            resources.ApplyResources(this.Info, "Info");
            this.Info.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Info.Name = "Info";
            // 
            // ShowMessageGetSE
            // 
            resources.ApplyResources(this.ShowMessageGetSE, "ShowMessageGetSE");
            this.ShowMessageGetSE.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ShowMessageGetSE.Name = "ShowMessageGetSE";
            // 
            // ShowMessageDownload
            // 
            resources.ApplyResources(this.ShowMessageDownload, "ShowMessageDownload");
            this.ShowMessageDownload.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.ShowMessageDownload.Name = "ShowMessageDownload";
            // 
            // Launch
            // 
            this.Launch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(86)))), ((int)(((byte)(154)))));
            this.Launch.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.Launch, "Launch");
            this.Launch.ForeColor = System.Drawing.Color.White;
            this.Launch.Name = "Launch";
            this.Launch.TabStop = false;
            this.Launch.UseVisualStyleBackColor = false;
            this.Launch.Click += new System.EventHandler(this.Launch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClipPurSEditionBuilder.Properties.Resources.UpdaterPicture;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // UpdateSE
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Launch);
            this.Controls.Add(this.ShowMessageDownload);
            this.Controls.Add(this.ShowMessageGetSE);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.DownloadUpdates);
            this.Controls.Add(this.ShowMessage);
            this.Controls.Add(this.VerNew);
            this.Controls.Add(this.VerNow);
            this.Controls.Add(this.CheckUpdates);
            this.Controls.Add(this.LinePanel);
            this.Controls.Add(this.InfoText);
            this.DoubleBuffered = true;
            this.Name = "UpdateSE";
            this.Load += new System.EventHandler(this.UpdateSE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.Panel LinePanel;
        private System.Windows.Forms.Button CheckUpdates;
        private System.Windows.Forms.Label VerNow;
        private System.Windows.Forms.Label VerNew;
        private System.Windows.Forms.Label ShowMessage;
        private System.Windows.Forms.Button DownloadUpdates;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label ShowMessageGetSE;
        private System.Windows.Forms.Label ShowMessageDownload;
        private System.Windows.Forms.Button Launch;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
