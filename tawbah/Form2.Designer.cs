namespace tawbah
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.khorodj = new System.Windows.Forms.PictureBox();
            this.tamma = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.khorodj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamma)).BeginInit();
            this.SuspendLayout();
            // 
            // khorodj
            // 
            this.khorodj.BackColor = System.Drawing.SystemColors.Control;
            this.khorodj.BackgroundImage = global::tawbah.Properties.Resources.khorodj;
            this.khorodj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.khorodj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.khorodj.Location = new System.Drawing.Point(114, 397);
            this.khorodj.Name = "khorodj";
            this.khorodj.Size = new System.Drawing.Size(237, 49);
            this.khorodj.TabIndex = 0;
            this.khorodj.TabStop = false;
            this.khorodj.Click += new System.EventHandler(this.khorodj_Click);
            this.khorodj.MouseEnter += new System.EventHandler(this.khorodj_MouseEnter);
            this.khorodj.MouseLeave += new System.EventHandler(this.khorodj_MouseLeave);
            // 
            // tamma
            // 
            this.tamma.BackgroundImage = global::tawbah.Properties.Resources.tamma2;
            this.tamma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tamma.Location = new System.Drawing.Point(-3, -3);
            this.tamma.Name = "tamma";
            this.tamma.Size = new System.Drawing.Size(469, 457);
            this.tamma.TabIndex = 1;
            this.tamma.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(465, 453);
            this.Controls.Add(this.khorodj);
            this.Controls.Add(this.tamma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تمّ حجب المواقع";
            ((System.ComponentModel.ISupportInitialize)(this.khorodj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tamma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox khorodj;
        private System.Windows.Forms.PictureBox tamma;
    }
}