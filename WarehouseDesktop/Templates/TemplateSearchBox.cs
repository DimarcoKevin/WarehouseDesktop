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

        // this function will grab the type of all columns
        public Type[] getColumnTypes() {
            int count = dataGrid.Columns.Count;
            Type[] types = new Type[count];

            for (int i = 0; i < count; i++) {
                types[i] = dataGrid.Columns[i].GetType();
            }

            return types;

        }


        // dynamically search through datagrid where any row matches text
        private void search(object sender, EventArgs e) {
            Type[] types = getColumnTypes();
            string[] columns = getColumnNames();
            string format = "";

            for (int i = 0; i < 3; i++) { //columns.Length; i++) {
                if (format.Length > 0) format += " OR ";
                format += string.Format("[{0}] = '{1}'", columns[i], SearchBox.Text);
            }

            MessageBox.Show(format);

            //This works for a single row!
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGrid.DataSource;
            //bs.Filter = format;
            bs.Filter = "[" + columns[1] + "] Like '%" + SearchBox.Text + "%' OR [" + columns[2] + "] Like '%" + SearchBox.Text + "%'";
            //bs.Filter = "[" + columns[2] + "] Like '%" + SearchBox.Text + "%'";
            dataGrid.DataSource = bs;

            MessageBox.Show(bs.Filter);

            //this works for sorting by column specifics
            //dataGrid.Sort(dataGrid.Columns[2], ListSortDirection.Ascending);
        }

        

    }
}
