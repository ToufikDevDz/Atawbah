﻿using System;
using System.Threading;
using System.Windows.Forms;


namespace tawbah
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            //إظهار نص الشكر
            this.nass.Text = "";
            this.nass.SelectedRtf = Properties.Resources.chokr1;
            this.nass.SelectionStart = 0;
        }

        private void license_Click(object sender, EventArgs e)
        {
            //تأثير عند الضغط
            licensebtn.BackgroundImage = Properties.Resources.license;
            licensebtn.Refresh();
            Thread.Sleep(100);
            licensebtn.BackgroundImage = Properties.Resources.lightlicense;

            //إظهار نص الترخيص
            this.nass.Text = "";
            this.nass.SelectedRtf = Properties.Resources.License1;
            this.nass.SelectionStart = 0;
        }

        private void chokr_MouseLeave(object sender, EventArgs e)
        {
            chokr.BackgroundImage = Properties.Resources.chokr;
        }

        private void iblagh_MouseLeave(object sender, EventArgs e)
        {
            iblagh.BackgroundImage = Properties.Resources.iblagh;
        }

        private void license_MouseLeave(object sender, EventArgs e)
        {
            licensebtn.BackgroundImage = Properties.Resources.license;
        }

        private void chokr_Click(object sender, EventArgs e)
        {
            //تأثير عند الضغط
            chokr.BackgroundImage = Properties.Resources.chokr;
            chokr.Refresh();
            Thread.Sleep(100);
            chokr.BackgroundImage = Properties.Resources.lightchokr;

            //إظهار نص الشكر          
            this.nass.Text = "";
            this.nass.SelectedRtf = Properties.Resources.chokr1;
            this.nass.SelectionStart = 0;
        }

        private void iblagh_Click(object sender, EventArgs e)
        {
            //تأثير عند الضغط
            iblagh.BackgroundImage = Properties.Resources.iblagh;
            iblagh.Refresh();
            Thread.Sleep(100);
            iblagh.BackgroundImage = Properties.Resources.lightiblagh;

            //فتح صفحة الإبلاغ عن الخطأ
            try
            {
                System.Diagnostics.Process.Start("https://forms.gle/cMBi3N1hvzjGmXex9");
            }
            catch { }
        }

        private void licensebtn_MouseEnter(object sender, EventArgs e)
        {
            licensebtn.BackgroundImage = Properties.Resources.lightlicense;
        }

        private void iblagh_MouseEnter(object sender, EventArgs e)
        {
            iblagh.BackgroundImage = Properties.Resources.lightiblagh;
        }

        private void chokr_MouseEnter(object sender, EventArgs e)
        {
            chokr.BackgroundImage = Properties.Resources.lightchokr;
        }

        private void nass_Enter(object sender, EventArgs e)
        {

            //حجب رمز الكتابة
            label2.Focus();
        }
    }
}