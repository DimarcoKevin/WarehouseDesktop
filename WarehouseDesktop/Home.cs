using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseDesktop {
    public partial class Home : Form {
        public Home() {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e) {
            // code for when homepage loads
        }

        private void Module1_DoubleClick(object sender, EventArgs e) {
            MessageBox.Show("Module 1 opened!");
        }
    }
}
