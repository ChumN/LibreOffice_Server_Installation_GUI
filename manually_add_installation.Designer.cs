namespace WindowsFormsApplication1
{
    partial class manually_add_installation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        #region Licence
        /*This file is part of the project "Reisisoft Server Install GUI",
        * which is licenced under LGPL v3+. You may find a copy in the source,
        * or obtain one at http://www.gnu.org/licenses/lgpl-3.0-standalone.html */
        #endregion
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manually_add_installation));
            this.okay = new System.Windows.Forms.Button();
            this.abort = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.configure = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // okay
            // 
            this.okay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.okay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okay.Location = new System.Drawing.Point(41, 80);
            this.okay.Name = "okay";
            this.okay.Size = new System.Drawing.Size(143, 37);
            this.okay.TabIndex = 0;
            this.okay.Text = "Okay";
            this.okay.UseVisualStyleBackColor = true;
            this.okay.Click += new System.EventHandler(this.okay_Click);
            // 
            // abort
            // 
            this.abort.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.abort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abort.Location = new System.Drawing.Point(190, 80);
            this.abort.Name = "abort";
            this.abort.Size = new System.Drawing.Size(132, 37);
            this.abort.TabIndex = 1;
            this.abort.Text = "Abort";
            this.abort.UseVisualStyleBackColor = true;
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(15, 26);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(333, 20);
            this.path.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Path to the soffice.exe of the parallel installation";
            // 
            // configure
            // 
            this.configure.Location = new System.Drawing.Point(12, 52);
            this.configure.Name = "configure";
            this.configure.Size = new System.Drawing.Size(336, 23);
            this.configure.TabIndex = 6;
            this.configure.Text = "Configure path";
            this.configure.UseVisualStyleBackColor = true;
            this.configure.Click += new System.EventHandler(this.configure_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "soffice.exe";
            // 
            // manually_add_installation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 129);
            this.Controls.Add(this.configure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.path);
            this.Controls.Add(this.abort);
            this.Controls.Add(this.okay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(376, 167);
            this.MinimumSize = new System.Drawing.Size(376, 167);
            this.Name = "manually_add_installation";
            this.Text = "Manually add parallel installation";
            this.Load += new System.EventHandler(this.manually_add_installation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okay;
        private System.Windows.Forms.Button abort;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button configure;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}