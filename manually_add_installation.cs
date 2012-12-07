﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using System.Threading;
using System.Globalization;


namespace WindowsFormsApplication1
{
    public partial class manually_add_installation : Form
    {
        access_settings set = new access_settings();
        public string[,] manually_added { get; private set; }
        ResourceManager rm = new ResourceManager("WindowsFormsApplication1.strings", Assembly.GetExecutingAssembly());
        public manually_add_installation()
        {
            
            InitializeComponent();
        }
        
        public string shared_string {get;  private set;}
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
       


        private void manually_add_installation_Load(object sender, EventArgs e)
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
                {
                    this.RightToLeftLayout = true;
                    path.RightToLeft = System.Windows.Forms.RightToLeft.No;
                }

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            
            button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            button2.DialogResult = System.Windows.Forms.DialogResult.Abort;
            // l10n
            label2.Text = getstring("mai_path_soffice");
            button3.Text = getstring("mai_config_path");
            this.Text = getstring("mai_text");
            button2.Text = getstring("mai_ok");
            button1.Text = getstring("mai_abort");
            


            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path_text = "";
            
            if(DialogResult.OK == openFileDialog1.ShowDialog())
           path_text = openFileDialog1.FileName;
            path.Text = path_text;
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path_text = path.Text;
           if(path_text != "")
            {
            string delete = "\\program\\soffice.exe";
            int i = path_text.IndexOf(delete);
            try
            {
                System.IO.File.ReadAllBytes(path_text);
                path_text = path_text.Remove(i);
                shared_string = path_text;
            }
            catch(Exception ex) {exeptionmessage(ex.Message);}
            }
        }
    }
}
