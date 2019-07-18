namespace login
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btn_IncreaseQty = new System.Windows.Forms.Button();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.lbl_product = new System.Windows.Forms.Label();
            this.textBoxStockQty = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_ChangeQty = new System.Windows.Forms.TextBox();
            this.lbl_loginInfo = new System.Windows.Forms.Label();
            this.lbl_storeTitle = new System.Windows.Forms.Label();
            this.lbl_StoreName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Store_DropDown = new System.Windows.Forms.ComboBox();
            this.btn_Send2Store = new System.Windows.Forms.Button();
            this.Previous_pic = new System.Windows.Forms.PictureBox();
            this.Close_pic = new System.Windows.Forms.PictureBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.lbl_ChangeQty = new System.Windows.Forms.Label();
            this.lbl_titlePage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Previous_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.PapayaWhip;
            this.pictureBox3.Image = global::login.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(322, 186);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(460, 442);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(2128, 1050);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.MediumBlue;
            this.textBoxSearch.Location = new System.Drawing.Point(462, 331);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(1436, 97);
            this.textBoxSearch.TabIndex = 10;
            this.textBoxSearch.Text = "Search here....";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // btn_IncreaseQty
            // 
            this.btn_IncreaseQty.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_IncreaseQty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_IncreaseQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IncreaseQty.Location = new System.Drawing.Point(2622, 1378);
            this.btn_IncreaseQty.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_IncreaseQty.Name = "btn_IncreaseQty";
            this.btn_IncreaseQty.Size = new System.Drawing.Size(490, 140);
            this.btn_IncreaseQty.TabIndex = 50;
            this.btn_IncreaseQty.Text = "Adjust Quantity";
            this.btn_IncreaseQty.UseVisualStyleBackColor = false;
            this.btn_IncreaseQty.Click += new System.EventHandler(this.btn_IncreseQty);
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.BackColor = System.Drawing.Color.Brown;
            this.buttonDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDisplay.Location = new System.Drawing.Point(20, 699);
            this.buttonDisplay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(424, 140);
            this.buttonDisplay.TabIndex = 70;
            this.buttonDisplay.Text = "View Store";
            this.buttonDisplay.UseVisualStyleBackColor = false;
            this.buttonDisplay.Click += new System.EventHandler(this.buttonDisplay_Click);
            // 
            // lbl_product
            // 
            this.lbl_product.AutoSize = true;
            this.lbl_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_product.ForeColor = System.Drawing.Color.Chartreuse;
            this.lbl_product.Location = new System.Drawing.Point(1950, 326);
            this.lbl_product.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(260, 42);
            this.lbl_product.TabIndex = 14;
            this.lbl_product.Text = "Product name:";
            // 
            // textBoxStockQty
            // 
            this.textBoxStockQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStockQty.ForeColor = System.Drawing.Color.Purple;
            this.textBoxStockQty.Location = new System.Drawing.Point(2622, 467);
            this.textBoxStockQty.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxStockQty.Multiline = true;
            this.textBoxStockQty.Name = "textBoxStockQty";
            this.textBoxStockQty.Size = new System.Drawing.Size(490, 89);
            this.textBoxStockQty.TabIndex = 30;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.Chartreuse;
            this.lbl_name.Location = new System.Drawing.Point(1950, 370);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(393, 63);
            this.lbl_name.TabIndex = 19;
            this.lbl_name.Text = "Product Name";
            // 
            // txt_ChangeQty
            // 
            this.txt_ChangeQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ChangeQty.ForeColor = System.Drawing.Color.Purple;
            this.txt_ChangeQty.Location = new System.Drawing.Point(2622, 942);
            this.txt_ChangeQty.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_ChangeQty.Multiline = true;
            this.txt_ChangeQty.Name = "txt_ChangeQty";
            this.txt_ChangeQty.Size = new System.Drawing.Size(490, 89);
            this.txt_ChangeQty.TabIndex = 40;
            // 
            // lbl_loginInfo
            // 
            this.lbl_loginInfo.AutoSize = true;
            this.lbl_loginInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loginInfo.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_loginInfo.Location = new System.Drawing.Point(324, 186);
            this.lbl_loginInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_loginInfo.Name = "lbl_loginInfo";
            this.lbl_loginInfo.Size = new System.Drawing.Size(325, 46);
            this.lbl_loginInfo.TabIndex = 23;
            this.lbl_loginInfo.Text = "Hello {username}";
            // 
            // lbl_storeTitle
            // 
            this.lbl_storeTitle.AutoSize = true;
            this.lbl_storeTitle.BackColor = System.Drawing.Color.CadetBlue;
            this.lbl_storeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_storeTitle.ForeColor = System.Drawing.Color.Purple;
            this.lbl_storeTitle.Location = new System.Drawing.Point(20, 376);
            this.lbl_storeTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_storeTitle.Name = "lbl_storeTitle";
            this.lbl_storeTitle.Size = new System.Drawing.Size(258, 42);
            this.lbl_storeTitle.TabIndex = 24;
            this.lbl_storeTitle.Text = "Viewing Store:";
            // 
            // lbl_StoreName
            // 
            this.lbl_StoreName.AutoSize = true;
            this.lbl_StoreName.BackColor = System.Drawing.Color.CadetBlue;
            this.lbl_StoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StoreName.ForeColor = System.Drawing.Color.Purple;
            this.lbl_StoreName.Location = new System.Drawing.Point(20, 450);
            this.lbl_StoreName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_StoreName.Name = "lbl_StoreName";
            this.lbl_StoreName.Size = new System.Drawing.Size(295, 69);
            this.lbl_StoreName.TabIndex = 25;
            this.lbl_StoreName.Text = "4000-Indy";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.Store_DropDown);
            this.panel2.Controls.Add(this.btn_Send2Store);
            this.panel2.Controls.Add(this.Previous_pic);
            this.panel2.Controls.Add(this.Close_pic);
            this.panel2.Controls.Add(this.lbl_date);
            this.panel2.Controls.Add(this.lbl_stock);
            this.panel2.Controls.Add(this.lbl_ChangeQty);
            this.panel2.Controls.Add(this.lbl_StoreName);
            this.panel2.Controls.Add(this.lbl_storeTitle);
            this.panel2.Controls.Add(this.lbl_loginInfo);
            this.panel2.Controls.Add(this.txt_ChangeQty);
            this.panel2.Controls.Add(this.lbl_name);
            this.panel2.Controls.Add(this.textBoxStockQty);
            this.panel2.Controls.Add(this.lbl_product);
            this.panel2.Controls.Add(this.buttonDisplay);
            this.panel2.Controls.Add(this.btn_IncreaseQty);
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.lbl_titlePage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3144, 1540);
            this.panel2.TabIndex = 1;
            // 
            // Store_DropDown
            // 
            this.Store_DropDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Store_DropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Store_DropDown.ForeColor = System.Drawing.Color.SeaGreen;
            this.Store_DropDown.FormattingEnabled = true;
            this.Store_DropDown.Items.AddRange(new object[] {
            "1000-Col",
            "1001-Col",
            "2000-Pitt",
            "2001-Pitt",
            "3000-Det",
            "3001-Det",
            "4000-Indy",
            "4001-Indy"});
            this.Store_DropDown.Location = new System.Drawing.Point(20, 1000);
            this.Store_DropDown.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Store_DropDown.Name = "Store_DropDown";
            this.Store_DropDown.Size = new System.Drawing.Size(424, 61);
            this.Store_DropDown.TabIndex = 60;
            this.Store_DropDown.Text = "Select a store";
            this.Store_DropDown.Enter += new System.EventHandler(this.Store_DropDown_Enter);
            this.Store_DropDown.Leave += new System.EventHandler(this.Store_DropDown_Leave);
            // 
            // btn_Send2Store
            // 
            this.btn_Send2Store.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Send2Store.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Send2Store.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send2Store.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btn_Send2Store.Location = new System.Drawing.Point(2626, 1190);
            this.btn_Send2Store.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Send2Store.Name = "btn_Send2Store";
            this.btn_Send2Store.Size = new System.Drawing.Size(490, 140);
            this.btn_Send2Store.TabIndex = 80;
            this.btn_Send2Store.Text = "Send to Store";
            this.btn_Send2Store.UseVisualStyleBackColor = false;
            this.btn_Send2Store.Click += new System.EventHandler(this.btn_Send2Store_Click);
            // 
            // Previous_pic
            // 
            this.Previous_pic.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Previous_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Previous_pic.Image = global::login.Properties.Resources.previous_blue;
            this.Previous_pic.Location = new System.Drawing.Point(2942, 0);
            this.Previous_pic.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Previous_pic.Name = "Previous_pic";
            this.Previous_pic.Size = new System.Drawing.Size(80, 78);
            this.Previous_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Previous_pic.TabIndex = 51;
            this.Previous_pic.TabStop = false;
            this.Previous_pic.Click += new System.EventHandler(this.Previous_pic_Click_1);
            // 
            // Close_pic
            // 
            this.Close_pic.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Close_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_pic.Image = global::login.Properties.Resources.close;
            this.Close_pic.Location = new System.Drawing.Point(3066, 0);
            this.Close_pic.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Close_pic.Name = "Close_pic";
            this.Close_pic.Size = new System.Drawing.Size(78, 78);
            this.Close_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close_pic.TabIndex = 50;
            this.Close_pic.TabStop = false;
            this.Close_pic.Click += new System.EventHandler(this.Close_pic_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(2462, 145);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(275, 42);
            this.lbl_date.TabIndex = 29;
            this.lbl_date.Text = "Today\'s Date is";
            // 
            // lbl_stock
            // 
            this.lbl_stock.AutoSize = true;
            this.lbl_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stock.ForeColor = System.Drawing.Color.White;
            this.lbl_stock.Location = new System.Drawing.Point(2616, 901);
            this.lbl_stock.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(579, 36);
            this.lbl_stock.TabIndex = 28;
            this.lbl_stock.Text = "Adjust by Quantity or Send to Listed Store:";
            // 
            // lbl_ChangeQty
            // 
            this.lbl_ChangeQty.AutoSize = true;
            this.lbl_ChangeQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ChangeQty.ForeColor = System.Drawing.Color.White;
            this.lbl_ChangeQty.Location = new System.Drawing.Point(2614, 422);
            this.lbl_ChangeQty.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_ChangeQty.Name = "lbl_ChangeQty";
            this.lbl_ChangeQty.Size = new System.Drawing.Size(366, 39);
            this.lbl_ChangeQty.TabIndex = 27;
            this.lbl_ChangeQty.Text = "Change Total Quantity:";
            // 
            // lbl_titlePage
            // 
            this.lbl_titlePage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_titlePage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_titlePage.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titlePage.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbl_titlePage.Location = new System.Drawing.Point(0, 0);
            this.lbl_titlePage.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_titlePage.Name = "lbl_titlePage";
            this.lbl_titlePage.Size = new System.Drawing.Size(3144, 186);
            this.lbl_titlePage.TabIndex = 26;
            this.lbl_titlePage.Text = "Inventory Management";
            this.lbl_titlePage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InventoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(3144, 1540);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "InventoryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryManagement Looby";
            this.Load += new System.EventHandler(this.InventoryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Previous_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btn_IncreaseQty;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.TextBox textBoxStockQty;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_ChangeQty;
        private System.Windows.Forms.Label lbl_loginInfo;
        private System.Windows.Forms.Label lbl_storeTitle;
        private System.Windows.Forms.Label lbl_StoreName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_titlePage;
        private System.Windows.Forms.Label lbl_ChangeQty;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.PictureBox Previous_pic;
        private System.Windows.Forms.PictureBox Close_pic;
        private System.Windows.Forms.Button btn_Send2Store;
        private System.Windows.Forms.ComboBox Store_DropDown;
    }
}