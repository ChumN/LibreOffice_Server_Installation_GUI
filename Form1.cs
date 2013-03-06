#region Licence
/*This file is part of the project "Reisisoft Server Install GUI",
 * which is licenced under LGPL v3+. You may find a copy in the source,
 * or obtain one at http://www.gnu.org/licenses/lgpl-3.0-standalone.html */
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Xml.Serialization;
using Microsoft.VisualBasic;


namespace WindowsFormsApplication1
{


    public partial class Form1 : Form
    {
        access_settings set = new access_settings();
        ResourceManager rm = new ResourceManager("WindowsFormsApplication1.strings", Assembly.GetExecutingAssembly());
        public Form1()
        {
            
            //l10n import
            string[] rtl = new string[] { "He" };
            try
            {

                SETTINGS temp = set.open_settings();
                string lang = temp.l10n;
                if (lang != null) 
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang, false);

                if (rtl.Contains(lang))
                    this.RightToLeftLayout = true;
               
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            SETTINGS temp = set.open_settings(); 
            string lang = temp.l10n;
            string[] rtl_lang = new string[] { "He" };
           


            if (rtl_lang.Contains(lang))
            {
               
                bootinipath.RightToLeft = System.Windows.Forms.RightToLeft.No;

                bootstrap_text.RightToLeft = System.Windows.Forms.RightToLeft.No;
               
                path_to_file_ondisk.RightToLeft = System.Windows.Forms.RightToLeft.No;
                
                subfolder.RightToLeft = System.Windows.Forms.RightToLeft.No;
                
                path_installdir.RightToLeft = System.Windows.Forms.RightToLeft.No;
               
                path_help.RightToLeft = System.Windows.Forms.RightToLeft.No;
              
                path_main.RightToLeft = System.Windows.Forms.RightToLeft.No;
               


            }
            
            //l10n start
            string dl_hp_txt = getstring("helppack");
            dl_hp_1.Text = dl_hp_txt;
            dl_hp_2.Text = dl_hp_txt;
            dl_hp_3.Text = dl_hp_txt;
            b_dl_lb.Text = getstring("bdllb");
            b_dl_master.Text = getstring("dlmaster");
            b_dl_ob.Text = getstring("dl_ob");
            b_dl_testing.Text = getstring("dltesting");
            b_open_libo_installer.Text = getstring("open_installer");
            button1.Text = getstring("about");
            button2.Text = getstring("open_help");
            button3.Text = getstring("config_installdir");
            button4.Text = getstring("open_bootstrap_ini");
            groupBox1.Text = getstring("edit_bs_ini");
            label2.Text = getstring("progress");
            label3.Text = label2.Text;
            open_bootstrap.Title = getstring("open_bootstrap_title");
            save_file.Text = getstring("save_bootstrap_ini");
            start_install.Text = getstring("start_install");
            wheretoinstall.Description = getstring("where_to_install");
            cb_subfolder.Text = getstring("subfolder_do");
            create_lnk.Text = getstring("b_create_shortcut");
            button5.Text = getstring("man_title");

            // Update version information
            version.Text = "LibreOffice Server Install GUI v." + set.program_version();
                     
            /* l10n end
             * Start Setting tooltips */
            ToolTip ink = new ToolTip();
            ToolTip d_lb = new ToolTip();
            ToolTip d_m = new ToolTip();
            ToolTip d_tb = new ToolTip();
            ToolTip d_ob = new ToolTip();
            ToolTip bootstrapini = new ToolTip();
            ToolTip b_hp_1 = new ToolTip();
            ToolTip b_hp_2 = new ToolTip();
            ToolTip b_hp_3 = new ToolTip();
            ToolTip pathtoexe = new ToolTip();
            string tt_lb = getstring("tt_lb");
            string tt_m = getstring("tt_m");
            string tt_tb = getstring("tt_tb");
            string tt_ob = getstring("tt_ob");
            string bootstrap = getstring("tt_bootstrap");
            ink.SetToolTip(this.create_lnk, getstring("tt_ink"));
            d_lb.SetToolTip(this.b_dl_lb, tt_lb);
            d_m.SetToolTip(this.b_dl_master, tt_m);
            d_tb.SetToolTip(this.b_dl_testing, tt_tb);
            d_ob.SetToolTip(this.b_dl_ob, tt_ob);
            b_hp_1.SetToolTip(this.dl_hp_1, getstring("tt_hp_lb"));
            b_hp_2.SetToolTip(this.dl_hp_2, getstring("tt_hp_test"));
            b_hp_3.SetToolTip(this.dl_hp_3, getstring("tt_hp_ob"));
            bootstrapini.SetToolTip(this.bootstrap_text, bootstrap);
            pathtoexe.SetToolTip(this.path_to_exe, getstring("tt_path_to_exe"));
            bootstrapini.ShowAlways = true;
            pathtoexe.ShowAlways = true;
            ink.IsBalloon = true;
            b_hp_1.IsBalloon = true;
            b_hp_2.IsBalloon = true;
            b_hp_3.IsBalloon = true;
            d_lb.IsBalloon = true;
            d_m.IsBalloon = true;
            d_ob.IsBalloon = true;
            d_tb.IsBalloon = true;
            bootstrapini.IsBalloon = true;
            pathtoexe.IsBalloon = true;
            /* End Setting tooltips
             *  Loading settings*/
            loadsettinmgs();

            
            button1.Text = getstring("about");
            help.Text = getstring("help");
            give_message.BalloonTipClicked += new EventHandler(gm_do);
            give_message.BalloonTipClosed += new EventHandler(gm_do);
            give_message.Click += new EventHandler(gm_do);
            give_message.DoubleClick += new EventHandler(gm_do);
            this.BringToFront();

           

        }
        private void loadsettinmgs()
        {
            try
            {
                SETTINGS toapply = set.open_settings();
                //Apply settings
                cb_subfolder.Checked = toapply.checkbox;
                path_installdir.Text = toapply.installdir;
                subfolder.Text = toapply.subfolder;
                hp_lang_select.SelectedIndex = toapply.lang;
                path_to_exe.Text = toapply.last_path_to_sofficeEXE;
            }
            catch (Exception)
            { }
        }

        private void gm_do(Object sender, EventArgs e)
        {
           // Interaction.AppActivate(this.Text);
            this.WindowState = FormWindowState.Normal;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string filename_install = openfile.FileName;
            path_main.Text = filename_install;
        }



        private void openLibohelp(object sender, EventArgs e)
        {
            openfile2.ShowDialog();
        }

        private void openfile2_FileOk(object sender, CancelEventArgs e)
        {
            string filename_help = openfile2.FileName;
            path_help.Text = filename_help;
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {


        }
       

        private void config_installdir(object sender, EventArgs e)
        {
            if (wheretoinstall.ShowDialog() == DialogResult.OK)
            {
                string fileame_installdir = wheretoinstall.SelectedPath;
                path_installdir.Text = fileame_installdir;
            }

        }

        private void start_install_Click(object sender, EventArgs e)
        {

            bool install_main = false;
            bool install_help = false;
            bool install_path = false;
            bool go_on = true;
            // Check settings
            if (path_main.TextLength > 0)
                install_main = true;
            if (path_help.TextLength > 0)
                install_help = true;
            if (path_installdir.TextLength > 0)
                install_path = true;

            // Throw an exeption, when no installdir choosen and a warning if no LibreOffice was choosen.
            try
            {
                if (!install_path)
                    throw new Exception(getstring("no_installdir"));
            }

            catch (Exception ex)
            {
                exeptionmessage(ex.Message);

            }
            finally
            {
                try
                {
                    if (!install_main)
                    {
                        MessageBox.Show(getstring("no_installfile"), getstring("warning"), MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        throw new Exception(getstring("go_back"));
                    }
                }

                catch (Exception) { go_on = false; }

            }
            if (go_on == true)
            {
                // Install
                string cmd_filename = create_cmd(install_main, install_help);
                try
                {
                    Process.Start(cmd_filename);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(getstring("installerror") + ex.Message, getstring("installnostart"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                string bootini = path_installdir + "\\program\\bootstrap.ini";




            }
        }
        private string final_installpath { get; set; }

        private string create_cmd(bool install_libo, bool install_help)
        {
            string path = path_installdir.Text;
            if (cb_subfolder.Checked && (subfolder.Text != ""))
            {

                path +=   "\\" + subfolder.Text;
            }
            path = path.Replace("\\\\", "\\");
            final_installpath = path;
            string cmd_file = "@ECHO off" + Environment.NewLine;
            if (install_libo)
                cmd_file += "start /wait msiexec /qr /norestart /a \"" + path_main.Text + "\" TARGETDIR=\"" + path + "\"" + Environment.NewLine;
            if (install_help)
                cmd_file += "start /wait msiexec /qr /a \"" + path_help.Text + "\" TARGETDIR=\"" + path + "\"" + Environment.NewLine;
            cmd_file += "exit";
            string filename = System.IO.Path.GetTempPath() + "install.cmd";
            try
            {
                System.IO.File.WriteAllText(filename, cmd_file);
                // If CMD file created --> Add to manager...
                SETTINGS temp = set.open_settings();
                temp.manager = set.update_manager_array(temp.manager, path);
                set.save_settings(temp);
                // Create path to soffice.exe
                path += "\\program\\soffice.exe";
                path_to_exe.Text = path;
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show(getstring("dirnotfound") + getstring("dirnotfoundmessage"), getstring("dirnotfound"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (System.Security.SecurityException)
            {
                MessageBox.Show(getstring("si_message"), getstring("si"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                exeptionmessage(ex.Message);
            }




            return filename;
        }


        private void open_bootstrap_Click(object sender, EventArgs e)
        {
            openbootstrap_ini();


        }

        private bool openbootstrap_ini()
        {
            bool working = true;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "abc.txt";
           if(final_installpath != null)
               path = final_installpath + "\\" + "program"+"\\" + "bootstrap.ini";
           
            try
            {
                bootstrap_text.Text = System.IO.File.ReadAllText(path);
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                working = false;
                if (open_bootstrap.ShowDialog() == DialogResult.OK)
                {
                    working = secondtry(open_bootstrap.FileName);
                }
                return working;
            }
            catch (System.IO.FileNotFoundException)
            {
                working = false;

                if (open_bootstrap.ShowDialog() == DialogResult.OK)
                {
                    working = secondtry(open_bootstrap.FileName);
                }


                return working;
            }

            catch (Exception ex)
            {
                working = false;
                exeptionmessage(ex.Message);
                return working;
            }
            if (working == true)
            {
                save_file.Enabled = true;
                bootinipath.Text = path;
            }
            return working;


        }

        private bool secondtry(string path)
        {
            bool working = true;

            try
            {
                bootstrap_text.Text = System.IO.File.ReadAllText(path);

            }
            catch (Exception ex)
            {
                working = false;
                exeptionmessage(ex.Message);


            }
            if (working == true)
            {
                save_file.Enabled = true;
                bootinipath.Text = path;
            }

            return working;

        }

        private void save_bootstrap(object sender, EventArgs e)
        {
            bool working = true;
            string exeptiontext = "";
            // Save bootstrap.ini
            try
            {
                System.IO.File.WriteAllText(bootinipath.Text, bootstrap_text.Text);
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                working = false;
                exeptiontext = ex.Message + " Error:DNF";
            }
            catch (System.IO.FileNotFoundException ex)
            {
                working = false;
                exeptiontext = ex.Message + " Error:FNF";
            }
            catch (System.IO.IOException ex)
            {
                working = false;
                exeptiontext = ex.Message + " Error:IOE";
            }
            catch (System.UnauthorizedAccessException ex)
            {
                working = false;
                exeptiontext = ex.Message + " Error:UAE" + Environment.NewLine + Environment.NewLine + getstring("help_runasadmin");
            }
            catch (System.NotSupportedException ex)
            {
                working = false;
                exeptiontext = ex.Message + " Error:NSE";
            }
            catch (System.Security.SecurityException ex)
            {
                working = false;
                exeptiontext = ex.Message + " Error:SE";
            }
            catch (Exception ex)
            {
                working = false;
                exeptiontext = ex.Message + " Error:???";
            }
            finally
            {

                if (working)
                {

                    MessageBox.Show(getstring("filesave"), getstring("title_filesave"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                else
                {

                    exeptionmessage(exeptiontext);

                }



            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            userinstallation.Text = "UserInstallation=$ORIGIN/..";
        }

        void download_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {

            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            b_dl_master.Enabled = false;
            b_dl_lb.Enabled = false;
            b_dl_ob.Enabled = false;
            b_dl_testing.Enabled = false;
            start_install.Enabled = false;
            // Creating a double value like 2.5 %
            double temp = percentage * 100;
            temp = Math.Truncate(temp);
            progressBar1.Value = Convert.ToInt16(temp);
            temp /= 100;
            string output = Convert.ToString(temp) + " %";
            percent.Text = output;
        }

        void download_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {


            give_message.ShowBalloonTip(10000, getstring("dl_finished_title"), getstring("dl_finished"), ToolTipIcon.Info);
            path_main.Text = path_to_file_ondisk.Text;
            progressBar1.Value = 0;
            percent.Text = "0 %";
            b_dl_master.Enabled = true;
            b_dl_lb.Enabled = true;
            b_dl_ob.Enabled = true;
            b_dl_testing.Enabled = true;
            start_install.Enabled = true;
            give_message.Text = "LibreOffice Server Installation GUI";


        }
        void download_hp_changed(object sender, DownloadProgressChangedEventArgs e)
        {

            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;
            dl_hp_1.Enabled = false;
            dl_hp_2.Enabled = false;
            dl_hp_3.Enabled = false;
            start_install.Enabled = false;
            // Creating a double value like 2.5 %
            double temp = percentage * 100;
            temp = Math.Truncate(temp);
            progressBar2.Value = Convert.ToInt16(temp);
            temp /= 100;
            string output = Convert.ToString(temp) + " %";
            percent2.Text = output;
        }

        void download_hp_dl_completed(object sender, AsyncCompletedEventArgs e)
        {


            give_message.ShowBalloonTip(10000, getstring("dl_finished_title"), getstring("dl_finished"), ToolTipIcon.Info);
            
                path_help.Text = path_to_file_on_disk_2.Text;
            
            progressBar2.Value = 0;
            percent2.Text = "0 %";
            dl_hp_1.Enabled = true;
            dl_hp_2.Enabled = true;
            dl_hp_3.Enabled = true;
            start_install.Enabled = true;
            give_message.Text = "LibreOffice Server Installation GUI";


        }
        public void startasyncdownload(string url, bool testing, bool master, bool latest_branch, bool older_branch)
        {
            startasyncdownload(url, testing, master, latest_branch, older_branch, false);
        }

        public void startasyncdownload(string url, bool testing, bool master, bool latest_branch, bool older_branch, bool helppack)
        {
            // Download
            bool cont = true;
            string lang = Convert.ToString(hp_lang_select.SelectedItem);
            try
            {
                if (helppack)
                {
                    if (lang == "")
                    {
                        cont = false;
                        throw new System.InvalidOperationException(getstring("error_langpack_nolang"));
                    }
                }
            }
            catch (Exception ex)
            {
                exeptionmessage(ex.Message);
            }
            if(cont)
            {
            string httpfile = downloadfile(url);
            if (httpfile != "error")
            {
                string filename = "";
                if (master)
                {
                    int starting_position = httpfile.IndexOf("<a href=\"master~");
                    httpfile = httpfile.Remove(0, 9 + starting_position);
                    starting_position = httpfile.IndexOf(".msi");
                    httpfile = httpfile.Remove(starting_position + 4);
                }
                else if (testing)
                {
                    int starting_position = httpfile.IndexOf("Directory</a>");

                    httpfile = httpfile.Remove(0, starting_position);
                    starting_position = httpfile.IndexOf("<a href=\"");

                    starting_position += 9;
                    httpfile = httpfile.Remove(0, starting_position);
                    string version = httpfile.Remove(5);
                    string link = "http://download.documentfoundation.org/libreoffice/testing/" + version + "/win/x86/?C=S;O=D";
                    httpfile = downloadfile(link);
                        starting_position = httpfile.IndexOf("Lib");
                        httpfile = httpfile.Remove(0, starting_position);
                        starting_position = httpfile.IndexOf(".msi") + 4;
                        httpfile = httpfile.Remove(starting_position);
                        if (helppack)
                        {
                            string vers2  = httpfile;
                            string insert = "_helppack_"+lang;
                            starting_position = vers2.IndexOf("x86")+3;
                            vers2 = vers2.Insert(starting_position, insert); ;
                            httpfile = vers2;
                        }
                    url = "http://download.documentfoundation.org/libreoffice/testing/" + version + "/win/x86/";

                }
                else if (latest_branch)
                {
                    int i = httpfile.IndexOf("Metadata");
                    httpfile = httpfile.Remove(0, i);
                    for (int j = 0; j < 3; j++)
                    {
                        i = httpfile.IndexOf("href=");
                        httpfile = httpfile.Remove(0, i + 6);
                    }
                    httpfile = httpfile.Remove(5);
                    url = "http://download.documentfoundation.org/libreoffice/stable/" + httpfile + "/win/x86/";
                    if (helppack)
                        httpfile = "LibreOffice_"+httpfile+"_Win_x86_helppack_"+lang+".msi";
                    else
                        httpfile = "LibreOffice_" + httpfile + "_Win_x86.msi";

                }
                else if (older_branch)
                {
                    int i = httpfile.IndexOf(">Parent Directory<");
                    httpfile = httpfile.Remove(0, i);
                    i = httpfile.IndexOf("a href");
                    i += 8;
                    httpfile = httpfile.Remove(0, i);
                    i = httpfile.IndexOf("/");
                    httpfile = httpfile.Remove(i);
                    url = "http://download.documentfoundation.org/libreoffice/stable/" + httpfile + "/win/x86/";
                    if (helppack)
                        httpfile = "LibO_" + httpfile + "_Win_x86_helppack_" + lang + ".msi";
                    else
                        httpfile = "LibO_" + httpfile + "_Win_x86_install_multi.msi";

                }
                filename = httpfile;
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 10000;
                progressBar2.Minimum = 0;
                progressBar2.Maximum = 10000;
                string path = Path.GetTempPath();
                WebClient downloadmaster = new WebClient();
                WebClient download_hp = new WebClient();
                string ua = "LibreOffice Server Install Gui " + set.program_version();
                downloadmaster.Headers["User-Agent"] = ua;
                download_hp.Headers["User-Agent"] = ua;
                download_hp.DownloadProgressChanged += new DownloadProgressChangedEventHandler(download_hp_changed);
                download_hp.DownloadFileCompleted += new AsyncCompletedEventHandler(download_hp_dl_completed);
                downloadmaster.DownloadProgressChanged += new DownloadProgressChangedEventHandler(download_DownloadProgressChanged);
                downloadmaster.DownloadFileCompleted += new AsyncCompletedEventHandler(download_DownloadFileCompleted);
                Uri uritofile = new Uri(url + httpfile);
                if (helppack)
                {
                    if (testing)
                        path += "libotesting_hp.msi";
                    else if (latest_branch)
                        path += "libolbranch_hp.msi";
                    else if (older_branch)
                        path += "liboobranch_hp.msi";
                }
                else
                {
                    if (master)
                        path += "libomaster.msi";
                    else if (testing)
                        path += "libotesting.msi";
                    else if (latest_branch)
                        path += "libolbranch.msi";
                    else if (older_branch)
                        path += "liboobranch.msi";
                }
                if (helppack)
                    path_to_file_on_disk_2.Text = path;
                else
                    path_to_file_ondisk.Text = path;
                string mb_question = getstring("versiondl");
                mb_question = mb_question.Replace("%version", filename);



                if (MessageBox.Show(mb_question, getstring("startdl"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    give_message.ShowBalloonTip(5000, getstring("dl_started_title"), getstring("dl_started"), ToolTipIcon.Info);
                    if (helppack)
                        download_hp.DownloadFileAsync(uritofile, path);
                    else
                        downloadmaster.DownloadFileAsync(uritofile, path);
                    int k =0;
                    if (!master)
                    {
                        k = filename.IndexOf("_") + 1;
                        filename = filename.Remove(0, k);
                        k = filename.IndexOf("_");
                        filename = filename.Remove(k);
                    }
                    else
                    {
                        k = filename.IndexOf("_");
                        filename = filename.Remove(k);
                    }
                    if(!helppack)
                    subfolder.Text = filename;
                }
           }
            }
        }

        private void b_dl_master_Click(object sender, EventArgs e)
        {
            startasyncdownload("http://dev-builds.libreoffice.org/daily/master/Win-x86@6/current/", false, true, false, false);
        }

        private void b_dl_lb_Click(object sender, EventArgs e)
        {
            startasyncdownload("http://download.documentfoundation.org/libreoffice/stable/", false, false, true, false);
        }

        private void b_dl_testing_Click(object sender, EventArgs e)
        {
            startasyncdownload("http://download.documentfoundation.org/libreoffice/testing/", true, false, false, false);
        }

        private void b_dl_ob_Click(object sender, EventArgs e)
        {
            startasyncdownload("http://download.documentfoundation.org/libreoffice/stable/", false, false, false, true);
        }
        private string downloadfile(string url)
        {
            WebClient httpfileclient = new WebClient();
            Uri urlhttp = new Uri(url);
            string httpfile = "error";
            try
            {
                Stream httptextraw = httpfileclient.OpenRead(urlhttp);
                StreamReader httpreader = new StreamReader(httptextraw);
                httpfile = httpreader.ReadToEnd();
                httptextraw.Close();
                httpreader.Close();

            }
            catch (System.Net.WebException ex)
            {
                exeptionmessage(ex.Message);

            }
            return httpfile;




        }

        private void open_installer_Click(object sender, EventArgs e)
        {
            openfile.ShowDialog();
        }
        public void exeptionmessage(string ex_message)
        {
            MessageBox.Show(getstring("standarderror") + ex_message, getstring("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public string getstring(string strMessage)
        {
            string rt = "???";
            try
            {
                rt = rm.GetString(strMessage);
            }
            catch (Exception)
            {
                exeptionmessage("An error in the l10n part occured!");
            }
            return rt;

        }



        private void show_about(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void savesettings(object sender, EventArgs e)
        {
            // Changing text of version
            tb_version.Text = subfolder.Text;
            // Really save settings
            SETTINGS thingstosave = set.open_settings();
            thingstosave.installdir = path_installdir.Text;
            thingstosave.subfolder = subfolder.Text;
            thingstosave.checkbox = cb_subfolder.Checked;
            thingstosave.lang = hp_lang_select.SelectedIndex;
            thingstosave.last_path_to_sofficeEXE = path_to_exe.Text;


            set.save_settings(thingstosave);
            

        
       

        }
        

        private void help_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            fm.ShowDialog();
        }



        public EventHandler balloon_tip_clicked { get; set; }

        private void path_to_file_ondisk_TextChanged(object sender, EventArgs e)
        {

        }

        private void path_help_TextChanged(object sender, EventArgs e)
        {

        }

        private void path_main_TextChanged(object sender, EventArgs e)
        {

        }

        private void dl_hp_1_Click(object sender, EventArgs e)
        {
            startasyncdownload("http://download.documentfoundation.org/libreoffice/stable/", false, false, true, false, true);
        }

        private void dl_hp_2_Click(object sender, EventArgs e)
        {
            startasyncdownload("http://download.documentfoundation.org/libreoffice/testing/", true, false, false, false, true);
        }

        private void dl_hp_3_Click(object sender, EventArgs e)
        {
            startasyncdownload("http://download.documentfoundation.org/libreoffice/stable/", false, false, false, true, true);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Manager fm = new Manager();
            fm.ShowDialog();
        }

        private void create_ink_Click(object sender, EventArgs e)
        {
            LINK lnk = new LINK();
            lnk.create_ink(path_to_exe.Text, tb_version.Text);
        }
    }
}
