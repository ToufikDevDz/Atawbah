//هام
//الأكواد المقتبسة من المواقع سواء بتصرف أو بدونه مكتوبة بين شولتين (//"  //") ومصادرها مذكورة في آخر الصفحة 
//حذار من روابط المصادر، فقد تحتوي على صور النساء، ننصحك بحجب الصور في المتصفح قبل الدخول إليها

using System;
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
        private void chokr_MouseEnter(object sender, EventArgs e)
        {
            chokr.BackgroundImage = Properties.Resources.lightchokr;
        }
        private void chokr_MouseLeave(object sender, EventArgs e)
        {
            chokr.BackgroundImage = Properties.Resources.chokr;
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
        private void nass_Enter(object sender, EventArgs e)
        {
            //هذا يساعد على حجب مؤشر الكتابة بإذن الله
            //"
            label2.Focus(); //" م1
        }

        private void soalwajawab_MouseEnter(object sender, EventArgs e)
        {
            soalwajawab.BackgroundImage = Properties.Resources.lightsoalwajawab;
        }

        private void soalwajawab_MouseLeave(object sender, EventArgs e)
        {
            soalwajawab.BackgroundImage = Properties.Resources.soalwajawab;
        }

        private void soalwajawab_Click(object sender, EventArgs e)
        {
            //تأثير عند الضغط
            soalwajawab.BackgroundImage = Properties.Resources.soalwajawab;
            soalwajawab.Refresh();
            Thread.Sleep(100);
            soalwajawab.BackgroundImage = Properties.Resources.lightsoalwajawab;

            //إظهارالأسئلة والأجوبة          
            this.nass.Text = "";
            this.nass.SelectedRtf = Properties.Resources.nassasilawaajwiba;
            this.nass.SelectionStart = 0;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //إظهار نص الترخيص
            this.nass.Text = "";
            this.nass.SelectedRtf = Properties.Resources.License1;
            this.nass.SelectionStart = 0;
        }

        private void nass_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            //فتح الروابط
            System.Diagnostics.Process.Start(e.LinkText);
        }
    }
}

//مصادر أكواد البرنامج

    //المصدر م1
    //Henk Holterman, Stack Overflow, https://stackoverflow.com/a/1140277, 
    //CC BY-SA 3.0, https://creativecommons.org/licenses/by-sa/3.0/