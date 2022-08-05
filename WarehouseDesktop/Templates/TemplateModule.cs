using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseDesktop.Templates {
    public partial class TemplateModule : UserControl {
        public TemplateModule() {
            InitializeComponent();
        }

        public TemplateModule(String imagePath, String title) {
            InitializeComponent();
            String filePath = "../Images/";
            pb.BackgroundImage = Image.FromFile(Path.Combine(filePath, imagePath));
            l_title.Text = title;

        }

        private void TemplateModule_Load(object sender, EventArgs e) {

        }
    }
}
