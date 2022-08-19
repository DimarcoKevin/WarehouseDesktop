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

            // adding search box
            TemplateSearchBox searchBox = new TemplateSearchBox();
            this.Controls.Add(searchBox);
            searchBox.Top = 10;
            searchBox.Left = 10;

            // adding data grid
            TemplateDataGridView data = new TemplateDataGridView(this.GetType().Name);
            this.Controls.Add(data);
            data.Top = 80;
            data.Left = 10;
        }
    }
}
