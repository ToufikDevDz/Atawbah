namespace tawbah
{
    partial class Form02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form02));
            this.tamma = new System.Windows.Forms.PictureBox();
            this.nass = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tahaqoq = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahaqoq)).BeginInit();
            this.SuspendLayout();
            // 
            // tamma
            // 
            this.tamma.BackgroundImage = global::tawbah.Properties.Resources.tamma;
            this.tamma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tamma.Location = new System.Drawing.Point(-2, -2);
            this.tamma.Margin = new System.Windows.Forms.Padding(0);
            this.tamma.Name = "tamma";
            this.tamma.Size = new System.Drawing.Size(469, 457);
            this.tamma.TabIndex = 1;
            this.tamma.TabStop = false;
            // 
            // nass
            // 
            this.nass.BackColor = System.Drawing.Color.White;
            this.nass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nass.Cursor = System.Windows.Forms.Cursors.Default;
            this.nass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nass.Location = new System.Drawing.Point(59, 244);
            this.nass.Margin = new System.Windows.Forms.Padding(5);
            this.nass.Name = "nass";
            this.nass.ReadOnly = true;
            this.nass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nass.Size = new System.Drawing.Size(350, 163);
            this.nass.TabIndex = 14;
            this.nass.Text = "";
            this.nass.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.nass_LinkClicked);
            this.nass.Enter += new System.EventHandler(this.nass_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(51, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 16;
            // 
            // tahaqoq
            // 
            this.tahaqoq.BackgroundImage = global::tawbah.Properties.Resources.tahaqoqnajah;
            this.tahaqoq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tahaqoq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tahaqoq.Location = new System.Drawing.Point(135, 434);
            this.tahaqoq.Margin = new System.Windows.Forms.Padding(0);
            this.tahaqoq.Name = "tahaqoq";
            this.tahaqoq.Size = new System.Drawing.Size(195, 48);
            this.tahaqoq.TabIndex = 17;
            this.tahaqoq.TabStop = false;
            this.tahaqoq.Click += new System.EventHandler(this.tahaqoq_Click);
            this.tahaqoq.MouseEnter += new System.EventHandler(this.tahaqoq_MouseEnter);
            this.tahaqoq.MouseLeave += new System.EventHandler(this.tahaqoq_MouseLeave);
            // 
            // Form02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(465, 507);
            this.Controls.Add(this.tahaqoq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nass);
            this.Controls.Add(this.tamma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form02";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تمّت عمليّة الحجب";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.tamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tahaqoq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox tamma;
        private System.Windows.Forms.RichTextBox nass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox tahaqoq;
    }
}