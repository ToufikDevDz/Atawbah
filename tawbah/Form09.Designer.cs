﻿namespace tawbah
{
    partial class Form09
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

        /// <summary>f
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form09));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iblagh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iblagh)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::tawbah.Properties.Resources.halmoqtarah02;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(565, 281);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // iblagh
            // 
            this.iblagh.BackColor = System.Drawing.Color.White;
            this.iblagh.BackgroundImage = global::tawbah.Properties.Resources.iblagh;
            this.iblagh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iblagh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iblagh.Location = new System.Drawing.Point(369, 146);
            this.iblagh.Margin = new System.Windows.Forms.Padding(0);
            this.iblagh.Name = "iblagh";
            this.iblagh.Size = new System.Drawing.Size(121, 40);
            this.iblagh.TabIndex = 12;
            this.iblagh.TabStop = false;
            this.iblagh.Click += new System.EventHandler(this.iblagh_Click);
            this.iblagh.MouseEnter += new System.EventHandler(this.iblagh_MouseEnter);
            this.iblagh.MouseLeave += new System.EventHandler(this.iblagh_MouseLeave);
            // 
            // Form09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(559, 277);
            this.Controls.Add(this.iblagh);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form09";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "الحل المقترح لمشكلة ظهور رسالة خطأ رقم 02";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iblagh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox iblagh;
    }
}