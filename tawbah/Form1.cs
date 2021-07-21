//هام
//الأكواد المقتبسة من المواقع سواء بتصرف أو بدونه مكتوبة بين شولتين (//"  //") ومصادرها مذكورة في آخر الصفحة 
//حذار من روابط المصادر، فقد تحتوي على صور النساء، ننصحك بحجب الصور في المتصفح قبل الدخول إليها

using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace tawbah
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //LinqBridge.dll التحقق من وجود الملف 
            if (!File.Exists("LinqBridge.dll"))
            {
                MessageBox.Show("ينقص الملف LinqBridge.dll، قم بإعادة تحميل البرنامج من موقعه الرّسمي ثم حاول تشغيله مرّة أخرى.", "حدث خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                System.Environment.Exit(1);
            }

            //Alt+F4 من الأوامر الخاصة بتعطيل 
            this.KeyPreview = true;

            //إخفاء فقاعة جديد
            if (Properties.Settings.Default.foqa3ajadid == false)
            {
                foqa3ajadid.Visible = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //التحقق من وجود إصدار جديد
            try
            {
                //"
                WebClient web = new WebClient();
                Stream stream = web.OpenRead("https://pastebin.com/raw/RJCWm0x3");
                using (StreamReader reader = new StreamReader(stream))
                {
                    String textakhiralisdarfilmawqii = reader.ReadToEnd();  //" م1 بتصرف
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

            //لمنع ظهور رسالة الخطأ عند تعذر الإتصال بالخادم
            catch { }


            //آخر الأخبار
            try
            {
                //"
                WebClient web2 = new WebClient();
                Stream stream2 = web2.OpenRead("https://pastebin.com/raw/zXugwVBD");
                using (StreamReader reader2 = new StreamReader(stream2))
                {
                    String text1 = reader2.ReadToEnd(); //" م1 بتصرف
                    Akhbar.Text = text1;
                }
            }

            //لمنع ظهور رسالة الخطأ عند تعذر الإتصال بالخادم
            catch { }

            //تهاني
            //العيد
            var akhbar = Akhbar.Text;
            if (akhbar.Contains("عيدك") | akhbar.Contains("تقبل الله"))
            {
                tahnia.BackgroundImage = Properties.Resources.al3id;
                tahnia.Visible = true;
            }

            //رمضان
            if (akhbar.Contains("رمضان"))
            {
                tahnia.BackgroundImage = Properties.Resources.ramadan;
                tahnia.Visible = true;
            }           

        }

        //Flush Dns
        public void flush()
        {
            //"
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C ipconfig /flushdns";
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            process.Start(); //" م2
        }

        //Dnscache تفعيل وتشغيل
        private void tachghildnscache()
        {
            //تفعيلها
            try
            {
                //"
                RegistryKey myKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\services\\Dnscache", true);
                if (myKey != null)
                {
                    myKey.SetValue("Start", "2", RegistryValueKind.String);
                    myKey.Close(); //" م3 بتصرف
                }
            }
            catch { }

            //تشغيلها
            //"
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C net start dnscache";
            process.StartInfo = startInfo;
            process.Start(); //" م2 بتصرف
        }

        //Dnscache إيقاف وإلغاء تفعيل
        //أضفنا هذا الأمر لحل مشكلة ظهور رسالة الخطأ أثناء العمليات عندما يكون ملف هوستس كبير
        private void iqafdnscache()
        {
            //إيقافها
            //"
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C net stop dnscache";
            process.StartInfo = startInfo;
            process.Start(); //" م2 بتصرف

            //إلغاء تفعيلها
            try
            {
                //"
                RegistryKey myKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\services\\Dnscache", true);
                if (myKey != null)
                {
                    myKey.SetValue("Start", "4", RegistryValueKind.String);
                    myKey.Close(); //" م3 بتصرف
                }
            }
            catch { }
        }

        //hosts موقع الملف 
        string pathhosts = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts");

        //ما يحدث للواجهة أثناء عملية التنفيذ
        public void intidhar()
        {
            this.ControlBox = false;
            this.UseWaitCursor = true;
            busy.Visible = true;
            hajbdisabled.Visible = true;

            //تعطيل الأزرار
            hawla.Enabled = false;
            mawqi.Enabled = false;
            tahdith.Enabled = false;
            zirmayzat.Enabled = false;
            hawla.BackgroundImage = Properties.Resources.hawlamoatal;
            mawqi.BackgroundImage = Properties.Resources.mawqimoatal;
            tahdith.BackgroundImage = Properties.Resources.tahdithmoatal;
            zirmayzat.BackgroundImage = Properties.Resources.ziralmayzatmoatal;
            hajbdisabled.BackgroundImage = Properties.Resources.hajbmoatal;
        }

        //إذا حدث خطأ أثناء عملية التنفيذ
        public void khataafitanfid()
        {
            //إظهار أزرار النافذة، وتنشيط زر حجب المواقع بإخفاء الزر الذي فوقه، وإخفاء الصورة المتحركة للتقدم واسترجاع مؤشر الفأرة إلى حالته الأصلية وتفعيل الأزرار
            intihaa();

            //فتح نافذة الحلول المقترح لمشكلة ظهور رسالة خطأ بعد الضغط على زر حجب المواقع
            //الخطوة الأولى : الانتظار قبل ظهور الرسالة - بدأ المؤقتة
            timer1.Enabled = true;
        }

        //إظهار أزرار النافذة، وتنشيط زر حجب المواقع بإخفاء الزر الذي فوقه، وإخفاء الصورة المتحركة للتقدم واسترجاع مؤشر الفأرة إلى حالته الأصلية وتفعيل الأزرار
        //تستخدم بعد انتهاء العمليات
        public void intihaa()
        {
            //Dnscache تفعيل وتشغيل
            tachghildnscache();

            //...
            this.ControlBox = true;
            this.UseWaitCursor = false;
            busy.Visible = false;
            hajbdisabled.Visible = false;

            //تفعيل الأزرار
            hawla.Enabled = true;
            mawqi.Enabled = true;
            tahdith.Enabled = true;
            zirmayzat.Enabled = true;
            hawla.BackgroundImage = Properties.Resources.hawla;
            mawqi.BackgroundImage = Properties.Resources.mawqi;
            tahdith.BackgroundImage = Properties.Resources.tahdith;
            zirmayzat.BackgroundImage = Properties.Resources.ziralmayzat;
            hajbdisabled.BackgroundImage = Properties.Resources.hajb;

            //تحديث النافذة
            //لحل مشكلة قد تحدث أحيانا بعد انتهاء العملية تتمثل في عدم تغير صورة المؤشر إلى صورة اليد إذا كان فوق الزر 
            this.flush();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //أثناء العمليات Alt+f4 تعطيل
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                if (backgroundWorker1.IsBusy | backgroundWorker2.IsBusy | backgroundWorker3.IsBusy | backgroundWorker4.IsBusy)
                {
                    //تعطيل
                    e.Handled = true;
                }
                else
                {
                    //تفعيل
                    e.Handled = false;
                }
            }


            //Ctrl + B حدث خطأ؟ يمكن استعادة الملف إلى حالته الأصلية بالضغط على الأزرار
            if (e.Control && e.KeyCode == Keys.B)
            {
                if (!backgroundWorker1.IsBusy && !backgroundWorker2.IsBusy && !backgroundWorker3.IsBusy && !backgroundWorker4.IsBusy)
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


            //Ctrl + K حدث خطأ؟ يمكن إلغاء حجب بعض محرّكات البحث (التي لم يتمكن البرنامج من فرض ميزة الوضع الآمن لها) (مثل ياهو ويندكس...) بالضغط على الأزرار
            if (e.Control && e.KeyCode == Keys.K)
            {
                if (!backgroundWorker1.IsBusy && !backgroundWorker2.IsBusy && !backgroundWorker3.IsBusy && !backgroundWorker4.IsBusy)
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


            //Ctrl + G إلغاء فرض ميزة البحث الآمن لمحركات البحث جوجل وبنج بالضغط على الأزرار
            if (e.Control && e.KeyCode == Keys.G)
            {
                if (!backgroundWorker1.IsBusy && !backgroundWorker2.IsBusy && !backgroundWorker3.IsBusy && !backgroundWorker4.IsBusy)
                {
                    var debug4 = MessageBox.Show("هل تريد إلغاء فرض ميزة البحث الآمن لمحركات البحث Google وBing؟", "رسالة", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

                    if (debug4 == DialogResult.Yes)
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
                //إذا كان الملف غير موجودا أو تم حذفه، يمكن إعادة عملية التنفيذ
                if (!File.Exists(pathhosts))
                {
                    tammaawla.Text = "0";
                    goto tah;
                }
                else
                {
                    //إذا كان الملف موجودا تظهر رسالة تم الحجب، بإذن الله
                    Form tammaform = new Form2();
                    tammaform.ShowDialog();
                }
            }

            if (tma == 0)
            {
                //التنفيذ
                if (!backgroundWorker1.IsBusy && !backgroundWorker2.IsBusy && !backgroundWorker3.IsBusy && !backgroundWorker4.IsBusy)
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //عملية حجب المواقع الخبيثة
            try
            {
                //hosts التحقق من وجود الملف
                if (!File.Exists(pathhosts))
                {
                    //إنشاء الملف إذا كان غير موجودا
                    //"
                    using (StreamWriter w = File.AppendText(pathhosts)); //" م4 بتصرف
                    goto starthajb;
                }

            starthajb:
                //Dnscache إيقاف وإلغاء تفعيل
                iqafdnscache();
                Thread.Sleep(5000);

                //إلغاء السمة للقراءة فقط والسمات الأخرى للملف
                FileInfo hostsnfo = new FileInfo(pathhosts);
                File.SetAttributes(pathhosts, FileAttributes.Normal);

                //(حذف >بعض< الأسطر التي أضافها البرنامج إلى الملف (لا يحذف الأسطر الخاصة بمانع الإعلانات مثلا
                //حذف الأسطر التي تحتوي على الكلمات كما هي، كاملة
                //twbh و twbhmwq3 و twbhmhrk و twbhamn
                //"
                var oldLines = System.IO.File.ReadAllLines(pathhosts);
                var newLines = oldLines.Select(line => new {
                    Line = line,
                    Words = line.Split(' ')
                })
                        //الكلمات الخاصة بالإصدارات القديمة والجديدة
                        .Where(lineInfo => !lineInfo.Words.Contains("twbh") && !lineInfo.Words.Contains("twbhmwq3") && !lineInfo.Words.Contains("twbhamn") && !lineInfo.Words.Contains("twbhmhrk"))
                        .Select(lineInfo => lineInfo.Line);
                System.IO.File.WriteAllLines(pathhosts, newLines.ToArray()); //" م5 بتصرف


                //إضافة المواقع إلى الملف 
                //"
                using (StreamWriter sw = File.AppendText(pathhosts))
                {
                    sw.WriteLine(Properties.Resources.qaimatalmawaqi);
                } //" م6 بتصرف

                //حذف الأسطر المكررة
                //"
                string[] lines = File.ReadAllLines(pathhosts);
                File.WriteAllLines(pathhosts, lines.Distinct().ToArray()); //" م7 بتصرف

                //تنشيط السمة للقراءة فقط
                hostsnfo.IsReadOnly = true;

                //Flush DNS
                flush();
            }

            catch (Exception k)
            {
                //إذا حدث خطأ، تتوقف العملية وتظهر رسالة الخطأ           
                khataafitanfid();
                MessageBox.Show(k.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            //async إيقاف
            backgroundWorker1.CancelAsync();

            //إنتظار 5 ثواني
            Thread.Sleep(5000);

            //إظهار رسالة تم
            Form tammaform = new Form2();
            tammaform.ShowDialog();

            //لا يمكن التنفيذ مرة أخرى إن شاء الله لأن العملية انتهت والحمد لله
            tammaawla.Text = "1";

            //بعد إنتهاء عملية حجب المواقع
            intihaa();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            //عملية استعادة الملف هوستس إلى حالته الأصلية
            try
            {
                //hosts التحقق من وجود الملف
                if (!File.Exists(pathhosts))
                {
                    //إنشاء الملف إذا كان غير موجودا
                    //"
                    using (StreamWriter w = File.AppendText(pathhosts)); //" م4 بتصرف
                    goto start3amaliya;
                }

            start3amaliya:
                //Dnscache إيقاف وإلغاء تفعيل
                iqafdnscache();
                Thread.Sleep(5000);

                //hosts إلغاء السمة للقراءة فقط والسمات الأخرى للملف
                FileInfo hostsnfo = new FileInfo(pathhosts);
                File.SetAttributes(pathhosts, FileAttributes.Normal);

                //حذف المواقع التي أضافها البرنامج إلى الملف
                //twbahو twbh حذف الأسطر التي تحتوي على كلمة
                //"
                string[] domains = { "twbh", "twbah"};
                string[] lines = File.ReadAllLines(pathhosts)
                                     .Where(l => !domains.Any(d => l.Contains(d)))
                                     .ToArray();

                File.WriteAllLines(pathhosts, lines); //" م8 بتصرف

                //تنشيط السمة للقراءة فقط
                FileInfo hostsnfo2 = new FileInfo(pathhosts);
                hostsnfo2.IsReadOnly = true;

                //Flush DNS
                flush();
            }

            catch (Exception k)
            {
                khataafitanfid();
                MessageBox.Show(k.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                MessageBox.Show("لم تتمّ إستعادة الملف hosts إلى حالته الأصليّة، حاول مرّة أخرى.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                return;
            }

            //async إيقاف
            backgroundWorker2.CancelAsync();

            //إنتظار 5 ثواني
            Thread.Sleep(5000);

            //بعد إنتهاء عملية استعادة الملف إلى حالته الأصلية
            intihaa();

            //يمكن حجب المواقع مرة أخرى
            tammaawla.Text = "0";

            //إظهار رسالة تم
            MessageBox.Show("تمّت إستعادة الملف hosts إلى حالته الأصليّة.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
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
            hawla.Refresh();
            hawla.BackgroundImage = Properties.Resources.lighthawla;

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
            //تأثير عند الضغط
            tahdith.BackgroundImage = Properties.Resources.tahdith;
            tahdith.Refresh();
            tahdith.BackgroundImage = Properties.Resources.lighttahdith;

            //التحقق من وجود إصدار جديد
            try
            {
                //"
                WebClient web = new WebClient();
                Stream stream = web.OpenRead("https://pastebin.com/raw/RJCWm0x3");
                using (StreamReader reader = new StreamReader(stream))
                {
                    String textakhiralisdarfilmawqii = reader.ReadToEnd(); //" م1 بتصرف
                    raqmalisdarmawqi.Text = textakhiralisdarfilmawqii;
                    var mwq = Convert.ToInt32(raqmalisdarmawqi.Text);
                    var brn = Convert.ToInt32(raqmalisdarfibarnamj.Text);
                    //في حالة وجود إصدار جديد
                    if (mwq > brn)
                    {
                        //فتح نافذة يوجد إصدار جديد للتحميل
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            //فتح نافذة الحلول المقترح لمشكلة ظهور رسالة خطأ بعد الضغط على زر حجب المواقع
            //الخطوة الثانية : إظهار النافذة
            timer1.Stop();
            Form halmoqtarah = new Form7();
            Enabled = false;
            halmoqtarah.ShowDialog();
            Enabled = true;
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            //إلغاء حجب بعض محرّكات البحث التي لم يتمكن البرنامج من فرض ميزة البحث الآمن لها
            try
            {
                //hosts التحقق من وجود الملف
                if (!File.Exists(pathhosts))
                {
                    //إنشاء الملف إذا كان غير موجودا
                    //"
                    using (StreamWriter w = File.AppendText(pathhosts)); //" م4 بتصرف
                    goto start3amaliya;
                }

            start3amaliya:
                //Dnscache إيقاف وإلغاء تفعيل
                iqafdnscache();
                Thread.Sleep(5000);

                //hosts إلغاء السمة للقراءة فقط والسمات الأخرى للملف
                FileInfo hostsnfo = new FileInfo(pathhosts);
                File.SetAttributes(pathhosts, FileAttributes.Normal);


                //hosts حذف المواقع التي أضافها البرنامج إلى الملف
                //twbhmhrk حذف الأسطر التي تحتوي على كلمة
                //"
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
                File.WriteAllText(pathhosts, n); //" م9 بتصرف

                //تنشيط السمة للقراءة فقط
                FileInfo hostsnfo2 = new FileInfo(pathhosts);
                hostsnfo2.IsReadOnly = true;

                //Flush DNS
                flush();
            }

            catch (Exception k)
            {
                khataafitanfid();
                MessageBox.Show(k.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                MessageBox.Show("لم يتمّ إلغاء حجب محرّكات البحث، حاول مرّة أخرى.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                return;
            }

            //async إيقاف
            backgroundWorker3.CancelAsync();

            //إنتظار 5 ثواني
            Thread.Sleep(5000);

            //بعد إنتهاء عملية إلغاء حجب بعض محركات البحث
            intihaa();

            //يمكن حجب المواقع مرة أخرى
            tammaawla.Text = "0";

            //إظهار رسالة تم
            MessageBox.Show("تمّ إلغاء حجب محرّكات البحث.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            //إلغاء فرض ميزة البحث الآمن لمحركات البحث جوجل وبنج
            try
            {
                //hosts التحقق من وجود الملف
                if (!File.Exists(pathhosts))
                {
                    //إنشاء الملف إذا كان غير موجودا
                    //"
                    using (StreamWriter w = File.AppendText(pathhosts));
                    //" م4 بتصرف
                    goto start3amaliya;
                }

            start3amaliya:
                //Dnscache إيقاف وإلغاء تفعيل
                iqafdnscache();
                Thread.Sleep(5000);

                //hosts إلغاء السمة للقراءة فقط والسمات الأخرى للملف
                FileInfo hostsnfo = new FileInfo(pathhosts);
                File.SetAttributes(pathhosts, FileAttributes.Normal);


                //hosts حذف المواقع التي أضافها البرنامج إلى الملف
                //twbhamn حذف الأسطر التي تحتوي على كلمة
                //"
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
                File.WriteAllText(pathhosts, n); //" م9 بتصرف

                //تنشيط السمة للقراءة فقط
                FileInfo hostsnfo2 = new FileInfo(pathhosts);
                hostsnfo2.IsReadOnly = true;

                //Flush DNS
                flush();
            }

            catch (Exception k)
            {
                khataafitanfid();
                MessageBox.Show(k.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                MessageBox.Show("لم يتمّ إلغاء فرض ميزة البحث الآمن لمحرّكات البحث Google وBing، حاول مرّة أخرى.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                return;
            }

            //async إيقاف
            backgroundWorker4.CancelAsync();

            //إنتظار 5 ثواني
            Thread.Sleep(5000);

            //بعد إنتهاء عملية إلغاء فرض ميزة البحث الآمن لمحركات البحث جوجل وبنج
            intihaa();

            //يمكن حجب المواقع مرة أخرى
            tammaawla.Text = "0";

            //إظهار رسالة تم
            MessageBox.Show("تمّ إلغاء فرض ميزة البحث الآمن لمحرّكات البحث Google وBing.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }

        private void ziri3dadat_Click(object sender, EventArgs e)
        {
            //تأثير عند الضغط
            ziri3dadat.BackgroundImage = Properties.Resources.i3dadat;
            ziri3dadat.Refresh();
            Thread.Sleep(100);
            ziri3dadat.BackgroundImage = Properties.Resources.lighti3dadat;

            //فتح نافذة إعدادات البرنامج البرنامج
            //لا يوجد إعدادات

            //فتح نافذة الحلول مقترح -> للتجريب فقط
            //Form halmoqform = new Form7();
            //halmoqform.ShowDialog();
        }

        private void ziri3dadat_MouseEnter(object sender, EventArgs e)
        {
            ziri3dadat.BackgroundImage = Properties.Resources.lighti3dadat;
        }

        private void ziri3dadat_MouseLeave(object sender, EventArgs e)
        {
            ziri3dadat.BackgroundImage = Properties.Resources.i3dadat;
        }

        private void zirmayzat_Click(object sender, EventArgs e)
        {
            //إخفاء فقاعة جديد وحفظ حالتها لكي لا تظهر في المرة القادمة إن شاء الله
            foqa3ajadid.Visible = false;
            Properties.Settings.Default.foqa3ajadid = false;
            Properties.Settings.Default.Save();

            //تأثير عند الضغط
            zirmayzat.BackgroundImage = Properties.Resources.ziralmayzat;
            zirmayzat.Refresh();
            Thread.Sleep(100);
            zirmayzat.BackgroundImage = Properties.Resources.lightziralmayzat;

            //فتح نافذة المزيد من الميزات
            Form almazidminalmayzatform = new Form4();
            almazidminalmayzatform.ShowDialog();
        }

        private void zirmayzat_MouseEnter(object sender, EventArgs e)
        {
            zirmayzat.BackgroundImage = Properties.Resources.lightziralmayzat;
        }

        private void zirmayzat_MouseLeave(object sender, EventArgs e)
        {
            zirmayzat.BackgroundImage = Properties.Resources.ziralmayzat;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // أحيانا لا يمكن حذف ملفات البرنامج حتى بعد إغلاقه لذلك حاولنا إيجاد حل لهذه المشكلة فأضفنا
            //هذا الأمر للتجريب. بارك الله فيكم
            Environment.Exit(1);
        }

    }
}

//مصادر أكواد البرنامج

    //المصدر م1
    //Phill, Stack Overflow, https://stackoverflow.com/a/4758360, 
    //CC BY-SA 2.5, https://creativecommons.org/licenses/by-sa/2.5/

    //المصدر م2
    //R1CH101, Stack Overflow, https://stackoverflow.com/a/45909851, 
    //CC BY-SA 3.0, https://creativecommons.org/licenses/by-sa/3.0/  

    //المصدر م3
    //Jontatas, Stack Overflow, https://stackoverflow.com/a/8816229, 
    //CC BY-SA 3.0, https://creativecommons.org/licenses/by-sa/3.0/  

    //المصدر م4
    //Chris Gessler, Stack Overflow, https://stackoverflow.com/a/10383123, 
    //CC BY-SA 3.0, https://creativecommons.org/licenses/by-sa/3.0/  

    //المصدر م5
    //Tim Schmelter, Stack Overflow, https://stackoverflow.com/a/10371680, 
    //CC BY-SA 3.0, https://creativecommons.org/licenses/by-sa/3.0/  

    //المصدر م6
    //Gabe, Stack Overflow, https://stackoverflow.com/a/2837040, 
    //CC BY-SA 3.0, https://creativecommons.org/licenses/by-sa/3.0/

    //المصدر م7
    //Darin Dimitrov, Stack Overflow, https://stackoverflow.com/a/1245524, 
    //CC BY-SA 2.5, https://creativecommons.org/licenses/by-sa/2.5/

    //المصدر م8
    //Sergey Berezovskiy, Stack Overflow, https://stackoverflow.com/a/20344108, 
    //CC BY-SA 3.0, https://creativecommons.org/licenses/by-sa/3.0/

    //المصدر م9
    //Md Kamruzzaman Sarker, Stack Overflow, https://stackoverflow.com/a/10371996, 
    //CC BY-SA 3.0, https://creativecommons.org/licenses/by-sa/3.0/