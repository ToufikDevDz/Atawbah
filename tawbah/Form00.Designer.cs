
namespace tawbah
{
    partial class Form00
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form00));
            this.altanbihat = new System.Windows.Forms.PictureBox();
            this.mowafiq = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.altanbihat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mowafiq)).BeginInit();
            this.SuspendLayout();
            // 
            // altanbihat
            // 
            this.altanbihat.BackColor = System.Drawing.Color.White;
            this.altanbihat.BackgroundImage = global::tawbah.Properties.Resources.tanbihat;
            this.altanbihat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.altanbihat.Location = new System.Drawing.Point(-15, -35);
            this.altanbihat.Margin = new System.Windows.Forms.Padding(0);
            this.altanbihat.Name = "altanbihat";
            this.altanbihat.Size = new System.Drawing.Size(548, 591);
            this.altanbihat.TabIndex = 6;
            this.altanbihat.TabStop = false;
            // 
            // mowafiq
            // 
            this.mowafiq.BackColor = System.Drawing.Color.White;
            this.mowafiq.BackgroundImage = global::tawbah.Properties.Resources.zirmowafiq;
            this.mowafiq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mowafiq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mowafiq.Location = new System.Drawing.Point(195, 394);
            this.mowafiq.Margin = new System.Windows.Forms.Padding(0);
            this.mowafiq.Name = "mowafiq";
            this.mowafiq.Size = new System.Drawing.Size(129, 49);
            this.mowafiq.TabIndex = 7;
            this.mowafiq.TabStop = false;
            this.mowafiq.Click += new System.EventHandler(this.mowafiq_Click);
            this.mowafiq.MouseEnter += new System.EventHandler(this.mowafiq_MouseEnter);
            this.mowafiq.MouseLeave += new System.EventHandler(this.mowafiq_MouseLeave);
            // 
            // Form00
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 516);
            this.Controls.Add(this.mowafiq);
            this.Controls.Add(this.altanbihat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form00";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تنبيهات";
            ((System.ComponentModel.ISupportInitialize)(this.altanbihat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mowafiq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox altanbihat;
        private System.Windows.Forms.PictureBox mowafiq;
    }
}