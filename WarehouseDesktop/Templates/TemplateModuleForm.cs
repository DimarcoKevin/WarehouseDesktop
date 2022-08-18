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
using WarehouseDesktop.Templates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WarehouseDesktop.Templates {
    public partial class TemplateModuleForm : Form {
        SqlConnection con = new SqlConnection(GlobalVariables.connectionString);
        public TemplateModuleForm() {
            InitializeComponent();
        }

        private void TemplateModuleForm_Load(object sender, EventArgs e) {
            // Making page full screen 
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;

            SqlDataAdapter SqlAdapter = new SqlDataAdapter("select * from dbo.users ", con);
            DataTable dt = new DataTable();

            SqlAdapter.Fill(dt);

            //TemplateDataGridView.
            //TemplateDataGridView.Select("select * from dbo.users");
        }
    }
}
