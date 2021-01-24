using System;
using System.Threading;
using System.Windows.Forms;

namespace tawbah
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void khorodj_Click(object sender, EventArgs e)
        {
            //تأثير عند الضغط
            khorodj.BackgroundImage = Properties.Resources.khorodj;
            khorodj.Refresh();
            Thread.Sleep(100);
            khorodj.BackgroundImage = Properties.Resources.lightkhorodj;

            //الخروج من البرنامج
            Application.Exit();
        }
        private void khorodj_MouseEnter(object sender, EventArgs e)
        {
            khorodj.BackgroundImage = Properties.Resources.lightkhorodj;
        }
        private void khorodj_MouseLeave(object sender, EventArgs e)
        {
            khorodj.BackgroundImage = Properties.Resources.khorodj;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //غلق بعض النوافذ الأخرى
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

            try
            {
                Application.OpenForms["Form7"].Close();
            }
            catch { }
        }
    }
}
