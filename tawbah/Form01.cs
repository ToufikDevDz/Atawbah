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
using System.Diagnostics;

namespace tawbah
{
    public partial class Form01 : Form
    {
        public Form01()
        {   
            //التحقق من وجود الملفات الأساسية للبرنامج وغلقه إذا لم تكن موجودة
                //LinqBridge.dll التحقق من وجود الملف 
                if (!File.Exists("LinqBridge.dll"))
                {
                    MessageBox.Show("ينقص الملف LinqBridge.dll، قم بإعادة تحميل البرنامج من موقعه الرّسمي، ثم حاول تشغيله مرّة أخرى.", "حدث خطأ", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    Environment.Exit(1);
                }

                //Atawbah.exe.config التحقق من وجود الملف 
                if (!File.Exists("Atawbah.exe.config"))
                {
                    MessageBox.Show("ينقص الملف Atawbah.exe.config، قم بإعادة تحميل البرنامج من موقعه الرّسمي، ثم حاول تشغيله مرّة أخرى.", "حدث خطأ", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    Environment.Exit(1);
                }

                //AltawbaMB.exe التحقق من وجود الملف 
                if (!File.Exists("AltawbaMB.exe"))
                {
                    MessageBox.Show("ينقص الملف AltawbaMB.exe، قم بإعادة تحميل البرنامج من موقعه الرّسمي، ثم حاول تشغيله مرّة أخرى.", "حدث خطأ", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                    Environment.Exit(1);
                }

            //تهيئة العناصر
            InitializeComponent();

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
                        Form isdarjadid = new Form05();
                        isdarjadid.ShowDialog();
                    }
                }
            }
            //لمنع ظهور رسالة الخطأ عند تعذر الإتصال بالخادم
            catch { }

            //إظهار رسالة في شريط الأخبار
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
            catch { }

            //إظهار نافذة التنبيهاب عند تشغيل البرنامج أول مرة
            if (Properties.Settings.Default.idhharNafidhatAlTanbihat == true)
            {
                Form hawlaform = new Form00();
                hawlaform.ShowDialog();
            }

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

            //Alt+F4 من الأوامر الخاصة بتعطيل 
            this.KeyPreview = true;
        }

//الدوال
    //hosts موقع الملف 
    string pathhosts = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts");

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
                    myKey.SetValue("Start", "2", RegistryValueKind.DWord);
                    myKey.Close(); //" م3 بتصرف
                }
            }
            /*إذا حدث خطأ في الأوامر الخاصة بالدي انس كاش لا تظهر رسائل الخطأ، فإذا نجح
            تفعيله فالحمد لله، وإلا سيحاول البرنامج إكمال العمليات الأخرى بدون تفعيله */
            catch { }

            //تشغيلها
            //"
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C net start dnscache";
            startInfo.Verb = "runas";
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
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            process.Start(); //" م2 بتصرف

            //إلغاء تفعيلها
            try
            {
                //"
                RegistryKey myKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\services\\Dnscache", true);
                if (myKey != null)
                {
                    myKey.SetValue("Start", "4", RegistryValueKind.DWord);
                    myKey.Close(); //" م3 بتصرف
                }
            }
            catch { }
        }

    //أوامر إزالة برنامج إيقاف تشغيل المتصفحات التي لا تدعم الحجب من قائمة البرامج التي يتم تشغيلها عند بدأ تشغيل ويندوز 
        public void izalatMBBT()
        {
            //إزالة القيمة من سجل النظام
            //"
            RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            key.DeleteValue("AltawbaMB"); //" م11 بتصرف          
        }

    //أوامر إيقاف برنامج إيقاف تشغيل المتصفحات التي لا تدعم الحجب
        public void iqafMBBT()
        {
            //"
            foreach (var process in Process.GetProcessesByName("AltawbaMB"))
            {
                process.Kill();
            } //" م9 بتصرف
        }

    //الأوامر الخاصة بظهور رسالة خطأ رقم 01
        public void khataa01() 
        {
            //إذا حدث خطأ، تتوقف العملية وتظهر رسالة الخطأ           
            khataafitanfidK01();
            MessageBox.Show("رقم الخطأ: 01", "حدث خطأ", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }

    //الأوامر الخاصة بظهور رسالة خطأ رقم 02
        public void khataa02()
        {
            //إذا حدث خطأ، تتوقف العملية وتظهر رسالة الخطأ           
            khataafitanfidK02();
            MessageBox.Show("رقم الخطأ: 02", "حدث خطأ", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }

    //ما يحدث للواجهة أثناء عملية التنفيذ
        public void intidhar()
        {
            //...
            this.UseWaitCursor = true;
            busy.Visible = true;

            //تعطيل الأزرار      
            hawla.BackgroundImage = Properties.Resources.hawlamoatal;
            hawla.Enabled = false;
            mawqi.BackgroundImage = Properties.Resources.mawqimoatal;
            mawqi.Enabled = false;
            tahdith.BackgroundImage = Properties.Resources.tahdithmoatal;
            tahdith.Enabled = false;
            zirmayzat.BackgroundImage = Properties.Resources.ziralmayzatmoatal;
            zirmayzat.Enabled = false;
            //تعطيل زر الحجب
            //إظهار نسخة زر الحجب التي فوقه، ولا يحدث شيئ إذا ضغطنا عليها
            //لم نستعمل نفس طريقة التعطيل لأنها لا تعمل جيدا
            fwqzirhajb.Visible = true;
        }

        //ما يحدث إذا حدث خطأ أثناء العمليات
        public void khataafitanfid()
        {
            //Dnscache تفعيل وتشغيل
            tachghildnscache();

            //إظهار أزرار النافذة، وتنشيط زر حجب المواقع بإخفاء الزر الذي فوقه، وإخفاء الصورة المتحركة للتقدم واسترجاع مؤشر الفأرة إلى حالته الأصلية وتفعيل الأزرار
            intihaa();

            //فتح نافذة الحلول المقترح لمشكلة ظهور رسالة الخطأ
            //الخطوة الأولى : الانتظار قبل ظهور الرسالة - بدأ المؤقتة
            timerRisalaKhataa.Enabled = true;
        }

    //ما يحدث إذا حدث خطأ رقم 01 أثناء العمليات  
        public void khataafitanfidK01()
        {
            //Dnscache تفعيل وتشغيل
            tachghildnscache();

            //إظهار أزرار النافذة، وتنشيط زر حجب المواقع بإخفاء الزر الذي فوقه، وإخفاء الصورة المتحركة للتقدم واسترجاع مؤشر الفأرة إلى حالته الأصلية وتفعيل الأزرار
            intihaa();

            //فتح نافذة الحلول المقترح لمشكلة ظهور رسالة خطأ
            //الخطوة الأولى : الانتظار قبل ظهور الرسالة - بدأ المؤقتة
            timerRisalaKhataa01.Enabled = true;
        }

        //ما يحدث إذا حدث خطأ رقم 02 أثناء العمليات  
        public void khataafitanfidK02()
        {
            //Dnscache تفعيل وتشغيل
            tachghildnscache();

            //إظهار أزرار النافذة، وتنشيط زر حجب المواقع بإخفاء الزر الذي فوقه، وإخفاء الصورة المتحركة للتقدم واسترجاع مؤشر الفأرة إلى حالته الأصلية وتفعيل الأزرار
            intihaa();

            //فتح نافذة الحلول المقترح لمشكلة ظهور رسالة الخطأ
            //الخطوة الأولى : الانتظار قبل ظهور الرسالة - بدأ المؤقتة
            timerRisalaKhataa02.Enabled = true;
        }

        //ما يحدث بعد انتهاء العمليات
        //تنشيط زر حجب المواقع بإخفاء الزر الذي فوقه، وإخفاء الصورة المتحركة للتقدم واسترجاع مؤشر الفأرة إلى حالته الأصلية وتفعيل الأزرار
        public void intihaa()
        {
            //...
            this.UseWaitCursor = false;
            busy.Visible = false;

            //تفعيل الأزرار
            hawla.BackgroundImage = Properties.Resources.hawla;
            hawla.Enabled = true;
            mawqi.BackgroundImage = Properties.Resources.mawqi;
            mawqi.Enabled = true;
            tahdith.BackgroundImage = Properties.Resources.tahdith;
            tahdith.Enabled = true;
            zirmayzat.BackgroundImage = Properties.Resources.ziralmayzat;
            zirmayzat.Enabled = true;
            //إخفاء نسخة زر الحجب
            fwqzirhajb.Visible = false;
        }

//أوامر مهمة
    //الأوامر الخاصة بظهور رسالة الخطأ
        //فتح نافذة الحل المقترح لمشكلة ظهور رسالة الخطأ رقم 01
        //(الخطوة الثانية : إظهار النافذة)
        private void timerRisalaKhataa01_Tick(object sender, EventArgs e)
        {
            timerRisalaKhataa01.Stop();
            Form halmoqtarahK01 = new Form08();
            halmoqtarahK01.ShowDialog();
        }

        //فتح نافذة الحل المقترح لمشكلة ظهور رسالة الخطأ رقم 02
        //(الخطوة الثانية : إظهار النافذة)
        private void timerRisalaKhataa02_Tick(object sender, EventArgs e)
        {
            timerRisalaKhataa02.Stop();
            Form halmoqtarahK02 = new Form09();
            halmoqtarahK02.ShowDialog();
        }

        //(فتح نافذة الحلول المقترح لمشكلة ظهور رسالة الخطأ (الرسائل الأخرى
        //(الخطوة الثانية : إظهار النافذة)
        private void timerRisalaKhataa_Tick(object sender, EventArgs e)
        {
            timerRisalaKhataa.Stop();
            Form halmoqtarah = new Form07();
            halmoqtarah.ShowDialog();
        }

        //ما يحدث أثناء غلق النافذة
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //منع غلق النافذة أثناء العمليات
            //عند ظهور الصورة المتحركة للانتظار
            if (busy.Visible == true)
            { 
                e.Cancel = true;
            }

            else
            {
                /*أحيانا لا يمكن حذف ملفات البرنامج حتى بعد إغلاقه لذلك حاولنا إيجاد حل لهذه المشكلة فأضفنا
                هذا الأمر للتجريب. بارك الله فيكم */
                Environment.Exit(1);
            }
        }

//العمليات
    //عملية حجب المواقع
        private void zirhajb_Click(object sender, EventArgs e)
        {
            //تأثير عند الضغط
            zirhajb.BackgroundImage = Properties.Resources.hajb;
            zirhajb.Refresh();
            Thread.Sleep(100);
            zirhajb.BackgroundImage = Properties.Resources.lighthajb;

            //عدم بدأ العملية إذا تمت من قبل
            int tma = Convert.ToInt32(tammaawla.Text);
            if (tma == 1)
            {
                //ظهور رسالة تم إذا تمت العملية من قبل بإذن الله
                Form tammaform = new Form02();
                tammaform.ShowDialog();
            }

            //التنفيذ إذا لم تتم العملية
            else
            {
                //التنفيذ
                if (!backgroundWorker1.IsBusy && !backgroundWorker2.IsBusy && !backgroundWorker3.IsBusy && !backgroundWorker4.IsBusy && !backgroundWorker5.IsBusy)
                {
                    intidhar();
                    backgroundWorker1.RunWorkerAsync();
                }
            }
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
                    using (File.Create(pathhosts)) { } //" م4 بتصرف
                    goto starthajb;
                }

            starthajb:
                //Dnscache إيقاف وإلغاء تفعيل
                iqafdnscache();

                //الانتظار ثانيتين
                Thread.Sleep(2000);

                //إلغاء السمة للقراءة فقط والسمات الأخرى للملف
                FileInfo hostsnfo = new FileInfo(pathhosts);
                File.SetAttributes(pathhosts, FileAttributes.Normal);

                //(حذف >بعض< الأسطر التي أضافها البرنامج إلى الملف (لا يحذف الأسطر الخاصة بمانع الإعلانات مثلا
                //حذف الأسطر التي تحتوي على الكلمات كما هي، كاملة
                //twbh و twbhmwq3 و twbhmhrk و twbhamn
                //حذار لا تدمجها
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

                //حذف الأسطر الخاصة بلوكل هوست الإصدارات القديمة والجديدة للبرنامج
                //"
                var lines = File.ReadAllLines(pathhosts)
                                .Where(line => !line.Contains("#local host Energized Protection # twbh") &&
                                               !line.Contains("127.0.0.1 localhost # twbh") &&
                                               !line.Contains("127.0.0.1 localhost.localdomain # twbh") &&
                                               !line.Contains("127.0.0.1 local # twbh") &&
                                               !line.Contains("255.255.255.255 broadcasthost # twbh") &&
                                               !line.Contains("::1 localhost # twbh") &&
                                               !line.Contains("::1 ip6-localhost # twbh") &&
                                               !line.Contains("::1 ip6-loopback # twbh") &&
                                               !line.Contains("fe80::1%lo0 localhost # twbh") &&
                                               !line.Contains("ff00::0 ip6-localnet # twbh") &&
                                               !line.Contains("ff00::0 ip6-mcastprefix # twbh") &&
                                               !line.Contains("ff02::1 ip6-allnodes # twbh") &&
                                               !line.Contains("ff02::2 ip6-allrouters # twbh") &&
                                               !line.Contains("ff02::3 ip6-allhosts # twbh") &&
                                               !line.Contains("0.0.0.0 0.0.0.0 # twbh")).ToArray();

                File.WriteAllText(pathhosts, string.Join(Environment.NewLine, lines)); //" م7 بتصرف

                //إضافة المواقع إلى الملف 
                //"
                using (StreamWriter sw = File.AppendText(pathhosts))
                {
                    sw.Write(Properties.Resources.qaimatalmawaqi);
                } //" م6 بتصرف

                //تنشيط السمة للقراءة فقط
                hostsnfo.IsReadOnly = true;

                //Dnscache تفعيل وتشغيل
                tachghildnscache();

                //Flush DNS
                flush();

                //إضافة معطل البرامج إلى بدء التشغيل التلقائي مع تشغيل الويندوز 
                //"
                RegistryKey key = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.SetValue("AltawbaMB", Path.Combine(AppDomain.CurrentDomain.BaseDirectory.ToString(), @"AltawbaMB.exe")); //" م8 بتصرف

                //إيقاف ثم تشغيل معطل البرامج
                iqafMBBT();
                //"
                System.Diagnostics.Process.Start(@"AltawbaMB.exe"); //" م10 بتصرف
            }

            catch (Exception ex)
            {
                if (ex is UnauthorizedAccessException)
                {
                    //hosts إذا حدث خطأ رفض الوصول إلى ملف
                    khataa01();
                    return;
                }
                if (ex is IOException)
                {
                    //إذا حدث خطأ: لا يمكن للعملية الوصول إلى الملف هوستس لأنه قيد الاستخدام بواسطة عملية أخرى 
                    khataa02();
                    return;
                }
                else
                {
                    //إذا حدث خطأ من نوع آخر، تتوقف العملية وتظهر رسالة الخطأ           
                    khataafitanfid();
                    MessageBox.Show(ex.Message, "حدث خطأ", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                    return;
                }
            }

            //async إيقاف
            backgroundWorker1.CancelAsync();

            //إنتظار 15 ثواني
            Thread.Sleep(15000);

            //لا يمكن التنفيذ مرة أخرى إن شاء الله لأن العملية انتهت والحمد لله
            tammaawla.Text = "1";

            //(تعطيل زر الحجب (لكي لا يتمكن المستخدم من الضغط عليه بعد انتهاء عملية الحجب وقبل ظهور نافذة تم
            zirhajb.Enabled = false;

            //بعد إنتهاء العملية
            intihaa();

            //إظهار رسالة تم
            Form tammaform = new Form02();
            tammaform.ShowDialog();

            //تفعيل زر الحجب
            zirhajb.Enabled = true;
        }

//برمجة أزرار العمليات
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
    //أثناء العمليات Alt+f4 تعطيل
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                if (backgroundWorker1.IsBusy | backgroundWorker2.IsBusy | backgroundWorker3.IsBusy | backgroundWorker4.IsBusy | backgroundWorker5.IsBusy)
                {
                    //تعطيل
                    e.Handled = true;
                }
                else
                {
                    //تفعيل
                    e.Handled = false;
                    //غلق البرنامج
                    Environment.Exit(1);
                }
            }

            //Ctrl + B حدث خطأ؟ يمكن استعادة الملف إلى حالته الأصلية وإزالة برنامج إيقاف تشغيل المتصفحات التي لا تدعم الحجب من قائمة البرامج التي يتم تشغيلها عند بدأ تشغيل الويندوز وذلك بالضغط على الأزرار
            if (e.Control && e.KeyCode == Keys.B)
            {
                if (!backgroundWorker1.IsBusy && !backgroundWorker2.IsBusy && !backgroundWorker3.IsBusy && !backgroundWorker4.IsBusy && !backgroundWorker5.IsBusy)
                {
                    var debug1 = MessageBox.Show("هل تريد إلغاء التغييرات؟", "رسالة", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

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


    //Ctrl + G إلغاء فرض ميزة البحث الآمن لمحركات البحث جوجل وبنج بالضغط على الأزرار
            if (e.Control && e.KeyCode == Keys.G)
            {
                if (!backgroundWorker1.IsBusy && !backgroundWorker2.IsBusy && !backgroundWorker3.IsBusy && !backgroundWorker4.IsBusy && !backgroundWorker5.IsBusy)
                {
                    var debug3 = MessageBox.Show("هل تريد إلغاء فرض ميزة البحث الآمن لمحركات البحث Google وBing؟", "رسالة", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

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
			
    //Ctrl + E إلغاء تفعيل برنامج إيقاف تشغيل المتصفحات التي لا تدعم الحجب
            if (e.Control && e.KeyCode == Keys.E)
            {
                if (!backgroundWorker1.IsBusy && !backgroundWorker2.IsBusy && !backgroundWorker3.IsBusy && !backgroundWorker4.IsBusy && !backgroundWorker5.IsBusy)
                {
                    var debug4 = MessageBox.Show("هل تريد إلغاء تفعيل برنامج إيقاف تشغيل المتصفحات التي لا تدعم الحجب؟", "رسالة", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);

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

//عمليات حذف الميزات
    //عملية استعادة الملف هوستس إلى حالته الأصلية وإلغاء تفعيل برنامج إيقاف تشغيل المتصفحات التي لا تدعم الحجب
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {          
            try
            {
                //hosts التحقق من وجود الملف
                if (!File.Exists(pathhosts))
                {
                    //إنشاء الملف إذا كان غير موجودا
                    //"
                    using (File.Create(pathhosts)) { } //" م4 بتصرف
                    goto start3amaliya;
                }

            start3amaliya:
                //Dnscache إيقاف وإلغاء تفعيل
                iqafdnscache();

                //الانتظار ثانيتين
                Thread.Sleep(2000);

                //hosts إلغاء السمة للقراءة فقط والسمات الأخرى للملف
                FileInfo hostsnfo = new FileInfo(pathhosts);
                File.SetAttributes(pathhosts, FileAttributes.Normal);

                //حذف المواقع التي أضافها البرنامج إلى الملف
                //twbahو twbh حذف الأسطر التي تحتوي على كلمة
                //"
                var lines = File.ReadAllLines(pathhosts)
                                .Where(line => !line.Contains("twbh") &&
                                               !line.Contains("twbah")).ToArray();

                File.WriteAllText(pathhosts, string.Join(Environment.NewLine, lines)); //" م7 بتصرف

                //تنشيط السمة للقراءة فقط
                hostsnfo.IsReadOnly = true;

                //Dnscache تفعيل وتشغيل
                tachghildnscache();

                //Flush DNS
                flush();

                //إزالة برنامج إيقاف تشغيل المتصفحات التي لا تدعم الحجب من قائمة البرامج التي يتم تشغيلها عند بدأ تشغيل الويندوز 
                //"
                izalatMBBT();

                //إيقافه
                //"
                iqafMBBT();
            }

            //إذا حدث خطأ
            catch (Exception ex)
            {
                if (ex is UnauthorizedAccessException)
                {
                    //hosts إذا حدث خطأ رفض الوصول إلى ملف
                    khataa01();
                    return;
                }
                if (ex is IOException)
                {
                    //إذا حدث خطأ: لا يمكن للعملية الوصول إلى الملف هوستس لأنه قيد الاستخدام بواسطة عملية أخرى 
                    khataa02();
                    return;
                }
                if (ex is ArgumentException)
                {
                    /*إذا كانت القيمة (في أوامر إزالة برنامج إيقاف تشغيل المتصفحات) غير موجودة في سجل النظام
                    لا يظهر الخطأ، لأنها قد تكون محذوفة بواسطة المستخدم أو لم يتم إضافتها أصلا */     
                }

                else
                {
                    //إذا حدث خطأ من نوع آخر، تتوقف العملية وتظهر رسالة الخطأ           
                    khataafitanfid();
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
            //async إيقاف
            backgroundWorker2.CancelAsync();

            //إنتظار 15 ثواني
            Thread.Sleep(15000);

            //بعد إنتهاء العملية
            intihaa();

            //يمكن حجب المواقع مرة أخرى
            tammaawla.Text = "0";

            //إظهار رسالة تم
            MessageBox.Show("تم إلغاء التغييرات.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }

    //عملية إلغاء حجب بعض محرّكات البحث التي لم يتمكن البرنامج من فرض ميزة البحث الآمن لها
        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //hosts التحقق من وجود الملف
                if (!File.Exists(pathhosts))
                {
                    //إنشاء الملف إذا كان غير موجودا
                    //"
                    using (File.Create(pathhosts)) { } //" م4 بتصرف
                    goto start3amaliya;
                }

            start3amaliya:
                //Dnscache إيقاف وإلغاء تفعيل
                iqafdnscache();

                //الانتظار ثانيتين
                Thread.Sleep(2000);

                //hosts إلغاء السمة للقراءة فقط والسمات الأخرى للملف
                FileInfo hostsnfo = new FileInfo(pathhosts);
                File.SetAttributes(pathhosts, FileAttributes.Normal);

                //hosts حذف المواقع التي أضافها البرنامج إلى الملف
                //twbhmhrk حذف الأسطر التي تحتوي على كلمة
                //"
                var lines = File.ReadAllLines(pathhosts)
                                .Where(line => !line.Contains("twbhmhrk")).ToArray();

                File.WriteAllText(pathhosts, string.Join(Environment.NewLine, lines)); //" م7 بتصرف

                //تنشيط السمة للقراءة فقط
                hostsnfo.IsReadOnly = true;

                //Dnscache تفعيل وتشغيل
                tachghildnscache();

                //Flush DNS
                flush();
            }

            catch (Exception ex)
            {
                if (ex is UnauthorizedAccessException)
                {
                    //hosts إذا حدث خطأ رفض الوصول إلى ملف
                    khataa01();
                    return;
                }
                if (ex is IOException)
                {
                    //إذا حدث خطأ: لا يمكن للعملية الوصول إلى الملف هوستس لأنه قيد الاستخدام بواسطة عملية أخرى 
                    khataa02();
                    return;
                }
                else
                {
                    //إذا حدث خطأ من نوع آخر، تتوقف العملية وتظهر رسالة الخطأ           
                    khataafitanfid();
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
            //async إيقاف
            backgroundWorker3.CancelAsync();

            //إنتظار 15 ثواني
            Thread.Sleep(15000);

            //بعد إنتهاء العملية
            intihaa();

            //يمكن حجب المواقع مرة أخرى
            tammaawla.Text = "0";

            //إظهار رسالة تم
            MessageBox.Show("تمّ إلغاء حجب محرّكات البحث.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }

    //عملية إلغاء فرض ميزة البحث الآمن لمحركات البحث جوجل وبنج
        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //hosts التحقق من وجود الملف
                if (!File.Exists(pathhosts))
                {
                    //إنشاء الملف إذا كان غير موجودا
                    //"
                    using (File.Create(pathhosts)) { } //" م4 بتصرف
                    goto start3amaliya;
                }

            start3amaliya:
                //Dnscache إيقاف وإلغاء تفعيل
                iqafdnscache();

                //الانتظار ثانيتين
                Thread.Sleep(2000);

                //hosts إلغاء السمة للقراءة فقط والسمات الأخرى للملف
                FileInfo hostsnfo = new FileInfo(pathhosts);
                File.SetAttributes(pathhosts, FileAttributes.Normal);

                //hosts حذف المواقع التي أضافها البرنامج إلى الملف
                //twbhamn حذف الأسطر التي تحتوي على كلمة
                //"
                var lines = File.ReadAllLines(pathhosts)
                                .Where(line => !line.Contains("twbhamn")).ToArray();

                File.WriteAllText(pathhosts, string.Join(Environment.NewLine, lines)); //" م7 بتصرف

                //تنشيط السمة للقراءة فقط
                hostsnfo.IsReadOnly = true;

                //Dnscache تفعيل وتشغيل
                tachghildnscache();

                //Flush DNS
                flush();
            }

            catch (Exception ex)
            {
                if (ex is UnauthorizedAccessException)
                {
                    //hosts إذا حدث خطأ رفض الوصول إلى ملف
                    khataa01();
                    return;
                }
                if (ex is IOException)
                {
                    //إذا حدث خطأ: لا يمكن للعملية الوصول إلى الملف هوستس لأنه قيد الاستخدام بواسطة عملية أخرى 
                    khataa02();
                    return;
                }
                else
                {
                    //إذا حدث خطأ من نوع آخر، تتوقف العملية وتظهر رسالة الخطأ           
                    khataafitanfid();
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
            //async إيقاف
            backgroundWorker4.CancelAsync();

            //إنتظار 15 ثواني
            Thread.Sleep(15000);

            //بعد إنتهاء العملية
            intihaa();

            //يمكن حجب المواقع مرة أخرى
            tammaawla.Text = "0";

            //إظهار رسالة تم
            MessageBox.Show("تمّ إلغاء فرض ميزة البحث الآمن لمحرّكات البحث Google وBing.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }

    //عملية إلغاء تفعيل برنامج إيقاف تشغيل المتصفحات التي لا تدعم الحجب
        private void backgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //إزالة برنامج إيقاف تشغيل المتصفحات التي لا تدعم الحجب من قائمة البرامج التي يتم تشغيلها عند بدأ تشغيل ويندوز 
                izalatMBBT();

                //إيقافه
                iqafMBBT();
            }

            catch (Exception ex)
            {
                if (ex is ArgumentException)
                {
                    /*إذا كانت القيمة (في أوامر إزالة برنامج إيقاف تشغيل المتصفحات) غير موجودة في سجل النظام
                    لا يظهر الخطأ، لأنها قد تكون محذوفة بواسطة المستخدم أو لم يتم إضافتها أصلا */
                }
                else
                {
                    //إذا حدث خطأ من نوع آخر، تتوقف العملية وتظهر رسالة الخطأ           
                    khataafitanfid();
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                    return;
                }
            }

            //async إيقاف
            backgroundWorker5.CancelAsync();

            //إنتظار 15 ثواني
            Thread.Sleep(15000);

            //بعد إنتهاء العملية
            intihaa();

            //يمكن حجب المواقع مرة أخرى
            tammaawla.Text = "0";

            //إظهار رسالة تم
            MessageBox.Show("تمّ إلغاء تفعيل برنامج إيقاف تشغيل المتصفّحات التي لا تدعم الحجب.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }

    //ما يحدث بعد الضغط على الأزرار الأخرى
    //زر التحقق من وجود إصدار جديد
        private void tahdith_Click(object sender, EventArgs e)
        {
            //تأثير عند الضغط
            tahdith.BackgroundImage = Properties.Resources.tahdith;
            tahdith.Refresh();
            Thread.Sleep(100);
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
                        Form isdarjadid = new Form05();
                        isdarjadid.ShowDialog();
                    }
                    //في حالة عدم وجود إصدار جديد
                    else
                    {
                        //فتح نافذة أنت تملك إصدار جديد
                        Form isdarjadid = new Form06();
                        isdarjadid.ShowDialog();
                    }
                }
            }

            //لمنع ظهور رسالة الخطأ أثناء تعذر الإتصال بالخادم
            catch { }
        }

    //زر المزيد من الميزات
        private void zirmayzat_Click(object sender, EventArgs e)
        {
            //تأثير عند الضغط
            zirmayzat.BackgroundImage = Properties.Resources.ziralmayzat;
            zirmayzat.Refresh();
            zirmayzat.BackgroundImage = Properties.Resources.lightziralmayzat;

            //فتح نافذة المزيد من الميزات
            Form almazidminalmayzatform = new Form04();
            almazidminalmayzatform.ShowDialog();
        }

    //زر حول البرنامج
        private void hawla_Click_1(object sender, EventArgs e)
        {
            //تأثير عند الضغط
            hawla.BackgroundImage = Properties.Resources.hawla;
            hawla.Refresh();
            hawla.BackgroundImage = Properties.Resources.lighthawla;

            //فتح نافذة حول البرنامج
            Form hawlaform = new Form03();
            hawlaform.ShowDialog();
        }

    //زر موقع البرنامج
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

//تأثيرات الأزرار
    //تأثير زر حجب المواقع
        private void zirhajb_MouseEnter(object sender, EventArgs e)
        {
            zirhajb.BackgroundImage = Properties.Resources.lighthajb;
        }

        private void zirhajb_MouseLeave(object sender, EventArgs e)
        {
            zirhajb.BackgroundImage = Properties.Resources.hajb;
        }

    //تأثير زر المزيد من الميزات
        private void zirmayzat_MouseEnter(object sender, EventArgs e)
        {
            zirmayzat.BackgroundImage = Properties.Resources.lightziralmayzat;
        }

        private void zirmayzat_MouseLeave(object sender, EventArgs e)
        {
            zirmayzat.BackgroundImage = Properties.Resources.ziralmayzat;
        }


    //تأثير زر التحقق من وجود إصدار جديد
        private void tahdith_MouseEnter(object sender, EventArgs e)
        {
            tahdith.BackgroundImage = Properties.Resources.lighttahdith;
        }

        private void tahdith_MouseLeave(object sender, EventArgs e)
        {
            tahdith.BackgroundImage = Properties.Resources.tahdith;
        }

    //تأثير زر حول البرنامج
        private void hawla_MouseEnter(object sender, EventArgs e)
        {
            hawla.BackgroundImage = Properties.Resources.lighthawla;
        }

        private void hawla_MouseLeave(object sender, EventArgs e)
        {
            hawla.BackgroundImage = Properties.Resources.hawla;
        }

    //تأثير زر موقع البرنامج
        private void mawqi_MouseEnter(object sender, EventArgs e)
        {
            mawqi.BackgroundImage = Properties.Resources.lightmawqi;
        }

        private void mawqi_MouseLeave(object sender, EventArgs e)
        {
            mawqi.BackgroundImage = Properties.Resources.mawqi;
        }

//تجريب الأوامر
        private void button1_Click(object sender, EventArgs e)
        {
            //فتح نافذة
            Form hawlaform = new Form05();
            hawlaform.ShowDialog();

            //CMD تجريب أوامر
            //System.Diagnostics.Process process = new System.Diagnostics.Process();
            //System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            //startInfo.FileName = "cmd.exe";
            //startInfo.Arguments = "/C sc config \"servicename\" start=disabled";
            //startInfo.Verb = "runas";
            //process.StartInfo = startInfo;
            //process.Start(); //" م2 بتصرف

            //تجريب إظهار الشولتين في الرسالة
            //MessageBox.Show("\"Assalamu Alaykoum\"");
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
//Jon Skeet, Stack Overflow, https://stackoverflow.com/a/802588/16707988, 
//CC BY-SA 2.5, https://creativecommons.org/licenses/by-sa/2.5/  

//المصدر م5
//Tim Schmelter, Stack Overflow, https://stackoverflow.com/a/10371680, 
//CC BY-SA 3.0, https://creativecommons.org/licenses/by-sa/3.0/  

//المصدر م6
//Gabe, Stack Overflow, https://stackoverflow.com/a/2837040, 
//CC BY-SA 3.0, https://creativecommons.org/licenses/by-sa/3.0/

//المصدر م7
//Servy, Stack Overflow, https://stackoverflow.com/a/15343247/16707988, 
//CC BY-SA 3.0, https://creativecommons.org/licenses/by-sa/3.0/

//المصدر م8
//mamal, Stack Overflow, https://stackoverflow.com/a/53475843, 
//CC BY-SA 4.0, https://creativecommons.org/licenses/by-sa/4.0/

//المصدر م9
//ConsultUtah, Stack Overflow, https://stackoverflow.com/a/3345421, 
//CC BY-SA 4.0, https://creativecommons.org/licenses/by-sa/4.0/

//المصدر م10
//Nasreddine, Stack Overflow, https://stackoverflow.com/a/37437954, 
//CC BY-SA 3.0, https://creativecommons.org/licenses/by-sa/3.0/

//المصدر م11
//Jon Skeet, Stack Overflow, https://stackoverflow.com/a/531338, 
//CC BY-SA 2.5, https://creativecommons.org/licenses/by-sa/2.5/