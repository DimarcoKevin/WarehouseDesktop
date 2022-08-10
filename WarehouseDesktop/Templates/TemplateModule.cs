namespace WarehouseDesktop.Templates {
    public partial class TemplateModule : UserControl {

        private string imagePath { get; set; }
        private string moduleTitle { get; set; }

        public TemplateModule() {
            InitializeComponent();
            imagePath = "Not populated";
            moduleTitle = "Not populated";
        }

        public TemplateModule(string title, string image) {
            InitializeComponent();
            moduleTitle = title;
            imagePath = image;

            // works for now but its super hacky
            string filePath = "../../../Images/";

            // setting image field and title field of object
            pb.BackgroundImage = Image.FromFile(filePath + imagePath);
            l_title.Text = moduleTitle;
        }      

        private void TemplateModule_Load(object sender, EventArgs e) {
           
        }
    }
}
