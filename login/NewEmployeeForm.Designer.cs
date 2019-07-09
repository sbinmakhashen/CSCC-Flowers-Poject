namespace login
{
    partial class NewEmployeeForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxZip = new System.Windows.Forms.TextBox();
            this.textBoxPay_Rate = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxPasswordConfirm = new System.Windows.Forms.TextBox();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.textBoxCity);
            this.panel1.Controls.Add(this.comboBoxState);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxZip);
            this.panel1.Controls.Add(this.textBoxPay_Rate);
            this.panel1.Controls.Add(this.textBoxStreet);
            this.panel1.Controls.Add(this.textBoxPasswordConfirm);
            this.panel1.Controls.Add(this.textBoxLastname);
            this.panel1.Controls.Add(this.buttonCreateAccount);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxFirstname);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1634, 1310);
            this.panel1.TabIndex = 1;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCity.ForeColor = System.Drawing.Color.Gray;
            this.textBoxCity.Location = new System.Drawing.Point(608, 839);
            this.textBoxCity.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBoxCity.Multiline = true;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(524, 89);
            this.textBoxCity.TabIndex = 260;
            this.textBoxCity.Text = "City";
            this.textBoxCity.Enter += new System.EventHandler(this.textBoxCity_Enter);
            this.textBoxCity.Leave += new System.EventHandler(this.textBoxCity_Leave);
            // 
            // comboBoxState
            // 
            this.comboBoxState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxState.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Items.AddRange(new object[] {
            "OH",
            "PA",
            "MI",
            "IN"});
            this.comboBoxState.Location = new System.Drawing.Point(1408, 839);
            this.comboBoxState.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(154, 91);
            this.comboBoxState.TabIndex = 270;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1152, 837);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 95);
            this.label4.TabIndex = 258;
            this.label4.Text = "State:";
            // 
            // textBoxZip
            // 
            this.textBoxZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZip.ForeColor = System.Drawing.Color.Gray;
            this.textBoxZip.Location = new System.Drawing.Point(138, 839);
            this.textBoxZip.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBoxZip.Multiline = true;
            this.textBoxZip.Name = "textBoxZip";
            this.textBoxZip.Size = new System.Drawing.Size(456, 89);
            this.textBoxZip.TabIndex = 250;
            this.textBoxZip.Text = "Zip";
            this.textBoxZip.Enter += new System.EventHandler(this.textBoxZip_Enter);
            this.textBoxZip.Leave += new System.EventHandler(this.textBoxZip_Leave);
            // 
            // textBoxPay_Rate
            // 
            this.textBoxPay_Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPay_Rate.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPay_Rate.Location = new System.Drawing.Point(136, 982);
            this.textBoxPay_Rate.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBoxPay_Rate.Multiline = true;
            this.textBoxPay_Rate.Name = "textBoxPay_Rate";
            this.textBoxPay_Rate.Size = new System.Drawing.Size(682, 89);
            this.textBoxPay_Rate.TabIndex = 280;
            this.textBoxPay_Rate.Text = "Pay Rate";
            this.textBoxPay_Rate.Enter += new System.EventHandler(this.textBoxPay_Rate_Enter);
            this.textBoxPay_Rate.Leave += new System.EventHandler(this.textBoxPay_Rate_Leave);
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStreet.ForeColor = System.Drawing.Color.Gray;
            this.textBoxStreet.Location = new System.Drawing.Point(138, 699);
            this.textBoxStreet.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBoxStreet.Multiline = true;
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(1426, 89);
            this.textBoxStreet.TabIndex = 240;
            this.textBoxStreet.Text = "Street";
            this.textBoxStreet.Enter += new System.EventHandler(this.textBoxStreet_Enter);
            this.textBoxStreet.Leave += new System.EventHandler(this.textBoxStreet_Leave);
            // 
            // textBoxPasswordConfirm
            // 
            this.textBoxPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPasswordConfirm.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPasswordConfirm.Location = new System.Drawing.Point(144, 554);
            this.textBoxPasswordConfirm.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBoxPasswordConfirm.Name = "textBoxPasswordConfirm";
            this.textBoxPasswordConfirm.Size = new System.Drawing.Size(1426, 90);
            this.textBoxPasswordConfirm.TabIndex = 230;
            this.textBoxPasswordConfirm.Text = "Confirm Password";
            this.textBoxPasswordConfirm.Enter += new System.EventHandler(this.textBoxPasswordConfirm_Enter);
            this.textBoxPasswordConfirm.Leave += new System.EventHandler(this.textBoxPasswordConfirm_Leave);
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastname.ForeColor = System.Drawing.Color.Gray;
            this.textBoxLastname.Location = new System.Drawing.Point(880, 275);
            this.textBoxLastname.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBoxLastname.Multiline = true;
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(686, 89);
            this.textBoxLastname.TabIndex = 210;
            this.textBoxLastname.Text = "Last Name";
            this.textBoxLastname.Enter += new System.EventHandler(this.textBoxLastname_Enter);
            this.textBoxLastname.Leave += new System.EventHandler(this.textBoxLastname_Leave);
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.BackColor = System.Drawing.Color.DarkMagenta;
            this.buttonCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateAccount.FlatAppearance.BorderSize = 0;
            this.buttonCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateAccount.ForeColor = System.Drawing.Color.LightCyan;
            this.buttonCreateAccount.Location = new System.Drawing.Point(136, 1135);
            this.buttonCreateAccount.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(1432, 143);
            this.buttonCreateAccount.TabIndex = 290;
            this.buttonCreateAccount.Text = "CREATE ACCOUNT";
            this.buttonCreateAccount.UseVisualStyleBackColor = false;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPassword.Location = new System.Drawing.Point(144, 407);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(1426, 90);
            this.textBoxPassword.TabIndex = 220;
            this.textBoxPassword.Text = "Password";
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstname.ForeColor = System.Drawing.Color.Gray;
            this.textBoxFirstname.Location = new System.Drawing.Point(138, 275);
            this.textBoxFirstname.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.textBoxFirstname.Multiline = true;
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(686, 89);
            this.textBoxFirstname.TabIndex = 200;
            this.textBoxFirstname.Text = "First Name";
            this.textBoxFirstname.Enter += new System.EventHandler(this.textBoxFirstname_Enter);
            this.textBoxFirstname.Leave += new System.EventHandler(this.textBoxFirstname_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(19)))));
            this.panel2.Controls.Add(this.lbl_date);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-16, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1710, 221);
            this.panel2.TabIndex = 0;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.LightCyan;
            this.lbl_date.Location = new System.Drawing.Point(889, 182);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(225, 39);
            this.lbl_date.TabIndex = 17;
            this.lbl_date.Text = "Today\'s Date:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkMagenta;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCyan;
            this.label2.Location = new System.Drawing.Point(1368, 4);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 54);
            this.label2.TabIndex = 16;
            this.label2.Text = "Previous";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.PapayaWhip;
            this.pictureBox3.Image = global::login.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(16, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(260, 221);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.BackColor = System.Drawing.Color.DarkMagenta;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.LightCyan;
            this.labelClose.Location = new System.Drawing.Point(1600, 4);
            this.labelClose.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(55, 55);
            this.labelClose.TabIndex = 1;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            this.labelClose.MouseEnter += new System.EventHandler(this.labelClose_MouseEnter);
            this.labelClose.MouseLeave += new System.EventHandler(this.labelClose_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkMagenta;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1710, 221);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Employee";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1634, 1310);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "NewEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPasswordConfirm;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.TextBox textBoxPay_Rate;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxZip;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label lbl_date;
    }
}