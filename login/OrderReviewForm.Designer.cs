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
            this.buttonViewOrd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_viewOrders = new System.Windows.Forms.Button();
            this.dateTimePicker_orders = new System.Windows.Forms.DateTimePicker();
            this.lbl_StoreIs = new System.Windows.Forms.Label();
            this.lbl_store = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.btn_ViewToday = new System.Windows.Forms.Button();
            this.Previous_pic = new System.Windows.Forms.PictureBox();
            this.Close_pic = new System.Windows.Forms.PictureBox();
            this.lbl_titlePage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Previous_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.PapayaWhip;
            this.pictureBox3.Image = global::login.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(178, 98);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // buttonViewOrd
            // 
            this.buttonViewOrd.BackColor = System.Drawing.Color.Tomato;
            this.buttonViewOrd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewOrd.Location = new System.Drawing.Point(10, 723);
            this.buttonViewOrd.Name = "buttonViewOrd";
            this.buttonViewOrd.Size = new System.Drawing.Size(168, 64);
            this.buttonViewOrd.TabIndex = 50;
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
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeight = 58;
            this.dataGridView1.Location = new System.Drawing.Point(188, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1340, 555);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.DataGridView1_DoubleClick);
            // 
            // btn_viewOrders
            // 
            this.btn_viewOrders.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_viewOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_viewOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewOrders.Location = new System.Drawing.Point(350, 114);
            this.btn_viewOrders.Name = "btn_viewOrders";
            this.btn_viewOrders.Size = new System.Drawing.Size(247, 49);
            this.btn_viewOrders.TabIndex = 30;
            this.btn_viewOrders.Text = "View Orders Due After";
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
            this.dateTimePicker_orders.Location = new System.Drawing.Point(610, 145);
            this.dateTimePicker_orders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker_orders.MinDate = new System.DateTime(1975, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_orders.Name = "dateTimePicker_orders";
            this.dateTimePicker_orders.Size = new System.Drawing.Size(427, 34);
            this.dateTimePicker_orders.TabIndex = 20;
            // 
            // lbl_StoreIs
            // 
            this.lbl_StoreIs.AutoSize = true;
            this.lbl_StoreIs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StoreIs.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbl_StoreIs.Location = new System.Drawing.Point(10, 170);
            this.lbl_StoreIs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StoreIs.Name = "lbl_StoreIs";
            this.lbl_StoreIs.Size = new System.Drawing.Size(122, 24);
            this.lbl_StoreIs.TabIndex = 21;
            this.lbl_StoreIs.Text = "Your Store Is:";
            // 
            // lbl_store
            // 
            this.lbl_store.AutoSize = true;
            this.lbl_store.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_store.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbl_store.Location = new System.Drawing.Point(10, 206);
            this.lbl_store.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_store.Name = "lbl_store";
            this.lbl_store.Size = new System.Drawing.Size(173, 36);
            this.lbl_store.TabIndex = 22;
            this.lbl_store.Text = "4001-INDY";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_date.Location = new System.Drawing.Point(1120, 77);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(147, 24);
            this.lbl_date.TabIndex = 23;
            this.lbl_date.Text = "Today\'s Date Is: ";
            // 
            // btn_ViewToday
            // 
            this.btn_ViewToday.BackColor = System.Drawing.Color.Thistle;
            this.btn_ViewToday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ViewToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewToday.Location = new System.Drawing.Point(350, 165);
            this.btn_ViewToday.Name = "btn_ViewToday";
            this.btn_ViewToday.Size = new System.Drawing.Size(247, 49);
            this.btn_ViewToday.TabIndex = 40;
            this.btn_ViewToday.Text = "View Orders For Today";
            this.btn_ViewToday.UseVisualStyleBackColor = false;
            this.btn_ViewToday.Click += new System.EventHandler(this.Btn_ViewToday_Click);
            // 
            // Previous_pic
            // 
            this.Previous_pic.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Previous_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Previous_pic.Image = global::login.Properties.Resources.previous_blue;
            this.Previous_pic.Location = new System.Drawing.Point(1454, 0);
            this.Previous_pic.Name = "Previous_pic";
            this.Previous_pic.Size = new System.Drawing.Size(39, 40);
            this.Previous_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Previous_pic.TabIndex = 49;
            this.Previous_pic.TabStop = false;
            this.Previous_pic.Click += new System.EventHandler(this.Previous_pic_Click);
            // 
            // Close_pic
            // 
            this.Close_pic.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Close_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_pic.Image = global::login.Properties.Resources.close;
            this.Close_pic.Location = new System.Drawing.Point(1531, 0);
            this.Close_pic.Name = "Close_pic";
            this.Close_pic.Size = new System.Drawing.Size(38, 40);
            this.Close_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close_pic.TabIndex = 48;
            this.Close_pic.TabStop = false;
            this.Close_pic.Click += new System.EventHandler(this.Close_pic_Click);
            // 
            // lbl_titlePage
            // 
            this.lbl_titlePage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_titlePage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_titlePage.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titlePage.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbl_titlePage.Location = new System.Drawing.Point(0, 0);
            this.lbl_titlePage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titlePage.Name = "lbl_titlePage";
            this.lbl_titlePage.Size = new System.Drawing.Size(1572, 98);
            this.lbl_titlePage.TabIndex = 27;
            this.lbl_titlePage.Text = "Order Review";
            this.lbl_titlePage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1572, 795);
            this.Controls.Add(this.Previous_pic);
            this.Controls.Add(this.Close_pic);
            this.Controls.Add(this.btn_ViewToday);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_store);
            this.Controls.Add(this.lbl_StoreIs);
            this.Controls.Add(this.dateTimePicker_orders);
            this.Controls.Add(this.btn_viewOrders);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonViewOrd);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbl_titlePage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderReviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Review Lobby";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Previous_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonViewOrd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_viewOrders;
        private System.Windows.Forms.DateTimePicker dateTimePicker_orders;
        private System.Windows.Forms.Label lbl_StoreIs;
        private System.Windows.Forms.Label lbl_store;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Button btn_ViewToday;
        private System.Windows.Forms.PictureBox Previous_pic;
        private System.Windows.Forms.PictureBox Close_pic;
        private System.Windows.Forms.Label lbl_titlePage;
    }
}