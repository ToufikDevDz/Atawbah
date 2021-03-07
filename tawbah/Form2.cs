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
            //إظهار نص التحقق من نجاح عملية حجب المواقع الخبيثة
            this.nass.Text = "";
            this.nass.SelectedRtf = Properties.Resources.nastahaqoq;
            this.nass.SelectionStart = 0;
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

        private void nass_Enter(object sender, EventArgs e)
        {
            //هذا يساعد على حجب مؤشر الكتابة بإذن الله
            label2.Focus();
        }

        private void tahaqoq_MouseEnter(object sender, EventArgs e)
        {
            tahaqoq.BackgroundImage = Properties.Resources.lighttahaqoqnajah;
        }

        private void tahaqoq_MouseLeave(object sender, EventArgs e)
        {
            tahaqoq.BackgroundImage = Properties.Resources.tahaqoqnajah;
        }

        private void tahaqoq_Click(object sender, EventArgs e)
        {
            //تأثير عند الضغط
            tahaqoq.BackgroundImage = Properties.Resources.tahaqoqnajah;
            tahaqoq.Refresh();
            Thread.Sleep(100);
            tahaqoq.BackgroundImage = Properties.Resources.lighttahaqoqnajah;

            //الدخول إلى الموقع المحجوب
            try
            {
                System.Diagnostics.Process.Start("http://bit.ly/2O3ZkwD");
            }
            catch { }
        }

        private void nass_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            //فتح الروابط
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}
