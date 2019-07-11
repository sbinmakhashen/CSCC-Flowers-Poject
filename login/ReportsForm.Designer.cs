namespace login
{
    partial class ReportsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelClose = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_reports = new System.Windows.Forms.DataGridView();
            this.lbl_titlePage = new System.Windows.Forms.Label();
            this.btn_GeneralLedger = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_store = new System.Windows.Forms.Label();
            this.lbl_StoreName = new System.Windows.Forms.Label();
            this.btn_ProfitLoss = new System.Windows.Forms.Button();
            this.btn_CashFlow = new System.Windows.Forms.Button();
            this.btn_Balance = new System.Windows.Forms.Button();
            this.cmBx_Month = new System.Windows.Forms.ComboBox();
            this.txt_Year = new System.Windows.Forms.TextBox();
            this.lbl_month = new System.Windows.Forms.Label();
            this.lbl_Report = new System.Windows.Forms.Label();
            this.lbl_ReportName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reports)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.PapayaWhip;
            this.pictureBox3.Image = global::login.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(260, 153);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.Black;
            this.labelClose.Location = new System.Drawing.Point(2122, 0);
            this.labelClose.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(55, 55);
            this.labelClose.TabIndex = 8;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1866, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 54);
            this.label2.TabIndex = 16;
            this.label2.Text = "Previous";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgv_reports
            // 
            this.dgv_reports.AllowUserToAddRows = false;
            this.dgv_reports.AllowUserToDeleteRows = false;
            this.dgv_reports.AllowUserToOrderColumns = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Indigo;
            this.dgv_reports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_reports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_reports.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_reports.ColumnHeadersHeight = 58;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_reports.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_reports.Location = new System.Drawing.Point(389, 331);
            this.dgv_reports.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_reports.Name = "dgv_reports";
            this.dgv_reports.ReadOnly = true;
            this.dgv_reports.RowHeadersWidth = 102;
            this.dgv_reports.RowTemplate.Height = 24;
            this.dgv_reports.ShowEditingIcon = false;
            this.dgv_reports.Size = new System.Drawing.Size(1717, 659);
            this.dgv_reports.TabIndex = 17;
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
            this.lbl_titlePage.Size = new System.Drawing.Size(2173, 153);
            this.lbl_titlePage.TabIndex = 32;
            this.lbl_titlePage.Text = "Reports";
            this.lbl_titlePage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_GeneralLedger
            // 
            this.btn_GeneralLedger.BackColor = System.Drawing.Color.Coral;
            this.btn_GeneralLedger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GeneralLedger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GeneralLedger.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_GeneralLedger.Location = new System.Drawing.Point(16, 331);
            this.btn_GeneralLedger.Margin = new System.Windows.Forms.Padding(6);
            this.btn_GeneralLedger.Name = "btn_GeneralLedger";
            this.btn_GeneralLedger.Size = new System.Drawing.Size(344, 87);
            this.btn_GeneralLedger.TabIndex = 33;
            this.btn_GeneralLedger.Text = "General Ledger";
            this.btn_GeneralLedger.UseVisualStyleBackColor = false;
            this.btn_GeneralLedger.Click += new System.EventHandler(this.Btn_GeneralLedger_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_date.Location = new System.Drawing.Point(1388, 121);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(216, 32);
            this.lbl_date.TabIndex = 34;
            this.lbl_date.Text = "Today\'s Date is:";
            // 
            // lbl_store
            // 
            this.lbl_store.AutoSize = true;
            this.lbl_store.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_store.ForeColor = System.Drawing.Color.Coral;
            this.lbl_store.Location = new System.Drawing.Point(20, 195);
            this.lbl_store.Name = "lbl_store";
            this.lbl_store.Size = new System.Drawing.Size(229, 32);
            this.lbl_store.TabIndex = 35;
            this.lbl_store.Text = "Currently Store:";
            // 
            // lbl_StoreName
            // 
            this.lbl_StoreName.AutoSize = true;
            this.lbl_StoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StoreName.ForeColor = System.Drawing.Color.Coral;
            this.lbl_StoreName.Location = new System.Drawing.Point(12, 227);
            this.lbl_StoreName.Name = "lbl_StoreName";
            this.lbl_StoreName.Size = new System.Drawing.Size(296, 61);
            this.lbl_StoreName.TabIndex = 36;
            this.lbl_StoreName.Text = "4000-INDY";
            // 
            // btn_ProfitLoss
            // 
            this.btn_ProfitLoss.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_ProfitLoss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ProfitLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btn_ProfitLoss.Location = new System.Drawing.Point(16, 430);
            this.btn_ProfitLoss.Margin = new System.Windows.Forms.Padding(6);
            this.btn_ProfitLoss.Name = "btn_ProfitLoss";
            this.btn_ProfitLoss.Size = new System.Drawing.Size(344, 93);
            this.btn_ProfitLoss.TabIndex = 37;
            this.btn_ProfitLoss.Text = "Profit/Loss Report";
            this.btn_ProfitLoss.UseVisualStyleBackColor = false;
            this.btn_ProfitLoss.Click += new System.EventHandler(this.Btn_ProfitLoss_Click);
            // 
            // btn_CashFlow
            // 
            this.btn_CashFlow.BackColor = System.Drawing.Color.LightGreen;
            this.btn_CashFlow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CashFlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btn_CashFlow.Location = new System.Drawing.Point(16, 535);
            this.btn_CashFlow.Margin = new System.Windows.Forms.Padding(6);
            this.btn_CashFlow.Name = "btn_CashFlow";
            this.btn_CashFlow.Size = new System.Drawing.Size(344, 93);
            this.btn_CashFlow.TabIndex = 38;
            this.btn_CashFlow.Text = "Cash Flow Report";
            this.btn_CashFlow.UseVisualStyleBackColor = false;
            // 
            // btn_Balance
            // 
            this.btn_Balance.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Balance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btn_Balance.Location = new System.Drawing.Point(16, 640);
            this.btn_Balance.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Balance.Name = "btn_Balance";
            this.btn_Balance.Size = new System.Drawing.Size(344, 93);
            this.btn_Balance.TabIndex = 39;
            this.btn_Balance.Text = "Balance Statement";
            this.btn_Balance.UseVisualStyleBackColor = false;
            // 
            // cmBx_Month
            // 
            this.cmBx_Month.AllowDrop = true;
            this.cmBx_Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBx_Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmBx_Month.FormattingEnabled = true;
            this.cmBx_Month.Items.AddRange(new object[] {
            "January",
            "Feburary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November"});
            this.cmBx_Month.Location = new System.Drawing.Point(26, 1052);
            this.cmBx_Month.Name = "cmBx_Month";
            this.cmBx_Month.Size = new System.Drawing.Size(334, 46);
            this.cmBx_Month.TabIndex = 40;
            // 
            // txt_Year
            // 
            this.txt_Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Year.Location = new System.Drawing.Point(389, 1053);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Size = new System.Drawing.Size(149, 45);
            this.txt_Year.TabIndex = 41;
            this.txt_Year.Text = "Year";
            // 
            // lbl_month
            // 
            this.lbl_month.AutoSize = true;
            this.lbl_month.ForeColor = System.Drawing.Color.LightSalmon;
            this.lbl_month.Location = new System.Drawing.Point(20, 1004);
            this.lbl_month.Name = "lbl_month";
            this.lbl_month.Size = new System.Drawing.Size(102, 32);
            this.lbl_month.TabIndex = 42;
            this.lbl_month.Text = "Month:";
            // 
            // lbl_Report
            // 
            this.lbl_Report.AutoSize = true;
            this.lbl_Report.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Report.Location = new System.Drawing.Point(1388, 195);
            this.lbl_Report.Name = "lbl_Report";
            this.lbl_Report.Size = new System.Drawing.Size(246, 32);
            this.lbl_Report.TabIndex = 43;
            this.lbl_Report.Text = "Currently Viewing:";
            // 
            // lbl_ReportName
            // 
            this.lbl_ReportName.AutoSize = true;
            this.lbl_ReportName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReportName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_ReportName.Location = new System.Drawing.Point(1383, 227);
            this.lbl_ReportName.Name = "lbl_ReportName";
            this.lbl_ReportName.Size = new System.Drawing.Size(416, 63);
            this.lbl_ReportName.TabIndex = 44;
            this.lbl_ReportName.Text = "General Ledger";
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(2173, 1124);
            this.Controls.Add(this.lbl_ReportName);
            this.Controls.Add(this.lbl_Report);
            this.Controls.Add(this.lbl_month);
            this.Controls.Add(this.txt_Year);
            this.Controls.Add(this.cmBx_Month);
            this.Controls.Add(this.btn_Balance);
            this.Controls.Add(this.btn_CashFlow);
            this.Controls.Add(this.btn_ProfitLoss);
            this.Controls.Add(this.lbl_StoreName);
            this.Controls.Add(this.lbl_store);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.btn_GeneralLedger);
            this.Controls.Add(this.dgv_reports);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbl_titlePage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports Lobby";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_reports;
        private System.Windows.Forms.Label lbl_titlePage;
        private System.Windows.Forms.Button btn_GeneralLedger;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_store;
        private System.Windows.Forms.Label lbl_StoreName;
        private System.Windows.Forms.Button btn_ProfitLoss;
        private System.Windows.Forms.Button btn_CashFlow;
        private System.Windows.Forms.Button btn_Balance;
        private System.Windows.Forms.ComboBox cmBx_Month;
        private System.Windows.Forms.TextBox txt_Year;
        private System.Windows.Forms.Label lbl_month;
        private System.Windows.Forms.Label lbl_Report;
        private System.Windows.Forms.Label lbl_ReportName;
    }
}