using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using System.IO;
using System.Threading;
using System.Globalization;


namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        ResourceManager rm = new ResourceManager("WindowsFormsApplication1.strings", Assembly.GetExecutingAssembly());
         
        public Form3()
        {
            //l10n import
            string l10n = "???";
            string[] rtl = new string[] { "He" };
            try
            {
                l10n = Path.GetTempPath() + "langsettings.config";
                string lang = File.ReadAllText(l10n);
                if (rtl.Contains(lang))
                    this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang, false);

            }
            catch (Exception)
            { }
            InitializeComponent();
            
            
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

        private void form3load(object sender, EventArgs e)
        {
            this.Text = getstring("help");
            string url = "http://reisi007.bplaced.com/program/doc.html";
            Uri uriurl = new Uri(url);
            help_browser.Url = uriurl;
        }
    }

}
