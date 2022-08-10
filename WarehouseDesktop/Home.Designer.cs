namespace WarehouseDesktop {
    partial class Home {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dock_panel_divider = new System.Windows.Forms.Panel();
            this.user_panel_divider = new System.Windows.Forms.Panel();
            this.l_welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dock_panel_divider
            // 
            this.dock_panel_divider.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dock_panel_divider.Location = new System.Drawing.Point(235, -1);
            this.dock_panel_divider.Name = "dock_panel_divider";
            this.dock_panel_divider.Size = new System.Drawing.Size(10, 817);
            this.dock_panel_divider.TabIndex = 3;
            // 
            // user_panel_divider
            // 
            this.user_panel_divider.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.user_panel_divider.Location = new System.Drawing.Point(0, 55);
            this.user_panel_divider.Name = "user_panel_divider";
            this.user_panel_divider.Size = new System.Drawing.Size(242, 10);
            this.user_panel_divider.TabIndex = 4;
            // 
            // l_welcome
            // 
            this.l_welcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_welcome.Location = new System.Drawing.Point(12, 9);
            this.l_welcome.Name = "l_welcome";
            this.l_welcome.Size = new System.Drawing.Size(217, 43);
            this.l_welcome.TabIndex = 5;
            this.l_welcome.Text = "TEMP";
            this.l_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 809);
            this.Controls.Add(this.l_welcome);
            this.Controls.Add(this.user_panel_divider);
            this.Controls.Add(this.dock_panel_divider);
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_Closing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel dock_panel_divider;
        private Panel user_panel_divider;
        private Label l_welcome;
    }
}