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
using System.Resources;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Globalization;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        access_settings set = new access_settings();
        ResourceManager rm = new ResourceManager("WindowsFormsApplication1.strings", Assembly.GetExecutingAssembly());
        public Form2()
        {
            //l10n import
            string[] rtl = new string[] { "He" };
            try
            {

                SETTINGS temp = set.open_settings();
                string lang = temp.l10n;
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang, false);

                if (rtl.Contains(lang))
                    this.RightToLeftLayout = true;



            }
            catch (Exception )
            { }
            InitializeComponent();
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = getstring("update_lang");
            string abouttxt = "";
            string translations = getstring("translations")+" ";
            string translator = getstring("translator")+" ";
            string de = getstring("de") + " ";
            string en = getstring("en") + " ";
            string fr = getstring("fr") + " ";
            string es = getstring("es") + " ";
            string he = getstring("he") + " ";
            string pt = getstring("pt") + " ";
            string programmer = getstring("programmer") + " ";
            string florei = "Florian Reisinger";
            string nemo = "NEMO ;)";
            string sl = getstring("sl") + " ";
            string da = getstring("da") + " ";
            abouttxt = programmer + florei + Environment.NewLine + translations + Environment.NewLine  ;
            abouttxt += en + florei + Environment.NewLine;
            abouttxt+= de + florei + Environment.NewLine;
            abouttxt += fr + "Sophie Gautier" + Environment.NewLine;
            abouttxt += es + "Adolfo Jayme Barrientos" + Environment.NewLine;
            abouttxt += sl + "Martin Srebotnjak" + Environment.NewLine;
            abouttxt += da + "Leif Lodahl"+ Environment.NewLine;
            abouttxt += pt + "Carlos Moreira" + Environment.NewLine; 
            abouttxt += he + "Yaron Shahrabani" + Environment.NewLine;
            about.Text = abouttxt;
            this.Text = getstring("about");
            lang_chooser.Sorted = true;

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

        public void exeptionmessage(string ex_message)
        {
            MessageBox.Show(getstring("standarderror") + ex_message, getstring("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void update_lang(object sender, EventArgs e)
        {
            SETTINGS temp = set.open_settings();
            temp.l10n = Convert.ToString(lang_chooser.SelectedItem);
            set.save_settings(temp);
            MessageBox.Show(getstring("language_change_success"), getstring("success"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
       

       
    }
}
