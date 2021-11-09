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
    public partial class Form05 : Form
    {
        public Form05()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //تأثير عند الضغط
            tahmil.BackgroundImage = Properties.Resources.tahmil;
            tahmil.Refresh();
            Thread.Sleep(100);
            tahmil.BackgroundImage = Properties.Resources.tahmillight;

            //الدخول إلى صفحة تحميل البرنامج
            try
            {
                System.Diagnostics.Process.Start("https://atawbah1.blogspot.com/p/tahmil.html");
            }
            catch { }
        }

        private void tahmil_MouseEnter(object sender, EventArgs e)
        {
            tahmil.BackgroundImage = Properties.Resources.tahmillight;
        }

        private void tahmil_MouseLeave(object sender, EventArgs e)
        {
            tahmil.BackgroundImage = Properties.Resources.tahmil;
        }
    }
}
