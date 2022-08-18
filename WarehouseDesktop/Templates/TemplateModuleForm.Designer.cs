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
            this.templateSearchBox1 = new WarehouseDesktop.Templates.TemplateSearchBox();
            this.templateDataGridView1 = new WarehouseDesktop.Templates.TemplateDataGridView();
            this.SuspendLayout();
            // 
            // templateSearchBox1
            // 
            this.templateSearchBox1.Location = new System.Drawing.Point(12, 12);
            this.templateSearchBox1.Name = "templateSearchBox1";
            this.templateSearchBox1.Size = new System.Drawing.Size(360, 50);
            this.templateSearchBox1.TabIndex = 0;
            // 
            // templateDataGridView1
            // 
            this.templateDataGridView1.Location = new System.Drawing.Point(12, 68);
            this.templateDataGridView1.Name = "templateDataGridView1";
            this.templateDataGridView1.Size = new System.Drawing.Size(685, 446);
            this.templateDataGridView1.TabIndex = 1;
            // 
            // TemplateModuleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 542);
            this.Controls.Add(this.templateDataGridView1);
            this.Controls.Add(this.templateSearchBox1);
            this.Name = "TemplateModuleForm";
            this.Text = "TemplateModuleForm";
            this.Load += new System.EventHandler(this.TemplateModuleForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TemplateSearchBox templateSearchBox1;
        private TemplateDataGridView templateDataGridView1;
    }
}