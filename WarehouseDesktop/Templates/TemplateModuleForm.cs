using System.Data;
using System.Data.SqlClient;
using Warehouse.Variables;

namespace WarehouseDesktop.Templates {
    public partial class TemplateModuleForm : Form {
        SqlConnection con = new SqlConnection(GlobalVariables.connectionString);
        public TemplateModuleForm() {
            // Bug fix! 
            // The templates don't need to init here since each child will init
            // but the build breaks if you remove it...
            InitializeComponent();
        }

        private void TemplateModuleForm_Load(object sender, EventArgs e) {
            // Making page full screen 
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;

            // adding data grid
            TemplateDataGridView data = new TemplateDataGridView(this.GetType().Name);
            this.Controls.Add(data);
            
            // setting object bounds
            data.Left = 0;
            data.Top = 60;
            data.Width = this.Width + 40;
            data.Height = this.Height - 100;

            // setting datawdindow bounds to parent object
            // subtracting space for scroll bars
            data.Controls[0].SetBounds(data.Left, data.Top, data.Width - 60, data.Height - 60); // TODO: fix use of hacky controls

            // adding search box and passing in the datagridview
            TemplateSearchBox searchBox = new TemplateSearchBox((DataGridView)data.Controls[0]); // TODO: fix this hacky casting solution
            this.Controls.Add(searchBox);
            searchBox.Top = 10;
            searchBox.Left = 10;

            try { // TODO: check if this is needed inside try/catch
               string[] columns = searchBox.getColumnNames(); // testing
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);    
            }
        }
    }
}
