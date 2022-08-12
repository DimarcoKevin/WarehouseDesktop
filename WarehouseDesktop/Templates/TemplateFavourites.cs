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
    public partial class TemplateFavourites : UserControl {
        private string imagePath { get; set; }
        private string moduleTitle { get; set; }

        public TemplateFavourites() {
            InitializeComponent();
            imagePath = "Not populated";
            moduleTitle = "Not populated";
        }

        public TemplateFavourites(string title, string image) {
            InitializeComponent();
            moduleTitle = title;
            imagePath = image;

            // works for now but its super hacky
            string filePath = "../../../Images/";

            // setting image field and title field of object
            pb.BackgroundImage = Image.FromFile(filePath + imagePath);
            l_title.Text = moduleTitle;
        }

        private void ModuleClick(object sender, EventArgs e) {
            MessageBox.Show("Module " + moduleTitle + " opened!");
        }
    }
}
