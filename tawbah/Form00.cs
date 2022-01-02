using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tawbah
{
    public partial class Form00 : Form
    {
        public Form00()
        {
            InitializeComponent();
        }

    //تأثير زر موافق
        private void mowafiq_MouseEnter(object sender, EventArgs e)
        {
            mowafiq.BackgroundImage = Properties.Resources.lightzirmowafiq;
        }

        private void mowafiq_MouseLeave(object sender, EventArgs e)
        {
            mowafiq.BackgroundImage = Properties.Resources.zirmowafiq;
        }

    //غلق النافذة بعد الضغط على زر موافق
        private void mowafiq_Click(object sender, EventArgs e)
        {
            //غلق النافذة وجعلها لا تظهر في المرة القادمة إن شاء الله
            this.Close();
            Properties.Settings.Default.idhharNafidhatAlTanbihat = false;
            Properties.Settings.Default.Save();
        }
    }
}
