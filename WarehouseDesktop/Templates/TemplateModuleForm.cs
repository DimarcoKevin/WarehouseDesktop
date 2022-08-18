using System.Data;
using System.Data.SqlClient;
using Warehouse.Variables;

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
        }
    }
}
