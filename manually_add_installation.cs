using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class manually_add_installation : Form
    {
        public string[,] manually_added { get; private set; }
        
        public manually_add_installation()
        {
            
            InitializeComponent();
        }
        
        public string shared_string {get;  private set;}
        
       


        private void manually_add_installation_Load(object sender, EventArgs e)
        {
            button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            button2.DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path_text = "";
            string delete = "\\program\\soffice.exe";
            if(DialogResult.OK == openFileDialog1.ShowDialog())
           path_text = openFileDialog1.FileName;
           int i = path_text.IndexOf(delete);
           try
           {
               path_text = path_text.Remove(i);
           }
           catch (Exception) { }
             path.Text = path_text;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
           string array = path.Text;
            shared_string = array;
        }
    }
}
