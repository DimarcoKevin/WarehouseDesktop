using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseDesktop.Templates {
    public partial class TemplateSearchBox : UserControl {

        DataGridView dataGrid;

        public TemplateSearchBox() {
            InitializeComponent();
            dataGrid = new DataGridView();  
        }

        public TemplateSearchBox(DataGridView data) {
            InitializeComponent();
            dataGrid = data;
        }

        // this function will grab the names of all columns and return them in an array
        public string[] getColumnNames() {
            int count = dataGrid.Columns.Count;
            string[] columns = new string[count];   

            for (int i = 0; i < count; i++) {
                columns[i] = dataGrid.Columns[i].Name;  
            }

            return columns;
        }

        // dynamically search through datagrid where any row matches text
        private void search(object sender, EventArgs e) {
            string[] columns = getColumnNames();
            string format = "";

            for (int i = 0; i < columns.Length; i++) {
                if (format.Length > 0) format += " OR ";
                format += string.Format("[{0}] = '{1}'", columns[i], SearchBox.Text);
            }

            MessageBox.Show(format);

            (dataGrid.DataSource as DataTable).DefaultView.RowFilter = format;
        }

        

    }
}
