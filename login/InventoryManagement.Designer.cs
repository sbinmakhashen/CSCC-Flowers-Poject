﻿namespace login
{
    partial class InventoryManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_NewItem = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.textBoxStockQty = new System.Windows.Forms.TextBox();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_product = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelClose = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.btn_NewItem);
            this.panel2.Controls.Add(this.lbl_name);
            this.panel2.Controls.Add(this.textBoxStockQty);
            this.panel2.Controls.Add(this.lbl_stock);
            this.panel2.Controls.Add(this.lbl_product);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buttonDisplay);
            this.panel2.Controls.Add(this.buttonInsert);
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2534, 1056);
            this.panel2.TabIndex = 1;
            // 
            // btn_NewItem
            // 
            this.btn_NewItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NewItem.Location = new System.Drawing.Point(15, 936);
            this.btn_NewItem.Margin = new System.Windows.Forms.Padding(6);
            this.btn_NewItem.Name = "btn_NewItem";
            this.btn_NewItem.Size = new System.Drawing.Size(312, 93);
            this.btn_NewItem.TabIndex = 20;
            this.btn_NewItem.Text = "New Item";
            this.btn_NewItem.UseVisualStyleBackColor = true;
            this.btn_NewItem.Click += new System.EventHandler(this.Btn_NewItem_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(329, 185);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(344, 55);
            this.lbl_name.TabIndex = 19;
            this.lbl_name.Text = "Product Name";
            // 
            // textBoxStockQty
            // 
            this.textBoxStockQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStockQty.Location = new System.Drawing.Point(1584, 316);
            this.textBoxStockQty.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxStockQty.Multiline = true;
            this.textBoxStockQty.Name = "textBoxStockQty";
            this.textBoxStockQty.Size = new System.Drawing.Size(312, 58);
            this.textBoxStockQty.TabIndex = 18;
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock.Location = new System.Drawing.Point(1578, 258);
            this.lbl_stock.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(151, 36);
            this.lbl_stock.TabIndex = 16;
            this.lbl_stock.Text = "Stock Qty:";
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product.Location = new System.Drawing.Point(333, 132);
            this.lbl_product.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(207, 36);
            this.lbl_product.TabIndex = 14;
            this.lbl_product.Text = "Product name:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1662, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 54);
            this.label2.TabIndex = 13;
            this.label2.Text = "Previous";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDisplay.Location = new System.Drawing.Point(15, 258);
            this.buttonDisplay.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(312, 93);
            this.buttonDisplay.TabIndex = 12;
            this.buttonDisplay.Text = "Display/Reset";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // buttonInsert
            // 
            this.buttonInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInsert.Location = new System.Drawing.Point(1584, 936);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(6);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(312, 93);
            this.buttonInsert.TabIndex = 11;
            this.buttonInsert.Text = "Update Quantity";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.ButtonInsert_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.MediumBlue;
            this.textBoxSearch.Location = new System.Drawing.Point(339, 15);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(1124, 97);
            this.textBoxSearch.TabIndex = 7;
            this.textBoxSearch.Text = "Search here....";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(339, 258);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1215, 771);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.White;
            this.labelClose.Location = new System.Drawing.Point(1841, 0);
            this.labelClose.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(55, 55);
            this.labelClose.TabIndex = 5;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.PapayaWhip;
            this.pictureBox3.Image = global::login.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(248, 229);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // InventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(2534, 1056);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "InventoryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryManagement Looby";
            this.Load += new System.EventHandler(this.InventoryManagement_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStockQty;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_NewItem;
    }
}