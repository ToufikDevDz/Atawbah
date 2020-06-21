using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace tawbah
{
    public partial class Form1 : Form
    {
        //ج1
        string line = "";

        public Form1()
        {
            InitializeComponent();
           
            //Alt+F4 من الأمور الخاصة بتعطيل 
            this.KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //التحقق من وجود إصدار جديد
            try
            {
                WebClient web2 = new WebClient();
                System.IO.Stream stream = web2.OpenRead("https://raw.githubusercontent.com/ToufikDevDz/Tawbah/master/raqmalisdar");
                using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
                {
                    String textakhiralisdarfilmawqii = reader.ReadToEnd();
                    raqmalisdarmawqi.Text = textakhiralisdarfilmawqii;
                    var mwq = Convert.ToInt32(raqmalisdarmawqi.Text);
                    var brn = Convert.ToInt32(raqmalisdarfibarnamj.Text);
                    if
                    (mwq > brn)
                    {
                        //فتح نافذة إصدار جديد
                        Form isdarjadid = new Form5();
                        isdarjadid.ShowDialog();
                    }

                }
            }

            catch
            {
            }

            //LinqBridge.dll التحقق من وجود الملف 
            if (File.Exists("LinqBridge.dll"))
            {
            }
            else
            {
                MessageBox.Show("ينقص الملف LinqBridge.dll، قم بإعادة تحميل البرنامج من موقعه الرسمي.", "حدث خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                Application.Exit();
            }

            //آخر الأخبار - مع حذف رسالة الخطأ عند إنقطاع الإتصال بالأنترنت
            try
            {
                WebClient web = new WebClient();
                System.IO.Stream stream = web.OpenRead("https://raw.githubusercontent.com/ToufikDevDz/Tawbah/master/akhabr");
                using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
                {
                    String text = reader.ReadToEnd();
                    Akhbar.Text = text;
                }
            }

            catch
            {
            }

        }

        private void btnhajb_Click(object sender, EventArgs e)
        {
            //تأثير عند الضغط
            btnhajb.BackgroundImage = Properties.Resources.hajb;
            btnhajb.Refresh();
            btnhajb.BackgroundImage = Properties.Resources.lighthajb;

            //عدم التنفيذ إذا انتهت العملية
            var tma = Convert.ToInt32(tammaawla.Text);
            if
            (tma == 1)
            {
                //إظهار رسالة تم
                Form tammaform = new Form2();
                tammaform.ShowDialog();
            }

            if
            (tma == 0)
            {
                //التنفيذ
                if (backgroundWorker1.IsBusy)
                {

                }
                else
                {
                    this.ControlBox = false;
                    hajbdisabled.Visible = true;
                    busy.Visible = true;
                    backgroundWorker1.RunWorkerAsync();
                }

            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            //التحقق من وجود الملف
            string pathhst = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts");
            if (!File.Exists(pathhst))
            {
                //إنشاء الملف إذا لم يكن موجود
                try
                {
                    using (StreamWriter w = File.AppendText(pathhst)) ;
                }
                catch (Exception ex)
                {
                    this.ControlBox = true;
                    hajbdisabled.Visible = false;
                    busy.Visible = false;

                    try
                    {
                        System.Diagnostics.Process.Start("https://forms.gle/cMBi3N1hvzjGmXex9");
                    }
                    catch
                    { }

                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                goto starthajb;
            }

        starthajb:
            //إلغاء السمة للقراءة فقط
            FileInfo hostsnfo = new FileInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts"));
            try
            {
                hostsnfo.IsReadOnly = false;
                File.SetAttributes(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts"), FileAttributes.Normal);
            }
            catch (Exception ex)
            {
                this.ControlBox = true;
                hajbdisabled.Visible = false;
                busy.Visible = false;

                try
                {
                    System.Diagnostics.Process.Start("https://forms.gle/cMBi3N1hvzjGmXex9");
                }
                catch
                { }

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            //hosts حذف المواقع التي أضافتها الإصدارات القديمة للبرنامج إلى الملف 
            //hosts حذف المواقع التي أضافها البرنامج إلى الملف
            //twbh حذف السطور التي تحتوي على كلمة
            try
            {
                string search_text = "twbh";
                string old;
                string n = "";
                StreamReader sr = File.OpenText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts"));
                while ((old = sr.ReadLine()) != null)
                {
                    if (!old.Contains(search_text))
                    {
                        n += old + Environment.NewLine;
                    }
                }
                sr.Close();
                File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts"), n);
            }
            catch (Exception ex)
            {
                this.ControlBox = true;
                hajbdisabled.Visible = false;
                busy.Visible = false;

                try
                {
                    System.Diagnostics.Process.Start("https://forms.gle/cMBi3N1hvzjGmXex9");
                }
                catch
                { }

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            //hosts إضافة السطور إلى الملف 
            try
            {
                using (StreamWriter sw = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts")))
                {
                    sw.WriteLine(Properties.Resources.qaimatalmawaqi);
                }
            }
            catch (Exception ex)
            {
                this.ControlBox = true;
                hajbdisabled.Visible = false;
                busy.Visible = false;

                try
                {
                    System.Diagnostics.Process.Start("https://forms.gle/cMBi3N1hvzjGmXex9");
                }
                catch
                { }

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            //حذف السطور المكررة
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts");
            try
            {
                string[] lines = File.ReadAllLines(path);
                File.WriteAllLines(path, lines.Distinct().ToArray());
            }
            catch (Exception ex)
            {
                this.ControlBox = true;
                hajbdisabled.Visible = false;
                busy.Visible = false;

                try
                {
                    System.Diagnostics.Process.Start("https://forms.gle/cMBi3N1hvzjGmXex9");
                }
                catch
                { }

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            //تنشيط السمة للقراءة فقط
            try
            {
                hostsnfo.IsReadOnly = true;
            }
            catch (Exception ex)
            {
                this.ControlBox = true;
                hajbdisabled.Visible = false;
                busy.Visible = false;

                try
                {
                    System.Diagnostics.Process.Start("https://forms.gle/cMBi3N1hvzjGmXex9");
                }
                catch
                { }

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            //إنتظار 40 ثانية
            Thread.Sleep(40000);

            //بعد إنتهاء عملية حجب المواقع
            this.ControlBox = true;
            hajbdisabled.Visible = false;
            busy.Visible = false;

            //async إيقاف
            backgroundWorker1.CancelAsync();

            //إظهار رسالة تم
            Form tammaform = new Form2();
            tammaform.ShowDialog();

            //لا يمكن التنفيذ مرة أخرى إن شاء الله لأن العملية انتهت والحمد لله
            tammaawla.Text = "1";

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.ControlBox = true;
            hajbdisabled.Visible = false;
            busy.Visible = false;
            Cursor.Current = Cursors.Default;
        }

        private void btnhajb_MouseLeave(object sender, EventArgs e)
        {
            btnhajb.BackgroundImage = Properties.Resources.hajb;
        }

        private void mawqi_Click(object sender, EventArgs e)
        {
            //تأثير عند الضغط
            mawqi.BackgroundImage = Properties.Resources.mawqi;
            mawqi.Refresh();
            Thread.Sleep(100);
            mawqi.BackgroundImage = Properties.Resources.lightmawqi;

            //الدخول إلى الموقع
            try
            {
                System.Diagnostics.Process.Start("https://atawbah1.blogspot.com/");
            }
            catch { }

        }

        private void mawqi_MouseLeave(object sender, EventArgs e)
        {
            mawqi.BackgroundImage = Properties.Resources.mawqi;
        }

        private void hawla_MouseLeave(object sender, EventArgs e)
        {
            hawla.BackgroundImage = Properties.Resources.hawla;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hajbdisabled.Visible = true;
            busy.Visible = true;
        }

        private void Akhbar_Click(object sender, EventArgs e)
        {

        }

        private void hawla_Click_1(object sender, EventArgs e)
        {
            //تأثير عند الضغط
            hawla.BackgroundImage = Properties.Resources.hawla;
            hawla.Refresh();
            Thread.Sleep(100);
            hawla.BackgroundImage = Properties.Resources.lighthawla;

            //فتح نافذة حول البرنامج
            Form hawlaform = new Form3();
            hawlaform.ShowDialog();

        }

        private void mawqi_MouseEnter(object sender, EventArgs e)
        {
            mawqi.BackgroundImage = Properties.Resources.lightmawqi;
        }

        private void hawla_MouseEnter(object sender, EventArgs e)
        {
            hawla.BackgroundImage = Properties.Resources.lighthawla;
        }

        private void btnhajb_MouseEnter(object sender, EventArgs e)
        {
            btnhajb.BackgroundImage = Properties.Resources.lighthajb;
        }


        private void hajbdisabled_Click(object sender, EventArgs e)
        {
            //فتح نافذة حول البرنامج
            Form isbirform = new Form4();
            isbirform.ShowDialog();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Alt+f4 تعطيل
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                e.Handled = true;
            }

            //Ctrl + L حدث خطأ؟ استعادة الحالة الأصلية للملف بالضغط على الأزرار
            if (e.Control && e.KeyCode == Keys.L)
            {
                if (!backgroundWorker1.IsBusy)
                {

                    if (backgroundWorker2.IsBusy)
                    {
                        MessageBox.Show("يرجى إعادة المحاولة مرّة أخرى.", "نصيحة", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    }
                    else
                    {
                        var debug1 = MessageBox.Show("هل تريد إسنعادة الملف hosts إلى حالته الأصليّة؟", "حدث خطأ", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                        if (debug1 == DialogResult.Yes)
                        {
                            this.ControlBox = false;
                            hajbdisabled.Visible = true;
                            busy.Visible = true;
                            backgroundWorker2.RunWorkerAsync();
                        }

                    }

                }
                else
                {
                    MessageBox.Show("يرجى إعادة المحاولة بعد إنتهاء عمليّة حجب المواقع.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                }

            }


        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {


            try
            {
                FileInfo hostsnfo = new FileInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts"));
                //إلغاء السمة للقراءة فقط
                hostsnfo.IsReadOnly = false;
                File.SetAttributes(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts"), FileAttributes.Normal);
            }
            catch (Exception ex)
            {
                this.ControlBox = true;
                hajbdisabled.Visible = false;
                busy.Visible = false;

                try
                {
                    System.Diagnostics.Process.Start("https://forms.gle/cMBi3N1hvzjGmXex9");
                }
                catch
                { }

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                MessageBox.Show("لم يتمّ إستعادة الملف hosts إلى حالته الأصليّة، حاول مرّة أخرى.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                return;
            }

            //hosts حذف المواقع التي أضافها البرنامج إلى الملف
            //twbh حذف السطور التي تحتوي على كلمة
            try
            {
                string search_text = "twbh";
                string old;
                string n = "";
                StreamReader sr = File.OpenText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts"));
                while ((old = sr.ReadLine()) != null)
                {
                    if (!old.Contains(search_text))
                    {
                        n += old + Environment.NewLine;
                    }
                }
                sr.Close();
                File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts"), n);
            }
            catch (Exception ex)
            {
                this.ControlBox = true;
                hajbdisabled.Visible = false;
                busy.Visible = false;

                try
                {
                    System.Diagnostics.Process.Start("https://forms.gle/cMBi3N1hvzjGmXex9");
                }
                catch
                { }

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                MessageBox.Show("لم يتمّ إستعادة الملف hosts إلى حالته الأصليّة، حاول مرّة أخرى.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                return;
            }

            //تنشيط السمة للقراءة فقط
            try
            {
                FileInfo hostsnfo2 = new FileInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts"));
                hostsnfo2.IsReadOnly = true;
            }
            catch (Exception ex)
            {
                this.ControlBox = true;
                hajbdisabled.Visible = false;
                busy.Visible = false;

                try
                {
                    System.Diagnostics.Process.Start("https://forms.gle/cMBi3N1hvzjGmXex9");
                }
                catch
                { }

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                MessageBox.Show("لم يتمّ إستعادة الملف hosts إلى حالته الأصليّة، حاول مرّة أخرى.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                return;
            }

            //إنتظار 10 ثواني
            Thread.Sleep(10000);

            //بعد إنتهاء عملية استعادة الملف إلى حالته الأصلية
            this.ControlBox = true;
            hajbdisabled.Visible = false;
            busy.Visible = false;

            //async إيقاف
            backgroundWorker1.CancelAsync();

            //إظهار رسالة تم
            MessageBox.Show("تمّ إستعادة الملف hosts إلى حالته الأصليّة.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            backgroundWorker2.CancelAsync();
        }


        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.ControlBox = true;
            hajbdisabled.Visible = false;
            busy.Visible = false;
            Cursor.Current = Cursors.Default;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(1);
        }
    }
}
