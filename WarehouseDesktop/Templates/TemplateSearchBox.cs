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
                types[i] = dataGrid.Columns[i].ValueType;
            }

            return types;
        }


        // dynamically search through datagrid where any row matches text
        private void search(object sender, EventArgs e) {
            Type[] types = getColumnTypes();
            string[] columns = getColumnNames();
            string format = "";
            string searchText = SearchBox.Text;
            Boolean isString = false;

            // validation for letters
            for (int i = 0; i < searchText.Length; i++) {
                if (Char.IsLetter(searchText[i])) isString = true;
            }

            // TODO: could later account for date fields
            // looping over columns to see their types
            for (int i = 0; i < columns.Length; i++) {
            
                // different column types
                if (types[i].ToString().Contains("String")) {

                    if (format.Length > 0) format += " OR ";
                    format += string.Format("[{0}] like '%{1}%'", columns[i], searchText);

                } else if (types[i].ToString().Contains("Decimal") && !isString) {
                     
                    if (format.Length > 0) format += " OR ";
                    format += string.Format("[{0}] = {1}", columns[i], searchText);
                } 
            }

            // resetting format string if nothing searched
            if (searchText.Length == 0) format = "";
 
            // binding the new search query to datagrid
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGrid.DataSource;
            bs.Filter = format;
            dataGrid.DataSource = bs;

            //this works for sorting by column specifics
            //dataGrid.Sort(dataGrid.Columns[2], ListSortDirection.Ascending);
        }

        // checking for enter key to run search function
        private void SearchBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return) search(sender, e);
        }
    }
}
