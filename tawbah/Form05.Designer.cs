namespace tawbah
{
    partial class Form05
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form05));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tahmil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahmil)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::tawbah.Properties.Resources.isdarjadid;
            this.pictureBox1.Location = new System.Drawing.Point(-14, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(438, 272);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tahmil
            // 
            this.tahmil.BackgroundImage = global::tawbah.Properties.Resources.tahmil;
            this.tahmil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tahmil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tahmil.Location = new System.Drawing.Point(126, 263);
            this.tahmil.Margin = new System.Windows.Forms.Padding(0);
            this.tahmil.Name = "tahmil";
            this.tahmil.Size = new System.Drawing.Size(159, 49);
            this.tahmil.TabIndex = 1;
            this.tahmil.TabStop = false;
            this.tahmil.Click += new System.EventHandler(this.pictureBox2_Click);
            this.tahmil.MouseEnter += new System.EventHandler(this.tahmil_MouseEnter);
            this.tahmil.MouseLeave += new System.EventHandler(this.tahmil_MouseLeave);
            // 
            // Form05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 336);
            this.Controls.Add(this.tahmil);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form05";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إصدار جديد";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahmil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox tahmil;
    }
}