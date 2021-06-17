namespace tawbah
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.khalfiyaalmayzat1 = new System.Windows.Forms.PictureBox();
            this.busy = new System.Windows.Forms.PictureBox();
            this.backgroundWorkerTachghilWTMYTB = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerTachghilMI3L = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerIqafWTMYTB = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerIqafMI3L = new System.ComponentModel.BackgroundWorker();
            this.zirfwtmyoutube = new System.Windows.Forms.PictureBox();
            this.zirmn3i3lnt = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.mofa3al_fwtm_ytb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mofa3al_mani3_i3l = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.intidhartahdith = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.khalfiyaalmayzat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zirfwtmyoutube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zirmn3i3lnt)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // khalfiyaalmayzat1
            // 
            this.khalfiyaalmayzat1.BackgroundImage = global::tawbah.Properties.Resources.almayzat01;
            this.khalfiyaalmayzat1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.khalfiyaalmayzat1.Location = new System.Drawing.Point(-1, -1);
            this.khalfiyaalmayzat1.Name = "khalfiyaalmayzat1";
            this.khalfiyaalmayzat1.Size = new System.Drawing.Size(604, 349);
            this.khalfiyaalmayzat1.TabIndex = 0;
            this.khalfiyaalmayzat1.TabStop = false;
            // 
            // busy
            // 
            this.busy.BackColor = System.Drawing.Color.White;
            this.busy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.busy.Image = global::tawbah.Properties.Resources.intidhar;
            this.busy.Location = new System.Drawing.Point(533, 295);
            this.busy.Name = "busy";
            this.busy.Size = new System.Drawing.Size(42, 28);
            this.busy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.busy.TabIndex = 13;
            this.busy.TabStop = false;
            this.busy.Visible = false;
            // 
            // backgroundWorkerTachghilWTMYTB
            // 
            this.backgroundWorkerTachghilWTMYTB.WorkerReportsProgress = true;
            this.backgroundWorkerTachghilWTMYTB.WorkerSupportsCancellation = true;
            this.backgroundWorkerTachghilWTMYTB.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerTachghilWTMYTB_DoWork);
            // 
            // backgroundWorkerTachghilMI3L
            // 
            this.backgroundWorkerTachghilMI3L.WorkerReportsProgress = true;
            this.backgroundWorkerTachghilMI3L.WorkerSupportsCancellation = true;
            this.backgroundWorkerTachghilMI3L.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerTachghilMI3L_DoWork);
            // 
            // backgroundWorkerIqafWTMYTB
            // 
            this.backgroundWorkerIqafWTMYTB.WorkerReportsProgress = true;
            this.backgroundWorkerIqafWTMYTB.WorkerSupportsCancellation = true;
            this.backgroundWorkerIqafWTMYTB.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerIqafWTMYTB_DoWork);
            // 
            // backgroundWorkerIqafMI3L
            // 
            this.backgroundWorkerIqafMI3L.WorkerReportsProgress = true;
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
            this.zirfwtmyoutube.Location = new System.Drawing.Point(502, 61);
            this.zirfwtmyoutube.Margin = new System.Windows.Forms.Padding(0);
            this.zirfwtmyoutube.Name = "zirfwtmyoutube";
            this.zirfwtmyoutube.Size = new System.Drawing.Size(59, 38);
            this.zirfwtmyoutube.TabIndex = 15;
            this.zirfwtmyoutube.TabStop = false;
            this.toolTip1.SetToolTip(this.zirfwtmyoutube, "اضغط على الزر لتشغيل أو إيقاف الميزة");
            this.zirfwtmyoutube.Click += new System.EventHandler(this.zirfwtmyoutube_Click);
            // 
            // zirmn3i3lnt
            // 
            this.zirmn3i3lnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zirmn3i3lnt.BackColor = System.Drawing.Color.White;
            this.zirmn3i3lnt.BackgroundImage = global::tawbah.Properties.Resources.zir0;
            this.zirmn3i3lnt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.zirmn3i3lnt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zirmn3i3lnt.Location = new System.Drawing.Point(502, 200);
            this.zirmn3i3lnt.Margin = new System.Windows.Forms.Padding(0);
            this.zirmn3i3lnt.Name = "zirmn3i3lnt";
            this.zirmn3i3lnt.Size = new System.Drawing.Size(59, 38);
            this.zirmn3i3lnt.TabIndex = 16;
            this.zirmn3i3lnt.TabStop = false;
            this.toolTip1.SetToolTip(this.zirmn3i3lnt, "اضغط على الزر لتشغيل أو إيقاف الميزة");
            this.zirmn3i3lnt.Click += new System.EventHandler(this.zirmn3i3lnt_Click);
            // 
            // mofa3al_fwtm_ytb
            // 
            this.mofa3al_fwtm_ytb.AutoSize = true;
            this.mofa3al_fwtm_ytb.Location = new System.Drawing.Point(499, 116);
            this.mofa3al_fwtm_ytb.Name = "mofa3al_fwtm_ytb";
            this.mofa3al_fwtm_ytb.Size = new System.Drawing.Size(13, 13);
            this.mofa3al_fwtm_ytb.TabIndex = 22;
            this.mofa3al_fwtm_ytb.Text = "0";
            this.mofa3al_fwtm_ytb.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "mofa3al";
            this.label4.Visible = false;
            // 
            // mofa3al_mani3_i3l
            // 
            this.mofa3al_mani3_i3l.AutoSize = true;
            this.mofa3al_mani3_i3l.Location = new System.Drawing.Point(499, 248);
            this.mofa3al_mani3_i3l.Name = "mofa3al_mani3_i3l";
            this.mofa3al_mani3_i3l.Size = new System.Drawing.Size(13, 13);
            this.mofa3al_mani3_i3l.TabIndex = 24;
            this.mofa3al_mani3_i3l.Text = "0";
            this.mofa3al_mani3_i3l.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 248);
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
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 344);
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
            this.Name = "Form4";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "المزيد من الميزات";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form4_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.khalfiyaalmayzat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zirfwtmyoutube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zirmn3i3lnt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
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
    }
}