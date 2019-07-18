namespace login
{
    partial class AccountingInformationForm
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
            this.dgv_accounting = new System.Windows.Forms.DataGridView();
            this.buttonReset = new System.Windows.Forms.Button();
            this.btn_AcctPay = new System.Windows.Forms.Button();
            this.btn_AcctRec = new System.Windows.Forms.Button();
            this.lbl_store = new System.Windows.Forms.Label();
            this.lbl_StoreName = new System.Windows.Forms.Label();
            this.lbl_view = new System.Windows.Forms.Label();
            this.lbl_TableViewing = new System.Windows.Forms.Label();
            this.lbl_titlePage = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.Previous_pic = new System.Windows.Forms.PictureBox();
            this.Close_pic = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_accounting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Previous_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_accounting
            // 
            this.dgv_accounting.AllowUserToAddRows = false;
            this.dgv_accounting.AllowUserToDeleteRows = false;
            this.dgv_accounting.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            this.dgv_accounting.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_accounting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_accounting.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_accounting.BackgroundColor = System.Drawing.Color.Tan;
            this.dgv_accounting.ColumnHeadersHeight = 58;
            this.dgv_accounting.Location = new System.Drawing.Point(628, 308);
            this.dgv_accounting.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dgv_accounting.Name = "dgv_accounting";
            this.dgv_accounting.ReadOnly = true;
            this.dgv_accounting.RowHeadersWidth = 102;
            this.dgv_accounting.RowTemplate.Height = 24;
            this.dgv_accounting.Size = new System.Drawing.Size(2350, 1164);
            this.dgv_accounting.TabIndex = 25;
            this.dgv_accounting.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_accounting_CellContentClick);
            this.dgv_accounting.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Tomato;
            this.buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(20, 1319);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(498, 153);
            this.buttonReset.TabIndex = 30;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // btn_AcctPay
            // 
            this.btn_AcctPay.BackColor = System.Drawing.Color.Turquoise;
            this.btn_AcctPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AcctPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AcctPay.Location = new System.Drawing.Point(20, 450);
            this.btn_AcctPay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_AcctPay.Name = "btn_AcctPay";
            this.btn_AcctPay.Size = new System.Drawing.Size(490, 153);
            this.btn_AcctPay.TabIndex = 10;
            this.btn_AcctPay.Text = "Accounts Payable";
            this.btn_AcctPay.UseVisualStyleBackColor = false;
            this.btn_AcctPay.Click += new System.EventHandler(this.Btn_AcctPay_Click);
            // 
            // btn_AcctRec
            // 
            this.btn_AcctRec.BackColor = System.Drawing.Color.Wheat;
            this.btn_AcctRec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AcctRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AcctRec.Location = new System.Drawing.Point(20, 851);
            this.btn_AcctRec.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_AcctRec.Name = "btn_AcctRec";
            this.btn_AcctRec.Size = new System.Drawing.Size(490, 153);
            this.btn_AcctRec.TabIndex = 20;
            this.btn_AcctRec.Text = "Accounts Receivable";
            this.btn_AcctRec.UseVisualStyleBackColor = false;
            this.btn_AcctRec.Click += new System.EventHandler(this.Btn_AcctRec_Click);
            // 
            // lbl_store
            // 
            this.lbl_store.AutoSize = true;
            this.lbl_store.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_store.ForeColor = System.Drawing.Color.Teal;
            this.lbl_store.Location = new System.Drawing.Point(20, 209);
            this.lbl_store.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_store.Name = "lbl_store";
            this.lbl_store.Size = new System.Drawing.Size(244, 42);
            this.lbl_store.TabIndex = 32;
            this.lbl_store.Text = "Your Store Is:";
            // 
            // lbl_StoreName
            // 
            this.lbl_StoreName.AutoSize = true;
            this.lbl_StoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StoreName.ForeColor = System.Drawing.Color.Teal;
            this.lbl_StoreName.Location = new System.Drawing.Point(20, 291);
            this.lbl_StoreName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_StoreName.Name = "lbl_StoreName";
            this.lbl_StoreName.Size = new System.Drawing.Size(327, 75);
            this.lbl_StoreName.TabIndex = 33;
            this.lbl_StoreName.Text = "4001-Indy";
            // 
            // lbl_view
            // 
            this.lbl_view.AutoSize = true;
            this.lbl_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_view.ForeColor = System.Drawing.Color.Brown;
            this.lbl_view.Location = new System.Drawing.Point(1740, 180);
            this.lbl_view.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_view.Name = "lbl_view";
            this.lbl_view.Size = new System.Drawing.Size(320, 42);
            this.lbl_view.TabIndex = 34;
            this.lbl_view.Text = "Currently Viewing:";
            // 
            // lbl_TableViewing
            // 
            this.lbl_TableViewing.AutoSize = true;
            this.lbl_TableViewing.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TableViewing.ForeColor = System.Drawing.Color.Brown;
            this.lbl_TableViewing.Location = new System.Drawing.Point(1740, 231);
            this.lbl_TableViewing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TableViewing.Name = "lbl_TableViewing";
            this.lbl_TableViewing.Size = new System.Drawing.Size(605, 69);
            this.lbl_TableViewing.TabIndex = 35;
            this.lbl_TableViewing.Text = "Accounts Receivable";
            // 
            // lbl_titlePage
            // 
            this.lbl_titlePage.BackColor = System.Drawing.Color.DarkKhaki;
            this.lbl_titlePage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_titlePage.Font = new System.Drawing.Font("Arial", 31.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titlePage.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_titlePage.Location = new System.Drawing.Point(0, 0);
            this.lbl_titlePage.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_titlePage.Name = "lbl_titlePage";
            this.lbl_titlePage.Size = new System.Drawing.Size(3144, 167);
            this.lbl_titlePage.TabIndex = 36;
            this.lbl_titlePage.Text = "Accounting Information";
            this.lbl_titlePage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(2426, 126);
            this.lbl_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(276, 42);
            this.lbl_Date.TabIndex = 37;
            this.lbl_Date.Text = "Today\'s Date Is";
            // 
            // Previous_pic
            // 
            this.Previous_pic.BackColor = System.Drawing.Color.DarkKhaki;
            this.Previous_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Previous_pic.Image = global::login.Properties.Resources.previous_blue;
            this.Previous_pic.Location = new System.Drawing.Point(2940, 0);
            this.Previous_pic.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Previous_pic.Name = "Previous_pic";
            this.Previous_pic.Size = new System.Drawing.Size(80, 78);
            this.Previous_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Previous_pic.TabIndex = 49;
            this.Previous_pic.TabStop = false;
            this.Previous_pic.Click += new System.EventHandler(this.Previous_pic_Click);
            // 
            // Close_pic
            // 
            this.Close_pic.BackColor = System.Drawing.Color.DarkKhaki;
            this.Close_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_pic.Image = global::login.Properties.Resources.close;
            this.Close_pic.Location = new System.Drawing.Point(3066, 0);
            this.Close_pic.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Close_pic.Name = "Close_pic";
            this.Close_pic.Size = new System.Drawing.Size(78, 78);
            this.Close_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close_pic.TabIndex = 48;
            this.Close_pic.TabStop = false;
            this.Close_pic.Click += new System.EventHandler(this.Close_pic_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.PapayaWhip;
            this.pictureBox3.Image = global::login.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(2, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(324, 167);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // AccountingInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(3144, 1540);
            this.Controls.Add(this.Previous_pic);
            this.Controls.Add(this.Close_pic);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_TableViewing);
            this.Controls.Add(this.lbl_view);
            this.Controls.Add(this.lbl_StoreName);
            this.Controls.Add(this.lbl_store);
            this.Controls.Add(this.btn_AcctRec);
            this.Controls.Add(this.btn_AcctPay);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.dgv_accounting);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbl_titlePage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AccountingInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountingInformationForm";
            this.Load += new System.EventHandler(this.AccountingInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_accounting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Previous_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dgv_accounting;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button btn_AcctPay;
        private System.Windows.Forms.Button btn_AcctRec;
        private System.Windows.Forms.Label lbl_store;
        private System.Windows.Forms.Label lbl_StoreName;
        private System.Windows.Forms.Label lbl_view;
        private System.Windows.Forms.Label lbl_TableViewing;
        private System.Windows.Forms.Label lbl_titlePage;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.PictureBox Previous_pic;
        private System.Windows.Forms.PictureBox Close_pic;
    }
}