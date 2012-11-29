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

namespace WindowsFormsApplication1
{
    public partial class Manager : Form
    {
        ResourceManager rm = new ResourceManager("WindowsFormsApplication1.strings", Assembly.GetExecutingAssembly());
        access_settings set = new access_settings();
        public Manager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

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
        private void update_selector()
        {
            SETTINGS temp = set.open_settings();
            string[] list = temp.manager;
            manager_list.Items.Clear();
            foreach (string s in list)
            {
                manager_list.Items.Add(s);
            }

        }

    }
}
