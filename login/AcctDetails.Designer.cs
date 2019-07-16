namespace login
{
    partial class AcctDetails
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
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_Vendor = new System.Windows.Forms.Label();
            this.lbl_amtOwed = new System.Windows.Forms.Label();
            this.lbl_paid = new System.Windows.Forms.Label();
            this.lbl_remain = new System.Windows.Forms.Label();
            this.btn_Payment = new System.Windows.Forms.Button();
            this.lbl_invoice = new System.Windows.Forms.Label();
            this.txt_payment = new System.Windows.Forms.TextBox();
            this.lbl_due = new System.Windows.Forms.Label();
            this.lbl_lateWarning = new System.Windows.Forms.Label();
            this.lbl_paidOff = new System.Windows.Forms.Label();
            this.btn_viewOrder = new System.Windows.Forms.Button();
            this.lbl_recName = new System.Windows.Forms.Label();
            this.lbl_recAddy = new System.Windows.Forms.Label();
            this.lbl_recEmail = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.groupBoxTitle = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Previous_pic = new System.Windows.Forms.PictureBox();
            this.Close_pic = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBoxTitle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Previous_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.Teal;
            this.lbl_date.Location = new System.Drawing.Point(2334, 130);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(285, 42);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "Today\'s Date is:";
            // 
            // lbl_Vendor
            // 
            this.lbl_Vendor.AutoSize = true;
            this.lbl_Vendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vendor.ForeColor = System.Drawing.Color.Teal;
            this.lbl_Vendor.Location = new System.Drawing.Point(30, 60);
            this.lbl_Vendor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Vendor.Name = "lbl_Vendor";
            this.lbl_Vendor.Size = new System.Drawing.Size(187, 54);
            this.lbl_Vendor.TabIndex = 4;
            this.lbl_Vendor.Text = "Vendor:";
            // 
            // lbl_amtOwed
            // 
            this.lbl_amtOwed.AutoSize = true;
            this.lbl_amtOwed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_amtOwed.ForeColor = System.Drawing.Color.Teal;
            this.lbl_amtOwed.Location = new System.Drawing.Point(30, 120);
            this.lbl_amtOwed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_amtOwed.Name = "lbl_amtOwed";
            this.lbl_amtOwed.Size = new System.Drawing.Size(418, 54);
            this.lbl_amtOwed.TabIndex = 5;
            this.lbl_amtOwed.Text = "Amount Still Owed:";
            // 
            // lbl_paid
            // 
            this.lbl_paid.AutoSize = true;
            this.lbl_paid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paid.ForeColor = System.Drawing.Color.Teal;
            this.lbl_paid.Location = new System.Drawing.Point(30, 180);
            this.lbl_paid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_paid.Name = "lbl_paid";
            this.lbl_paid.Size = new System.Drawing.Size(480, 54);
            this.lbl_paid.TabIndex = 6;
            this.lbl_paid.Text = "Amount Paid To Date:";
            // 
            // lbl_remain
            // 
            this.lbl_remain.AutoSize = true;
            this.lbl_remain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_remain.ForeColor = System.Drawing.Color.Teal;
            this.lbl_remain.Location = new System.Drawing.Point(30, 240);
            this.lbl_remain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_remain.Name = "lbl_remain";
            this.lbl_remain.Size = new System.Drawing.Size(265, 54);
            this.lbl_remain.TabIndex = 7;
            this.lbl_remain.Text = "Remainder:";
            // 
            // btn_Payment
            // 
            this.btn_Payment.BackColor = System.Drawing.Color.SeaShell;
            this.btn_Payment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Payment.ForeColor = System.Drawing.Color.Blue;
            this.btn_Payment.Location = new System.Drawing.Point(1300, 50);
            this.btn_Payment.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Payment.Name = "btn_Payment";
            this.btn_Payment.Size = new System.Drawing.Size(548, 132);
            this.btn_Payment.TabIndex = 20;
            this.btn_Payment.Text = "Record Payment";
            this.btn_Payment.UseVisualStyleBackColor = false;
            this.btn_Payment.Click += new System.EventHandler(this.Btn_Payment_Click);
            // 
            // lbl_invoice
            // 
            this.lbl_invoice.AutoSize = true;
            this.lbl_invoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invoice.ForeColor = System.Drawing.Color.Teal;
            this.lbl_invoice.Location = new System.Drawing.Point(1400, 60);
            this.lbl_invoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_invoice.Name = "lbl_invoice";
            this.lbl_invoice.Size = new System.Drawing.Size(406, 54);
            this.lbl_invoice.TabIndex = 9;
            this.lbl_invoice.Text = "Vendor\'s Invoice #";
            // 
            // txt_payment
            // 
            this.txt_payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_payment.Location = new System.Drawing.Point(1180, 900);
            this.txt_payment.Margin = new System.Windows.Forms.Padding(4);
            this.txt_payment.Multiline = true;
            this.txt_payment.Name = "txt_payment";
            this.txt_payment.Size = new System.Drawing.Size(764, 76);
            this.txt_payment.TabIndex = 10;
            // 
            // lbl_due
            // 
            this.lbl_due.AutoSize = true;
            this.lbl_due.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_due.ForeColor = System.Drawing.Color.Teal;
            this.lbl_due.Location = new System.Drawing.Point(30, 300);
            this.lbl_due.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_due.Name = "lbl_due";
            this.lbl_due.Size = new System.Drawing.Size(189, 54);
            this.lbl_due.TabIndex = 11;
            this.lbl_due.Text = "Due By:";
            // 
            // lbl_lateWarning
            // 
            this.lbl_lateWarning.AutoSize = true;
            this.lbl_lateWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lateWarning.ForeColor = System.Drawing.Color.Red;
            this.lbl_lateWarning.Location = new System.Drawing.Point(1420, 835);
            this.lbl_lateWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_lateWarning.Name = "lbl_lateWarning";
            this.lbl_lateWarning.Size = new System.Drawing.Size(288, 46);
            this.lbl_lateWarning.TabIndex = 12;
            this.lbl_lateWarning.Text = "!!! Past Due !!!";
            // 
            // lbl_paidOff
            // 
            this.lbl_paidOff.AutoSize = true;
            this.lbl_paidOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paidOff.ForeColor = System.Drawing.Color.Green;
            this.lbl_paidOff.Location = new System.Drawing.Point(1420, 835);
            this.lbl_paidOff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_paidOff.Name = "lbl_paidOff";
            this.lbl_paidOff.Size = new System.Drawing.Size(230, 46);
            this.lbl_paidOff.TabIndex = 13;
            this.lbl_paidOff.Text = "Paid In Full";
            // 
            // btn_viewOrder
            // 
            this.btn_viewOrder.BackColor = System.Drawing.Color.Salmon;
            this.btn_viewOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_viewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewOrder.ForeColor = System.Drawing.Color.Black;
            this.btn_viewOrder.Location = new System.Drawing.Point(1300, 300);
            this.btn_viewOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btn_viewOrder.Name = "btn_viewOrder";
            this.btn_viewOrder.Size = new System.Drawing.Size(548, 97);
            this.btn_viewOrder.TabIndex = 15;
            this.btn_viewOrder.Text = "View Order Details";
            this.btn_viewOrder.UseVisualStyleBackColor = false;
            this.btn_viewOrder.Click += new System.EventHandler(this.Btn_viewOrder_Click);
            // 
            // lbl_recName
            // 
            this.lbl_recName.AutoSize = true;
            this.lbl_recName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recName.ForeColor = System.Drawing.Color.Teal;
            this.lbl_recName.Location = new System.Drawing.Point(1400, 120);
            this.lbl_recName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_recName.Name = "lbl_recName";
            this.lbl_recName.Size = new System.Drawing.Size(173, 54);
            this.lbl_recName.TabIndex = 15;
            this.lbl_recName.Text = "Name: ";
            // 
            // lbl_recAddy
            // 
            this.lbl_recAddy.AutoSize = true;
            this.lbl_recAddy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recAddy.ForeColor = System.Drawing.Color.Teal;
            this.lbl_recAddy.Location = new System.Drawing.Point(1400, 240);
            this.lbl_recAddy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_recAddy.Name = "lbl_recAddy";
            this.lbl_recAddy.Size = new System.Drawing.Size(221, 54);
            this.lbl_recAddy.TabIndex = 16;
            this.lbl_recAddy.Text = "Address: ";
            // 
            // lbl_recEmail
            // 
            this.lbl_recEmail.AutoSize = true;
            this.lbl_recEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recEmail.ForeColor = System.Drawing.Color.Teal;
            this.lbl_recEmail.Location = new System.Drawing.Point(1400, 180);
            this.lbl_recEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_recEmail.Name = "lbl_recEmail";
            this.lbl_recEmail.Size = new System.Drawing.Size(152, 54);
            this.lbl_recEmail.TabIndex = 17;
            this.lbl_recEmail.Text = "Email:";
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Title.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(3144, 170);
            this.lbl_Title.TabIndex = 28;
            this.lbl_Title.Text = "Accounts ... Adjustment";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxTitle
            // 
            this.groupBoxTitle.BackColor = System.Drawing.Color.Silver;
            this.groupBoxTitle.Controls.Add(this.lbl_recAddy);
            this.groupBoxTitle.Controls.Add(this.lbl_recEmail);
            this.groupBoxTitle.Controls.Add(this.lbl_Vendor);
            this.groupBoxTitle.Controls.Add(this.lbl_amtOwed);
            this.groupBoxTitle.Controls.Add(this.lbl_recName);
            this.groupBoxTitle.Controls.Add(this.lbl_paid);
            this.groupBoxTitle.Controls.Add(this.lbl_remain);
            this.groupBoxTitle.Controls.Add(this.lbl_invoice);
            this.groupBoxTitle.Controls.Add(this.lbl_due);
            this.groupBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTitle.ForeColor = System.Drawing.Color.Brown;
            this.groupBoxTitle.Location = new System.Drawing.Point(16, 221);
            this.groupBoxTitle.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxTitle.Name = "groupBoxTitle";
            this.groupBoxTitle.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxTitle.Size = new System.Drawing.Size(3104, 519);
            this.groupBoxTitle.TabIndex = 29;
            this.groupBoxTitle.TabStop = false;
            this.groupBoxTitle.Text = "Accounting...details...here";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btn_Payment);
            this.groupBox1.Controls.Add(this.btn_viewOrder);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Brown;
            this.groupBox1.Location = new System.Drawing.Point(20, 1108);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(3104, 424);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Status Actions";
            // 
            // Previous_pic
            // 
            this.Previous_pic.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Previous_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Previous_pic.Image = global::login.Properties.Resources.previous_blue;
            this.Previous_pic.Location = new System.Drawing.Point(2936, 0);
            this.Previous_pic.Margin = new System.Windows.Forms.Padding(6);
            this.Previous_pic.Name = "Previous_pic";
            this.Previous_pic.Size = new System.Drawing.Size(78, 78);
            this.Previous_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Previous_pic.TabIndex = 41;
            this.Previous_pic.TabStop = false;
            this.Previous_pic.Click += new System.EventHandler(this.Previous_pic_Click);
            // 
            // Close_pic
            // 
            this.Close_pic.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Close_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_pic.Image = global::login.Properties.Resources.close;
            this.Close_pic.Location = new System.Drawing.Point(3068, 0);
            this.Close_pic.Margin = new System.Windows.Forms.Padding(6);
            this.Close_pic.Name = "Close_pic";
            this.Close_pic.Size = new System.Drawing.Size(76, 78);
            this.Close_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close_pic.TabIndex = 40;
            this.Close_pic.TabStop = false;
            this.Close_pic.Click += new System.EventHandler(this.Close_pic_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.PapayaWhip;
            this.pictureBox3.Image = global::login.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(-8, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(332, 170);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // AcctDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(3144, 1540);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Previous_pic);
            this.Controls.Add(this.Close_pic);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxTitle);
            this.Controls.Add(this.lbl_paidOff);
            this.Controls.Add(this.lbl_lateWarning);
            this.Controls.Add(this.txt_payment);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AcctDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AcctDetails";
            this.groupBoxTitle.ResumeLayout(false);
            this.groupBoxTitle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Previous_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_Vendor;
        private System.Windows.Forms.Label lbl_amtOwed;
        private System.Windows.Forms.Label lbl_paid;
        private System.Windows.Forms.Label lbl_remain;
        private System.Windows.Forms.Button btn_Payment;
        private System.Windows.Forms.Label lbl_invoice;
        private System.Windows.Forms.TextBox txt_payment;
        private System.Windows.Forms.Label lbl_due;
        private System.Windows.Forms.Label lbl_lateWarning;
        private System.Windows.Forms.Label lbl_paidOff;
        private System.Windows.Forms.Button btn_viewOrder;
        private System.Windows.Forms.Label lbl_recName;
        private System.Windows.Forms.Label lbl_recAddy;
        private System.Windows.Forms.Label lbl_recEmail;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox groupBoxTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox Previous_pic;
        private System.Windows.Forms.PictureBox Close_pic;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}