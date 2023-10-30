namespace WarehouseDesktop.Templates {
    partial class TemplateDataGridView {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            Data = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Data).BeginInit();
            SuspendLayout();
            // 
            // Data
            // 
            Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Data.Location = new Point(0, 0);
            Data.Name = "Data";
            Data.RowTemplate.Height = 25;
            Data.Size = new Size(674, 458);
            Data.TabIndex = 0;
            Data.CellValueChanged += updateStampValues;
            // 
            // TemplateDataGridView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Data);
            Name = "TemplateDataGridView";
            Size = new Size(700, 500);
            Load += TemplateDataGridView_Load;
            ((System.ComponentModel.ISupportInitialize)Data).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Data;
    }
}
