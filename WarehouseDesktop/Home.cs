using System;
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
        }

        private void Items_Open(object sender, EventArgs e) {
            MessageBox.Show("Items module opened!");
        }

        private void Pallets_Open(object sender, EventArgs e) {
            MessageBox.Show("Pallets module opened!");
        }
    }
}
