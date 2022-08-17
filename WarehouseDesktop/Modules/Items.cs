using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseDesktop.Modules {
    public partial class Items : Form {
        public Items() {
            InitializeComponent();
        }

        private void Items_Load(object sender, EventArgs e) {
            // Making page full screen 
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
