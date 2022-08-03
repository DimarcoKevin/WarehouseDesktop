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

            // Making page full screen 
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;

            // making panel divider full height
            panel_divider.Height = this.Height;
        }

        private void Items_Open(object sender, EventArgs e) {
            MessageBox.Show("Items module opened!");
        }

        private void Pallets_Open(object sender, EventArgs e) {
            MessageBox.Show("Pallets module opened!");
        }
    }
}
