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
            imagePath = "Not populated";
            moduleTitle = "Not populated";

        }

        public TemplateModule(string image, string title) {
            InitializeComponent();

            string filePath = "../Images/";
            imagePath = image;
            moduleTitle = title;
            pb.BackgroundImage = Image.FromFile(Path.Combine(filePath, imagePath));
            l_title.Text = moduleTitle;

        }

        public string imagePath { get; set; }
        public string moduleTitle { get; set; }

        private void TemplateModule_Load(object sender, EventArgs e) {

        }
    }
}
