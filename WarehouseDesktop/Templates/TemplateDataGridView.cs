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
        public TemplateDataGridView() {
            InitializeComponent();
}
        private void TemplateDataGridView_Load(object sender, EventArgs e) {

            SqlDataAdapter SqlAdapter = new SqlDataAdapter("select * from dbo.items" , con);
            DataTable dt = new DataTable();

            SqlAdapter.Fill(dt);

            Data.DataSource = dt;
            
            Data.Select();

            MessageBox.Show(Data.Rows.Count.ToString());
        }
    }
}
