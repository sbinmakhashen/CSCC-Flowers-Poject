namespace login
{
    partial class OrdersDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_OrderItems = new System.Windows.Forms.DataGridView();
            this.lbl_OrderNumber = new System.Windows.Forms.Label();
            this.lbl_Paid = new System.Windows.Forms.Label();
            this.lbl_DelDate = new System.Windows.Forms.Label();
            this.lbl_delAdd = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_OrderStatus = new System.Windows.Forms.Label();
            this.btn_SetComplete = new System.Windows.Forms.Button();
            this.btn_Processing = new System.Windows.Forms.Button();
            this.btn_outDel = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Unclaim = new System.Windows.Forms.Button();
            this.lbl_empClaimed = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_titlePage = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Previous_pic = new System.Windows.Forms.PictureBox();
            this.Close_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Previous_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_OrderItems
            // 
            this.dgv_OrderItems.AllowUserToAddRows = false;
            this.dgv_OrderItems.AllowUserToDeleteRows = false;
            this.dgv_OrderItems.AllowUserToOrderColumns = true;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_OrderItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_OrderItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_OrderItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_OrderItems.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgv_OrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderItems.Location = new System.Drawing.Point(9, 119);
            this.dgv_OrderItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_OrderItems.Name = "dgv_OrderItems";
            this.dgv_OrderItems.ReadOnly = true;
            this.dgv_OrderItems.RowHeadersWidth = 102;
            this.dgv_OrderItems.RowTemplate.Height = 40;
            this.dgv_OrderItems.Size = new System.Drawing.Size(659, 547);
            this.dgv_OrderItems.TabIndex = 0;
            // 
            // lbl_OrderNumber
            // 
            this.lbl_OrderNumber.AutoSize = true;
            this.lbl_OrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderNumber.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbl_OrderNumber.Location = new System.Drawing.Point(4, 72);
            this.lbl_OrderNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_OrderNumber.Name = "lbl_OrderNumber";
            this.lbl_OrderNumber.Size = new System.Drawing.Size(175, 29);
            this.lbl_OrderNumber.TabIndex = 1;
            this.lbl_OrderNumber.Text = "Order Number:";
            // 
            // lbl_Paid
            // 
            this.lbl_Paid.AutoSize = true;
            this.lbl_Paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Paid.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbl_Paid.Location = new System.Drawing.Point(5, 161);
            this.lbl_Paid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Paid.Name = "lbl_Paid";
            this.lbl_Paid.Size = new System.Drawing.Size(74, 29);
            this.lbl_Paid.TabIndex = 2;
            this.lbl_Paid.Text = "Paid: ";
            // 
            // lbl_DelDate
            // 
            this.lbl_DelDate.AutoSize = true;
            this.lbl_DelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DelDate.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbl_DelDate.Location = new System.Drawing.Point(4, 214);
            this.lbl_DelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DelDate.Name = "lbl_DelDate";
            this.lbl_DelDate.Size = new System.Drawing.Size(168, 29);
            this.lbl_DelDate.TabIndex = 3;
            this.lbl_DelDate.Text = "Delivery Date: ";
            // 
            // lbl_delAdd
            // 
            this.lbl_delAdd.AutoSize = true;
            this.lbl_delAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_delAdd.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbl_delAdd.Location = new System.Drawing.Point(4, 285);
            this.lbl_delAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_delAdd.Name = "lbl_delAdd";
            this.lbl_delAdd.Size = new System.Drawing.Size(201, 29);
            this.lbl_delAdd.TabIndex = 4;
            this.lbl_delAdd.Text = "Delivery Address:";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbl_Total.Location = new System.Drawing.Point(4, 119);
            this.lbl_Total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(80, 29);
            this.lbl_Total.TabIndex = 5;
            this.lbl_Total.Text = "Total: ";
            // 
            // lbl_OrderStatus
            // 
            this.lbl_OrderStatus.AutoSize = true;
            this.lbl_OrderStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OrderStatus.ForeColor = System.Drawing.Color.PeachPuff;
            this.lbl_OrderStatus.Location = new System.Drawing.Point(4, 19);
            this.lbl_OrderStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_OrderStatus.Name = "lbl_OrderStatus";
            this.lbl_OrderStatus.Size = new System.Drawing.Size(160, 29);
            this.lbl_OrderStatus.TabIndex = 6;
            this.lbl_OrderStatus.Text = "Order Status: ";
            // 
            // btn_SetComplete
            // 
            this.btn_SetComplete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_SetComplete.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_SetComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SetComplete.Location = new System.Drawing.Point(591, 25);
            this.btn_SetComplete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SetComplete.Name = "btn_SetComplete";
            this.btn_SetComplete.Size = new System.Drawing.Size(342, 49);
            this.btn_SetComplete.TabIndex = 7;
            this.btn_SetComplete.Text = "Set Processed (Ready for Delivery)";
            this.btn_SetComplete.UseVisualStyleBackColor = false;
            this.btn_SetComplete.Click += new System.EventHandler(this.Btn_SetComplete_Click);
            // 
            // btn_Processing
            // 
            this.btn_Processing.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Processing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Processing.Location = new System.Drawing.Point(251, 25);
            this.btn_Processing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Processing.Name = "btn_Processing";
            this.btn_Processing.Size = new System.Drawing.Size(304, 49);
            this.btn_Processing.TabIndex = 8;
            this.btn_Processing.Text = "Set Recieved (Claim Order)";
            this.btn_Processing.UseVisualStyleBackColor = false;
            this.btn_Processing.Click += new System.EventHandler(this.Btn_Processing_Click);
            // 
            // btn_outDel
            // 
            this.btn_outDel.BackColor = System.Drawing.Color.Tan;
            this.btn_outDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_outDel.Location = new System.Drawing.Point(985, 25);
            this.btn_outDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_outDel.Name = "btn_outDel";
            this.btn_outDel.Size = new System.Drawing.Size(342, 49);
            this.btn_outDel.TabIndex = 9;
            this.btn_outDel.Text = "Set Out for Delivery";
            this.btn_outDel.UseVisualStyleBackColor = false;
            this.btn_outDel.Click += new System.EventHandler(this.Btn_outDel_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.Peru;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(1387, 25);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(150, 49);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "Cancel Order";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // btn_Unclaim
            // 
            this.btn_Unclaim.BackColor = System.Drawing.Color.Tomato;
            this.btn_Unclaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Unclaim.Location = new System.Drawing.Point(5, 25);
            this.btn_Unclaim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Unclaim.Name = "btn_Unclaim";
            this.btn_Unclaim.Size = new System.Drawing.Size(217, 49);
            this.btn_Unclaim.TabIndex = 13;
            this.btn_Unclaim.Text = "Unclaim Order";
            this.btn_Unclaim.UseVisualStyleBackColor = false;
            this.btn_Unclaim.Click += new System.EventHandler(this.Btn_Unclaim_Click);
            // 
            // lbl_empClaimed
            // 
            this.lbl_empClaimed.AutoSize = true;
            this.lbl_empClaimed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empClaimed.ForeColor = System.Drawing.Color.Gold;
            this.lbl_empClaimed.Location = new System.Drawing.Point(5, 383);
            this.lbl_empClaimed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_empClaimed.Name = "lbl_empClaimed";
            this.lbl_empClaimed.Size = new System.Drawing.Size(295, 25);
            this.lbl_empClaimed.TabIndex = 14;
            this.lbl_empClaimed.Text = "Employee processing this order: ";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.Teal;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.PeachPuff;
            this.lbl_date.Location = new System.Drawing.Point(1184, 69);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(142, 24);
            this.lbl_date.TabIndex = 15;
            this.lbl_date.Text = "Today\'s Date is:";
            // 
            // lbl_titlePage
            // 
            this.lbl_titlePage.BackColor = System.Drawing.Color.DarkKhaki;
            this.lbl_titlePage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_titlePage.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titlePage.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbl_titlePage.Location = new System.Drawing.Point(0, 0);
            this.lbl_titlePage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titlePage.Name = "lbl_titlePage";
            this.lbl_titlePage.Size = new System.Drawing.Size(1572, 93);
            this.lbl_titlePage.TabIndex = 16;
            this.lbl_titlePage.Text = "Order Details";
            this.lbl_titlePage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.PapayaWhip;
            this.pictureBox3.Image = global::login.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(154, 93);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Processing);
            this.groupBox1.Controls.Add(this.btn_outDel);
            this.groupBox1.Controls.Add(this.btn_Unclaim);
            this.groupBox1.Controls.Add(this.btn_SetComplete);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 695);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1551, 88);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Status Actions";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox2.Controls.Add(this.lbl_OrderNumber);
            this.groupBox2.Controls.Add(this.lbl_Paid);
            this.groupBox2.Controls.Add(this.lbl_DelDate);
            this.groupBox2.Controls.Add(this.lbl_delAdd);
            this.groupBox2.Controls.Add(this.lbl_empClaimed);
            this.groupBox2.Controls.Add(this.lbl_Total);
            this.groupBox2.Controls.Add(this.lbl_OrderStatus);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.ForeColor = System.Drawing.Color.Honeydew;
            this.groupBox2.Location = new System.Drawing.Point(690, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(856, 547);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Details";
            // 
            // Previous_pic
            // 
            this.Previous_pic.BackColor = System.Drawing.Color.DarkKhaki;
            this.Previous_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Previous_pic.Image = global::login.Properties.Resources.previous_blue;
            this.Previous_pic.Location = new System.Drawing.Point(1472, 0);
            this.Previous_pic.Name = "Previous_pic";
            this.Previous_pic.Size = new System.Drawing.Size(39, 40);
            this.Previous_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Previous_pic.TabIndex = 51;
            this.Previous_pic.TabStop = false;
            this.Previous_pic.Click += new System.EventHandler(this.Previous_pic_Click);
            // 
            // Close_pic
            // 
            this.Close_pic.BackColor = System.Drawing.Color.DarkKhaki;
            this.Close_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_pic.Image = global::login.Properties.Resources.close;
            this.Close_pic.Location = new System.Drawing.Point(1534, 0);
            this.Close_pic.Name = "Close_pic";
            this.Close_pic.Size = new System.Drawing.Size(38, 40);
            this.Close_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close_pic.TabIndex = 50;
            this.Close_pic.TabStop = false;
            this.Close_pic.Click += new System.EventHandler(this.Close_pic_Click);
            // 
            // OrdersDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1572, 795);
            this.Controls.Add(this.Previous_pic);
            this.Controls.Add(this.Close_pic);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.dgv_OrderItems);
            this.Controls.Add(this.lbl_titlePage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OrdersDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrdersDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Previous_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_OrderItems;
        private System.Windows.Forms.Label lbl_OrderNumber;
        private System.Windows.Forms.Label lbl_Paid;
        private System.Windows.Forms.Label lbl_DelDate;
        private System.Windows.Forms.Label lbl_delAdd;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_OrderStatus;
        private System.Windows.Forms.Button btn_SetComplete;
        private System.Windows.Forms.Button btn_Processing;
        private System.Windows.Forms.Button btn_outDel;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Unclaim;
        private System.Windows.Forms.Label lbl_empClaimed;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_titlePage;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox Previous_pic;
        private System.Windows.Forms.PictureBox Close_pic;
    }
}