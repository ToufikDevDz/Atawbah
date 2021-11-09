using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace tawbah
{
    public partial class Form06 : Form
    {
        public Form06()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer غلق النافذة بعد مدة، انظر 
            Close();
        }
    }
}
