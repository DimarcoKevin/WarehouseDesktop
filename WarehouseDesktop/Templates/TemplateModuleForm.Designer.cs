namespace WarehouseDesktop.Templates {
    partial class TemplateModuleForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.TemplateSearchBox = new WarehouseDesktop.Templates.TemplateSearchBox();
            this.TemplateDataGridView = new WarehouseDesktop.Templates.TemplateDataGridView();
            this.SuspendLayout();
            // 
            // TemplateSearchBox
            // 
            this.TemplateSearchBox.Location = new System.Drawing.Point(12, 12);
            this.TemplateSearchBox.Name = "TemplateSearchBox";
            this.TemplateSearchBox.Size = new System.Drawing.Size(360, 50);
            this.TemplateSearchBox.TabIndex = 0;
            // 
            // TemplateDataGridView
            // 
            this.TemplateDataGridView.Location = new System.Drawing.Point(12, 68);
            this.TemplateDataGridView.Name = "TemplateDataGridView";
            this.TemplateDataGridView.Size = new System.Drawing.Size(685, 446);
            this.TemplateDataGridView.TabIndex = 1;
            this.TemplateDataGridView.Load += new System.EventHandler(this.templateDataGridView1_Load);
            // 
            // TemplateModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 542);
            this.Controls.Add(this.TemplateDataGridView);
            this.Controls.Add(this.TemplateSearchBox);
            this.Name = "TemplateModuleForm";
            this.Text = "TemplateModuleForm";
            this.Load += new System.EventHandler(this.TemplateModuleForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TemplateSearchBox TemplateSearchBox;
        private TemplateDataGridView TemplateDataGridView;
    }
}