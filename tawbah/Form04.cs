//هام
//الأكواد المقتبسة من المواقع سواء بتصرف أو بدونه مكتوبة بين شولتين (//"  //") ومصادرها مذكورة في آخر الصفحة 
//حذار من روابط المصادر، فقد تحتوي على صور النساء، ننصحك بحجب الصور في المتصفح قبل الدخول إليها


using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Threading;
using Microsoft.Win32;

namespace tawbah
{
    public partial class Form04 : Form
    {
        public Form04()
        {
            InitializeComponent();

            //أوامر تحديث حالة الأزرار
            tahdithform();

            //Alt+F4 من الأوامر الخاصة بتعطيل 
            this.KeyPreview = true;

            //إخفاء رسالة إعادة تشغيل مانع الإعلانات إذا تم غلقها من طرف المستخدم
            if (Properties.Settings.Default.idhharRisalatI3adatTachghilMani3AlI3lanat == false)
            {
                risalaMi3lanat.Visible = false;
                zirIghlaqAlrisala.Visible = false;
            }
        }

//الدوال
    //hosts موقع الملف 
        string pathhosts = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts");

    //أوامر تحديث حالة الأزرار
        private void tahdithform()
        {
            //تحديث حالة الأزرار
            if (File.Exists(pathhosts))
            {
                using (StreamReader sr = new StreamReader(pathhosts))
                {
                    string contents = sr.ReadToEnd();
                    //إذا كانت الكلمة موجودة داخل الملف فهذا يعني أن الميزة مفعلة لأن الأسطر الخاصة بها التي يضيفها البرنامج تحتوي على الكلمة
                    //خاص بالإصدارات القديمة twbhytb
                    if (contents.Contains("twbahfwtmy") | contents.Contains("twbhytb"))
                    {
                        //تفعيل الزر إذا وجد البرنامج الأسطر الخاصة بالميزة داخل ملف هوستس
                        zirfwtmyoutube.BackgroundImage = Properties.Resources.zir1;
                        mofa3al_fwtm_ytb.Text = "1";
                    }
                    else
                    {
                        //عدم تفعيل الزر إذا لم يجدها البرنامج
                        zirfwtmyoutube.BackgroundImage = Properties.Resources.zir0;
                        mofa3al_fwtm_ytb.Text = "0";
                    }

                    if (contents.Contains("twbahmi3lnt"))
                    {
                        zirmn3i3lnt.BackgroundImage = Properties.Resources.zir1;
                        mofa3al_mani3_i3l.Text = "1";
                    }
                    else
                    {
                        zirmn3i3lnt.BackgroundImage = Properties.Resources.zir0;
                        mofa3al_mani3_i3l.Text = "0";
                    }
                }
            }

            else
            {
                zirfwtmyoutube.BackgroundImage = Properties.Resources.zir0;
                mofa3al_fwtm_ytb.Text = "0";
                zirmn3i3lnt.BackgroundImage = Properties.Resources.zir0;
                mofa3al_mani3_i3l.Text = "0";
            }
        }

    //Flush Dns
        private void flush()
        {
            //"
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C ipconfig /flushdns";
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            process.Start(); //" م1
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
                    myKey.Close();
                } //" م2 بتصرف
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
            process.Start(); //" م1 بتصرف
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
            process.Start(); //" م1 بتصرف

            //إلغاء تفعيلها
            try
            {
                //"
                RegistryKey myKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\services\\Dnscache", true);
                if (myKey != null)
                {
                    myKey.SetValue("Start", "4", RegistryValueKind.DWord);
                    myKey.Close();
                } //" م2 بتصرف
            }
            catch { }
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

        //ما يحدث أثناء عملية التنفيذ
        private void intidhar()
        {
            this.UseWaitCursor = true;
            busy.Visible = true;
            //تعطيل الأزرار
            zirfwtmyoutube.Enabled = false;
            zirmn3i3lnt.Enabled = false;

            //تغيير صور الأزرار مع الحفاظ على حالتها مفعلة أو غير مفعلة
            if (mofa3al_fwtm_ytb.Text == "0")
            {
                zirfwtmyoutube.BackgroundImage = Properties.Resources.zir0moatal;
            }
            else
            {
                zirfwtmyoutube.BackgroundImage = Properties.Resources.zir1moatal;
            }

            if (mofa3al_mani3_i3l.Text == "0")
            {
                zirmn3i3lnt.BackgroundImage = Properties.Resources.zir0moatal;
            }
            else
            {
                zirmn3i3lnt.BackgroundImage = Properties.Resources.zir1moatal;
            }
        }

        //ما يحدث إذا حدث خطأ أثناء العمليات
        public void khataafitanfid()
        {
            //Dnscache تفعيل وتشغيل
            tachghildnscache();

            //إخفاء الصورة المتحركة وتفعيل الأزرار والعناصر الأخرى
            intihaa();

            //فتح نافذة الحلول المقترح لمشكلة ظهور رسالة خطأ بعد الضغط على أحد الأزرار
            //الخطوة الأولى : الانتظار قبل ظهور الرسالة - بدأ المؤقتة
            timerRisalaKhataa.Enabled = true;
        }

        //ما يحدث إذا حدث خطأ رقم 01 أثناء عملية التنفيذ  
        public void khataafitanfidK01()
        {
            //Dnscache تفعيل وتشغيل
            tachghildnscache();

            //إخفاء الصورة المتحركة وتفعيل الأزرار والعناصر الأخرى
            intihaa();

            //فتح نافذة الحلول المقترح لمشكلة ظهور رسالة خطأ بعد الضغط على أحد الأزرار
            //الخطوة الأولى : الانتظار قبل ظهور الرسالة - بدأ المؤقتة
            timerRisalaKhataa01.Enabled = true;
        }

        //ما يحدث إذا حدث خطأ رقم 02 أثناء عملية التنفيذ  
        public void khataafitanfidK02()
        {
            //Dnscache تفعيل وتشغيل
            tachghildnscache();

            //إخفاء الصورة المتحركة وتفعيل الأزرار والعناصر الأخرى
            intihaa();

            //فتح نافذة الحلول المقترح لمشكلة ظهور رسالة خطأ بعد الضغط على أحد الأزرار
            //الخطوة الأولى : الانتظار قبل ظهور الرسالة - بدأ المؤقتة
            timerRisalaKhataa02.Enabled = true;
        }

        //ما يحدث بعد انتهاء عملية التنفيذ
        //إظهار أزرار النافذة، تفعيل الأزرار ألخ
        private void intihaa()
        {            
            //...
            this.UseWaitCursor = false;
            busy.Visible = false;
            //تفعيل الأزرار
            zirfwtmyoutube.Enabled = true;
            zirmn3i3lnt.Enabled = true;

            //تغيير صور الأزرار مع الحفاظ على حالتها
            if (mofa3al_fwtm_ytb.Text == "0")
            {
                zirfwtmyoutube.BackgroundImage = Properties.Resources.zir0;
            }
            else
            {
                zirfwtmyoutube.BackgroundImage = Properties.Resources.zir1;
            }

            if (mofa3al_mani3_i3l.Text == "0")
            {
                zirmn3i3lnt.BackgroundImage = Properties.Resources.zir0;
            }
            else
            {
                zirmn3i3lnt.BackgroundImage = Properties.Resources.zir1;
            }

            //تحديث النافذة
            //لحل مشكلة قد تحدث أحيانا بعد انتهاء العملية تتمثل في عدم تغير صورة المؤشر إلى صورة اليد إذا كان فوق الزر 
            this.flush();
        }

//أوامر مهمة
    //فتح نافذة الحلول المقترح لمشكلة ظهور رسالة خطأ 
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

        //(فتح نافذة الحلول المقترح لمشكلة ظهور رسالة الخطأ (رسائل الخطأ الأخرى
        //(الخطوة الثانية : إظهار النافذة)
        private void timerRisalaKhataa_Tick(object sender, EventArgs e)
        {
            timerRisalaKhataa.Stop();
            Form halmoqtarah = new Form07();
            halmoqtarah.ShowDialog();
        }

    //تحديث حالة الأزرار كل 5 ثواني
        private void intidhartahdith_Tick(object sender, EventArgs e)
        {
            
            if (busy.Visible == false)
            {
                tahdithform();
            }
        }

    //أثناء العمليات Alt+f4 تعطيل
        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                if (backgroundWorkerTachghilWTMYTB.IsBusy | backgroundWorkerIqafWTMYTB.IsBusy | backgroundWorkerTachghilMI3L.IsBusy | backgroundWorkerIqafMI3L.IsBusy)
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
        }

    //ما يحدث أثناء غلق النافذة
        private void Form04_FormClosing(object sender, FormClosingEventArgs e)
        {
            //منع غلق النافذة أثناء العمليات
            //عند ظهور الصورة المتحركة للانتظار
            if (busy.Visible == true)
            { 
                e.Cancel = true;
            }

            else
            {
                e.Cancel = false;
            }
        }

        //العمليات
        //تفعيل/إلغاء تفعيل فرض وضع تقييد المحتوى لليوتيوب
        //الزر
        private void zirfwtmyoutube_Click(object sender, EventArgs e)
        {
            //إذا كان الزر مفعل سيتم حذف التغييرات إن شاء الله
            if (mofa3al_fwtm_ytb.Text == "1")
            {
                if (!backgroundWorkerTachghilWTMYTB.IsBusy | !backgroundWorkerIqafWTMYTB.IsBusy | !backgroundWorkerTachghilMI3L.IsBusy | !backgroundWorkerIqafMI3L.IsBusy)
                {
                    intidhar();
                    backgroundWorkerIqafWTMYTB.RunWorkerAsync();
                }

                else
                {
                    MessageBox.Show("انتظر حتّى تكتمل العمليّة الأخرى ثم أعد المحاولة، بارك الله فيك.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }
            }

            //إذا كان الزر غير مفعل ستبدأ عملية فرض وضع تقييد المحتوى لليوتيوب إن شاء الله
            if (mofa3al_fwtm_ytb.Text == "0")
            {
                if (!backgroundWorkerTachghilWTMYTB.IsBusy | !backgroundWorkerIqafWTMYTB.IsBusy | !backgroundWorkerTachghilMI3L.IsBusy | !backgroundWorkerIqafMI3L.IsBusy)
                {
                    intidhar();
                    backgroundWorkerTachghilWTMYTB.RunWorkerAsync();
                }

                else
                {
                    MessageBox.Show("انتظر حتّى تكتمل العمليّة الأخرى ثم أعد المحاولة، بارك الله فيك.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }
            }
        }

        //تفعيل فرض وضع تقييد المحتوى لليوتيوب
        private void backgroundWorkerTachghilWTMYTB_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //hosts التحقق من وجود الملف
                if (!File.Exists(pathhosts))
                {
                    //إنشاء الملف إذا كان غير موجودا
                    //"
                    using (File.Create(pathhosts)) { } //" م3 بتصرف 
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
                //(والأسطر الخاصة باللوكل هوست twbhytbو twbahfwtmy الأسطر التي تحتوي على كلمة)
                //خاصة بالإصدارات القديمة twbhytb
                //"
                var lines = File.ReadAllLines(pathhosts)
                                .Where(line => !line.Contains("twbahfwtmy") &&
                                               !line.Contains("twbhytb") &&
                                               !line.Contains("#local host Energized Protection # twbh") &&
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

                File.WriteAllText(pathhosts, string.Join(Environment.NewLine, lines));
                //" م4 بتصرف

                //إضافة الأسطر الخاصة بميزة فرض وضع تقييد المحتوى لليوتيوب إلى الملف 
                //مع إضافة أسطر لوكل هوست الخاصة بالإصدار وهي موجودة في نفس الملف الخاص بالميزة
                //"
                using (StreamWriter sw = File.AppendText(pathhosts))
                {
                    sw.Write(Properties.Resources.qaimatfwtmyoutube);
                } //" م5 بتصرف

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
                    //إذا حدث خطأ، تتوقف العملية وتظهر رسالة الخطأ           
                    khataafitanfid();
                    MessageBox.Show(ex.Message, "حدث خطأ", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                    return;
                }
            }

            //async إيقاف
            backgroundWorkerTachghilWTMYTB.CancelAsync();

            //إنتظار 15 ثواني
            Thread.Sleep(15000);

            //تغيير صورة الزر وجعله مفعل
            zirfwtmyoutube.BackgroundImage = Properties.Resources.zir1;

            //يمكن إلغاء تفعيلها مرة أخرى
            mofa3al_fwtm_ytb.Text = "1";

            //بعد إنتهاء العملية
            intihaa();
        }

        //إلغاء تفعيل فرض وضع تقييد المحتوى لليوتيوب
        private void backgroundWorkerIqafWTMYTB_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //hosts التحقق من وجود الملف
                if (!File.Exists(pathhosts))
                {
                    //إنشاء الملف إذا كان غير موجودا
                    //"
                    using (File.Create(pathhosts)) { } //" م3 بتصرف 
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
                //(twbahfwtmy حذف الأسطر التي تحتوي على كلمة)
                //وكلمة أخرى خاصة بالإصدارات القديمة
                //"
                var lines = File.ReadAllLines(pathhosts)
                                .Where(line => !line.Contains("twbahfwtmy") &&
                                               !line.Contains("twbhytb")).ToArray();

                File.WriteAllText(pathhosts, string.Join(Environment.NewLine, lines)); //" م4 بتصرف

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
                    //إذا حدث خطأ، تتوقف العملية وتظهر رسالة الخطأ           
                    khataafitanfid();
                    MessageBox.Show(ex.Message, "حدث خطأ", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                    return;
                }
            }

            //async إيقاف
            backgroundWorkerIqafWTMYTB.CancelAsync();

            //إنتظار 15 ثواني
            Thread.Sleep(15000);

            //جعل الزر غير مفعل
            zirfwtmyoutube.BackgroundImage = Properties.Resources.zir0;

            //يمكن تفعيلها مرة أخرى
            mofa3al_fwtm_ytb.Text = "0";

            //بعد إنتهاء العملية
            intihaa();
        }

    //تفعيل/إلغاء تفعيل مانع الإعلانات
        //الزر
        private void zirmn3i3lnt_Click(object sender, EventArgs e)
        {
            //إذا كان الزر مفعل سيتم حذف التغييرات إن شاء الله
            if (mofa3al_mani3_i3l.Text == "1")
            {
                if (!backgroundWorkerTachghilWTMYTB.IsBusy | !backgroundWorkerIqafWTMYTB.IsBusy | !backgroundWorkerTachghilMI3L.IsBusy | !backgroundWorkerIqafMI3L.IsBusy)
                {
                    intidhar();
                    backgroundWorkerIqafMI3L.RunWorkerAsync();
                }

                else
                {
                    MessageBox.Show("انتظر حتّى تكتمل العمليّة الأخرى ثم أعد المحاولة، بارك الله فيك.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }
            }

            //إذا كان الزر غير مفعل ستبدأ عملية تشغيل مانع الإعلانات إن شاء الله
            if (mofa3al_mani3_i3l.Text == "0")
            {
                if (!backgroundWorkerTachghilWTMYTB.IsBusy | !backgroundWorkerIqafWTMYTB.IsBusy | !backgroundWorkerTachghilMI3L.IsBusy | !backgroundWorkerIqafMI3L.IsBusy)
                {
                    intidhar();
                    backgroundWorkerTachghilMI3L.RunWorkerAsync();
                }

                else
                {
                    MessageBox.Show("انتظر حتّى تكتمل العمليّة الأخرى ثم أعد المحاولة، بارك الله فيك.", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
                }
            }
        }

        //تفعيل مانع الإعلانات
        private void backgroundWorkerTachghilMI3L_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //hosts التحقق من وجود الملف
                if (!File.Exists(pathhosts))
                {
                    //إنشاء الملف إذا كان غير موجودا
                    //"
                    using (File.Create(pathhosts)) { } //" م3 بتصرف 
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
                //(والأسطر الخاصة باللوكل هوست twbahmi3lnt الأسطر التي تحتوي على كلمة)
                //"
                var lines = File.ReadAllLines(pathhosts)
                                .Where(line => !line.Contains("twbahmi3lnt") &&
                                               !line.Contains("#local host Energized Protection # twbh") &&
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

                File.WriteAllText(pathhosts, string.Join(Environment.NewLine, lines)); //" م4 بتصرف

                //إضافة الأسطر الخاصة بمانع الإعلانات إلى الملف 
                //"
                using (StreamWriter sw = File.AppendText(pathhosts))
                {
                    sw.Write(Properties.Resources.qaimatmani3ali3lanat);
                } //" م5 بتصرف

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
                    //إذا حدث خطأ، تتوقف العملية وتظهر رسالة الخطأ           
                    khataafitanfid();
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                    return;
                }
            }

            //async إيقاف
            backgroundWorkerTachghilMI3L.CancelAsync();

            //إنتظار 15 ثواني
            Thread.Sleep(15000);

            //تغيير صورة الزر وجعله مفعل
            zirmn3i3lnt.BackgroundImage = Properties.Resources.zir1;

            //يمكن إلغاء تفعيلها مرة أخرى
            mofa3al_mani3_i3l.Text = "1";

            //بعد إنتهاء العملية
            intihaa();
        }

        //إلغاء تفعيل مانع الإعلانات
        private void backgroundWorkerIqafMI3L_DoWork(object sender, DoWorkEventArgs e)
        {          
            try
            {
                //hosts التحقق من وجود الملف
                if (!File.Exists(pathhosts))
                {
                    //إنشاء الملف إذا كان غير موجودا
                    //"
                    using (File.Create(pathhosts)) { } //" م3 بتصرف 
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
                //twbahmi3lnt حذف الأسطر التي تحتوي على كلمة
                //"
                var lines = File.ReadAllLines(pathhosts)
                                .Where(line => !line.Contains("twbahmi3lnt")).ToArray();

                File.WriteAllText(pathhosts, string.Join(Environment.NewLine, lines)); //" م4 بتصرف

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
                    //إذا حدث خطأ، تتوقف العملية وتظهر رسالة الخطأ           
                    khataafitanfid();
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1);
                    return;
                }
            }

            //async إيقاف
            backgroundWorkerIqafMI3L.CancelAsync();

            //إنتظار 15 ثواني
            Thread.Sleep(15000);

            //جعل الزر غير مفعل
            zirmn3i3lnt.BackgroundImage = Properties.Resources.zir0;

            //يمكن تفعيلها مرة أخرى
            mofa3al_mani3_i3l.Text = "0";

            //بعد إنتهاء العملية
            intihaa();
        }

//وظائف الأزرار
    //زر غلق الرسالة الخاصة بمانع الإعلانات
    private void zirIghlaqAlrisala_Click(object sender, EventArgs e)
    {
        //إخفاءالرسالة وحفظ حالتها لكي لا تظهر في المرة القادمة إن شاء الله
        risalaMi3lanat.Visible = false;
        zirIghlaqAlrisala.Visible = false;
        Properties.Settings.Default.idhharRisalatI3adatTachghilMani3AlI3lanat = false;
        Properties.Settings.Default.Save();
    }

    }
}

//مصادر أكواد البرنامج

//المصدر م1
//R1CH101, Stack Overflow, https://stackoverflow.com/a/45909851, 
//CC BY-SA 3.0, https://creativecommons.org/licenses/by-sa/3.0/ 

//المصدر م2
//Jontatas, Stack Overflow, https://stackoverflow.com/a/8816229, 
//CC BY-SA 3.0, https://creativecommons.org/licenses/by-sa/3.0/  

//المصدر م3
//Jon Skeet, Stack Overflow, https://stackoverflow.com/a/802588/16707988, 
//CC BY-SA 2.5, https://creativecommons.org/licenses/by-sa/2.5/  

//المصدر م4
//Servy, Stack Overflow, https://stackoverflow.com/a/15343247/16707988, 
//CC BY-SA 3.0, https://creativecommons.org/licenses/by-sa/3.0/

//المصدر م5
//Gabe, Stack Overflow, https://stackoverflow.com/a/2837040, 
//CC BY-SA 3.0, https://creativecommons.org/licenses/by-sa/3.0/

//المصدر م6
//Darin Dimitrov, Stack Overflow, https://stackoverflow.com/a/1245524, 
//CC BY-SA 2.5, https://creativecommons.org/licenses/by-sa/2.5/