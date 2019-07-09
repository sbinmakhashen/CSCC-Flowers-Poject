namespace login
{
    partial class OrderReviewForm
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelClose = new System.Windows.Forms.Label();
            this.buttonViewOrd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btn_viewOrders = new System.Windows.Forms.Button();
            this.dateTimePicker_orders = new System.Windows.Forms.DateTimePicker();
            this.lbl_StoreIs = new System.Windows.Forms.Label();
            this.lbl_store = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.btn_ViewToday = new System.Windows.Forms.Button();
            this.lbl_titlePage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.PapayaWhip;
            this.pictureBox3.Image = global::login.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(300, 153);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.Black;
            this.labelClose.Location = new System.Drawing.Point(1992, 0);
            this.labelClose.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(55, 55);
            this.labelClose.TabIndex = 6;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // buttonViewOrd
            // 
            this.buttonViewOrd.BackColor = System.Drawing.Color.Tomato;
            this.buttonViewOrd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewOrd.Location = new System.Drawing.Point(30, 1050);
            this.buttonViewOrd.Margin = new System.Windows.Forms.Padding(6);
            this.buttonViewOrd.Name = "buttonViewOrd";
            this.buttonViewOrd.Size = new System.Drawing.Size(272, 76);
            this.buttonViewOrd.TabIndex = 15;
            this.buttonViewOrd.Text = "Reset Table";
            this.buttonViewOrd.UseVisualStyleBackColor = false;
            this.buttonViewOrd.Click += new System.EventHandler(this.ButtonViewOrd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeight = 58;
            this.dataGridView1.Location = new System.Drawing.Point(414, 440);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1552, 686);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.DataGridView1_DoubleClick);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1762, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 54);
            this.label4.TabIndex = 17;
            this.label4.Text = "Previous";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.Maroon;
            this.textBoxSearch.Location = new System.Drawing.Point(414, 349);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(946, 76);
            this.textBoxSearch.TabIndex = 18;
            this.textBoxSearch.Text = "Search Address Here....";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // btn_viewOrders
            // 
            this.btn_viewOrders.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_viewOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_viewOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewOrders.Location = new System.Drawing.Point(414, 213);
            this.btn_viewOrders.Margin = new System.Windows.Forms.Padding(6);
            this.btn_viewOrders.Name = "btn_viewOrders";
            this.btn_viewOrders.Size = new System.Drawing.Size(352, 60);
            this.btn_viewOrders.TabIndex = 19;
            this.btn_viewOrders.Text = "View Orders Due After:";
            this.btn_viewOrders.UseVisualStyleBackColor = false;
            this.btn_viewOrders.Click += new System.EventHandler(this.Btn_viewOrders_Click);
            // 
            // dateTimePicker_orders
            // 
            this.dateTimePicker_orders.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_orders.CalendarForeColor = System.Drawing.Color.BurlyWood;
            this.dateTimePicker_orders.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker_orders.CalendarTitleBackColor = System.Drawing.Color.Teal;
            this.dateTimePicker_orders.CalendarTrailingForeColor = System.Drawing.Color.Gray;
            this.dateTimePicker_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_orders.Location = new System.Drawing.Point(776, 213);
            this.dateTimePicker_orders.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_orders.MinDate = new System.DateTime(1975, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_orders.Name = "dateTimePicker_orders";
            this.dateTimePicker_orders.Size = new System.Drawing.Size(764, 60);
            this.dateTimePicker_orders.TabIndex = 20;
            // 
            // lbl_StoreIs
            // 
            this.lbl_StoreIs.AutoSize = true;
            this.lbl_StoreIs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StoreIs.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbl_StoreIs.Location = new System.Drawing.Point(25, 298);
            this.lbl_StoreIs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_StoreIs.Name = "lbl_StoreIs";
            this.lbl_StoreIs.Size = new System.Drawing.Size(197, 36);
            this.lbl_StoreIs.TabIndex = 21;
            this.lbl_StoreIs.Text = "Your Store Is:";
            // 
            // lbl_store
            // 
            this.lbl_store.AutoSize = true;
            this.lbl_store.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_store.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbl_store.Location = new System.Drawing.Point(19, 364);
            this.lbl_store.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_store.Name = "lbl_store";
            this.lbl_store.Size = new System.Drawing.Size(296, 61);
            this.lbl_store.TabIndex = 22;
            this.lbl_store.Text = "4001-INDY";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_date.Location = new System.Drawing.Point(1305, 117);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(235, 36);
            this.lbl_date.TabIndex = 23;
            this.lbl_date.Text = "Today\'s Date Is: ";
            // 
            // btn_ViewToday
            // 
            this.btn_ViewToday.BackColor = System.Drawing.Color.Thistle;
            this.btn_ViewToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ViewToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewToday.Location = new System.Drawing.Point(1550, 213);
            this.btn_ViewToday.Margin = new System.Windows.Forms.Padding(6);
            this.btn_ViewToday.Name = "btn_ViewToday";
            this.btn_ViewToday.Size = new System.Drawing.Size(416, 60);
            this.btn_ViewToday.TabIndex = 24;
            this.btn_ViewToday.Text = "View Orders For Today";
            this.btn_ViewToday.UseVisualStyleBackColor = false;
            this.btn_ViewToday.Click += new System.EventHandler(this.Btn_ViewToday_Click);
            // 
            // lbl_titlePage
            // 
            this.lbl_titlePage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_titlePage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_titlePage.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titlePage.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbl_titlePage.Location = new System.Drawing.Point(0, 0);
            this.lbl_titlePage.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_titlePage.Name = "lbl_titlePage";
            this.lbl_titlePage.Size = new System.Drawing.Size(2046, 153);
            this.lbl_titlePage.TabIndex = 27;
            this.lbl_titlePage.Text = "Order Review";
            this.lbl_titlePage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2046, 1145);
            this.Controls.Add(this.btn_ViewToday);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_store);
            this.Controls.Add(this.lbl_StoreIs);
            this.Controls.Add(this.dateTimePicker_orders);
            this.Controls.Add(this.btn_viewOrders);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonViewOrd);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbl_titlePage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "OrderReviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Review Lobby";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Button buttonViewOrd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btn_viewOrders;
        private System.Windows.Forms.DateTimePicker dateTimePicker_orders;
        private System.Windows.Forms.Label lbl_StoreIs;
        private System.Windows.Forms.Label lbl_store;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Button btn_ViewToday;
        private System.Windows.Forms.Label lbl_titlePage;
    }
}