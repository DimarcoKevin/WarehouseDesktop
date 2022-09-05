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

        private void ModuleClick(object sender, EventArgs e) {

            // grabbing module name based on clicked module title
            try {
                var module = Activator.CreateInstance(Type.GetType("WarehouseDesktop.Modules." + moduleTitle)) as Form;
                module.ShowDialog();
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                return;
            }

        }

        private void ModuleDragDrop(object sender, DragEventArgs e) {

            // setting cursor to cross
            Cursor = Cursors.Cross;

            // checking if the drop is in the favourite section or main section
            Boolean favourite = (e.X < 270);

            MessageBox.Show("Favourite :" + favourite);

            // resetting cursor to default
            Cursor = Cursors.Default;

        }

    }
}
