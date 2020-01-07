namespace ClipPurSEditionBuilder.ControlsSE
{
    partial class LicenSE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenSE));
            this.LogoViewer = new System.Windows.Forms.PictureBox();
            this.InfoText = new System.Windows.Forms.Label();
            this.LinePanel = new System.Windows.Forms.Panel();
            this.UserText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LogoViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoViewer
            // 
            resources.ApplyResources(this.LogoViewer, "LogoViewer");
            this.LogoViewer.Image = global::ClipPurSEditionBuilder.Properties.Resources.Logo;
            this.LogoViewer.Name = "LogoViewer";
            this.LogoViewer.TabStop = false;
            // 
            // InfoText
            // 
            resources.ApplyResources(this.InfoText, "InfoText");
            this.InfoText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InfoText.Name = "InfoText";
            // 
            // LinePanel
            // 
            resources.ApplyResources(this.LinePanel, "LinePanel");
            this.LinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LinePanel.Name = "LinePanel";
            // 
            // UserText
            // 
            resources.ApplyResources(this.UserText, "UserText");
            this.UserText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UserText.Name = "UserText";
            // 
            // LicenSE
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.UserText);
            this.Controls.Add(this.InfoText);
            this.Controls.Add(this.LinePanel);
            this.Controls.Add(this.LogoViewer);
            this.Name = "LicenSE";
            this.Load += new System.EventHandler(this.LicenSE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoViewer;
        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.Panel LinePanel;
        private System.Windows.Forms.Label UserText;
    }
}
