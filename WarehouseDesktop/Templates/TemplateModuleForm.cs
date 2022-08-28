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

            // adding data grid
            TemplateDataGridView data = new TemplateDataGridView(this.GetType().Name);
            this.Controls.Add(data);
            
            // setting object bounds
            data.Left = 0;
            data.Top = 40;
            data.Width = this.Width;
            data.Height = this.Height;  

            // setting datawdindow bounds to parent object
            // subtracting space for scroll bars
            data.Controls[0].SetBounds(data.Left, data.Top, data.Width - 15, data.Height - 15);

            // adding search box and passing in the datagridview
            TemplateSearchBox searchBox = new TemplateSearchBox((DataGridView)data.Controls[0]);
            this.Controls.Add(searchBox);
            searchBox.Top = 10;
            searchBox.Left = 10;

            try {
                searchBox.getColumnNames(); // testing
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);    
            }
        }
    }
}
