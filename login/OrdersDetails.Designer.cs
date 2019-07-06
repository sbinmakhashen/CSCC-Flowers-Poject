﻿namespace login
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.lbl_logout = new System.Windows.Forms.Label();
            this.lbl_previous = new System.Windows.Forms.Label();
            this.btn_Unclaim = new System.Windows.Forms.Button();
            this.lbl_empClaimed = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_OrderItems
            // 
            this.dgv_OrderItems.AllowUserToAddRows = false;
            this.dgv_OrderItems.AllowUserToDeleteRows = false;
            this.dgv_OrderItems.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_OrderItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_OrderItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_OrderItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_OrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_OrderItems.Location = new System.Drawing.Point(18, 195);
            this.dgv_OrderItems.Name = "dgv_OrderItems";
            this.dgv_OrderItems.ReadOnly = true;
            this.dgv_OrderItems.RowHeadersWidth = 102;
            this.dgv_OrderItems.RowTemplate.Height = 40;
            this.dgv_OrderItems.Size = new System.Drawing.Size(498, 538);
            this.dgv_OrderItems.TabIndex = 0;
            // 
            // lbl_OrderNumber
            // 
            this.lbl_OrderNumber.AutoSize = true;
            this.lbl_OrderNumber.Location = new System.Drawing.Point(522, 195);
            this.lbl_OrderNumber.Name = "lbl_OrderNumber";
            this.lbl_OrderNumber.Size = new System.Drawing.Size(202, 32);
            this.lbl_OrderNumber.TabIndex = 1;
            this.lbl_OrderNumber.Text = "Order Number:";
            // 
            // lbl_Paid
            // 
            this.lbl_Paid.AutoSize = true;
            this.lbl_Paid.Location = new System.Drawing.Point(522, 295);
            this.lbl_Paid.Name = "lbl_Paid";
            this.lbl_Paid.Size = new System.Drawing.Size(88, 32);
            this.lbl_Paid.TabIndex = 2;
            this.lbl_Paid.Text = "Paid: ";
            // 
            // lbl_DelDate
            // 
            this.lbl_DelDate.AutoSize = true;
            this.lbl_DelDate.Location = new System.Drawing.Point(522, 336);
            this.lbl_DelDate.Name = "lbl_DelDate";
            this.lbl_DelDate.Size = new System.Drawing.Size(200, 32);
            this.lbl_DelDate.TabIndex = 3;
            this.lbl_DelDate.Text = "Delivery Date: ";
            // 
            // lbl_delAdd
            // 
            this.lbl_delAdd.AutoSize = true;
            this.lbl_delAdd.Location = new System.Drawing.Point(522, 377);
            this.lbl_delAdd.Name = "lbl_delAdd";
            this.lbl_delAdd.Size = new System.Drawing.Size(237, 32);
            this.lbl_delAdd.TabIndex = 4;
            this.lbl_delAdd.Text = "Delivery Address:";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Location = new System.Drawing.Point(522, 243);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(94, 32);
            this.lbl_Total.TabIndex = 5;
            this.lbl_Total.Text = "Total: ";
            // 
            // lbl_OrderStatus
            // 
            this.lbl_OrderStatus.AutoSize = true;
            this.lbl_OrderStatus.Location = new System.Drawing.Point(1054, 525);
            this.lbl_OrderStatus.Name = "lbl_OrderStatus";
            this.lbl_OrderStatus.Size = new System.Drawing.Size(190, 32);
            this.lbl_OrderStatus.TabIndex = 6;
            this.lbl_OrderStatus.Text = "Order Status: ";
            // 
            // btn_SetComplete
            // 
            this.btn_SetComplete.Location = new System.Drawing.Point(791, 525);
            this.btn_SetComplete.Name = "btn_SetComplete";
            this.btn_SetComplete.Size = new System.Drawing.Size(247, 94);
            this.btn_SetComplete.TabIndex = 7;
            this.btn_SetComplete.Text = "Set Complete";
            this.btn_SetComplete.UseVisualStyleBackColor = true;
            this.btn_SetComplete.Click += new System.EventHandler(this.Btn_SetComplete_Click);
            // 
            // btn_Processing
            // 
            this.btn_Processing.Location = new System.Drawing.Point(528, 525);
            this.btn_Processing.Name = "btn_Processing";
            this.btn_Processing.Size = new System.Drawing.Size(247, 94);
            this.btn_Processing.TabIndex = 8;
            this.btn_Processing.Text = "Claim Order";
            this.btn_Processing.UseVisualStyleBackColor = true;
            this.btn_Processing.Click += new System.EventHandler(this.Btn_Processing_Click);
            // 
            // btn_outDel
            // 
            this.btn_outDel.Location = new System.Drawing.Point(791, 639);
            this.btn_outDel.Name = "btn_outDel";
            this.btn_outDel.Size = new System.Drawing.Size(247, 94);
            this.btn_outDel.TabIndex = 9;
            this.btn_outDel.Text = "Set Out for Delivery";
            this.btn_outDel.UseVisualStyleBackColor = true;
            this.btn_outDel.Click += new System.EventHandler(this.Btn_outDel_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(1225, 639);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(247, 94);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Text = "Cancel Order";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // lbl_logout
            // 
            this.lbl_logout.AutoSize = true;
            this.lbl_logout.Location = new System.Drawing.Point(1438, 24);
            this.lbl_logout.Name = "lbl_logout";
            this.lbl_logout.Size = new System.Drawing.Size(34, 32);
            this.lbl_logout.TabIndex = 11;
            this.lbl_logout.Text = "X";
            this.lbl_logout.Click += new System.EventHandler(this.Lbl_logout_Click);
            // 
            // lbl_previous
            // 
            this.lbl_previous.AutoSize = true;
            this.lbl_previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_previous.Location = new System.Drawing.Point(1284, 24);
            this.lbl_previous.Name = "lbl_previous";
            this.lbl_previous.Size = new System.Drawing.Size(126, 32);
            this.lbl_previous.TabIndex = 12;
            this.lbl_previous.Text = "Previous";
            this.lbl_previous.Click += new System.EventHandler(this.Lbl_previous_Click);
            // 
            // btn_Unclaim
            // 
            this.btn_Unclaim.Location = new System.Drawing.Point(528, 639);
            this.btn_Unclaim.Name = "btn_Unclaim";
            this.btn_Unclaim.Size = new System.Drawing.Size(247, 94);
            this.btn_Unclaim.TabIndex = 13;
            this.btn_Unclaim.Text = "Unclaim Order";
            this.btn_Unclaim.UseVisualStyleBackColor = true;
            this.btn_Unclaim.Click += new System.EventHandler(this.Btn_Unclaim_Click);
            // 
            // lbl_empClaimed
            // 
            this.lbl_empClaimed.AutoSize = true;
            this.lbl_empClaimed.Location = new System.Drawing.Point(522, 767);
            this.lbl_empClaimed.Name = "lbl_empClaimed";
            this.lbl_empClaimed.Size = new System.Drawing.Size(427, 32);
            this.lbl_empClaimed.TabIndex = 14;
            this.lbl_empClaimed.Text = "Employee processing this order: ";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(12, 148);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(216, 32);
            this.lbl_date.TabIndex = 15;
            this.lbl_date.Text = "Today\'s Date is:";
            // 
            // OrdersDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 808);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_empClaimed);
            this.Controls.Add(this.btn_Unclaim);
            this.Controls.Add(this.lbl_previous);
            this.Controls.Add(this.lbl_logout);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_outDel);
            this.Controls.Add(this.btn_Processing);
            this.Controls.Add(this.btn_SetComplete);
            this.Controls.Add(this.lbl_OrderStatus);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_delAdd);
            this.Controls.Add(this.lbl_DelDate);
            this.Controls.Add(this.lbl_Paid);
            this.Controls.Add(this.lbl_OrderNumber);
            this.Controls.Add(this.dgv_OrderItems);
            this.Name = "OrdersDetails";
            this.Text = "OrdersDetails";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderItems)).EndInit();
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
        private System.Windows.Forms.Label lbl_logout;
        private System.Windows.Forms.Label lbl_previous;
        private System.Windows.Forms.Button btn_Unclaim;
        private System.Windows.Forms.Label lbl_empClaimed;
        private System.Windows.Forms.Label lbl_date;
    }
}