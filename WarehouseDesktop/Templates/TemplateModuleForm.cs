using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseDesktop.Templates;

namespace WarehouseDesktop.Templates {
    public partial class TemplateModuleForm : Form {
        public TemplateModuleForm() {
            InitializeComponent();
        }

        private void TemplateModuleForm_Load(object sender, EventArgs e) {
                // Making page full screen 
                this.TopMost = true;
                this.WindowState = FormWindowState.Maximized;
            
        }
    }
}
