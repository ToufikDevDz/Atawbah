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
        public Form1()
        {
           InitializeComponent();
           //التحقق من وجود إصدار جديد
           try
           {
              WebClient web1 = new WebClient();
              Stream stream1 = web1.OpenRead("https://pastebin.com/raw/RJCWm0x3");
              using (StreamReader reader = new StreamReader(stream1))
              {
                 String textakhiralisdarfilmawqii = reader.ReadToEnd();
                 raqmalisdarmawqi.Text = textakhiralisdarfilmawqii;
                 var mwq = Convert.ToInt32(raqmalisdarmawqi.Text);
                 var brn = Convert.ToInt32(raqmalisdarfibarnamj.Text);
                 if (mwq > brn)
                 {
                    //فتح نافذة إصدار جديد
                    Form isdarjadid = new Form5();
                    isdarjadid.ShowDialog();
                 }
              }
           }

           //لمنع ظهور رسالة الخطأ أثناء تعذر الإتصال بالخادم
           catch { }

           //LinqBridge.dll التحقق من وجود الملف 
           if (!File.Exists("LinqBridge.dll"))
           {
               MessageBox.Show("ينقص الملف LinqBridge.dll، قم بإعادة تحميل البرنامج من موقعه الرسمي.", "حدث خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
               Application.Exit();
           }

           //آخر الأخبار
            try
           {
               WebClient web2 = new WebClient();
               Stream stream2 = web2.OpenRead("https://pastebin.com/raw/zXugwVBD");
               using (StreamReader reader2 = new StreamReader(stream2))
               {
                   String text1 = reader2.ReadToEnd();
                   Akhbar.Text = text1;
               }
           }
        
           //لمنع ظهور رسالة الخطأ أثناء تعذر الإتصال بالخادم
           catch { }


           //Alt+F4 من الأمور الخاصة بتعطيل 
           this.KeyPreview = true;
        }

        //hosts موقع الملف 
        string pathhosts = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts");

        //ما يحدث للواجهة أثناء عملية التنفيذ
        public void intidhar()
        {
            this.ControlBox = false;
            hajbdisabled.Visible = true;
            busy.Visible = true;
        }

        //إذا حدث خطأ أثناء عملية التنفيذ
        public void khataafitanfid()
        {
           //إظهار أزرار النافذة، وتنشيط زر حجب المواقع بإخفاء الزر الذي فوقه، وإخفاء الصورة المتحركة للتقدم
           this.ControlBox = true;
           hajbdisabled.Visible = false;
           busy.Visible = false;

            //فتح نافذة الحل المقترح لمشكلة ظهور رسالة خطأ بعد الضغط على زر حجب المواقع
            //الخطوة الأولى : الانتظار قبل ظهور الرسالة - بدأ المؤقتة
            timer1.Enabled = true;
        }

        //بعد انتهاء عملية التنفيذ
        public void intihaa()
        {
           //إظهار أزرار النافذة، تنشيط زر حجب المواقع، وإخفاء الصورة المتحركة للتقدم
           this.ControlBox = true;
           hajbdisabled.Visible = false;
           busy.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //Alt+f4 تعطيل
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                e.Handled = true;
            }

            //Ctrl + B حدث خطأ؟ يمكن استعادة الملف إلى حالته الأصلية بالضغط على الأزرار
            if (e.Control && e.KeyCode == Keys.B)
            {
                if (!backgroundWorker1.IsBusy && !backgroundWorker2.IsBusy && !backgroundWorker3.IsBusy && !backgroundWorker4.IsBusy && !backgroundWorker5.IsBusy)
                {
                    var debug1 = MessageBox.Show("هل تريد إستعادة الملف hosts إلى حالته الأصليّة؟", "رسالة", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                    if (debug1 == DialogResult.Yes)
                    {
                        intidhar();
                        backgroundWorker2.RunWorkerAsync();
                    }
                }

                else
                {
                    MessageBox.Show("انتظر حتّى تكتمل العمليّة الأخرى ثم أعد المحاولة، بارك الله فيك.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }
            }


            //Ctrl + M حدث خطأ؟ يمكن إلغاء حجب بعض محرّكات البحث (التي لم يتمكن البرنامج من فرض ميزة الوضع الآمن فيها) (مثل ياهو ويندكس...) بالضغط على الأزرار
            if (e.Control && e.KeyCode == Keys.M)
            {
                if (!backgroundWorker1.IsBusy && !backgroundWorker2.IsBusy && !backgroundWorker3.IsBusy && !backgroundWorker4.IsBusy && !backgroundWorker5.IsBusy)
                {
                     var debug2 = MessageBox.Show("هل تريد إلغاء حجب بعض محرّكات البحث؟", "رسالة", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                     if (debug2 == DialogResult.Yes)
                     {
                         intidhar();
                         backgroundWorker3.RunWorkerAsync();
                     }                  
                }

                else
                {
                    MessageBox.Show("انتظر حتّى تكتمل العمليّة الأخرى ثم أعد المحاولة، بارك الله فيك.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }
            }

            //Ctrl + Y  إلغاء فرض ميزة وضع تقييد المحتوى لليوتيوب بالضغط على الأزرار
            if (e.Control && e.KeyCode == Keys.Y)
            {
                if (!backgroundWorker1.IsBusy && !backgroundWorker2.IsBusy && !backgroundWorker3.IsBusy && !backgroundWorker4.IsBusy && !backgroundWorker5.IsBusy)
                {
                    var debug3 = MessageBox.Show("هل تريد إلغاء فرض ميزة وضع تقييد المحتوى لليوتيوب؟", "رسالة", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                    if (debug3 == DialogResult.Yes)
                    {
                        intidhar();
                        backgroundWorker4.RunWorkerAsync();
                    }
                }

                else
                {
                    MessageBox.Show("انتظر حتّى تكتمل العمليّة الأخرى ثم أعد المحاولة، بارك الله فيك.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }
            }

            //Ctrl + G إلغاء فرض ميزة البحث الآمن لمحركات البحث جوجل وبنج بالضغط على الأزرار
            if (e.Control && e.KeyCode == Keys.G)
            {
                if (!backgroundWorker1.IsBusy && !backgroundWorker2.IsBusy && !backgroundWorker3.IsBusy && !backgroundWorker4.IsBusy && !backgroundWorker5.IsBusy)
                {
                    var debug4 = MessageBox.Show("هل تريد إلغاء فرض ميزة البحث الآمن لمحركات البحث Google وBing؟", "رسالة", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                    if (debug4 == DialogResult.Yes)
                    {
                        intidhar();
                        backgroundWorker5.RunWorkerAsync();
                    }
                }

                else
                {
                    MessageBox.Show("انتظر حتّى تكتمل العمليّة الأخرى ثم أعد المحاولة، بارك الله فيك.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // أحيانا لا يمكن حذف ملفات البرنامج حتى بعد إغلاقه لذلك حاولنا إيجاد حل لهذه المشكلة فأضفنا
            //هذا الأمر للتجريب. بارك الله فيكم
            System.Environment.Exit(1);
        }

        private void btnhajb_Click(object sender, EventArgs e)
        {
            //تأثير عند الضغط
            btnhajb.BackgroundImage = Properties.Resources.hajb;
            btnhajb.Refresh();
            btnhajb.BackgroundImage = Properties.Resources.lighthajb;

        //عدم التنفيذ إذا تمت العملية
            tah:
            var tma = Convert.ToInt32(tammaawla.Text);  
            if (tma == 1)
            {
                //إذا لم يكن الملف موجودا أو تم حذفه، يمكن إعادة عملية التنفيذ
                if (!File.Exists(pathhosts))
                {
                    tammaawla.Text = "0";
                    goto tah;
                }
                else
                {
                   //إذا كان الملف موجودا تظهر رسالة تم بإذن الله

                   //غلق النوافذ الأخرى
                   //jari

                   //ظهور رسالة تم بإذن الله
                   Form tammaform = new Form2();
                   tammaform.ShowDialog();
                }
            }

            if (tma == 0)
            {
                //التنفيذ
                if (!backgroundWorker1.IsBusy && !backgroundWorker2.IsBusy && !backgroundWorker3.IsBusy && !backgroundWorker4.IsBusy && !backgroundWorker5.IsBusy)
                {
                    intidhar();
                    backgroundWorker1.RunWorkerAsync();
                }
            }
        }

        private void btnhajb_MouseEnter(object sender, EventArgs e)
        {
            btnhajb.BackgroundImage = Properties.Resources.lighthajb;
        }

        private void btnhajb_MouseLeave(object sender, EventArgs e)
        {
            btnhajb.BackgroundImage = Properties.Resources.hajb;
        }

        private void hajbdisabled_Click(object sender, EventArgs e)
        {
            //فتح نافذة اصبر جاري عملية حجب المواقع
            //تظهر أثناء عملية الحجب فقط
            if (backgroundWorker1.IsBusy)
            {
                Form isbirform = new Form4();
                isbirform.ShowDialog();
            }
            if (!backgroundWorker1.IsBusy)
            {
                MessageBox.Show("انتظر حتّى تكتمل العمليّة الأخرى ثم أعد المحاولة، بارك الله فيك.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //التحقق من وجود الملف
                if (!File.Exists(pathhosts))
                {
                    //إنشاء الملف إذا لم يكن موجودا
                    using (StreamWriter w = File.AppendText(pathhosts));
                    goto starthajb;
                }

                starthajb:
                //hosts إلغاء السمة للقراءة فقط والسمات الأخرى للملف
                FileInfo hostsnfo = new FileInfo(pathhosts);
                File.SetAttributes(pathhosts, FileAttributes.Normal);

                //hosts حذف المواقع التي أضافها البرنامج إلى الملف
                //(twbh حذف السطور التي تحتوي على كلمة)
                string search_text = "twbh";
                string old;
                string n = "";
                StreamReader sr = File.OpenText(pathhosts);

                while ((old = sr.ReadLine()) != null)
                {
                    if (!old.Contains(search_text))
                    {
                        n += old + Environment.NewLine;
                    }
                }

                sr.Close();
                File.WriteAllText(pathhosts, n);

                //hosts إضافة السطور إلى الملف 
                using (StreamWriter sw = File.AppendText(pathhosts))
                {
                    sw.WriteLine(Properties.Resources.qaimatalmawaqi);
                }

                //حذف السطور المكررة
                string[] lines = File.ReadAllLines(pathhosts);
                File.WriteAllLines(pathhosts, lines.Distinct().ToArray());

                //تنشيط السمة للقراءة فقط
                hostsnfo.IsReadOnly = true;

                //Flush DNS
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "/C ipconfig /flushdns";
                startInfo.Verb = "runas";
                process.StartInfo = startInfo;
                process.Start();
            }

            catch (Exception k)
            {
                //إذا حدث خطأ، تتوقف العملية وتظهر رسالة الخطأ
                khataafitanfid();
                MessageBox.Show(k.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

        //إنتظار 30 ثانية
        Thread.Sleep(30000);

        //بعد إنتهاء عملية حجب المواقع
        intihaa();

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
            intihaa();
            Cursor.Current = Cursors.Default;
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

           try { 
           //hosts إلغاء السمة للقراءة فقط والسمات الأخرى للملف
           FileInfo hostsnfo = new FileInfo(pathhosts);   
           File.SetAttributes(pathhosts, FileAttributes.Normal);
 

           //hosts حذف المواقع التي أضافها البرنامج إلى الملف
           //twbh حذف السطور التي تحتوي على كلمة
           string search_text = "twbh";
           string old;
           string n = "";
           StreamReader sr = File.OpenText(pathhosts);

                while ((old = sr.ReadLine()) != null)
                {
                    if (!old.Contains(search_text))
                    {
                        n += old + Environment.NewLine;
                    }
                }

                sr.Close();
                File.WriteAllText(pathhosts, n);
        
           //تنشيط السمة للقراءة فقط
           FileInfo hostsnfo2 = new FileInfo(pathhosts);
           hostsnfo2.IsReadOnly = true;
           }

           catch (Exception k2)
           {
               khataafitanfid();
               MessageBox.Show(k2.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
               MessageBox.Show("لم تتمّ إستعادة الملف hosts إلى حالته الأصليّة، حاول مرّة أخرى.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
               return;
           }

           //إنتظار 10 ثواني
           Thread.Sleep(10000);

           //بعد إنتهاء عملية استعادة الملف إلى حالته الأصلية
           intihaa();

           //يمكن حجب المواقع مرة أخرى
           tammaawla.Text = "0";

           //async إيقاف
           backgroundWorker2.CancelAsync();

           //إظهار رسالة تم
           MessageBox.Show("تمّت إستعادة الملف hosts إلى حالته الأصليّة.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            intihaa();
            Cursor.Current = Cursors.Default;
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

        private void mawqi_MouseEnter(object sender, EventArgs e)
        {
            mawqi.BackgroundImage = Properties.Resources.lightmawqi;
        }

        private void mawqi_MouseLeave(object sender, EventArgs e)
        {
            mawqi.BackgroundImage = Properties.Resources.mawqi;
        }

        private void hawla_Click_1(object sender, EventArgs e)
        {
            //تأثير عند الضغط
            hawla.BackgroundImage = Properties.Resources.hawla;

            //فتح نافذة حول البرنامج
            Form hawlaform = new Form3();
            hawlaform.ShowDialog();
        }

        private void hawla_MouseEnter(object sender, EventArgs e)
        {
            hawla.BackgroundImage = Properties.Resources.lighthawla;
        }

        private void hawla_MouseLeave(object sender, EventArgs e)
        {
            hawla.BackgroundImage = Properties.Resources.hawla;
        }

        private void tahdith_Click(object sender, EventArgs e)
        {
            //التحقق من وجود إصدار جديد
            try
            {
                WebClient web3 = new WebClient();
                Stream stream3 = web3.OpenRead("https://pastebin.com/raw/RJCWm0x3");
                using (StreamReader reader = new StreamReader(stream3))
                {
                    String textakhiralisdarfilmawqii = reader.ReadToEnd();
                    raqmalisdarmawqi.Text = textakhiralisdarfilmawqii;
                    var mwq = Convert.ToInt32(raqmalisdarmawqi.Text);
                    var brn = Convert.ToInt32(raqmalisdarfibarnamj.Text);
                    //في حالة وجود إصدار جديد
                    if (mwq > brn)
                    {
                        //فتح نافذة إصدار جديد
                        Form isdarjadid = new Form5();
                        isdarjadid.ShowDialog();
                    }
                    //في حالة عدم وجود إصدار جديد
                    else
                    {
                        //فتح نافذة أنت تملك إصدار جديد
                        Form isdarjadid = new Form6();
                        isdarjadid.ShowDialog();
                    }
                }
            }

            //لمنع ظهور رسالة الخطأ أثناء تعذر الإتصال بالخادم
            catch { }
        }

        private void tahdith_MouseEnter(object sender, EventArgs e)
        {
            tahdith.BackgroundImage = Properties.Resources.lighttahdith;
        }

        private void tahdith_MouseLeave(object sender, EventArgs e)
        {
            tahdith.BackgroundImage = Properties.Resources.tahdith;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Flush DNS
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C ipconfig /flushdns";
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //فتح نافذة الحل المقترح لمشكلة ظهور رسالة خطأ بعد الضغط على زر حجب المواقع
            //الخطوة الثانية : إظهار النافذة
            timer1.Stop();
            Form halmoqtarah = new Form7();
            Enabled = false;
            halmoqtarah.ShowDialog();
            Enabled = true;
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            //إلغاء حجب بعض محرّكات البحث التي لم يتمكن البرنامج من فرض ميزة البحث الآمن عليها
            try
            {
                //hosts إلغاء السمة للقراءة فقط والسمات الأخرى للملف
                FileInfo hostsnfo = new FileInfo(pathhosts);
                File.SetAttributes(pathhosts, FileAttributes.Normal);


                //hosts حذف المواقع التي أضافها البرنامج إلى الملف
                //twbhmhrk حذف السطور التي تحتوي على كلمة
                string search_text = "twbhmhrk";
                string old;
                string n = "";
                StreamReader sr = File.OpenText(pathhosts);

                while ((old = sr.ReadLine()) != null)
                {
                    if (!old.Contains(search_text))
                    {
                        n += old + Environment.NewLine;
                    }
                }

                sr.Close();
                File.WriteAllText(pathhosts, n);

                //تنشيط السمة للقراءة فقط
                FileInfo hostsnfo3 = new FileInfo(pathhosts);
                hostsnfo3.IsReadOnly = true;
            }

            catch (Exception k3)
            {
                khataafitanfid();
                MessageBox.Show(k3.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                MessageBox.Show("لم يتمّ إلغاء حجب محرّكات البحث، حاول مرّة أخرى.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                return;
            }

            //إنتظار 10 ثواني
            Thread.Sleep(10000);

            //بعد إنتهاء عملية إلغاء حجب بعض محركات البحث
            intihaa();

            //يمكن حجب المواقع مرة أخرى
            tammaawla.Text = "0";

            //async إيقاف
            backgroundWorker3.CancelAsync();

            //إظهار رسالة تم
            MessageBox.Show("تمّ إلغاء حجب محرّكات البحث.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }

        private void backgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            intihaa();
            Cursor.Current = Cursors.Default;
        }

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            //إلغاء فرض ميزة "وضع تقييد المحتوى" لليوتيوب
            try
            {
                //hosts إلغاء السمة للقراءة فقط والسمات الأخرى للملف
                FileInfo hostsnfo = new FileInfo(pathhosts);
                File.SetAttributes(pathhosts, FileAttributes.Normal);


                //hosts حذف المواقع التي أضافها البرنامج إلى الملف
                //twbhytb حذف السطور التي تحتوي على كلمة
                string search_text = "twbhytb";
                string old;
                string n = "";
                StreamReader sr = File.OpenText(pathhosts);

                while ((old = sr.ReadLine()) != null)
                {
                    if (!old.Contains(search_text))
                    {
                        n += old + Environment.NewLine;
                    }
                }

                sr.Close();
                File.WriteAllText(pathhosts, n);

                //تنشيط السمة للقراءة فقط
                FileInfo hostsnfo4 = new FileInfo(pathhosts);
                hostsnfo4.IsReadOnly = true;
            }

            catch (Exception k4)
            {
                khataafitanfid();
                MessageBox.Show(k4.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                MessageBox.Show("لم يتمّ إلغاء فرض ميزة وضع تقييد المحتوى لليوتيوب، حاول مرّة أخرى.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                return;
            }

            //إنتظار 10 ثواني
            Thread.Sleep(10000);

            //بعد إنتهاء عملية إلغاء فرض ميزة وضع تقييد المحتوى لليوتيوب
            intihaa();

            //يمكن حجب المواقع مرة أخرى
            tammaawla.Text = "0";

            //async إيقاف
            backgroundWorker4.CancelAsync();

            //إظهار رسالة تم
            MessageBox.Show("تمّ إلغاء فرض ميزة وضع تقييد المحتوى لليوتيوب.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }

        private void backgroundWorker4_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            intihaa();
            Cursor.Current = Cursors.Default;
        }

        private void backgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
        {
            //إلغاء فرض ميزة البحث الآمن لمحركات البحث جوجل وبنج
            try
            {
                //hosts إلغاء السمة للقراءة فقط والسمات الأخرى للملف
                FileInfo hostsnfo = new FileInfo(pathhosts);
                File.SetAttributes(pathhosts, FileAttributes.Normal);


                //hosts حذف المواقع التي أضافها البرنامج إلى الملف
                //twbhamn حذف السطور التي تحتوي على كلمة
                string search_text = "twbhamn";
                string old;
                string n = "";
                StreamReader sr = File.OpenText(pathhosts);

                while ((old = sr.ReadLine()) != null)
                {
                    if (!old.Contains(search_text))
                    {
                        n += old + Environment.NewLine;
                    }
                }

                sr.Close();
                File.WriteAllText(pathhosts, n);

                //تنشيط السمة للقراءة فقط
                FileInfo hostsnfo5 = new FileInfo(pathhosts);
                hostsnfo5.IsReadOnly = true;
            }

            catch (Exception k5)
            {
                khataafitanfid();
                MessageBox.Show(k5.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                MessageBox.Show("لم يتمّ إلغاء فرض ميزة البحث الآمن لمحرّكات البحث Google وBing، حاول مرّة أخرى.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                return;
            }

            //إنتظار 10 ثواني
            Thread.Sleep(10000);

            //بعد إنتهاء عملية إلغاء فرض ميزة البحث الآمن لمحركات البحث جوجل وبنج
            intihaa();

            //يمكن حجب المواقع مرة أخرى
            tammaawla.Text = "0";

            //async إيقاف
            backgroundWorker5.CancelAsync();

            //إظهار رسالة تم
            MessageBox.Show("تمّ إلغاء فرض ميزة البحث الآمن لمحرّكات البحث Google وBing.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }

        private void backgroundWorker5_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            intihaa();
            Cursor.Current = Cursors.Default;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form hal = new Form2();
            hal.ShowDialog();
        }
    }
}
