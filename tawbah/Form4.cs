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
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();

            //Alt+F4 من الأوامر الخاصة بتعطيل 
            this.KeyPreview = true;

            //أوامر تحديث حالة الأزرار
            tahdithform();
        }

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
                    myKey.SetValue("Start", "2", RegistryValueKind.String);
                    myKey.Close();
                } //" م2 بتصرف
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
            process.StartInfo = startInfo;
            process.Start(); //" م1 بتصرف

            //إلغاء تفعيلها
            try
            {
                //"
                RegistryKey myKey = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\services\\Dnscache", true);
                if (myKey != null)
                {
                    myKey.SetValue("Start", "4", RegistryValueKind.String);
                    myKey.Close();
                } //" م2 بتصرف
            }
            catch { }
        }

        //ما يحدث أثناء عملية التنفيذ
        private void intidhar()
        {
            this.ControlBox = false;
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

        //إذا حدث خطأ أثناء عملية التنفيذ
        private void khataafitanfid()
        {
            intihaa();

            //فتح نافذة الحلول المقترح لمشكلة ظهور رسالة خطأ بعد الضغط على زر حجب المواقع
            //الخطوة الأولى : الانتظار قبل ظهور الرسالة - بدأ المؤقتة
            timer1.Enabled = true;
        }


        //إظهار أزرار النافذة، تفعيل الأزرار ألخ
        //تستخدم بعد انتهاء العمليات
        private void intihaa()
        {
            //Dnscache تفعيل وتشغيل
            tachghildnscache();
            
            //...
            this.ControlBox = true;
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

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            //أثناء العمليات Alt+f4 تعطيل
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

        private void backgroundWorkerTachghilWTMYTB_DoWork(object sender, DoWorkEventArgs e)
        {
            //تشغيل فرض وضع تقييد المحتوى لليوتيوب
            try
            {
                //hosts التحقق من وجود الملف
                if (!File.Exists(pathhosts))
                {
                    //إنشاء الملف إذا كان غير موجودا
                    //"
                    using (StreamWriter w = File.AppendText(pathhosts)); //" م3 بتصرف 
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
                //(twbahfwtmy حذف الأسطر التي تحتوي على كلمة)
                //وكلمة أخرى خاصة بالإصدارات القديمة
                //"
                string[] domains = { "twbahfwtmy", "twbhytb" };
                string[] lines = File.ReadAllLines(pathhosts)
                                     .Where(l => !domains.Any(d => l.Contains(d)))
                                     .ToArray();

                File.WriteAllLines(pathhosts, lines); //" م4 بتصرف

                //حذف الأسطر الخاصة بلوكل هوست الإصدارات القديمة للبرنامج
                //"
                string[] domains2 = {
                    "#local host Energized Protection # twbh",
                    "127.0.0.1 localhost # twbh",
                    "127.0.0.1 localhost.localdomain # twbh",
                    "127.0.0.1 local # twbh",
                    "255.255.255.255 broadcasthost # twbh",
                    "::1 localhost # twbh",
                    "::1 ip6-localhost # twbh",
                    "::1 ip6-loopback # twbh",
                    "fe80::1%lo0 localhost # twbh",
                    "ff00::0 ip6-localnet # twbh",
                    "ff00::0 ip6-mcastprefix # twbh",
                    "ff02::1 ip6-allnodes # twbh",
                    "ff02::2 ip6-allrouters # twbh",
                    "ff02::3 ip6-allhosts # twbh",
                    "0.0.0.0 0.0.0.0 # twbh",
                };

                string[] lines2 = File.ReadAllLines(pathhosts)
                                     .Where(l => !domains2.Any(d => l.Contains(d)))
                                     .ToArray();

                File.WriteAllLines(pathhosts, lines2); //" م4 بتصرف

                //إضافة الأسطر الخاصة بميزة فرض وضع تقييد المحتوى لليوتيوب إلى الملف 
                //مع إضافة أسطر لوكل هوست الخاصة بالإصدار وهي موجودة في نفس الملف الخاص بالميزة
                //"
                using (StreamWriter sw = File.AppendText(pathhosts))
                {
                    sw.WriteLine(Properties.Resources.qaimatfwtmyoutube);
                } //" م5 بتصرف

                //حذف الأسطر المكررة
                //"
                string[] lines3 = File.ReadAllLines(pathhosts);
                File.WriteAllLines(pathhosts, lines3.Distinct().ToArray()); //" م6 بتصرف

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
            backgroundWorkerTachghilWTMYTB.CancelAsync();

            //إنتظار 5 ثواني
            Thread.Sleep(5000);

            //تغيير صورة الزر وجعله مفعل
            zirfwtmyoutube.BackgroundImage = Properties.Resources.zir1;

            //يمكن إلغاء تفعيلها مرة أخرى
            mofa3al_fwtm_ytb.Text = "1";

            //بعد إنتهاء العملية
            intihaa();
        }

        private void backgroundWorkerIqafWTMYTB_DoWork(object sender, DoWorkEventArgs e)
        {
            //إيقاف فرض وضع تقييد المحتوى لليوتيوب
            try
            {
                //hosts التحقق من وجود الملف
                if (!File.Exists(pathhosts))
                {
                    //إنشاء الملف إذا كان غير موجودا
                    //"
                    using (StreamWriter w = File.AppendText(pathhosts)); //" م3 بتصرف
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
                //(twbahfwtmy حذف الأسطر التي تحتوي على كلمة)
                //وكلمة أخرى خاصة بالإصدارات القديمة
                //"
                string[] domains = { "twbahfwtmy", "twbhytb" };
                string[] lines = File.ReadAllLines(pathhosts)
                                     .Where(l => !domains.Any(d => l.Contains(d)))
                                     .ToArray();

                File.WriteAllLines(pathhosts, lines); //" م4 بتصرف

                //تنشيط السمة للقراءة فقط
                FileInfo hostsnfo2 = new FileInfo(pathhosts);
                hostsnfo2.IsReadOnly = true;

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
            backgroundWorkerIqafWTMYTB.CancelAsync();

            //إنتظار 5 ثواني
            Thread.Sleep(5000);

            //جعل الزر غير مفعل
            zirfwtmyoutube.BackgroundImage = Properties.Resources.zir0;

            //يمكن تفعيلها مرة أخرى
            mofa3al_fwtm_ytb.Text = "0";

            //بعد إنتهاء العملية
            intihaa();
        }

        private void zirfwtmyoutube_Click(object sender, EventArgs e)
        {
            //إذا كان الزر مفعل سيتم حذف التغييرات إن شاء الله
            if (mofa3al_fwtm_ytb.Text=="1")
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

        private void backgroundWorkerTachghilMI3L_DoWork(object sender, DoWorkEventArgs e)
        {
            //تشغيل مانع الإعلانات
            try
            {
                //hosts التحقق من وجود الملف
                if (!File.Exists(pathhosts))
                {
                    //إنشاء الملف إذا كان غير موجودا
                    //"
                    using (StreamWriter w = File.AppendText(pathhosts)); //" م3 بتصرف
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
                //(twbahmi3lnt حذف الأسطر التي تحتوي على كلمة)
                //"
                string search_text = "twbahmi3lnt";
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
                File.WriteAllText(pathhosts, n); //" م7 بتصرف

                //حذف الأسطر الخاصة بلوكل هوست الإصدارات القديمة للبرنامج
                //"
                string[] domains2 = {
                    "#local host Energized Protection # twbh",
                    "127.0.0.1 localhost # twbh",
                    "127.0.0.1 localhost.localdomain # twbh",
                    "127.0.0.1 local # twbh",
                    "255.255.255.255 broadcasthost # twbh",
                    "::1 localhost # twbh",
                    "::1 ip6-localhost # twbh",
                    "::1 ip6-loopback # twbh",
                    "fe80::1%lo0 localhost # twbh",
                    "ff00::0 ip6-localnet # twbh",
                    "ff00::0 ip6-mcastprefix # twbh",
                    "ff02::1 ip6-allnodes # twbh",
                    "ff02::2 ip6-allrouters # twbh",
                    "ff02::3 ip6-allhosts # twbh",
                    "0.0.0.0 0.0.0.0 # twbh",
                };

                string[] lines3 = File.ReadAllLines(pathhosts)
                                     .Where(l => !domains2.Any(d => l.Contains(d)))
                                     .ToArray();

                File.WriteAllLines(pathhosts, lines3); //" م4 بتصرف

                //إضافة الأسطر الخاصة بمانع الإعلانات إلى الملف 
                //"
                using (StreamWriter sw = File.AppendText(pathhosts))
                {
                    sw.WriteLine(Properties.Resources.qaimatmani3ali3lanat);
                } //" م5 بتصرف

                //حذف الأسطر المكررة
                //"
                string[] lines = File.ReadAllLines(pathhosts);
                File.WriteAllLines(pathhosts, lines.Distinct().ToArray()); //" م6 بتصرف

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
            backgroundWorkerTachghilMI3L.CancelAsync();

            //إنتظار 5 ثواني
            Thread.Sleep(5000);

            //تغيير صورة الزر وجعله مفعل
            zirmn3i3lnt.BackgroundImage = Properties.Resources.zir1;

            //يمكن إلغاء تفعيلها مرة أخرى
            mofa3al_mani3_i3l.Text = "1";

            //بعد إنتهاء العملية
            intihaa();
        }

        private void backgroundWorkerIqafMI3L_DoWork(object sender, DoWorkEventArgs e)
        {
            //إيقاف مانع الإعلانات
            try
            {
                //hosts التحقق من وجود الملف
                if (!File.Exists(pathhosts))
                {
                    //إنشاء الملف إذا كان غير موجودا
                    //"
                    using (StreamWriter w = File.AppendText(pathhosts)); //" م3 بتصرف
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
                //twbahmi3lnt حذف الأسطر التي تحتوي على كلمة
                //"
                string search_text = "twbahmi3lnt";
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
                File.WriteAllText(pathhosts, n); //" م7 بتصرف

                //تنشيط السمة للقراءة فقط
                FileInfo hostsnfo2 = new FileInfo(pathhosts);
                hostsnfo2.IsReadOnly = true;

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
            backgroundWorkerIqafMI3L.CancelAsync();

            //إنتظار 5 ثواني
            Thread.Sleep(5000);

            //جعل الزر غير مفعل
            zirmn3i3lnt.BackgroundImage = Properties.Resources.zir0;

            //يمكن تفعيلها مرة أخرى
            mofa3al_mani3_i3l.Text = "0";

            //بعد إنتهاء العملية
            intihaa();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //فتح نافذة الحلول المقترح لمشكلة ظهور رسالة خطأ بعد الضغط على الزر 
            //الخطوة الثانية : إظهار النافذة
            timer1.Stop();
            Form halmoqtarah = new Form7();
            Enabled = false;
            halmoqtarah.ShowDialog();
            Enabled = true;
        }

        private void intidhartahdith_Tick(object sender, EventArgs e)
        {
            //تحديث حالة الأزرار كل 3 ثواني
            if (busy.Visible==false)
            { 
                tahdithform();
            }
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
//Chris Gessler, Stack Overflow, https://stackoverflow.com/a/10383123, 
//CC BY-SA 3.0, https://creativecommons.org/licenses/by-sa/3.0/  

//المصدر م4
//Sergey Berezovskiy, Stack Overflow, https://stackoverflow.com/a/20344108, 
//CC BY-SA 3.0, https://creativecommons.org/licenses/by-sa/3.0/

//المصدر م5
//Gabe, Stack Overflow, https://stackoverflow.com/a/2837040, 
//CC BY-SA 3.0, https://creativecommons.org/licenses/by-sa/3.0/

//المصدر م6
//Darin Dimitrov, Stack Overflow, https://stackoverflow.com/a/1245524, 
//CC BY-SA 2.5, https://creativecommons.org/licenses/by-sa/2.5/

//المصدر م7
//Tim Schmelter, Stack Overflow, https://stackoverflow.com/a/10371680, 
//CC BY-SA 3.0, https://creativecommons.org/licenses/by-sa/3.0/  