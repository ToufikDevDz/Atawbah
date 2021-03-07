using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace tawbah
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void iblagh_Click(object sender, EventArgs e)
        {
            //تأثير عند الضغط على الزر
            iblagh.BackgroundImage = Properties.Resources.iblagh;
            iblagh.Refresh();
            Thread.Sleep(100);
            iblagh.BackgroundImage = Properties.Resources.lightiblagh;

            //فتح صفحة الإبلاغ عن الخطأ
            try
            {
                System.Diagnostics.Process.Start("https://bit.ly/iblagh-at");
            }
            catch { }
        }

        private void iblagh_MouseEnter(object sender, EventArgs e)
        {
            iblagh.BackgroundImage = Properties.Resources.lightiblagh;
        }
        private void iblagh_MouseLeave(object sender, EventArgs e)
        {
            iblagh.BackgroundImage = Properties.Resources.iblagh;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            //غلق بعض النوافذ الأخرى
            try
            {
                Application.OpenForms["Form2"].Close();
            }
            catch { }

            try
            {
                Application.OpenForms["Form3"].Close();
            }
            catch { }

            try
            {
                Application.OpenForms["Form4"].Close();
            }
            catch { }

            try
            {
                Application.OpenForms["Form5"].Close();
            }
            catch { }

            try
            {
                Application.OpenForms["Form6"].Close();
            }
            catch { }
        }
    }
}
