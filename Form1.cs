﻿using System;
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
using System.Configuration;


namespace WindowsFormsApplication1
{


    public partial class Form1 : Form
    {
        

        public Form1()
        {
            //l10n
            try
            {
                string temp = Path.GetTempPath() + "langsettings.config";
                string lang = File.ReadAllText(temp);
                
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang, false);

            }
            catch (Exception)
            { }
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           //l10n start
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
            open_bootstrap.Title = getstring("open_bootstrap_title");
            save_file.Text = getstring("save_bootstrap_ini");
            start_install.Text = getstring("start_install");
            wheretoinstall.Description = getstring("where_to_install");
            cb_subfolder.Text = getstring("subfolder_do");
            /* l10n end
             * Start Setting tooltips */
            ToolTip d_lb = new ToolTip();
            ToolTip d_m = new ToolTip();
            ToolTip d_tb = new ToolTip();
            ToolTip d_ob = new ToolTip();
            ToolTip bootstrapini = new ToolTip();
            string tt_lb = getstring("tt_lb");
            string tt_m = getstring("tt_m");
            string tt_tb = getstring("tt_tb");
            string tt_ob = getstring("tt_ob");
            d_lb.SetToolTip(this.b_dl_lb, tt_lb);
            d_m.SetToolTip(this.b_dl_master, tt_m);
            d_tb.SetToolTip(this.b_dl_testing, tt_tb);
            d_ob.SetToolTip(this.b_dl_ob, tt_ob);
            bootstrapini.SetToolTip(this.userinstallation,getstring("tt_bootstrap"));
            bootstrapini.ShowAlways = true;
            d_lb.IsBalloon = true;
            d_m.IsBalloon = true;
            d_ob.IsBalloon = true;
            d_tb.IsBalloon = true;
            bootstrapini.IsBalloon = true;
            help.Text = getstring("help");
            /* End Setting tooltips
             * Start Loading settings */
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(SETTINGS));
                string path = getsettingsfilename();
                StreamReader sr = new StreamReader(@path);
                SETTINGS toapply = (SETTINGS)ser.Deserialize(sr);
                sr.Close();
                //Apply settings
                cb_subfolder.Checked = toapply.checkbox;
                path_installdir.Text = toapply.installdir;
                subfolder.Text = toapply.subfolder;

            }
            catch (Exception ex)
            { exeptionmessage(ex.Message); }

            // End Loading settings
            button1.Text = getstring("about");
            give_message.BalloonTipClicked += new EventHandler(gm_do);
            give_message.BalloonTipClosed += new EventHandler(gm_do);
            give_message.Click += new EventHandler(gm_do);
            give_message.DoubleClick += new EventHandler(gm_do);

        }
        private void gm_do(Object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            //Interaction.AppActivate(this.Text);
            
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

            // Throw an exeption, when no installdir choosen and a wearning if no LibreOffice was choosen.
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

                        if (MessageBox.Show(getstring("no_installfile"), getstring("warning"), MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
                            throw new Exception(getstring("go_back"));
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

        private string create_cmd(bool install_libo, bool install_help)
        {
            string path = path_installdir.Text;
            if (cb_subfolder.Checked)
                path +=  subfolder.Text +"\\";
           
            MessageBox.Show(path);
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
            string path = path_installdir.Text + "\\program\\bootstrap.ini";
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
            give_message.Text = "LibreOffice Server Installation GUI";

            path_main.Text = path_to_file_ondisk.Text;
            progressBar1.Value = 0;
            percent.Text = "0 %";
            b_dl_master.Enabled = true;
            b_dl_lb.Enabled = true;
            b_dl_ob.Enabled = true;
            b_dl_testing.Enabled = true;
            start_install.Enabled = true;

        }

        public void startasyncdownload(string url, bool testing, bool master, bool latest_branch, bool older_branch)
        {
            // Download
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
                    filename = httpfile;
                }
                else if (testing)
                {
                    try
                    {
                        int starting_position = httpfile.IndexOf("Directory</a>");

                        httpfile = httpfile.Remove(0, starting_position);

                        starting_position = httpfile.IndexOf("<a href=\"");

                        starting_position += 9;
                        httpfile = httpfile.Remove(0, starting_position);
                        string version = httpfile.Remove(5);
                        string link = "http://download.documentfoundation.org/libreoffice/testing/" + version + "/win/x86/?C=S;O=D";
                        httpfile = downloadfile(link);
                        starting_position = httpfile.IndexOf("LibO_");
                        httpfile = httpfile.Remove(0, starting_position);
                        starting_position = httpfile.IndexOf(".msi") + 4;
                        httpfile = httpfile.Remove(starting_position);
                        filename = httpfile;
                        url = "http://download.documentfoundation.org/libreoffice/testing/" + version + "/win/x86/";
                    }
                    catch (Exception ex)
                    {
                        exeptionmessage(getstring("notest") + ex.Message);

                    }
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
                    httpfile = "LibO_" + httpfile + "_Win_x86_install_multi.msi";
                    filename = httpfile;

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
                    httpfile = "LibO_" + httpfile + "_Win_x86_install_multi.msi";
                    filename = httpfile;

                }
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 10000;
                string path = Path.GetTempPath();
                WebClient downloadmaster = new WebClient();
                downloadmaster.DownloadProgressChanged += new DownloadProgressChangedEventHandler(download_DownloadProgressChanged);
                downloadmaster.DownloadFileCompleted += new AsyncCompletedEventHandler(download_DownloadFileCompleted);
                Uri uritofile = new Uri(url + httpfile);
                if (master)
                    path += "libomaster.msi";
                else if (testing)
                    path += "libotesting.msi";
                else if (latest_branch)
                    path += "libolbranch.msi";
                else if (older_branch)
                    path += "liboobranch.msi";
                path_to_file_ondisk.Text = path;
                string mb_question = getstring("versiondl");
                mb_question = mb_question.Replace("%version", filename);

                if (MessageBox.Show(mb_question, getstring("startdl"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    give_message.ShowBalloonTip(5000, getstring("dl_started_title"), getstring("dl_started"), ToolTipIcon.Info);
                    downloadmaster.DownloadFileAsync(uritofile, path);
                    int k = filename.IndexOf("LibO");
                    filename = filename.Remove(k, 5);
                    k = filename.IndexOf("_");
                    filename = filename.Remove(k);
                    subfolder.Text = filename;
                }
            }
        }

        private void b_dl_master_Click(object sender, EventArgs e)
        {
            startasyncdownload("http://dev-builds.libreoffice.org/daily/Win-x86@6/master/current/", false, true, false, false);
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
                ResourceManager rm = new ResourceManager("WindowsFormsApplication1.strings", Assembly.GetExecutingAssembly());
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
            form.Visible = true;
        }

        private void savesettings(object sender, EventArgs e)
        {
            SETTINGS thingstosave = new SETTINGS();
            thingstosave.installdir = path_installdir.Text;
            thingstosave.subfolder = subfolder.Text;
            thingstosave.checkbox = cb_subfolder.Checked;

            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(SETTINGS));
                string path = getsettingsfilename();
                FileStream str = new FileStream(@path, FileMode.Create);
                ser.Serialize(str, thingstosave);
                str.Close();
            }
            catch (Exception)
            { /*exeptionmessage(ex.Message);*/ }
           
        }
        public class SETTINGS
        {
            public string installdir;
            public string subfolder;
            public bool checkbox;

        }
       private string getsettingsfilename()
       { return   Path.GetTempPath() + "libo_si_gui_path.config";}

       private void help_Click(object sender, EventArgs e)
       {
           Form3 fm3 = new Form3();
           fm3.Show();
       }
      

    }
}
