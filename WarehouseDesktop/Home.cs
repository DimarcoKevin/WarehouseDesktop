using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

            // Making page full screen 
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;

            // making panel divider full height
            dock_panel_divider.Height = this.Height;

            // setting welcome message
            l_welcome.Text = "Welcome " + user + "!";

            // grabbing all module data
            PopulateModules();

            // grabbing user specific favourite modules
            PopulateFavouriteModules();
        }

        private void Home_Closing(object sender, FormClosingEventArgs e) {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Application.ExitThread();
            } else {
                e.Cancel = true; 
            }
        }

        private void PopulateModules() {
            SqlDataAdapter SqlAdapter = new SqlDataAdapter("select * from modules order by order_no asc", con);
            DataTable dt = new DataTable();

            SqlAdapter.Fill(dt);

            int panel = dock_panel_divider.Right;

            // dynamically adding module objects
            for (int i = 0; i < dt.Rows.Count; i++) {
                string? name = dt.Rows[i]["module_name"].ToString();
                string? image = dt.Rows[i]["module_image"].ToString();

                TemplateModule module = new TemplateModule(name, image);
                this.Controls.Add(module);
                module.Top = 50;
                module.Left = (160 * i) + panel;
            }
        }

        private void PopulateFavouriteModules() {
            SqlDataAdapter SqlAdapter = new SqlDataAdapter("select m.module_name, m.module_image from favourite_modules f " +
                                            "join modules m on f.module = m.module_name where f.username = '" + user + "' order by f.order_no asc", con);
            DataTable dt = new DataTable();

            SqlAdapter.Fill(dt);

            int panel = user_panel_divider.Bottom;

            // dynamically adding module objects
            for (int i = 0; i < dt.Rows.Count; i++) {
                string? name = dt.Rows[i]["module_name"].ToString();
                string? image = dt.Rows[i]["module_image"].ToString();

                TemplateFavourites module = new TemplateFavourites(name, image);
                this.Controls.Add(module);
                module.Left = 10;
                module.Top = (120 * i) + panel + 10;
            }
        }


    }
}
