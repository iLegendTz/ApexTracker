namespace ApexTracker
{
    partial class Card
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_container = new System.Windows.Forms.Panel();
            this.lb_points = new System.Windows.Forms.Label();
            this.pb_rank = new System.Windows.Forms.PictureBox();
            this.lb_username = new System.Windows.Forms.Label();
            this.panel_topBar = new System.Windows.Forms.Panel();
            this.panel_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rank)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_container
            // 
            this.panel_container.BackColor = System.Drawing.SystemColors.Control;
            this.panel_container.Controls.Add(this.lb_points);
            this.panel_container.Controls.Add(this.pb_rank);
            this.panel_container.Controls.Add(this.lb_username);
            this.panel_container.Location = new System.Drawing.Point(0, 18);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(530, 141);
            this.panel_container.TabIndex = 0;
            this.panel_container.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.panel_container.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);
            this.panel_container.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpEvent);
            // 
            // lb_points
            // 
            this.lb_points.AutoSize = true;
            this.lb_points.BackColor = System.Drawing.Color.Transparent;
            this.lb_points.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_points.ForeColor = System.Drawing.Color.Black;
            this.lb_points.Location = new System.Drawing.Point(163, 45);
            this.lb_points.Name = "lb_points";
            this.lb_points.Size = new System.Drawing.Size(88, 32);
            this.lb_points.TabIndex = 2;
            this.lb_points.Text = "0 PTS";
            // 
            // pb_rank
            // 
            this.pb_rank.BackColor = System.Drawing.Color.Transparent;
            this.pb_rank.Location = new System.Drawing.Point(0, 0);
            this.pb_rank.Name = "pb_rank";
            this.pb_rank.Size = new System.Drawing.Size(142, 142);
            this.pb_rank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_rank.TabIndex = 1;
            this.pb_rank.TabStop = false;
            this.pb_rank.WaitOnLoad = true;
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.BackColor = System.Drawing.Color.Transparent;
            this.lb_username.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.ForeColor = System.Drawing.Color.Black;
            this.lb_username.Location = new System.Drawing.Point(157, 13);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(116, 32);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "Wattson";
            this.lb_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_topBar
            // 
            this.panel_topBar.BackColor = System.Drawing.Color.Black;
            this.panel_topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_topBar.Location = new System.Drawing.Point(0, 0);
            this.panel_topBar.Name = "panel_topBar";
            this.panel_topBar.Size = new System.Drawing.Size(530, 18);
            this.panel_topBar.TabIndex = 1;
            this.panel_topBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDownEvent);
            this.panel_topBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMoveEvent);
            this.panel_topBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUpEvent);
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(530, 158);
            this.ControlBox = false;
            this.Controls.Add(this.panel_topBar);
            this.Controls.Add(this.panel_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(310, 158);
            this.Name = "Card";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_container.ResumeLayout(false);
            this.panel_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_rank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Label lb_username;
        internal System.Windows.Forms.PictureBox pb_rank;
        internal System.Windows.Forms.Label lb_points;
        internal System.Windows.Forms.Panel panel_container;
        internal System.Windows.Forms.Panel panel_topBar;
    }
}

