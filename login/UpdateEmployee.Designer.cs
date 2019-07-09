namespace login
{
    partial class UpdateEmployee
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.text_Username = new System.Windows.Forms.TextBox();
            this.txt_FName = new System.Windows.Forms.TextBox();
            this.txt_LName = new System.Windows.Forms.TextBox();
            this.txt_Street = new System.Windows.Forms.TextBox();
            this.drpd_State = new System.Windows.Forms.ComboBox();
            this.txt_Zip = new System.Windows.Forms.TextBox();
            this.drpd_store = new System.Windows.Forms.ComboBox();
            this.txt_Pay = new System.Windows.Forms.TextBox();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Terminate = new System.Windows.Forms.Button();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_hired = new System.Windows.Forms.Label();
            this.lbl_terminated = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Search.Location = new System.Drawing.Point(242, 644);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(147, 48);
            this.btn_Search.TabIndex = 30;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // text_Username
            // 
            this.text_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Username.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.text_Username.Location = new System.Drawing.Point(9, 644);
            this.text_Username.Margin = new System.Windows.Forms.Padding(4);
            this.text_Username.Name = "text_Username";
            this.text_Username.Size = new System.Drawing.Size(212, 49);
            this.text_Username.TabIndex = 20;
            this.text_Username.Text = "Username";
            this.text_Username.Enter += new System.EventHandler(this.text_Username_Enter);
            this.text_Username.Leave += new System.EventHandler(this.text_Username_Leave);
            // 
            // txt_FName
            // 
            this.txt_FName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txt_FName.Location = new System.Drawing.Point(9, 140);
            this.txt_FName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_FName.Name = "txt_FName";
            this.txt_FName.Size = new System.Drawing.Size(374, 49);
            this.txt_FName.TabIndex = 100;
            this.txt_FName.Text = "First Name";
            this.txt_FName.Click += new System.EventHandler(this.txt_FName_Click);
            this.txt_FName.Enter += new System.EventHandler(this.txt_FName_Enter);
            this.txt_FName.Leave += new System.EventHandler(this.txt_FName_Leave);
            // 
            // txt_LName
            // 
            this.txt_LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txt_LName.Location = new System.Drawing.Point(408, 140);
            this.txt_LName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LName.Multiline = true;
            this.txt_LName.Name = "txt_LName";
            this.txt_LName.Size = new System.Drawing.Size(361, 49);
            this.txt_LName.TabIndex = 110;
            this.txt_LName.Text = "Last Name";
            this.txt_LName.Click += new System.EventHandler(this.txt_LName_Click);
            this.txt_LName.Enter += new System.EventHandler(this.txt_LName_Enter);
            this.txt_LName.Leave += new System.EventHandler(this.txt_LName_Leave);
            // 
            // txt_Street
            // 
            this.txt_Street.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Street.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txt_Street.Location = new System.Drawing.Point(10, 231);
            this.txt_Street.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Street.Name = "txt_Street";
            this.txt_Street.Size = new System.Drawing.Size(760, 49);
            this.txt_Street.TabIndex = 120;
            this.txt_Street.Text = "Street";
            this.txt_Street.Click += new System.EventHandler(this.txt_Street_Click);
            this.txt_Street.Enter += new System.EventHandler(this.txt_Street_Enter);
            this.txt_Street.Leave += new System.EventHandler(this.txt_Street_Leave);
            // 
            // drpd_State
            // 
            this.drpd_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpd_State.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.drpd_State.FormattingEnabled = true;
            this.drpd_State.Items.AddRange(new object[] {
            "OH",
            "PA",
            "MI",
            "IN"});
            this.drpd_State.Location = new System.Drawing.Point(408, 335);
            this.drpd_State.Margin = new System.Windows.Forms.Padding(4);
            this.drpd_State.Name = "drpd_State";
            this.drpd_State.Size = new System.Drawing.Size(126, 50);
            this.drpd_State.TabIndex = 150;
            this.drpd_State.Text = "State";
            this.drpd_State.Click += new System.EventHandler(this.drpd_State_Click);
            this.drpd_State.Enter += new System.EventHandler(this.drpd_State_Enter);
            this.drpd_State.Leave += new System.EventHandler(this.drpd_State_Leave);
            // 
            // txt_Zip
            // 
            this.txt_Zip.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Zip.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txt_Zip.Location = new System.Drawing.Point(562, 335);
            this.txt_Zip.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Zip.Name = "txt_Zip";
            this.txt_Zip.Size = new System.Drawing.Size(208, 49);
            this.txt_Zip.TabIndex = 160;
            this.txt_Zip.Text = "Zip";
            this.txt_Zip.Click += new System.EventHandler(this.txt_Zip_Click);
            this.txt_Zip.Enter += new System.EventHandler(this.txt_Zip_Enter);
            this.txt_Zip.Leave += new System.EventHandler(this.txt_Zip_Leave);
            // 
            // drpd_store
            // 
            this.drpd_store.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpd_store.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.drpd_store.FormattingEnabled = true;
            this.drpd_store.Items.AddRange(new object[] {
            "1000-Col",
            "1001-Col",
            "2000-Pitt",
            "2001-Pitt",
            "3000-Det",
            "3001-Det",
            "4000-Indy",
            "4001-Indy"});
            this.drpd_store.Location = new System.Drawing.Point(9, 424);
            this.drpd_store.Margin = new System.Windows.Forms.Padding(4);
            this.drpd_store.Name = "drpd_store";
            this.drpd_store.Size = new System.Drawing.Size(374, 50);
            this.drpd_store.TabIndex = 170;
            this.drpd_store.Text = "Store";
            this.drpd_store.Click += new System.EventHandler(this.drpd_store_Click);
            this.drpd_store.Enter += new System.EventHandler(this.drpd_store_Enter);
            this.drpd_store.Leave += new System.EventHandler(this.drpd_store_Leave);
            // 
            // txt_Pay
            // 
            this.txt_Pay.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pay.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txt_Pay.Location = new System.Drawing.Point(408, 425);
            this.txt_Pay.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Pay.Name = "txt_Pay";
            this.txt_Pay.Size = new System.Drawing.Size(361, 49);
            this.txt_Pay.TabIndex = 180;
            this.txt_Pay.Text = "Pay Rate";
            this.txt_Pay.Click += new System.EventHandler(this.txt_Pay_Click);
            this.txt_Pay.Enter += new System.EventHandler(this.txt_Pay_Enter);
            this.txt_Pay.Leave += new System.EventHandler(this.txt_Pay_Leave);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(422, 644);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(156, 48);
            this.btn_Update.TabIndex = 190;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // btn_Terminate
            // 
            this.btn_Terminate.BackColor = System.Drawing.Color.Maroon;
            this.btn_Terminate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Terminate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Terminate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_Terminate.Location = new System.Drawing.Point(611, 644);
            this.btn_Terminate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Terminate.Name = "btn_Terminate";
            this.btn_Terminate.Size = new System.Drawing.Size(156, 48);
            this.btn_Terminate.TabIndex = 0;
            this.btn_Terminate.Text = "Terminate";
            this.btn_Terminate.UseVisualStyleBackColor = false;
            this.btn_Terminate.Click += new System.EventHandler(this.Btn_Terminate_Click);
            // 
            // txt_city
            // 
            this.txt_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_city.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txt_city.Location = new System.Drawing.Point(9, 335);
            this.txt_city.Margin = new System.Windows.Forms.Padding(4);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(374, 49);
            this.txt_city.TabIndex = 140;
            this.txt_city.Text = "City";
            this.txt_city.Click += new System.EventHandler(this.txt_city_Click);
            this.txt_city.Enter += new System.EventHandler(this.txt_city_Enter);
            this.txt_city.Leave += new System.EventHandler(this.txt_city_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.panel2.Controls.Add(this.lbl_date);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 114);
            this.panel2.TabIndex = 191;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_date.Location = new System.Drawing.Point(286, 85);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(96, 18);
            this.lbl_date.TabIndex = 17;
            this.lbl_date.Text = "Todays Date:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(631, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Previous";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.PapayaWhip;
            this.pictureBox3.Image = global::login.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(-7, -4);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(116, 118);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.White;
            this.labelClose.Location = new System.Drawing.Point(758, 1);
            this.labelClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(27, 27);
            this.labelClose.TabIndex = 1;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PeachPuff;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(789, 114);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Employee";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(2, 487);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(192, 39);
            this.lbl_username.TabIndex = 192;
            this.lbl_username.Text = "Username: ";
            // 
            // lbl_hired
            // 
            this.lbl_hired.AutoSize = true;
            this.lbl_hired.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hired.Location = new System.Drawing.Point(4, 527);
            this.lbl_hired.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_hired.Name = "lbl_hired";
            this.lbl_hired.Size = new System.Drawing.Size(189, 39);
            this.lbl_hired.TabIndex = 193;
            this.lbl_hired.Text = "Date Hired:";
            // 
            // lbl_terminated
            // 
            this.lbl_terminated.AutoSize = true;
            this.lbl_terminated.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_terminated.ForeColor = System.Drawing.Color.Brown;
            this.lbl_terminated.Location = new System.Drawing.Point(2, 567);
            this.lbl_terminated.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_terminated.Name = "lbl_terminated";
            this.lbl_terminated.Size = new System.Drawing.Size(198, 39);
            this.lbl_terminated.TabIndex = 194;
            this.lbl_terminated.Text = "Terminated:";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.Location = new System.Drawing.Point(402, 487);
            this.lbl_type.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(111, 39);
            this.lbl_type.TabIndex = 195;
            this.lbl_type.Text = "Type: ";
            // 
            // UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(785, 719);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.lbl_terminated);
            this.Controls.Add(this.lbl_hired);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.btn_Terminate);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.txt_Pay);
            this.Controls.Add(this.drpd_store);
            this.Controls.Add(this.txt_Zip);
            this.Controls.Add(this.drpd_State);
            this.Controls.Add(this.txt_Street);
            this.Controls.Add(this.txt_LName);
            this.Controls.Add(this.txt_FName);
            this.Controls.Add(this.text_Username);
            this.Controls.Add(this.btn_Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox text_Username;
        private System.Windows.Forms.TextBox txt_FName;
        private System.Windows.Forms.TextBox txt_LName;
        private System.Windows.Forms.TextBox txt_Street;
        private System.Windows.Forms.ComboBox drpd_State;
        private System.Windows.Forms.TextBox txt_Zip;
        private System.Windows.Forms.ComboBox drpd_store;
        private System.Windows.Forms.TextBox txt_Pay;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Terminate;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_hired;
        private System.Windows.Forms.Label lbl_terminated;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_date;
    }
}