﻿namespace WarehouseDesktop.Templates {
    partial class TemplateModule {
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
            this.Module = new System.Windows.Forms.Panel();
            this.pb = new System.Windows.Forms.PictureBox();
            this.l_title = new System.Windows.Forms.Label();
            this.Module.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // Module
            // 
            this.Module.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Module.Controls.Add(this.pb);
            this.Module.Controls.Add(this.l_title);
            this.Module.Location = new System.Drawing.Point(16, 14);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(132, 201);
            this.Module.TabIndex = 2;
            // 
            // pb
            // 
            this.pb.BackgroundImage = global::WarehouseDesktop.Properties.Resources.Add_item_icon_large;
            this.pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb.Location = new System.Drawing.Point(3, 3);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(127, 130);
            this.pb.TabIndex = 1;
            this.pb.TabStop = false;
            this.pb.DragDrop += new System.Windows.Forms.DragEventHandler(this.ModuleDrop);
            this.pb.DoubleClick += new System.EventHandler(this.ModuleClick);
            this.pb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ModuleDrag);
            // 
            // l_title
            // 
            this.l_title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.l_title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_title.Location = new System.Drawing.Point(3, 132);
            this.l_title.Name = "l_title";
            this.l_title.Size = new System.Drawing.Size(126, 60);
            this.l_title.TabIndex = 0;
            this.l_title.Text = "TEMP";
            this.l_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.l_title.DragDrop += new System.Windows.Forms.DragEventHandler(this.ModuleDrop);
            this.l_title.DoubleClick += new System.EventHandler(this.ModuleClick);
            this.l_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ModuleDrag);
            // 
            // TemplateModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Module);
            this.Name = "TemplateModule";
            this.Size = new System.Drawing.Size(163, 230);
            this.Module.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Module;
        private PictureBox pb;
        private Label l_title;
    }
}
