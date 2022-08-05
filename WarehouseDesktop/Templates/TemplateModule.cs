namespace WarehouseDesktop.Templates {
    public partial class TemplateModule : UserControl {
        public TemplateModule() {
            InitializeComponent();
            imagePath = "Not populated";
            moduleTitle = "Not populated";
        }

        public TemplateModule(string image, string title) {
            InitializeComponent();           
            imagePath = image;
            moduleTitle = title;
        }

        public string imagePath { get; set; }
        public string moduleTitle { get; set; }

        private void TemplateModule_Load(object sender, EventArgs e) {
            // grabbing folder path
            string filePath = "../Images/";

            // setting image field and title field of object
            pb.BackgroundImage = Image.FromFile(Path.Combine(filePath, imagePath));
            l_title.Text = moduleTitle;
        }
    }
}
