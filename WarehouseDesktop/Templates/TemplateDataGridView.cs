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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WarehouseDesktop.Templates {
    public partial class TemplateDataGridView : UserControl {
        SqlConnection con = new SqlConnection(GlobalVariables.connectionString);

        string table;

        public TemplateDataGridView() {
            InitializeComponent();
            table = "";
        }

        public TemplateDataGridView(string tableName) {
            InitializeComponent();
            table = tableName;
        }

        private void TemplateDataGridView_Load(object sender, EventArgs e) {

            // checking for empty table name
            if (table.Equals("")) {
                MessageBox.Show("Table name cannot be empty");
                return;
            }

            // dynamically selecting from table 
            SqlDataAdapter SqlAdapter = new SqlDataAdapter("select * from dbo." + table , con);
            DataTable dt = new DataTable();

            // populating datatable and sharing data
            SqlAdapter.Fill(dt);
            Data.DataSource = dt;

            // checking for empty table
            if (dt.Rows.Count == 0) {
                MessageBox.Show("Table has zero rows");
                return;
            }

            Data.Select();
        }
    }
}
