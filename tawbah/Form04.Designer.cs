namespace tawbah
{
    partial class Form04
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form04));
            this.timerRisalaKhataa = new System.Windows.Forms.Timer(this.components);
            this.khalfiyaalmayzat1 = new System.Windows.Forms.PictureBox();
            this.busy = new System.Windows.Forms.PictureBox();
            this.backgroundWorkerTachghilWTMYTB = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerTachghilMI3L = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerIqafWTMYTB = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerIqafMI3L = new System.ComponentModel.BackgroundWorker();
            this.zirfwtmyoutube = new System.Windows.Forms.PictureBox();
            this.zirmn3i3lnt = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.risalaMi3lanat = new System.Windows.Forms.PictureBox();
            this.zirIghlaqAlrisala = new System.Windows.Forms.PictureBox();
            this.adadAlNitaqatMI3lanat = new System.Windows.Forms.PictureBox();
            this.mofa3al_fwtm_ytb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mofa3al_mani3_i3l = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.intidhartahdith = new System.Windows.Forms.Timer(this.components);
            this.timerRisalaKhataa01 = new System.Windows.Forms.Timer(this.components);
            this.timerRisalaKhataa02 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.khalfiyaalmayzat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zirfwtmyoutube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zirmn3i3lnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.risalaMi3lanat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zirIghlaqAlrisala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adadAlNitaqatMI3lanat)).BeginInit();
            this.SuspendLayout();
            // 
            // timerRisalaKhataa
            // 
            this.timerRisalaKhataa.Interval = 1000;
            this.timerRisalaKhataa.Tick += new System.EventHandler(this.timerRisalaKhataa_Tick);
            // 
            // khalfiyaalmayzat1
            // 
            this.khalfiyaalmayzat1.BackgroundImage = global::tawbah.Properties.Resources.almayzat01;
            this.khalfiyaalmayzat1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.khalfiyaalmayzat1.Location = new System.Drawing.Point(-3, -4);
            this.khalfiyaalmayzat1.Margin = new System.Windows.Forms.Padding(0);
            this.khalfiyaalmayzat1.Name = "khalfiyaalmayzat1";
            this.khalfiyaalmayzat1.Size = new System.Drawing.Size(652, 520);
            this.khalfiyaalmayzat1.TabIndex = 0;
            this.khalfiyaalmayzat1.TabStop = false;
            // 
            // busy
            // 
            this.busy.BackColor = System.Drawing.Color.White;
            this.busy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.busy.Image = global::tawbah.Properties.Resources.intidhar;
            this.busy.Location = new System.Drawing.Point(99, 440);
            this.busy.Margin = new System.Windows.Forms.Padding(0);
            this.busy.Name = "busy";
            this.busy.Size = new System.Drawing.Size(42, 28);
            this.busy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.busy.TabIndex = 13;
            this.busy.TabStop = false;
            this.busy.Visible = false;
            // 
            // backgroundWorkerTachghilWTMYTB
            // 
            this.backgroundWorkerTachghilWTMYTB.WorkerSupportsCancellation = true;
            this.backgroundWorkerTachghilWTMYTB.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerTachghilWTMYTB_DoWork);
            // 
            // backgroundWorkerTachghilMI3L
            // 
            this.backgroundWorkerTachghilMI3L.WorkerSupportsCancellation = true;
            this.backgroundWorkerTachghilMI3L.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerTachghilMI3L_DoWork);
            // 
            // backgroundWorkerIqafWTMYTB
            // 
            this.backgroundWorkerIqafWTMYTB.WorkerSupportsCancellation = true;
            this.backgroundWorkerIqafWTMYTB.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerIqafWTMYTB_DoWork);
            // 
            // backgroundWorkerIqafMI3L
            // 
            this.backgroundWorkerIqafMI3L.WorkerSupportsCancellation = true;
            this.backgroundWorkerIqafMI3L.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerIqafMI3L_DoWork);
            // 
            // zirfwtmyoutube
            // 
            this.zirfwtmyoutube.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zirfwtmyoutube.BackColor = System.Drawing.Color.White;
            this.zirfwtmyoutube.BackgroundImage = global::tawbah.Properties.Resources.zir0;
            this.zirfwtmyoutube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.zirfwtmyoutube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zirfwtmyoutube.Location = new System.Drawing.Point(91, 146);
            this.zirfwtmyoutube.Margin = new System.Windows.Forms.Padding(0);
            this.zirfwtmyoutube.Name = "zirfwtmyoutube";
            this.zirfwtmyoutube.Size = new System.Drawing.Size(59, 38);
            this.zirfwtmyoutube.TabIndex = 15;
            this.zirfwtmyoutube.TabStop = false;
            this.toolTip1.SetToolTip(this.zirfwtmyoutube, "اضغط على الزر لتفعيل أو إلغاء تفعيل الميزة");
            this.zirfwtmyoutube.Click += new System.EventHandler(this.zirfwtmyoutube_Click);
            // 
            // zirmn3i3lnt
            // 
            this.zirmn3i3lnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zirmn3i3lnt.BackColor = System.Drawing.Color.White;
            this.zirmn3i3lnt.BackgroundImage = global::tawbah.Properties.Resources.zir0;
            this.zirmn3i3lnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.zirmn3i3lnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zirmn3i3lnt.Location = new System.Drawing.Point(91, 353);
            this.zirmn3i3lnt.Margin = new System.Windows.Forms.Padding(0);
            this.zirmn3i3lnt.Name = "zirmn3i3lnt";
            this.zirmn3i3lnt.Size = new System.Drawing.Size(59, 38);
            this.zirmn3i3lnt.TabIndex = 16;
            this.zirmn3i3lnt.TabStop = false;
            this.toolTip1.SetToolTip(this.zirmn3i3lnt, "اضغط على الزر لتفعيل أو إلغاء تفعيل الميزة");
            this.zirmn3i3lnt.Click += new System.EventHandler(this.zirmn3i3lnt_Click);
            // 
            // risalaMi3lanat
            // 
            this.risalaMi3lanat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.risalaMi3lanat.BackColor = System.Drawing.Color.White;
            this.risalaMi3lanat.BackgroundImage = global::tawbah.Properties.Resources.risala01;
            this.risalaMi3lanat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.risalaMi3lanat.Cursor = System.Windows.Forms.Cursors.Default;
            this.risalaMi3lanat.Location = new System.Drawing.Point(241, 287);
            this.risalaMi3lanat.Margin = new System.Windows.Forms.Padding(0);
            this.risalaMi3lanat.Name = "risalaMi3lanat";
            this.risalaMi3lanat.Size = new System.Drawing.Size(363, 79);
            this.risalaMi3lanat.TabIndex = 25;
            this.risalaMi3lanat.TabStop = false;
            // 
            // zirIghlaqAlrisala
            // 
            this.zirIghlaqAlrisala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zirIghlaqAlrisala.BackColor = System.Drawing.Color.White;
            this.zirIghlaqAlrisala.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zirIghlaqAlrisala.BackgroundImage")));
            this.zirIghlaqAlrisala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.zirIghlaqAlrisala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zirIghlaqAlrisala.Location = new System.Drawing.Point(577, 298);
            this.zirIghlaqAlrisala.Margin = new System.Windows.Forms.Padding(0);
            this.zirIghlaqAlrisala.Name = "zirIghlaqAlrisala";
            this.zirIghlaqAlrisala.Size = new System.Drawing.Size(11, 12);
            this.zirIghlaqAlrisala.TabIndex = 26;
            this.zirIghlaqAlrisala.TabStop = false;
            this.zirIghlaqAlrisala.Click += new System.EventHandler(this.zirIghlaqAlrisala_Click);
            // 
            // adadAlNitaqatMI3lanat
            // 
            this.adadAlNitaqatMI3lanat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adadAlNitaqatMI3lanat.BackColor = System.Drawing.Color.White;
            this.adadAlNitaqatMI3lanat.BackgroundImage = global::tawbah.Properties.Resources.adadannitaqat;
            this.adadAlNitaqatMI3lanat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.adadAlNitaqatMI3lanat.Cursor = System.Windows.Forms.Cursors.Default;
            this.adadAlNitaqatMI3lanat.Location = new System.Drawing.Point(51, 318);
            this.adadAlNitaqatMI3lanat.Margin = new System.Windows.Forms.Padding(0);
            this.adadAlNitaqatMI3lanat.Name = "adadAlNitaqatMI3lanat";
            this.adadAlNitaqatMI3lanat.Size = new System.Drawing.Size(144, 22);
            this.adadAlNitaqatMI3lanat.TabIndex = 27;
            this.adadAlNitaqatMI3lanat.TabStop = false;
            // 
            // mofa3al_fwtm_ytb
            // 
            this.mofa3al_fwtm_ytb.AutoSize = true;
            this.mofa3al_fwtm_ytb.Location = new System.Drawing.Point(182, 167);
            this.mofa3al_fwtm_ytb.Name = "mofa3al_fwtm_ytb";
            this.mofa3al_fwtm_ytb.Size = new System.Drawing.Size(13, 13);
            this.mofa3al_fwtm_ytb.TabIndex = 22;
            this.mofa3al_fwtm_ytb.Text = "0";
            this.mofa3al_fwtm_ytb.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "mofa3al";
            this.label4.Visible = false;
            // 
            // mofa3al_mani3_i3l
            // 
            this.mofa3al_mani3_i3l.AutoSize = true;
            this.mofa3al_mani3_i3l.Location = new System.Drawing.Point(182, 377);
            this.mofa3al_mani3_i3l.Name = "mofa3al_mani3_i3l";
            this.mofa3al_mani3_i3l.Size = new System.Drawing.Size(13, 13);
            this.mofa3al_mani3_i3l.TabIndex = 24;
            this.mofa3al_mani3_i3l.Text = "0";
            this.mofa3al_mani3_i3l.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "mofa3al";
            this.label2.Visible = false;
            // 
            // intidhartahdith
            // 
            this.intidhartahdith.Enabled = true;
            this.intidhartahdith.Interval = 3000;
            this.intidhartahdith.Tick += new System.EventHandler(this.intidhartahdith_Tick);
            // 
            // timerRisalaKhataa01
            // 
            this.timerRisalaKhataa01.Interval = 1000;
            this.timerRisalaKhataa01.Tick += new System.EventHandler(this.timerRisalaKhataa01_Tick);
            // 
            // timerRisalaKhataa02
            // 
            this.timerRisalaKhataa02.Interval = 1000;
            this.timerRisalaKhataa02.Tick += new System.EventHandler(this.timerRisalaKhataa02_Tick);
            // 
            // Form04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 514);
            this.Controls.Add(this.adadAlNitaqatMI3lanat);
            this.Controls.Add(this.zirIghlaqAlrisala);
            this.Controls.Add(this.risalaMi3lanat);
            this.Controls.Add(this.mofa3al_mani3_i3l);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mofa3al_fwtm_ytb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.zirmn3i3lnt);
            this.Controls.Add(this.zirfwtmyoutube);
            this.Controls.Add(this.busy);
            this.Controls.Add(this.khalfiyaalmayzat1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form04";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "المزيد من الميزات (اختيارية)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form04_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form4_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.khalfiyaalmayzat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zirfwtmyoutube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zirmn3i3lnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.risalaMi3lanat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zirIghlaqAlrisala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adadAlNitaqatMI3lanat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerRisalaKhataa;
        private System.Windows.Forms.PictureBox khalfiyaalmayzat1;
        private System.Windows.Forms.PictureBox busy;
        private System.ComponentModel.BackgroundWorker backgroundWorkerTachghilWTMYTB;
        private System.ComponentModel.BackgroundWorker backgroundWorkerTachghilMI3L;
        private System.ComponentModel.BackgroundWorker backgroundWorkerIqafWTMYTB;
        private System.ComponentModel.BackgroundWorker backgroundWorkerIqafMI3L;
        private System.Windows.Forms.PictureBox zirfwtmyoutube;
        private System.Windows.Forms.PictureBox zirmn3i3lnt;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label mofa3al_fwtm_ytb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label mofa3al_mani3_i3l;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer intidhartahdith;
        private System.Windows.Forms.Timer timerRisalaKhataa01;
        private System.Windows.Forms.Timer timerRisalaKhataa02;
        private System.Windows.Forms.PictureBox risalaMi3lanat;
        private System.Windows.Forms.PictureBox zirIghlaqAlrisala;
        private System.Windows.Forms.PictureBox adadAlNitaqatMI3lanat;
    }
}