//هام
//الأكواد المقتبسة من المواقع سواء بتصرف أو بدونه مكتوبة بين شولتين (//"  //") ومصادرها مذكورة في آخر الصفحة 
//حذار من روابط المصادر، فقد تحتوي على صور النساء، ننصحك بحجب الصور في المتصفح قبل الدخول إليها

using System;
using System.Threading;
using System.Windows.Forms;

namespace tawbah
{
    public partial class Form02 : Form
    {
        public Form02()
        {
            InitializeComponent();

            //إظهار نص التحقق من نجاح عملية حجب المواقع الخبيثة
            nass.Text = "";
            nass.SelectedRtf = Properties.Resources.nastahaqoq;
            nass.SelectionStart = 0;

            //غلق بعض النوافذ الأخرى
            try
            {
                Application.OpenForms["Form3"].Close();
                Application.OpenForms["Form4"].Close();
                Application.OpenForms["Form5"].Close();
                Application.OpenForms["Form6"].Close();
                Application.OpenForms["Form7"].Close();
                Application.OpenForms["Form8"].Close();
                Application.OpenForms["Form9"].Close();
            }
            catch { }
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

        private void nass_Enter(object sender, EventArgs e)
        {
            //هذا يساعد على حجب مؤشر الكتابة بإذن الله
            //"
            label2.Focus(); //" م1
        }

        private void tahaqoq_MouseEnter(object sender, EventArgs e)
        {
            tahaqoq.BackgroundImage = Properties.Resources.lighttahaqoqnajah;
        }

        private void tahaqoq_MouseLeave(object sender, EventArgs e)
        {
            tahaqoq.BackgroundImage = Properties.Resources.tahaqoqnajah;
        }

        private void soarabittahaqoq_Click(object sender, EventArgs e)
        {
            //تأثير عند الضغط
            soarabittahaqoq.BackgroundImage = Properties.Resources.rabittahaqoq;
            soarabittahaqoq.Refresh();
            Thread.Sleep(100);
            soarabittahaqoq.BackgroundImage = Properties.Resources.lightrabittahaqoq;

            //إظهار فقاعة تم نسخ الرابط
            ToolTip tt = new ToolTip();
            tt.Show("تم نسخ الرابط", soarabittahaqoq, 50, -20, 2000);

            //نسخ الرابط
            //استخدمنا هذه الأوامر حتى لا تظهر مشكلة 
            //Current thread must be set to single thread apartment (STA) mode before OLE calls can be made.

            //"
            Thread thread = new Thread(() => Clipboard.SetText("https://lilhajb.blogspot.com/"));
            thread.SetApartmentState(ApartmentState.STA); //Set the thread to STA
            thread.Start();
            thread.Join(); //Wait for the thread to end //" م2
        }

        private void soarabittahaqoq_MouseEnter(object sender, EventArgs e)
        {
           
            soarabittahaqoq.BackgroundImage = Properties.Resources.lightrabittahaqoq;
           
        }

        private void soarabittahaqoq_MouseLeave(object sender, EventArgs e)
        {
            soarabittahaqoq.BackgroundImage = Properties.Resources.rabittahaqoq;
        }
    }
}

//مصادر أكواد البرنامج

//المصدر م1
//Henk Holterman, Stack Overflow, https://stackoverflow.com/a/1140277, 
//CC BY-SA 3.0, https://creativecommons.org/licenses/by-sa/3.0/

//المصدر م2
//It'sNotALie., Stack Overflow, https://stackoverflow.com/a/17762059, 
//CC BY-SA 4.0, https://creativecommons.org/licenses/by-sa/4.0/