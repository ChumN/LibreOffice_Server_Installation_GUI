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
using System.Reflection;
using System.Diagnostics;

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

            this.Text = getstring("man_title");
            button1.Text = getstring("man_exit");
            button3.Text = getstring("man_addinstall");
            button2.Text = getstring("man_del");
            update_selector();
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
            if(list != null)
                foreach( string s in list)
                {
                    manager_list.Items.Add(s);
                }

        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            manually_add_installation fm = new manually_add_installation();
            fm.ShowDialog();
            if(fm.shared_string != null)
            {
                SETTINGS temp = set.open_settings();
                temp.manager = set.update_manager_array(temp.manager, fm.shared_string);
                set.save_settings(temp);
                update_selector();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create CMD file, which deletes the selected folders ...
            List<string> list = new List<string>();
            List<object> list_o = new List<object>();
            foreach (object itemChecked in manager_list.CheckedItems)
            {
                list.Add(itemChecked.ToString());
                list_o.Add(itemChecked);
            }

            string[] array = list.ToArray();

            string output = "";

            foreach (string s in array)
            {
                string m = s.Replace("//","/");
                output += "del " + m + " /s /f /q" + Environment.NewLine;
                output += "rd " + m + " /s /q" + Environment.NewLine;
            }
            output += "exit";
            string filename = System.IO.Path.GetTempPath() + "del_manager.cmd";
            try
            {
                System.IO.File.WriteAllText(filename, output);
               Process.Start(filename);
                
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
            object[] o_array = list_o.ToArray();
            foreach (object o in o_array)
            {
                manager_list.Items.Remove(o);
            }
            List<string> new_manager = new List<string>();
            foreach (string o in manager_list.Items)
            {
                new_manager.Add(o);
            }
            SETTINGS sett = set.open_settings();
            sett.manager = new_manager.ToArray();
            set.save_settings(sett);
            
            update_selector();
        }

    }
}
