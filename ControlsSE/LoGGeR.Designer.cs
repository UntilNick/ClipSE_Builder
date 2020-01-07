namespace ClipPurSEditionBuilder.ControlsSE
{
    partial class LoGGeR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoGGeR));
            this.LinePanel = new System.Windows.Forms.Panel();
            this.InfoText = new System.Windows.Forms.Label();
            this.AddInfoText = new System.Windows.Forms.Label();
            this.AddInfoBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LinePanel
            // 
            resources.ApplyResources(this.LinePanel, "LinePanel");
            this.LinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.LinePanel.Name = "LinePanel";
            // 
            // InfoText
            // 
            resources.ApplyResources(this.InfoText, "InfoText");
            this.InfoText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.InfoText.Name = "InfoText";
            // 
            // AddInfoText
            // 
            resources.ApplyResources(this.AddInfoText, "AddInfoText");
            this.AddInfoText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddInfoText.Name = "AddInfoText";
            // 
            // AddInfoBox
            // 
            resources.ApplyResources(this.AddInfoBox, "AddInfoBox");
            this.AddInfoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.AddInfoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddInfoBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddInfoBox.Name = "AddInfoBox";
            this.AddInfoBox.ReadOnly = true;
            this.AddInfoBox.TabStop = false;
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Name = "label2";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::ClipPurSEditionBuilder.Properties.Resources.tenor;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // LoGGeR
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddInfoBox);
            this.Controls.Add(this.AddInfoText);
            this.Controls.Add(this.LinePanel);
            this.Controls.Add(this.InfoText);
            this.Name = "LoGGeR";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LinePanel;
        private System.Windows.Forms.Label InfoText;
        private System.Windows.Forms.Label AddInfoText;
        private System.Windows.Forms.TextBox AddInfoBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
