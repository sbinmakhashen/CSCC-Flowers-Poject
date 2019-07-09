﻿namespace login
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelClose = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_accounting = new System.Windows.Forms.DataGridView();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btn_AcctPay = new System.Windows.Forms.Button();
            this.btn_AcctRec = new System.Windows.Forms.Button();
            this.lbl_store = new System.Windows.Forms.Label();
            this.lbl_StoreName = new System.Windows.Forms.Label();
            this.lbl_view = new System.Windows.Forms.Label();
            this.lbl_TableViewing = new System.Windows.Forms.Label();
            this.lbl_titlePage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_accounting)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.PapayaWhip;
            this.pictureBox3.Image = global::login.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(1, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(124, 86);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.BackColor = System.Drawing.Color.DarkKhaki;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.Black;
            this.labelClose.Location = new System.Drawing.Point(944, 0);
            this.labelClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(27, 27);
            this.labelClose.TabIndex = 7;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkKhaki;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(818, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Previous";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgv_accounting
            // 
            this.dgv_accounting.AllowUserToAddRows = false;
            this.dgv_accounting.AllowUserToDeleteRows = false;
            this.dgv_accounting.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            this.dgv_accounting.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_accounting.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv_accounting.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_accounting.BackgroundColor = System.Drawing.Color.Tan;
            this.dgv_accounting.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_accounting.Location = new System.Drawing.Point(165, 153);
            this.dgv_accounting.Name = "dgv_accounting";
            this.dgv_accounting.ReadOnly = true;
            this.dgv_accounting.RowHeadersWidth = 102;
            this.dgv_accounting.RowTemplate.Height = 24;
            this.dgv_accounting.Size = new System.Drawing.Size(794, 385);
            this.dgv_accounting.TabIndex = 17;
            this.dgv_accounting.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.Tomato;
            this.buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(8, 499);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(156, 48);
            this.buttonReset.TabIndex = 28;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.IndianRed;
            this.textBoxSearch.Location = new System.Drawing.Point(165, 99);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(432, 48);
            this.textBoxSearch.TabIndex = 29;
            this.textBoxSearch.Text = "Search here....";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // btn_AcctPay
            // 
            this.btn_AcctPay.BackColor = System.Drawing.Color.Turquoise;
            this.btn_AcctPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AcctPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AcctPay.Location = new System.Drawing.Point(1, 238);
            this.btn_AcctPay.Name = "btn_AcctPay";
            this.btn_AcctPay.Size = new System.Drawing.Size(156, 48);
            this.btn_AcctPay.TabIndex = 30;
            this.btn_AcctPay.Text = "Accounts Payable";
            this.btn_AcctPay.UseVisualStyleBackColor = false;
            this.btn_AcctPay.Click += new System.EventHandler(this.Btn_AcctPay_Click);
            // 
            // btn_AcctRec
            // 
            this.btn_AcctRec.BackColor = System.Drawing.Color.Wheat;
            this.btn_AcctRec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AcctRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AcctRec.Location = new System.Drawing.Point(1, 368);
            this.btn_AcctRec.Name = "btn_AcctRec";
            this.btn_AcctRec.Size = new System.Drawing.Size(156, 48);
            this.btn_AcctRec.TabIndex = 31;
            this.btn_AcctRec.Text = "Accounts Recievable";
            this.btn_AcctRec.UseVisualStyleBackColor = false;
            this.btn_AcctRec.Click += new System.EventHandler(this.Btn_AcctRec_Click);
            // 
            // lbl_store
            // 
            this.lbl_store.AutoSize = true;
            this.lbl_store.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_store.ForeColor = System.Drawing.Color.Teal;
            this.lbl_store.Location = new System.Drawing.Point(11, 110);
            this.lbl_store.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_store.Name = "lbl_store";
            this.lbl_store.Size = new System.Drawing.Size(98, 18);
            this.lbl_store.TabIndex = 32;
            this.lbl_store.Text = "Your Store Is:";
            // 
            // lbl_StoreName
            // 
            this.lbl_StoreName.AutoSize = true;
            this.lbl_StoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StoreName.ForeColor = System.Drawing.Color.Teal;
            this.lbl_StoreName.Location = new System.Drawing.Point(8, 148);
            this.lbl_StoreName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StoreName.Name = "lbl_StoreName";
            this.lbl_StoreName.Size = new System.Drawing.Size(150, 36);
            this.lbl_StoreName.TabIndex = 33;
            this.lbl_StoreName.Text = "4001-Indy";
            // 
            // lbl_view
            // 
            this.lbl_view.AutoSize = true;
            this.lbl_view.ForeColor = System.Drawing.Color.Brown;
            this.lbl_view.Location = new System.Drawing.Point(670, 98);
            this.lbl_view.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_view.Name = "lbl_view";
            this.lbl_view.Size = new System.Drawing.Size(121, 17);
            this.lbl_view.TabIndex = 34;
            this.lbl_view.Text = "Currently Viewing:";
            // 
            // lbl_TableViewing
            // 
            this.lbl_TableViewing.AutoSize = true;
            this.lbl_TableViewing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TableViewing.ForeColor = System.Drawing.Color.Brown;
            this.lbl_TableViewing.Location = new System.Drawing.Point(669, 122);
            this.lbl_TableViewing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TableViewing.Name = "lbl_TableViewing";
            this.lbl_TableViewing.Size = new System.Drawing.Size(214, 25);
            this.lbl_TableViewing.TabIndex = 35;
            this.lbl_TableViewing.Text = "Accounts Receivable";
            // 
            // lbl_titlePage
            // 
            this.lbl_titlePage.BackColor = System.Drawing.Color.DarkKhaki;
            this.lbl_titlePage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_titlePage.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titlePage.ForeColor = System.Drawing.Color.DarkCyan;
            this.lbl_titlePage.Location = new System.Drawing.Point(0, 0);
            this.lbl_titlePage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titlePage.Name = "lbl_titlePage";
            this.lbl_titlePage.Size = new System.Drawing.Size(971, 86);
            this.lbl_titlePage.TabIndex = 36;
            this.lbl_titlePage.Text = "Accounting Information";
            this.lbl_titlePage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccountingInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(971, 550);
            this.Controls.Add(this.lbl_TableViewing);
            this.Controls.Add(this.lbl_view);
            this.Controls.Add(this.lbl_StoreName);
            this.Controls.Add(this.lbl_store);
            this.Controls.Add(this.btn_AcctRec);
            this.Controls.Add(this.btn_AcctPay);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.dgv_accounting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbl_titlePage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountingInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountingInformationForm";
            this.Load += new System.EventHandler(this.AccountingInformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_accounting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_accounting;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btn_AcctPay;
        private System.Windows.Forms.Button btn_AcctRec;
        private System.Windows.Forms.Label lbl_store;
        private System.Windows.Forms.Label lbl_StoreName;
        private System.Windows.Forms.Label lbl_view;
        private System.Windows.Forms.Label lbl_TableViewing;
        private System.Windows.Forms.Label lbl_titlePage;
    }
}