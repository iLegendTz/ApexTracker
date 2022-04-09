namespace ApexTracker.View
{
    partial class Configuration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.lb_color = new System.Windows.Forms.Label();
            this.colorDialog_viewColor = new System.Windows.Forms.ColorDialog();
            this.panel_colorPicker = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_platform = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.txtb_username = new System.Windows.Forms.TextBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.cb_darkMode = new System.Windows.Forms.CheckBox();
            this.lb_darkMode = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_color
            // 
            this.lb_color.AutoSize = true;
            this.lb_color.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_color.Location = new System.Drawing.Point(12, 125);
            this.lb_color.Name = "lb_color";
            this.lb_color.Size = new System.Drawing.Size(85, 18);
            this.lb_color.TabIndex = 0;
            this.lb_color.Text = "View Color";
            // 
            // panel_colorPicker
            // 
            this.panel_colorPicker.BackColor = System.Drawing.Color.Black;
            this.panel_colorPicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_colorPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel_colorPicker.Location = new System.Drawing.Point(120, 125);
            this.panel_colorPicker.Name = "panel_colorPicker";
            this.panel_colorPicker.Size = new System.Drawing.Size(154, 18);
            this.panel_colorPicker.TabIndex = 1;
            this.panel_colorPicker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_colorPicker_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cb_platform);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.txtb_username);
            this.panel1.Controls.Add(this.lb_username);
            this.panel1.Controls.Add(this.cb_darkMode);
            this.panel1.Controls.Add(this.lb_darkMode);
            this.panel1.Controls.Add(this.panel_colorPicker);
            this.panel1.Controls.Add(this.lb_color);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 450);
            this.panel1.TabIndex = 2;
            // 
            // cb_platform
            // 
            this.cb_platform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_platform.Enabled = false;
            this.cb_platform.FormattingEnabled = true;
            this.cb_platform.Items.AddRange(new object[] {
            "PC",
            "Xbox",
            "PS"});
            this.cb_platform.Location = new System.Drawing.Point(120, 52);
            this.cb_platform.Name = "cb_platform";
            this.cb_platform.Size = new System.Drawing.Size(154, 21);
            this.cb_platform.TabIndex = 7;
            // 
            // btn_search
            // 
            this.btn_search.Enabled = false;
            this.btn_search.Location = new System.Drawing.Point(157, 79);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txtb_username
            // 
            this.txtb_username.Enabled = false;
            this.txtb_username.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_username.Location = new System.Drawing.Point(120, 24);
            this.txtb_username.Name = "txtb_username";
            this.txtb_username.Size = new System.Drawing.Size(154, 22);
            this.txtb_username.TabIndex = 5;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(12, 24);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(80, 18);
            this.lb_username.TabIndex = 4;
            this.lb_username.Text = "Username";
            // 
            // cb_darkMode
            // 
            this.cb_darkMode.AutoSize = true;
            this.cb_darkMode.Location = new System.Drawing.Point(120, 173);
            this.cb_darkMode.Name = "cb_darkMode";
            this.cb_darkMode.Size = new System.Drawing.Size(15, 14);
            this.cb_darkMode.TabIndex = 3;
            this.cb_darkMode.UseVisualStyleBackColor = true;
            this.cb_darkMode.CheckedChanged += new System.EventHandler(this.cb_darkMode_CheckedChanged);
            // 
            // lb_darkMode
            // 
            this.lb_darkMode.AutoSize = true;
            this.lb_darkMode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_darkMode.Location = new System.Drawing.Point(12, 170);
            this.lb_darkMode.Name = "lb_darkMode";
            this.lb_darkMode.Size = new System.Drawing.Size(86, 18);
            this.lb_darkMode.TabIndex = 2;
            this.lb_darkMode.Text = "Dark Mode";
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Configuration";
            this.Text = "Configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Configuration_FormClosing);
            this.Load += new System.EventHandler(this.Configuration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_color;
        private System.Windows.Forms.ColorDialog colorDialog_viewColor;
        private System.Windows.Forms.Panel panel_colorPicker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cb_darkMode;
        private System.Windows.Forms.Label lb_darkMode;
        private System.Windows.Forms.TextBox txtb_username;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cb_platform;
    }
}