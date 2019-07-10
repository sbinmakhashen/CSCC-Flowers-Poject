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
            this.lbl_close = new System.Windows.Forms.Label();
            this.lbl_previous = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Location = new System.Drawing.Point(1558, 25);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(34, 32);
            this.lbl_close.TabIndex = 0;
            this.lbl_close.Text = "X";
            this.lbl_close.Click += new System.EventHandler(this.Lbl_close_Click);
            // 
            // lbl_previous
            // 
            this.lbl_previous.AutoSize = true;
            this.lbl_previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_previous.Location = new System.Drawing.Point(1383, 25);
            this.lbl_previous.Name = "lbl_previous";
            this.lbl_previous.Size = new System.Drawing.Size(126, 32);
            this.lbl_previous.TabIndex = 1;
            this.lbl_previous.Text = "Previous";
            this.lbl_previous.Click += new System.EventHandler(this.Lbl_previous_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(655, 25);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(313, 32);
            this.lbl_Title.TabIndex = 2;
            this.lbl_Title.Text = "Accounts ... Adjustment";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(964, 87);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(216, 32);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "Today\'s Date is:";
            // 
            // lbl_Vendor
            // 
            this.lbl_Vendor.AutoSize = true;
            this.lbl_Vendor.Location = new System.Drawing.Point(146, 229);
            this.lbl_Vendor.Name = "lbl_Vendor";
            this.lbl_Vendor.Size = new System.Drawing.Size(115, 32);
            this.lbl_Vendor.TabIndex = 4;
            this.lbl_Vendor.Text = "Vendor:";
            // 
            // lbl_amtOwed
            // 
            this.lbl_amtOwed.AutoSize = true;
            this.lbl_amtOwed.Location = new System.Drawing.Point(146, 280);
            this.lbl_amtOwed.Name = "lbl_amtOwed";
            this.lbl_amtOwed.Size = new System.Drawing.Size(280, 32);
            this.lbl_amtOwed.TabIndex = 5;
            this.lbl_amtOwed.Text = "Ammount Still Owed:";
            // 
            // lbl_paid
            // 
            this.lbl_paid.AutoSize = true;
            this.lbl_paid.Location = new System.Drawing.Point(146, 327);
            this.lbl_paid.Name = "lbl_paid";
            this.lbl_paid.Size = new System.Drawing.Size(316, 32);
            this.lbl_paid.TabIndex = 6;
            this.lbl_paid.Text = "Ammount Paid To Date:";
            // 
            // lbl_remain
            // 
            this.lbl_remain.AutoSize = true;
            this.lbl_remain.Location = new System.Drawing.Point(146, 378);
            this.lbl_remain.Name = "lbl_remain";
            this.lbl_remain.Size = new System.Drawing.Size(162, 32);
            this.lbl_remain.TabIndex = 7;
            this.lbl_remain.Text = "Remainder:";
            // 
            // btn_Payment
            // 
            this.btn_Payment.Location = new System.Drawing.Point(152, 664);
            this.btn_Payment.Name = "btn_Payment";
            this.btn_Payment.Size = new System.Drawing.Size(302, 112);
            this.btn_Payment.TabIndex = 8;
            this.btn_Payment.Text = "Record Payment";
            this.btn_Payment.UseVisualStyleBackColor = true;
            this.btn_Payment.Click += new System.EventHandler(this.Btn_Payment_Click);
            // 
            // lbl_invoice
            // 
            this.lbl_invoice.AutoSize = true;
            this.lbl_invoice.Location = new System.Drawing.Point(812, 229);
            this.lbl_invoice.Name = "lbl_invoice";
            this.lbl_invoice.Size = new System.Drawing.Size(246, 32);
            this.lbl_invoice.TabIndex = 9;
            this.lbl_invoice.Text = "Vendor\'s Invoice #";
            // 
            // txt_payment
            // 
            this.txt_payment.Location = new System.Drawing.Point(152, 601);
            this.txt_payment.Name = "txt_payment";
            this.txt_payment.Size = new System.Drawing.Size(302, 38);
            this.txt_payment.TabIndex = 10;
            // 
            // lbl_due
            // 
            this.lbl_due.AutoSize = true;
            this.lbl_due.Location = new System.Drawing.Point(146, 429);
            this.lbl_due.Name = "lbl_due";
            this.lbl_due.Size = new System.Drawing.Size(115, 32);
            this.lbl_due.TabIndex = 11;
            this.lbl_due.Text = "Due By:";
            // 
            // lbl_lateWarning
            // 
            this.lbl_lateWarning.AutoSize = true;
            this.lbl_lateWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lateWarning.ForeColor = System.Drawing.Color.Red;
            this.lbl_lateWarning.Location = new System.Drawing.Point(145, 546);
            this.lbl_lateWarning.Name = "lbl_lateWarning";
            this.lbl_lateWarning.Size = new System.Drawing.Size(245, 39);
            this.lbl_lateWarning.TabIndex = 12;
            this.lbl_lateWarning.Text = "!!! Past Due !!!";
            // 
            // lbl_paidOff
            // 
            this.lbl_paidOff.AutoSize = true;
            this.lbl_paidOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paidOff.ForeColor = System.Drawing.Color.Green;
            this.lbl_paidOff.Location = new System.Drawing.Point(145, 546);
            this.lbl_paidOff.Name = "lbl_paidOff";
            this.lbl_paidOff.Size = new System.Drawing.Size(201, 39);
            this.lbl_paidOff.TabIndex = 13;
            this.lbl_paidOff.Text = "Paid In Full";
            // 
            // btn_viewOrder
            // 
            this.btn_viewOrder.Location = new System.Drawing.Point(152, 782);
            this.btn_viewOrder.Name = "btn_viewOrder";
            this.btn_viewOrder.Size = new System.Drawing.Size(302, 60);
            this.btn_viewOrder.TabIndex = 14;
            this.btn_viewOrder.Text = "View Order Details";
            this.btn_viewOrder.UseVisualStyleBackColor = true;
            this.btn_viewOrder.Click += new System.EventHandler(this.Btn_viewOrder_Click);
            // 
            // lbl_recName
            // 
            this.lbl_recName.AutoSize = true;
            this.lbl_recName.Location = new System.Drawing.Point(812, 280);
            this.lbl_recName.Name = "lbl_recName";
            this.lbl_recName.Size = new System.Drawing.Size(105, 32);
            this.lbl_recName.TabIndex = 15;
            this.lbl_recName.Text = "Name: ";
            // 
            // lbl_recAddy
            // 
            this.lbl_recAddy.AutoSize = true;
            this.lbl_recAddy.Location = new System.Drawing.Point(812, 378);
            this.lbl_recAddy.Name = "lbl_recAddy";
            this.lbl_recAddy.Size = new System.Drawing.Size(134, 32);
            this.lbl_recAddy.TabIndex = 16;
            this.lbl_recAddy.Text = "Address: ";
            // 
            // lbl_recEmail
            // 
            this.lbl_recEmail.AutoSize = true;
            this.lbl_recEmail.Location = new System.Drawing.Point(812, 327);
            this.lbl_recEmail.Name = "lbl_recEmail";
            this.lbl_recEmail.Size = new System.Drawing.Size(95, 32);
            this.lbl_recEmail.TabIndex = 17;
            this.lbl_recEmail.Text = "Email:";
            // 
            // AcctDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1614, 1001);
            this.Controls.Add(this.lbl_recEmail);
            this.Controls.Add(this.lbl_recAddy);
            this.Controls.Add(this.lbl_recName);
            this.Controls.Add(this.btn_viewOrder);
            this.Controls.Add(this.lbl_paidOff);
            this.Controls.Add(this.lbl_lateWarning);
            this.Controls.Add(this.lbl_due);
            this.Controls.Add(this.txt_payment);
            this.Controls.Add(this.lbl_invoice);
            this.Controls.Add(this.btn_Payment);
            this.Controls.Add(this.lbl_remain);
            this.Controls.Add(this.lbl_paid);
            this.Controls.Add(this.lbl_amtOwed);
            this.Controls.Add(this.lbl_Vendor);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_previous);
            this.Controls.Add(this.lbl_close);
            this.Name = "AcctDetails";
            this.Text = "AcctDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label lbl_previous;
        private System.Windows.Forms.Label lbl_Title;
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
    }
}