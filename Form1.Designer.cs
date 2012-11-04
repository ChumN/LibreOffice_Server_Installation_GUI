namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openfile = new System.Windows.Forms.OpenFileDialog();
            this.b_open_libo_installer = new System.Windows.Forms.Button();
            this.path_main = new System.Windows.Forms.TextBox();
            this.path_help = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openfile2 = new System.Windows.Forms.OpenFileDialog();
            this.start_install = new System.Windows.Forms.Button();
            this.wheretoinstall = new System.Windows.Forms.FolderBrowserDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.path_installdir = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.bootstrap_text = new System.Windows.Forms.TextBox();
            this.open_bootstrap = new System.Windows.Forms.OpenFileDialog();
            this.save_file = new System.Windows.Forms.Button();
            this.bootinipath = new System.Windows.Forms.TextBox();
            this.userinstallation = new System.Windows.Forms.TextBox();
            this.b_dl_master = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.path_to_file_ondisk = new System.Windows.Forms.TextBox();
            this.percent = new System.Windows.Forms.Label();
            this.b_dl_lb = new System.Windows.Forms.Button();
            this.b_dl_ob = new System.Windows.Forms.Button();
            this.b_dl_testing = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openfile
            // 
            this.openfile.DefaultExt = "msi";
            resources.ApplyResources(this.openfile, "openfile");
            this.openfile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // b_open_libo_installer
            // 
            resources.ApplyResources(this.b_open_libo_installer, "b_open_libo_installer");
            this.b_open_libo_installer.Name = "b_open_libo_installer";
            this.b_open_libo_installer.UseVisualStyleBackColor = true;
            this.b_open_libo_installer.Click += new System.EventHandler(this.open_installer_Click);
            // 
            // path_main
            // 
            resources.ApplyResources(this.path_main, "path_main");
            this.path_main.Name = "path_main";
            this.path_main.ReadOnly = true;
            // 
            // path_help
            // 
            resources.ApplyResources(this.path_help, "path_help");
            this.path_help.Name = "path_help";
            this.path_help.ReadOnly = true;
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.openLibohelp);
            // 
            // openfile2
            // 
            this.openfile2.DefaultExt = "msi";
            resources.ApplyResources(this.openfile2, "openfile2");
            this.openfile2.FileOk += new System.ComponentModel.CancelEventHandler(this.openfile2_FileOk);
            // 
            // start_install
            // 
            resources.ApplyResources(this.start_install, "start_install");
            this.start_install.Name = "start_install";
            this.start_install.UseVisualStyleBackColor = true;
            this.start_install.Click += new System.EventHandler(this.start_install_Click);
            // 
            // wheretoinstall
            // 
            resources.ApplyResources(this.wheretoinstall, "wheretoinstall");
            this.wheretoinstall.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.wheretoinstall.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.config_installdir);
            // 
            // path_installdir
            // 
            resources.ApplyResources(this.path_installdir, "path_installdir");
            this.path_installdir.Name = "path_installdir";
            this.path_installdir.ReadOnly = true;
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.open_bootstrap_Click);
            // 
            // bootstrap_text
            // 
            resources.ApplyResources(this.bootstrap_text, "bootstrap_text");
            this.bootstrap_text.Name = "bootstrap_text";
            // 
            // open_bootstrap
            // 
            this.open_bootstrap.FileName = "bootstrap.ini";
            resources.ApplyResources(this.open_bootstrap, "open_bootstrap");
            // 
            // save_file
            // 
            resources.ApplyResources(this.save_file, "save_file");
            this.save_file.Name = "save_file";
            this.save_file.UseVisualStyleBackColor = true;
            this.save_file.Click += new System.EventHandler(this.save_bootstrap);
            // 
            // bootinipath
            // 
            resources.ApplyResources(this.bootinipath, "bootinipath");
            this.bootinipath.Name = "bootinipath";
            this.bootinipath.ReadOnly = true;
            // 
            // userinstallation
            // 
            resources.ApplyResources(this.userinstallation, "userinstallation");
            this.userinstallation.Name = "userinstallation";
            this.userinstallation.ReadOnly = true;
            this.userinstallation.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // b_dl_master
            // 
            resources.ApplyResources(this.b_dl_master, "b_dl_master");
            this.b_dl_master.Name = "b_dl_master";
            this.b_dl_master.UseVisualStyleBackColor = true;
            this.b_dl_master.Click += new System.EventHandler(this.b_dl_master_Click);
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.save_file);
            this.groupBox1.Controls.Add(this.bootinipath);
            this.groupBox1.Controls.Add(this.userinstallation);
            this.groupBox1.Controls.Add(this.bootstrap_text);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.show_about);
            // 
            // path_to_file_ondisk
            // 
            resources.ApplyResources(this.path_to_file_ondisk, "path_to_file_ondisk");
            this.path_to_file_ondisk.Name = "path_to_file_ondisk";
            this.path_to_file_ondisk.ReadOnly = true;
            // 
            // percent
            // 
            resources.ApplyResources(this.percent, "percent");
            this.percent.BackColor = System.Drawing.Color.Transparent;
            this.percent.Name = "percent";
            // 
            // b_dl_lb
            // 
            resources.ApplyResources(this.b_dl_lb, "b_dl_lb");
            this.b_dl_lb.Name = "b_dl_lb";
            this.b_dl_lb.Tag = "";
            this.b_dl_lb.UseVisualStyleBackColor = true;
            this.b_dl_lb.Click += new System.EventHandler(this.b_dl_lb_Click);
            // 
            // b_dl_ob
            // 
            resources.ApplyResources(this.b_dl_ob, "b_dl_ob");
            this.b_dl_ob.Name = "b_dl_ob";
            this.b_dl_ob.UseVisualStyleBackColor = true;
            this.b_dl_ob.Click += new System.EventHandler(this.b_dl_ob_Click);
            // 
            // b_dl_testing
            // 
            resources.ApplyResources(this.b_dl_testing, "b_dl_testing");
            this.b_dl_testing.Name = "b_dl_testing";
            this.b_dl_testing.UseVisualStyleBackColor = true;
            this.b_dl_testing.Click += new System.EventHandler(this.b_dl_testing_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.percent);
            this.Controls.Add(this.b_dl_testing);
            this.Controls.Add(this.b_dl_ob);
            this.Controls.Add(this.b_dl_lb);
            this.Controls.Add(this.path_to_file_ondisk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.b_dl_master);
            this.Controls.Add(this.path_installdir);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.start_install);
            this.Controls.Add(this.path_help);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.path_main);
            this.Controls.Add(this.b_open_libo_installer);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openfile;
        private System.Windows.Forms.Button b_open_libo_installer;
        private System.Windows.Forms.TextBox path_main;
        private System.Windows.Forms.TextBox path_help;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openfile2;
        private System.Windows.Forms.Button start_install;
        private System.Windows.Forms.FolderBrowserDialog wheretoinstall;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox path_installdir;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox bootstrap_text;
        private System.Windows.Forms.OpenFileDialog open_bootstrap;
        private System.Windows.Forms.Button save_file;
        private System.Windows.Forms.TextBox bootinipath;
        private System.Windows.Forms.TextBox userinstallation;
        private System.Windows.Forms.Button b_dl_master;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox path_to_file_ondisk;
        private System.Windows.Forms.Label percent;
        private System.Windows.Forms.Button b_dl_lb;
        private System.Windows.Forms.Button b_dl_ob;
        private System.Windows.Forms.Button b_dl_testing;
        private System.Windows.Forms.Button button1;
    }
}

