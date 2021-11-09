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
    public partial class Form09 : Form
    {
        public Form09()
        {
            InitializeComponent();

            //غلق بعض النوافذ الأخرى
            try
            {
                Application.OpenForms["Form2"].Close();
                Application.OpenForms["Form3"].Close();
                Application.OpenForms["Form4"].Close();
                Application.OpenForms["Form5"].Close();
                Application.OpenForms["Form6"].Close();
                Application.OpenForms["Form7"].Close();
                Application.OpenForms["Form8"].Close();
            }
            catch { }
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
    }
}
