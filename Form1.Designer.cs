
namespace marathon_network
{
    partial class main_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.ip_subnet_txt = new System.Windows.Forms.TextBox();
            this.find_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ip_label = new System.Windows.Forms.Label();
            this.ip_listview = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.ip_address01 = new System.Windows.Forms.ColumnHeader();
            this.status01 = new System.Windows.Forms.ColumnHeader();
            this.marathon_progressbar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.about_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ip_subnet_txt
            // 
            this.ip_subnet_txt.Location = new System.Drawing.Point(93, 12);
            this.ip_subnet_txt.Name = "ip_subnet_txt";
            this.ip_subnet_txt.Size = new System.Drawing.Size(906, 31);
            this.ip_subnet_txt.TabIndex = 0;
            // 
            // find_btn
            // 
            this.find_btn.Location = new System.Drawing.Point(93, 49);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(112, 34);
            this.find_btn.TabIndex = 1;
            this.find_btn.Text = "Search";
            this.find_btn.UseVisualStyleBackColor = true;
            this.find_btn.Click += new System.EventHandler(this.find_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(223, 49);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(112, 34);
            this.clear_btn.TabIndex = 6;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "My IP Address:";
            // 
            // ip_label
            // 
            this.ip_label.AutoSize = true;
            this.ip_label.Location = new System.Drawing.Point(152, 105);
            this.ip_label.Name = "ip_label";
            this.ip_label.Size = new System.Drawing.Size(59, 25);
            this.ip_label.TabIndex = 10;
            this.ip_label.Text = "my_ip";
            // 
            // ip_listview
            // 
            this.ip_listview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ip_listview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.ip_address01,
            this.status01});
            this.ip_listview.HideSelection = false;
            this.ip_listview.Location = new System.Drawing.Point(15, 166);
            this.ip_listview.Name = "ip_listview";
            this.ip_listview.Size = new System.Drawing.Size(986, 573);
            this.ip_listview.TabIndex = 12;
            this.ip_listview.UseCompatibleStateImageBehavior = false;
            this.ip_listview.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "";
            // 
            // ip_address01
            // 
            this.ip_address01.Text = "IP Address";
            this.ip_address01.Width = 200;
            // 
            // status01
            // 
            this.status01.Text = "Status";
            this.status01.Width = 450;
            // 
            // marathon_progressbar
            // 
            this.marathon_progressbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.marathon_progressbar.Location = new System.Drawing.Point(0, 771);
            this.marathon_progressbar.Name = "marathon_progressbar";
            this.marathon_progressbar.Size = new System.Drawing.Size(1012, 34);
            this.marathon_progressbar.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Subnet:";
            // 
            // about_btn
            // 
            this.about_btn.Location = new System.Drawing.Point(888, 49);
            this.about_btn.Name = "about_btn";
            this.about_btn.Size = new System.Drawing.Size(112, 34);
            this.about_btn.TabIndex = 15;
            this.about_btn.Text = "About";
            this.about_btn.UseVisualStyleBackColor = true;
            this.about_btn.Click += new System.EventHandler(this.about_btn_Click);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 805);
            this.Controls.Add(this.about_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.marathon_progressbar);
            this.Controls.Add(this.ip_listview);
            this.Controls.Add(this.ip_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.find_btn);
            this.Controls.Add(this.ip_subnet_txt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main_form";
            this.Text = "Marathon Network";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.main_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ip_subnet_txt;
        private System.Windows.Forms.Button find_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ip_label;
        private System.Windows.Forms.ListView ip_listview;
        private System.Windows.Forms.ColumnHeader ip_address01;
        private System.Windows.Forms.ColumnHeader status01;
        private System.Windows.Forms.ProgressBar marathon_progressbar;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button about_btn;
    }
}

