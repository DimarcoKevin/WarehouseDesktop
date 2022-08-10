﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.Variables;
using WarehouseDesktop.Templates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WarehouseDesktop {
    public partial class Home : Form {
        SqlConnection con = new SqlConnection(GlobalVariables.connectionString);

        String user = GlobalVariables.user;
        String role = GlobalVariables.role; 

        public Home() {
            InitializeComponent();
}
        private void Home_Load(object sender, EventArgs e) {

            SqlDataAdapter SqlAdapter = new SqlDataAdapter("select * from dbo.modules", con);
            DataTable dt = new DataTable();

            SqlAdapter.Fill(dt);

            for(int i = 0; i < dt.Rows.Count; i++) {
                string? name = dt.Rows[i]["module_name"].ToString();
                string? image = dt.Rows[i]["module_image"].ToString();

                TemplateModule module = new TemplateModule(name, image);
                module.Top = 200 * (i+1);
                module.Left = 200 * (i+1);
                this.Controls.Add(module);  
            }

            // Making page full screen 
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;

            // making panel divider full height
            dock_panel_divider.Height = this.Height;

            // setting welcome message
            l_welcome.Text = "Welcome " + user + "!";
        }

        private void Home_Closing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Application.ExitThread();
            } else {
                e.Cancel = true; 
            }
        }

        private void Items_Open(object sender, EventArgs e) {
            MessageBox.Show("Items module opened!");
        }

        private void Pallets_Open(object sender, EventArgs e) {
            MessageBox.Show("Pallets module opened!");
        }

        
    }
}
