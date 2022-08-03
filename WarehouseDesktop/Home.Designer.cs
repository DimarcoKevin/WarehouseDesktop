namespace WarehouseDesktop {
    partial class Home {
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
            this.ItemsModule = new System.Windows.Forms.Panel();
            this.pb_items = new System.Windows.Forms.PictureBox();
            this.l_items_title = new System.Windows.Forms.Label();
            this.PalletsModule = new System.Windows.Forms.Panel();
            this.pb_pallets = new System.Windows.Forms.PictureBox();
            this.l_pallets_title = new System.Windows.Forms.Label();
            this.ItemsModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_items)).BeginInit();
            this.PalletsModule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pallets)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemsModule
            // 
            this.ItemsModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ItemsModule.Controls.Add(this.pb_items);
            this.ItemsModule.Controls.Add(this.l_items_title);
            this.ItemsModule.Location = new System.Drawing.Point(261, 12);
            this.ItemsModule.Name = "ItemsModule";
            this.ItemsModule.Size = new System.Drawing.Size(132, 201);
            this.ItemsModule.TabIndex = 1;
            // 
            // pb_items
            // 
            this.pb_items.BackgroundImage = global::WarehouseDesktop.Properties.Resources.Add_item_icon_large;
            this.pb_items.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_items.Location = new System.Drawing.Point(3, 3);
            this.pb_items.Name = "pb_items";
            this.pb_items.Size = new System.Drawing.Size(127, 130);
            this.pb_items.TabIndex = 1;
            this.pb_items.TabStop = false;
            this.pb_items.DoubleClick += new System.EventHandler(this.Items_Open);
            // 
            // l_items_title
            // 
            this.l_items_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_items_title.Location = new System.Drawing.Point(3, 132);
            this.l_items_title.Name = "l_items_title";
            this.l_items_title.Size = new System.Drawing.Size(126, 60);
            this.l_items_title.TabIndex = 0;
            this.l_items_title.Text = "Items";
            this.l_items_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l_items_title.DoubleClick += new System.EventHandler(this.Items_Open);
            // 
            // PalletsModule
            // 
            this.PalletsModule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PalletsModule.Controls.Add(this.pb_pallets);
            this.PalletsModule.Controls.Add(this.l_pallets_title);
            this.PalletsModule.Location = new System.Drawing.Point(426, 12);
            this.PalletsModule.Name = "PalletsModule";
            this.PalletsModule.Size = new System.Drawing.Size(132, 201);
            this.PalletsModule.TabIndex = 2;
            // 
            // pb_pallets
            // 
            this.pb_pallets.BackgroundImage = global::WarehouseDesktop.Properties.Resources.Package_add_icon_large;
            this.pb_pallets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb_pallets.Location = new System.Drawing.Point(3, 3);
            this.pb_pallets.Name = "pb_pallets";
            this.pb_pallets.Size = new System.Drawing.Size(127, 130);
            this.pb_pallets.TabIndex = 1;
            this.pb_pallets.TabStop = false;
            this.pb_pallets.DoubleClick += new System.EventHandler(this.Pallets_Open);
            // 
            // l_pallets_title
            // 
            this.l_pallets_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_pallets_title.Location = new System.Drawing.Point(3, 132);
            this.l_pallets_title.Name = "l_pallets_title";
            this.l_pallets_title.Size = new System.Drawing.Size(126, 60);
            this.l_pallets_title.TabIndex = 0;
            this.l_pallets_title.Text = "Pallets";
            this.l_pallets_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l_pallets_title.DoubleClick += new System.EventHandler(this.Pallets_Open);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 809);
            this.Controls.Add(this.PalletsModule);
            this.Controls.Add(this.ItemsModule);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ItemsModule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_items)).EndInit();
            this.PalletsModule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_pallets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel ItemsModule;
        private PictureBox pb_items;
        private Label l_items_title;
        private Panel PalletsModule;
        private PictureBox pb_pallets;
        private Label l_pallets_title;
    }
}