﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.Variables;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WarehouseDesktop.Templates {
    public partial class TemplateDataGridView : UserControl {
        SqlConnection con = new SqlConnection(GlobalVariables.connectionString);
        DataTable originalDT = new DataTable();

        string table;
        bool saveNeeded = false;

        public TemplateDataGridView() {
            InitializeComponent();
            table = "";
        }

        public TemplateDataGridView(string tableName) {
            InitializeComponent();
            table = tableName;
        }

        private void TemplateDataGridView_Load(object sender, EventArgs e) {

            // checking for empty table name
            if (table.Equals("")) {
                MessageBox.Show("Table name cannot be empty");
                return;
            }

            // dynamically selecting from table 
            SqlDataAdapter SqlAdapter = new SqlDataAdapter("select * from dbo." + table, con);
            DataTable dt = new DataTable();

            // populating datatable and original datatable
            SqlAdapter.Fill(dt);
            SqlAdapter.Fill(originalDT);

            // checking for empty table
            if (dt.Rows.Count == 0) {
                MessageBox.Show("Table has zero rows");
                return;
            }

            // sharing data
            Data.DataSource = dt;
            Data.Select();
        }

        // this is basically an itemchanged event to update user/time stamps
        private void updateStampValues(object sender, DataGridViewCellEventArgs e) {


            // getting name of column being updated
            DataGridView dgv = (DataGridView)sender;
            string columnName = dgv.Columns[e.ColumnIndex].Name;

            // validation to prevent infinte loops
            if (columnName.Equals("user_stamp") || columnName.Equals("time_stamp")) { return; }

            // this will prevent updating of IDs
            if (columnName.Equals("id")) {
                var underlyingDataRow = ((DataRowView)this.Data.Rows[e.RowIndex].DataBoundItem).Row;
                underlyingDataRow.RejectChanges();
                MessageBox.Show("Cannot manually update IDs");
                return;
            }

            // this will be used later when adding save functionality
            saveNeeded = true;

            // updating time_stamp and user_stamp
            if (this.Data.Columns.Contains("user_stamp") && this.Data.Columns.Contains("time_stamp")) {
                this.Data.Rows[e.RowIndex].Cells["user_stamp"].Value = GlobalVariables.user;
                this.Data.Rows[e.RowIndex].Cells["time_stamp"].Value = DateTime.Now;
            }
        }

        // TODO: this is currently called on column double click
        // TODO: will have to implement a way to save in module
        // TODO: look into adding menus too
        // testing update of this datagridview
        private void update(object sender, DataGridViewCellEventArgs e) {
            con.Open();

            try {

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                con.Close();
            }
        }
    }
}
