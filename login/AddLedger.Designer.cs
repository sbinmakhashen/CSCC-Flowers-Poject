namespace login
{
    partial class AddLedger
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
            this.Previous_pic = new System.Windows.Forms.PictureBox();
            this.Close_pic = new System.Windows.Forms.PictureBox();
            this.cmb_Type = new System.Windows.Forms.ComboBox();
            this.lbl_entryType = new System.Windows.Forms.Label();
            this.cmb_Particular = new System.Windows.Forms.ComboBox();
            this.lbl_entryParticular = new System.Windows.Forms.Label();
            this.lbl_entryAmt = new System.Windows.Forms.Label();
            this.txt_Amt = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_StoreName = new System.Windows.Forms.Label();
            this.lbl_store = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_entryDetail = new System.Windows.Forms.Label();
            this.cmb_Detail = new System.Windows.Forms.ComboBox();
            this.txt_ItemID = new System.Windows.Forms.TextBox();
            this.lbl_entryItem = new System.Windows.Forms.Label();
            this.txt_Correction = new System.Windows.Forms.TextBox();
            this.lbl_entryCorrection = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_titlePage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Previous_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Previous_pic
            // 
            this.Previous_pic.BackColor = System.Drawing.Color.BurlyWood;
            this.Previous_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Previous_pic.Image = global::login.Properties.Resources.previous_blue;
            this.Previous_pic.Location = new System.Drawing.Point(2922, -2);
            this.Previous_pic.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Previous_pic.Name = "Previous_pic";
            this.Previous_pic.Size = new System.Drawing.Size(78, 78);
            this.Previous_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Previous_pic.TabIndex = 51;
            this.Previous_pic.TabStop = false;
            this.Previous_pic.Click += new System.EventHandler(this.Previous_pic_Click);
            // 
            // Close_pic
            // 
            this.Close_pic.BackColor = System.Drawing.Color.BurlyWood;
            this.Close_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_pic.Image = global::login.Properties.Resources.close;
            this.Close_pic.Location = new System.Drawing.Point(3034, -2);
            this.Close_pic.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Close_pic.Name = "Close_pic";
            this.Close_pic.Size = new System.Drawing.Size(76, 78);
            this.Close_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close_pic.TabIndex = 50;
            this.Close_pic.TabStop = false;
            this.Close_pic.Click += new System.EventHandler(this.Close_pic_Click);
            // 
            // cmb_Type
            // 
            this.cmb_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Type.FormattingEnabled = true;
            this.cmb_Type.Items.AddRange(new object[] {
            "Sales",
            "Expense",
            "Utilities",
            "Payroll",
            "Inventory Purchase",
            "Correction"});
            this.cmb_Type.Location = new System.Drawing.Point(600, 500);
            this.cmb_Type.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_Type.Name = "cmb_Type";
            this.cmb_Type.Size = new System.Drawing.Size(560, 61);
            this.cmb_Type.TabIndex = 52;
            this.cmb_Type.SelectedIndexChanged += new System.EventHandler(this.Cmb_Type_SelectedIndexChanged);
            // 
            // lbl_entryType
            // 
            this.lbl_entryType.AutoSize = true;
            this.lbl_entryType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_entryType.Location = new System.Drawing.Point(60, 500);
            this.lbl_entryType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_entryType.Name = "lbl_entryType";
            this.lbl_entryType.Size = new System.Drawing.Size(128, 54);
            this.lbl_entryType.TabIndex = 53;
            this.lbl_entryType.Text = "Type";
            // 
            // cmb_Particular
            // 
            this.cmb_Particular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Particular.FormattingEnabled = true;
            this.cmb_Particular.Items.AddRange(new object[] {
            "Vendor Expense",
            "Petty Cash",
            "Marketing",
            "Emergency Repair"});
            this.cmb_Particular.Location = new System.Drawing.Point(2300, 500);
            this.cmb_Particular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_Particular.Name = "cmb_Particular";
            this.cmb_Particular.Size = new System.Drawing.Size(560, 61);
            this.cmb_Particular.TabIndex = 54;
            this.cmb_Particular.SelectedIndexChanged += new System.EventHandler(this.Cmb_Particular_SelectedIndexChanged);
            // 
            // lbl_entryParticular
            // 
            this.lbl_entryParticular.AutoSize = true;
            this.lbl_entryParticular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_entryParticular.Location = new System.Drawing.Point(1750, 500);
            this.lbl_entryParticular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_entryParticular.Name = "lbl_entryParticular";
            this.lbl_entryParticular.Size = new System.Drawing.Size(221, 54);
            this.lbl_entryParticular.TabIndex = 55;
            this.lbl_entryParticular.Text = "Particular";
            // 
            // lbl_entryAmt
            // 
            this.lbl_entryAmt.AutoSize = true;
            this.lbl_entryAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_entryAmt.Location = new System.Drawing.Point(60, 1000);
            this.lbl_entryAmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_entryAmt.Name = "lbl_entryAmt";
            this.lbl_entryAmt.Size = new System.Drawing.Size(184, 54);
            this.lbl_entryAmt.TabIndex = 56;
            this.lbl_entryAmt.Text = "Amount";
            // 
            // txt_Amt
            // 
            this.txt_Amt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Amt.Location = new System.Drawing.Point(600, 1000);
            this.txt_Amt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Amt.Name = "txt_Amt";
            this.txt_Amt.Size = new System.Drawing.Size(560, 60);
            this.txt_Amt.TabIndex = 57;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(1282, 1269);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(458, 159);
            this.btn_add.TabIndex = 58;
            this.btn_add.Text = "Add New Item";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // lbl_StoreName
            // 
            this.lbl_StoreName.AutoSize = true;
            this.lbl_StoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StoreName.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_StoreName.Location = new System.Drawing.Point(4, 298);
            this.lbl_StoreName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_StoreName.Name = "lbl_StoreName";
            this.lbl_StoreName.Size = new System.Drawing.Size(327, 75);
            this.lbl_StoreName.TabIndex = 60;
            this.lbl_StoreName.Text = "4001-Indy";
            // 
            // lbl_store
            // 
            this.lbl_store.AutoSize = true;
            this.lbl_store.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_store.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lbl_store.Location = new System.Drawing.Point(8, 192);
            this.lbl_store.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_store.Name = "lbl_store";
            this.lbl_store.Size = new System.Drawing.Size(308, 54);
            this.lbl_store.TabIndex = 59;
            this.lbl_store.Text = "Your Store Is:";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(2154, 135);
            this.lbl_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(347, 54);
            this.lbl_Date.TabIndex = 61;
            this.lbl_Date.Text = "Today\'s Date Is";
            // 
            // lbl_entryDetail
            // 
            this.lbl_entryDetail.AutoSize = true;
            this.lbl_entryDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_entryDetail.Location = new System.Drawing.Point(1750, 750);
            this.lbl_entryDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_entryDetail.Name = "lbl_entryDetail";
            this.lbl_entryDetail.Size = new System.Drawing.Size(316, 54);
            this.lbl_entryDetail.TabIndex = 63;
            this.lbl_entryDetail.Text = "Detail Reason";
            // 
            // cmb_Detail
            // 
            this.cmb_Detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Detail.FormattingEnabled = true;
            this.cmb_Detail.Items.AddRange(new object[] {
            "Lunch",
            "Dinner",
            "Supplies",
            "Incentive",
            "Other"});
            this.cmb_Detail.Location = new System.Drawing.Point(2300, 750);
            this.cmb_Detail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_Detail.Name = "cmb_Detail";
            this.cmb_Detail.Size = new System.Drawing.Size(560, 61);
            this.cmb_Detail.TabIndex = 64;
            // 
            // txt_ItemID
            // 
            this.txt_ItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ItemID.Location = new System.Drawing.Point(600, 750);
            this.txt_ItemID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ItemID.Name = "txt_ItemID";
            this.txt_ItemID.Size = new System.Drawing.Size(560, 60);
            this.txt_ItemID.TabIndex = 66;
            // 
            // lbl_entryItem
            // 
            this.lbl_entryItem.AutoSize = true;
            this.lbl_entryItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_entryItem.Location = new System.Drawing.Point(60, 750);
            this.lbl_entryItem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_entryItem.Name = "lbl_entryItem";
            this.lbl_entryItem.Size = new System.Drawing.Size(320, 54);
            this.lbl_entryItem.TabIndex = 65;
            this.lbl_entryItem.Text = "Inventory Item";
            // 
            // txt_Correction
            // 
            this.txt_Correction.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Correction.Location = new System.Drawing.Point(2300, 1000);
            this.txt_Correction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Correction.Name = "txt_Correction";
            this.txt_Correction.Size = new System.Drawing.Size(560, 60);
            this.txt_Correction.TabIndex = 68;
            // 
            // lbl_entryCorrection
            // 
            this.lbl_entryCorrection.AutoSize = true;
            this.lbl_entryCorrection.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_entryCorrection.Location = new System.Drawing.Point(1750, 1000);
            this.lbl_entryCorrection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_entryCorrection.Name = "lbl_entryCorrection";
            this.lbl_entryCorrection.Size = new System.Drawing.Size(414, 54);
            this.lbl_entryCorrection.TabIndex = 67;
            this.lbl_entryCorrection.Text = "Correction Reason";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.PapayaWhip;
            this.pictureBox3.Image = global::login.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(2, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(322, 186);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 69;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_titlePage
            // 
            this.lbl_titlePage.BackColor = System.Drawing.Color.BurlyWood;
            this.lbl_titlePage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_titlePage.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titlePage.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbl_titlePage.Location = new System.Drawing.Point(0, 0);
            this.lbl_titlePage.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_titlePage.Name = "lbl_titlePage";
            this.lbl_titlePage.Size = new System.Drawing.Size(3108, 186);
            this.lbl_titlePage.TabIndex = 70;
            this.lbl_titlePage.Text = "Add Ledger";
            this.lbl_titlePage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(3108, 1449);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txt_Correction);
            this.Controls.Add(this.lbl_entryCorrection);
            this.Controls.Add(this.txt_ItemID);
            this.Controls.Add(this.lbl_entryItem);
            this.Controls.Add(this.cmb_Detail);
            this.Controls.Add(this.lbl_entryDetail);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_StoreName);
            this.Controls.Add(this.lbl_store);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_Amt);
            this.Controls.Add(this.lbl_entryAmt);
            this.Controls.Add(this.lbl_entryParticular);
            this.Controls.Add(this.cmb_Particular);
            this.Controls.Add(this.lbl_entryType);
            this.Controls.Add(this.cmb_Type);
            this.Controls.Add(this.Previous_pic);
            this.Controls.Add(this.Close_pic);
            this.Controls.Add(this.lbl_titlePage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddLedger";
            this.Text = "AddLedger";
            ((System.ComponentModel.ISupportInitialize)(this.Previous_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Previous_pic;
        private System.Windows.Forms.PictureBox Close_pic;
        private System.Windows.Forms.ComboBox cmb_Type;
        private System.Windows.Forms.Label lbl_entryType;
        private System.Windows.Forms.ComboBox cmb_Particular;
        private System.Windows.Forms.Label lbl_entryParticular;
        private System.Windows.Forms.Label lbl_entryAmt;
        private System.Windows.Forms.TextBox txt_Amt;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lbl_StoreName;
        private System.Windows.Forms.Label lbl_store;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_entryDetail;
        private System.Windows.Forms.ComboBox cmb_Detail;
        private System.Windows.Forms.TextBox txt_ItemID;
        private System.Windows.Forms.Label lbl_entryItem;
        private System.Windows.Forms.TextBox txt_Correction;
        private System.Windows.Forms.Label lbl_entryCorrection;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_titlePage;
    }
}