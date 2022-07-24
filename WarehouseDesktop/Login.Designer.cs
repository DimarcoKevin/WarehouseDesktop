namespace WarehouseDesktop {
    partial class Login {
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
            this.l_username = new System.Windows.Forms.Label();
            this.l_password = new System.Windows.Forms.Label();
            this.t_username = new System.Windows.Forms.TextBox();
            this.t_password = new System.Windows.Forms.TextBox();
            this.b_login = new System.Windows.Forms.Button();
            this.l_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_username
            // 
            this.l_username.AutoSize = true;
            this.l_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_username.Location = new System.Drawing.Point(26, 31);
            this.l_username.Name = "l_username";
            this.l_username.Size = new System.Drawing.Size(81, 21);
            this.l_username.TabIndex = 0;
            this.l_username.Tag = "";
            this.l_username.Text = "Username";
            // 
            // l_password
            // 
            this.l_password.AutoSize = true;
            this.l_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_password.Location = new System.Drawing.Point(26, 77);
            this.l_password.Name = "l_password";
            this.l_password.Size = new System.Drawing.Size(76, 21);
            this.l_password.TabIndex = 1;
            this.l_password.Tag = "";
            this.l_password.Text = "Password";
            // 
            // t_username
            // 
            this.t_username.Location = new System.Drawing.Point(113, 33);
            this.t_username.Name = "t_username";
            this.t_username.Size = new System.Drawing.Size(129, 23);
            this.t_username.TabIndex = 2;
            // 
            // t_password
            // 
            this.t_password.Location = new System.Drawing.Point(113, 75);
            this.t_password.Name = "t_password";
            this.t_password.PasswordChar = '*';
            this.t_password.Size = new System.Drawing.Size(129, 23);
            this.t_password.TabIndex = 3;
            // 
            // b_login
            // 
            this.b_login.Location = new System.Drawing.Point(92, 120);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(97, 34);
            this.b_login.TabIndex = 4;
            this.b_login.Text = "Login";
            this.b_login.UseVisualStyleBackColor = true;
            this.b_login.Click += new System.EventHandler(this.login_button_Click);
            // 
            // l_error
            // 
            this.l_error.Location = new System.Drawing.Point(26, 179);
            this.l_error.Name = "l_error";
            this.l_error.Size = new System.Drawing.Size(216, 34);
            this.l_error.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 221);
            this.Controls.Add(this.l_error);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.t_password);
            this.Controls.Add(this.t_username);
            this.Controls.Add(this.l_password);
            this.Controls.Add(this.l_username);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label l_username;
        private Label l_password;
        private TextBox t_username;
        private TextBox t_password;
        private Button b_login;
        private Label l_error;
    }
}