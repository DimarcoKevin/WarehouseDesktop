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
    public partial class Login : Form {
        SqlConnection con = new SqlConnection(GlobalVariables.connectionString);
        public Login() {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e) {
            String username = t_username.Text;
            String password = t_password.Text;

            SqlDataAdapter SqlAdapter = new SqlDataAdapter("select * from dbo.users where username = '" + username + "' and password = '" + password + "'", con);
            DataTable dt = new DataTable();

            SqlAdapter.Fill(dt);

            // checking if any rows are found
            if (dt.Rows.Count == 0) {
                l_error.Text = "Error, cannot sign you in...";
                t_username.Text = "";
                t_password.Text = "";
                return;
            }

            // showing home page
            Form home = new Form();
            home.Show();


            // TODO find way to actually close original pages
            // hiding login view
            Hide();

            
        }
    }
}
