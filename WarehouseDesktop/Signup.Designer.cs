namespace WarehouseDesktop {
    partial class Signup {
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
            this.l_error = new System.Windows.Forms.Label();
            this.b_signup = new System.Windows.Forms.Button();
            this.t_password = new System.Windows.Forms.TextBox();
            this.t_username = new System.Windows.Forms.TextBox();
            this.l_password = new System.Windows.Forms.Label();
            this.l_username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_error
            // 
            this.l_error.Location = new System.Drawing.Point(34, 167);
            this.l_error.Name = "l_error";
            this.l_error.Size = new System.Drawing.Size(216, 34);
            this.l_error.TabIndex = 11;
            // 
            // b_signup
            // 
            this.b_signup.Location = new System.Drawing.Point(100, 108);
            this.b_signup.Name = "b_signup";
            this.b_signup.Size = new System.Drawing.Size(97, 34);
            this.b_signup.TabIndex = 10;
            this.b_signup.Text = "Signup";
            this.b_signup.UseVisualStyleBackColor = true;
            this.b_signup.Click += new System.EventHandler(this.b_signup_Click);
            // 
            // t_password
            // 
            this.t_password.Location = new System.Drawing.Point(121, 63);
            this.t_password.Name = "t_password";
            this.t_password.PasswordChar = '*';
            this.t_password.Size = new System.Drawing.Size(129, 23);
            this.t_password.TabIndex = 9;
            // 
            // t_username
            // 
            this.t_username.Location = new System.Drawing.Point(121, 21);
            this.t_username.Name = "t_username";
            this.t_username.Size = new System.Drawing.Size(129, 23);
            this.t_username.TabIndex = 8;
            // 
            // l_password
            // 
            this.l_password.AutoSize = true;
            this.l_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_password.Location = new System.Drawing.Point(34, 65);
            this.l_password.Name = "l_password";
            this.l_password.Size = new System.Drawing.Size(76, 21);
            this.l_password.TabIndex = 7;
            this.l_password.Tag = "";
            this.l_password.Text = "Password";
            // 
            // l_username
            // 
            this.l_username.AutoSize = true;
            this.l_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_username.Location = new System.Drawing.Point(34, 19);
            this.l_username.Name = "l_username";
            this.l_username.Size = new System.Drawing.Size(81, 21);
            this.l_username.TabIndex = 6;
            this.l_username.Tag = "";
            this.l_username.Text = "Username";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 221);
            this.Controls.Add(this.l_error);
            this.Controls.Add(this.b_signup);
            this.Controls.Add(this.t_password);
            this.Controls.Add(this.t_username);
            this.Controls.Add(this.l_password);
            this.Controls.Add(this.l_username);
            this.Name = "Signup";
            this.Text = "Signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label l_error;
        private Button b_signup;
        private TextBox t_password;
        private TextBox t_username;
        private Label l_password;
        private Label l_username;
    }
}