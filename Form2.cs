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
        public Form2()
        {
            
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
            string sl = getstring("sl") + " ";
            string pt = getstring("pt") + " ";
            string programmer = getstring("programmer") + " ";
            string florei = "Florian Reisinger";
            string nemo = "no one ;)";
            abouttxt = programmer + florei + Environment.NewLine + translations + Environment.NewLine  ;
            abouttxt += en + florei + Environment.NewLine;
            abouttxt+= de + florei + Environment.NewLine;
            abouttxt += fr + "Sophie Gautier" + Environment.NewLine;
            abouttxt += sl + "Martin Srebotnjak" + Environment.NewLine;
            abouttxt += pt + "Carlos Moreira" + Environment.NewLine;
            about.Text = abouttxt;
            this.Text = getstring("about");
            lang_chooser.Sorted = true;

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

        public void exeptionmessage(string ex_message)
        {
            MessageBox.Show(getstring("standarderror") + ex_message, getstring("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void update_lang(object sender, EventArgs e)
        {
            
            try
            {

                string temp = Path.GetTempPath() + "langsettings.config";
                File.WriteAllText(temp, lang_chooser.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                exeptionmessage(ex.Message);

            }
            MessageBox.Show(getstring("language_change_success"), getstring("success"), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
       

       
    }
}
