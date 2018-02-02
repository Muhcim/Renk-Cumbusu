namespace RenkCümbüşü
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnKırmızı = new System.Windows.Forms.Button();
            this.BtnMavi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnKırmızı
            // 
            this.BtnKırmızı.BackColor = System.Drawing.Color.Red;
            this.BtnKırmızı.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKırmızı.Location = new System.Drawing.Point(1227, -1);
            this.BtnKırmızı.Name = "BtnKırmızı";
            this.BtnKırmızı.Size = new System.Drawing.Size(82, 40);
            this.BtnKırmızı.TabIndex = 0;
            this.BtnKırmızı.Text = "Kırmızı";
            this.BtnKırmızı.UseVisualStyleBackColor = false;
            this.BtnKırmızı.Click += new System.EventHandler(this.BtnKırmızı_Click);
            // 
            // BtnMavi
            // 
            this.BtnMavi.BackColor = System.Drawing.Color.Aqua;
            this.BtnMavi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMavi.Location = new System.Drawing.Point(1313, -1);
            this.BtnMavi.Name = "BtnMavi";
            this.BtnMavi.Size = new System.Drawing.Size(82, 40);
            this.BtnMavi.TabIndex = 1;
            this.BtnMavi.Text = "Mavi";
            this.BtnMavi.UseVisualStyleBackColor = false;
            this.BtnMavi.Click += new System.EventHandler(this.BtnMavi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1400, 819);
            this.Controls.Add(this.BtnMavi);
            this.Controls.Add(this.BtnKırmızı);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnKırmızı;
        private System.Windows.Forms.Button BtnMavi;
    }
}

