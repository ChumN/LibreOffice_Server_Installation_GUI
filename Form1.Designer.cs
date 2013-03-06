namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        #region Licence
        /*This file is part of the project "Reisisoft Server Install GUI",
        * which is licenced under LGPL v3+. You may find a copy in the source,
        * or obtain one at http://www.gnu.org/licenses/lgpl-3.0-standalone.html */
        #endregion

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
            this.components = new System.ComponentModel.Container();
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
            this.button5 = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.path_to_file_ondisk = new System.Windows.Forms.TextBox();
            this.percent = new System.Windows.Forms.Label();
            this.b_dl_lb = new System.Windows.Forms.Button();
            this.b_dl_ob = new System.Windows.Forms.Button();
            this.b_dl_testing = new System.Windows.Forms.Button();
            this.cb_subfolder = new System.Windows.Forms.CheckBox();
            this.subfolder = new System.Windows.Forms.TextBox();
            this.give_message = new System.Windows.Forms.NotifyIcon(this.components);
            this.dl_hp_1 = new System.Windows.Forms.Button();
            this.dl_hp_2 = new System.Windows.Forms.Button();
            this.dl_hp_3 = new System.Windows.Forms.Button();
            this.hp_lang_select = new System.Windows.Forms.ComboBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.percent2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.path_to_file_on_disk_2 = new System.Windows.Forms.TextBox();
            this.version = new System.Windows.Forms.Label();
            this.path_to_exe = new System.Windows.Forms.TextBox();
            this.tb_version = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.create_lnk = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openfile
            // 
            this.openfile.DefaultExt = "msi";
            this.openfile.Filter = "LibreOffice installation file|Lib*Win_x86*.msi;*LibO-Dev*Win_x86_install*.msi;lib" +
    "reoffice*.msi";
            this.openfile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // b_open_libo_installer
            // 
            this.b_open_libo_installer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_open_libo_installer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_open_libo_installer.Location = new System.Drawing.Point(13, 13);
            this.b_open_libo_installer.Name = "b_open_libo_installer";
            this.b_open_libo_installer.Size = new System.Drawing.Size(206, 23);
            this.b_open_libo_installer.TabIndex = 0;
            this.b_open_libo_installer.Text = "Open LibreOffice installer";
            this.b_open_libo_installer.UseVisualStyleBackColor = true;
            this.b_open_libo_installer.Click += new System.EventHandler(this.open_installer_Click);
            // 
            // path_main
            // 
            this.path_main.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.path_main.ForeColor = System.Drawing.SystemColors.ControlText;
            this.path_main.Location = new System.Drawing.Point(225, 16);
            this.path_main.Name = "path_main";
            this.path_main.ReadOnly = true;
            this.path_main.Size = new System.Drawing.Size(195, 20);
            this.path_main.TabIndex = 1;
            this.path_main.TextChanged += new System.EventHandler(this.path_main_TextChanged);
            // 
            // path_help
            // 
            this.path_help.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.path_help.ForeColor = System.Drawing.SystemColors.ControlText;
            this.path_help.Location = new System.Drawing.Point(225, 42);
            this.path_help.Name = "path_help";
            this.path_help.ReadOnly = true;
            this.path_help.Size = new System.Drawing.Size(195, 20);
            this.path_help.TabIndex = 3;
            this.path_help.TextChanged += new System.EventHandler(this.path_help_TextChanged);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(13, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Open LibreOffice help";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.openLibohelp);
            // 
            // openfile2
            // 
            this.openfile2.DefaultExt = "msi";
            this.openfile2.Filter = "LibreOffice help installation file | *Win_x86_helppack_*.msi";
            this.openfile2.FileOk += new System.ComponentModel.CancelEventHandler(this.openfile2_FileOk);
            // 
            // start_install
            // 
            this.start_install.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.start_install.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_install.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.start_install.ForeColor = System.Drawing.SystemColors.ControlText;
            this.start_install.Location = new System.Drawing.Point(13, 100);
            this.start_install.Name = "start_install";
            this.start_install.Size = new System.Drawing.Size(407, 74);
            this.start_install.TabIndex = 4;
            this.start_install.Text = "Start installation";
            this.start_install.UseVisualStyleBackColor = true;
            this.start_install.Click += new System.EventHandler(this.start_install_Click);
            // 
            // wheretoinstall
            // 
            this.wheretoinstall.Description = "Choose installation directory";
            this.wheretoinstall.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.wheretoinstall.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(12, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(207, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Configure installation directory";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.config_installdir);
            // 
            // path_installdir
            // 
            this.path_installdir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.path_installdir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.path_installdir.Location = new System.Drawing.Point(225, 73);
            this.path_installdir.Name = "path_installdir";
            this.path_installdir.ReadOnly = true;
            this.path_installdir.Size = new System.Drawing.Size(195, 20);
            this.path_installdir.TabIndex = 6;
            this.path_installdir.TextChanged += new System.EventHandler(this.savesettings);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(6, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(175, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Open bootstap.ini";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.open_bootstrap_Click);
            // 
            // bootstrap_text
            // 
            this.bootstrap_text.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bootstrap_text.Location = new System.Drawing.Point(6, 72);
            this.bootstrap_text.Multiline = true;
            this.bootstrap_text.Name = "bootstrap_text";
            this.bootstrap_text.Size = new System.Drawing.Size(386, 107);
            this.bootstrap_text.TabIndex = 8;
            // 
            // open_bootstrap
            // 
            this.open_bootstrap.FileName = "bootstrap.ini";
            this.open_bootstrap.Filter = "LibreOffice bootstrap.ini file | bootstrap.ini";
            this.open_bootstrap.Title = "Open bootstrap.ini";
            // 
            // save_file
            // 
            this.save_file.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.save_file.Enabled = false;
            this.save_file.ForeColor = System.Drawing.SystemColors.ControlText;
            this.save_file.Location = new System.Drawing.Point(187, 17);
            this.save_file.Name = "save_file";
            this.save_file.Size = new System.Drawing.Size(205, 23);
            this.save_file.TabIndex = 9;
            this.save_file.Text = "Save bootstap.ini";
            this.save_file.UseVisualStyleBackColor = true;
            this.save_file.Click += new System.EventHandler(this.save_bootstrap);
            // 
            // bootinipath
            // 
            this.bootinipath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bootinipath.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bootinipath.Location = new System.Drawing.Point(6, 46);
            this.bootinipath.Name = "bootinipath";
            this.bootinipath.ReadOnly = true;
            this.bootinipath.Size = new System.Drawing.Size(387, 20);
            this.bootinipath.TabIndex = 10;
            // 
            // userinstallation
            // 
            this.userinstallation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userinstallation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.userinstallation.Location = new System.Drawing.Point(6, 185);
            this.userinstallation.Name = "userinstallation";
            this.userinstallation.ReadOnly = true;
            this.userinstallation.Size = new System.Drawing.Size(387, 20);
            this.userinstallation.TabIndex = 11;
            this.userinstallation.Text = "UserInstallation=$ORIGIN/..";
            this.userinstallation.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // b_dl_master
            // 
            this.b_dl_master.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_dl_master.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_dl_master.Location = new System.Drawing.Point(225, 287);
            this.b_dl_master.Name = "b_dl_master";
            this.b_dl_master.Size = new System.Drawing.Size(204, 23);
            this.b_dl_master.TabIndex = 13;
            this.b_dl_master.Text = "Download latest master";
            this.b_dl_master.UseVisualStyleBackColor = true;
            this.b_dl_master.Click += new System.EventHandler(this.b_dl_master_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar1.Location = new System.Drawing.Point(86, 258);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(692, 23);
            this.progressBar1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(12, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Progress:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.help);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.save_file);
            this.groupBox1.Controls.Add(this.bootinipath);
            this.groupBox1.Controls.Add(this.userinstallation);
            this.groupBox1.Controls.Add(this.bootstrap_text);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(426, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 246);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit bootdtrap.ini";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(102, 215);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 25);
            this.button5.TabIndex = 24;
            this.button5.Text = "Manager";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // help
            // 
            this.help.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help.ForeColor = System.Drawing.SystemColors.ControlText;
            this.help.Location = new System.Drawing.Point(6, 215);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(90, 25);
            this.help.TabIndex = 23;
            this.help.Text = "Help";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(212, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 25);
            this.button1.TabIndex = 22;
            this.button1.Text = "About / Change language";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.show_about);
            // 
            // path_to_file_ondisk
            // 
            this.path_to_file_ondisk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.path_to_file_ondisk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.path_to_file_ondisk.Location = new System.Drawing.Point(13, 229);
            this.path_to_file_ondisk.Name = "path_to_file_ondisk";
            this.path_to_file_ondisk.ReadOnly = true;
            this.path_to_file_ondisk.Size = new System.Drawing.Size(206, 20);
            this.path_to_file_ondisk.TabIndex = 17;
            this.path_to_file_ondisk.TextChanged += new System.EventHandler(this.path_to_file_ondisk_TextChanged);
            // 
            // percent
            // 
            this.percent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.percent.AutoSize = true;
            this.percent.BackColor = System.Drawing.Color.Transparent;
            this.percent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.percent.Location = new System.Drawing.Point(784, 268);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(24, 13);
            this.percent.TabIndex = 18;
            this.percent.Text = "0 %";
            this.percent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // b_dl_lb
            // 
            this.b_dl_lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_dl_lb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_dl_lb.Location = new System.Drawing.Point(15, 287);
            this.b_dl_lb.Name = "b_dl_lb";
            this.b_dl_lb.Size = new System.Drawing.Size(206, 23);
            this.b_dl_lb.TabIndex = 19;
            this.b_dl_lb.Tag = "";
            this.b_dl_lb.Text = "Download latest branch";
            this.b_dl_lb.UseVisualStyleBackColor = true;
            this.b_dl_lb.Click += new System.EventHandler(this.b_dl_lb_Click);
            // 
            // b_dl_ob
            // 
            this.b_dl_ob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_dl_ob.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_dl_ob.Location = new System.Drawing.Point(629, 287);
            this.b_dl_ob.Name = "b_dl_ob";
            this.b_dl_ob.Size = new System.Drawing.Size(195, 23);
            this.b_dl_ob.TabIndex = 20;
            this.b_dl_ob.Text = "Download older branch";
            this.b_dl_ob.UseVisualStyleBackColor = true;
            this.b_dl_ob.Click += new System.EventHandler(this.b_dl_ob_Click);
            // 
            // b_dl_testing
            // 
            this.b_dl_testing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.b_dl_testing.ForeColor = System.Drawing.SystemColors.ControlText;
            this.b_dl_testing.Location = new System.Drawing.Point(435, 287);
            this.b_dl_testing.Name = "b_dl_testing";
            this.b_dl_testing.Size = new System.Drawing.Size(188, 23);
            this.b_dl_testing.TabIndex = 21;
            this.b_dl_testing.Text = "Download latest testing build";
            this.b_dl_testing.UseVisualStyleBackColor = true;
            this.b_dl_testing.Click += new System.EventHandler(this.b_dl_testing_Click);
            // 
            // cb_subfolder
            // 
            this.cb_subfolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_subfolder.AutoSize = true;
            this.cb_subfolder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cb_subfolder.Location = new System.Drawing.Point(13, 180);
            this.cb_subfolder.Name = "cb_subfolder";
            this.cb_subfolder.Size = new System.Drawing.Size(348, 17);
            this.cb_subfolder.TabIndex = 22;
            this.cb_subfolder.Text = "Should a subfolder be created automatically? Name of the subfolder:";
            this.cb_subfolder.UseVisualStyleBackColor = true;
            this.cb_subfolder.CheckedChanged += new System.EventHandler(this.savesettings);
            // 
            // subfolder
            // 
            this.subfolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.subfolder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.subfolder.Location = new System.Drawing.Point(12, 203);
            this.subfolder.Name = "subfolder";
            this.subfolder.Size = new System.Drawing.Size(407, 20);
            this.subfolder.TabIndex = 23;
            this.subfolder.TextChanged += new System.EventHandler(this.savesettings);
            // 
            // give_message
            // 
            this.give_message.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.give_message.Icon = ((System.Drawing.Icon)(resources.GetObject("give_message.Icon")));
            this.give_message.Text = "Libreoffice Server Installation GUI";
            this.give_message.Visible = true;
            // 
            // dl_hp_1
            // 
            this.dl_hp_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dl_hp_1.Location = new System.Drawing.Point(15, 317);
            this.dl_hp_1.Name = "dl_hp_1";
            this.dl_hp_1.Size = new System.Drawing.Size(204, 23);
            this.dl_hp_1.TabIndex = 24;
            this.dl_hp_1.Text = "Download helppack";
            this.dl_hp_1.UseVisualStyleBackColor = true;
            this.dl_hp_1.Click += new System.EventHandler(this.dl_hp_1_Click);
            // 
            // dl_hp_2
            // 
            this.dl_hp_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dl_hp_2.Location = new System.Drawing.Point(436, 317);
            this.dl_hp_2.Name = "dl_hp_2";
            this.dl_hp_2.Size = new System.Drawing.Size(187, 23);
            this.dl_hp_2.TabIndex = 25;
            this.dl_hp_2.Text = "Download helppack";
            this.dl_hp_2.UseVisualStyleBackColor = true;
            this.dl_hp_2.Click += new System.EventHandler(this.dl_hp_2_Click);
            // 
            // dl_hp_3
            // 
            this.dl_hp_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dl_hp_3.Location = new System.Drawing.Point(630, 317);
            this.dl_hp_3.Name = "dl_hp_3";
            this.dl_hp_3.Size = new System.Drawing.Size(194, 23);
            this.dl_hp_3.TabIndex = 26;
            this.dl_hp_3.Text = "Download helppack";
            this.dl_hp_3.UseVisualStyleBackColor = true;
            this.dl_hp_3.Click += new System.EventHandler(this.dl_hp_3_Click);
            // 
            // hp_lang_select
            // 
            this.hp_lang_select.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hp_lang_select.FormattingEnabled = true;
            this.hp_lang_select.Items.AddRange(new object[] {
            "ast",
            "bg",
            "bn-IN",
            "bn",
            "bo",
            "bs",
            "ca-XV",
            "ca",
            "cs",
            "da",
            "de",
            "dz ",
            "el",
            "en-GB ",
            "en-US ",
            "en-ZA",
            "eo",
            "es",
            "et ",
            "eu",
            "fi",
            "fr",
            "gl",
            "gu",
            "he",
            "hi",
            "hr",
            "hu",
            "id",
            "is",
            "it",
            "ja",
            "ka",
            "km",
            "ko",
            "lb",
            "nb",
            "ne",
            "nl",
            "nn",
            "om",
            "pl",
            "pt-BR",
            "pt",
            "ru",
            "si",
            "si",
            "sk ",
            "sl",
            "sq",
            "sv",
            "tg",
            "tr",
            "ug",
            "uk",
            "vi",
            "zh-CN",
            "zh-TW"});
            this.hp_lang_select.Location = new System.Drawing.Point(225, 319);
            this.hp_lang_select.Name = "hp_lang_select";
            this.hp_lang_select.Size = new System.Drawing.Size(204, 21);
            this.hp_lang_select.TabIndex = 27;
            this.hp_lang_select.SelectedIndexChanged += new System.EventHandler(this.savesettings);
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar2.Location = new System.Drawing.Point(86, 346);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(692, 23);
            this.progressBar2.TabIndex = 28;
            // 
            // percent2
            // 
            this.percent2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.percent2.AutoSize = true;
            this.percent2.BackColor = System.Drawing.Color.Transparent;
            this.percent2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.percent2.Location = new System.Drawing.Point(784, 356);
            this.percent2.Name = "percent2";
            this.percent2.Size = new System.Drawing.Size(24, 13);
            this.percent2.TabIndex = 30;
            this.percent2.Text = "0 %";
            this.percent2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Progress:";
            // 
            // path_to_file_on_disk_2
            // 
            this.path_to_file_on_disk_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.path_to_file_on_disk_2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.path_to_file_on_disk_2.Location = new System.Drawing.Point(225, 229);
            this.path_to_file_on_disk_2.Name = "path_to_file_on_disk_2";
            this.path_to_file_on_disk_2.ReadOnly = true;
            this.path_to_file_on_disk_2.Size = new System.Drawing.Size(195, 20);
            this.path_to_file_on_disk_2.TabIndex = 31;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(12, 384);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(177, 13);
            this.version.TabIndex = 32;
            this.version.Text = "LibreOffice Server Install GUI v x.x.x";
            // 
            // path_to_exe
            // 
            this.path_to_exe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.path_to_exe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.path_to_exe.Location = new System.Drawing.Point(225, 381);
            this.path_to_exe.Name = "path_to_exe";
            this.path_to_exe.ReadOnly = true;
            this.path_to_exe.Size = new System.Drawing.Size(176, 20);
            this.path_to_exe.TabIndex = 33;
            this.path_to_exe.TextChanged += new System.EventHandler(this.savesettings);
            // 
            // tb_version
            // 
            this.tb_version.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_version.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_version.Location = new System.Drawing.Point(459, 381);
            this.tb_version.Name = "tb_version";
            this.tb_version.Size = new System.Drawing.Size(200, 20);
            this.tb_version.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Version:";
            // 
            // create_lnk
            // 
            this.create_lnk.Location = new System.Drawing.Point(665, 375);
            this.create_lnk.Name = "create_lnk";
            this.create_lnk.Size = new System.Drawing.Size(159, 26);
            this.create_lnk.TabIndex = 36;
            this.create_lnk.Text = "Create shortcut";
            this.create_lnk.UseVisualStyleBackColor = true;
            this.create_lnk.Click += new System.EventHandler(this.create_ink_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 406);
            this.Controls.Add(this.create_lnk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_version);
            this.Controls.Add(this.path_to_exe);
            this.Controls.Add(this.version);
            this.Controls.Add(this.path_to_file_on_disk_2);
            this.Controls.Add(this.percent2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.hp_lang_select);
            this.Controls.Add(this.dl_hp_3);
            this.Controls.Add(this.dl_hp_2);
            this.Controls.Add(this.dl_hp_1);
            this.Controls.Add(this.subfolder);
            this.Controls.Add(this.cb_subfolder);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(852, 444);
            this.MinimumSize = new System.Drawing.Size(852, 360);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "LibreOffice Server Installation GUI";
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
        private System.Windows.Forms.CheckBox cb_subfolder;
        private System.Windows.Forms.TextBox subfolder;
        private System.Windows.Forms.Button help;
        private System.Windows.Forms.NotifyIcon give_message;
        private System.Windows.Forms.Button dl_hp_1;
        private System.Windows.Forms.Button dl_hp_2;
        private System.Windows.Forms.Button dl_hp_3;
        private System.Windows.Forms.ComboBox hp_lang_select;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label percent2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox path_to_file_on_disk_2;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.TextBox path_to_exe;
        private System.Windows.Forms.TextBox tb_version;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button create_lnk;
    }
}

