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

        public void search(string text) {
            
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

    }
}
