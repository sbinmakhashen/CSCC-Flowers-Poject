namespace login
{
    partial class ChangePW
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
            this.lbl_DisplayUsername = new System.Windows.Forms.Label();
            this.txt_CurrentPW = new System.Windows.Forms.TextBox();
            this.txt_NewPW = new System.Windows.Forms.TextBox();
            this.txt_ConfirmNewPW = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_ChgPW = new System.Windows.Forms.Button();
            this.btn_NotYou = new System.Windows.Forms.Button();
            this.lbl_logout = new System.Windows.Forms.Label();
            this.lbl_Previous = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_titlePage = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.checkBox_show_hide = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_DisplayUsername
            // 
            this.lbl_DisplayUsername.AutoSize = true;
            this.lbl_DisplayUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DisplayUsername.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_DisplayUsername.Location = new System.Drawing.Point(13, 183);
            this.lbl_DisplayUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DisplayUsername.Name = "lbl_DisplayUsername";
            this.lbl_DisplayUsername.Size = new System.Drawing.Size(360, 46);
            this.lbl_DisplayUsername.TabIndex = 0;
            this.lbl_DisplayUsername.Text = "Your Username is: ";
            // 
            // txt_CurrentPW
            // 
            this.txt_CurrentPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CurrentPW.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txt_CurrentPW.Location = new System.Drawing.Point(374, 298);
            this.txt_CurrentPW.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CurrentPW.Name = "txt_CurrentPW";
            this.txt_CurrentPW.Size = new System.Drawing.Size(714, 91);
            this.txt_CurrentPW.TabIndex = 4;
            this.txt_CurrentPW.Text = "Current Password";
            this.txt_CurrentPW.Enter += new System.EventHandler(this.txt_CurrentPW_Enter);
            this.txt_CurrentPW.Leave += new System.EventHandler(this.txt_CurrentPW_Leave);
            // 
            // txt_NewPW
            // 
            this.txt_NewPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NewPW.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txt_NewPW.Location = new System.Drawing.Point(374, 412);
            this.txt_NewPW.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NewPW.Name = "txt_NewPW";
            this.txt_NewPW.Size = new System.Drawing.Size(714, 82);
            this.txt_NewPW.TabIndex = 5;
            this.txt_NewPW.Text = "New Password";
            this.txt_NewPW.Enter += new System.EventHandler(this.txt_NewPW_Enter);
            this.txt_NewPW.Leave += new System.EventHandler(this.txt_NewPW_Leave);
            // 
            // txt_ConfirmNewPW
            // 
            this.txt_ConfirmNewPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmNewPW.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txt_ConfirmNewPW.Location = new System.Drawing.Point(374, 523);
            this.txt_ConfirmNewPW.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ConfirmNewPW.Name = "txt_ConfirmNewPW";
            this.txt_ConfirmNewPW.Size = new System.Drawing.Size(714, 82);
            this.txt_ConfirmNewPW.TabIndex = 6;
            this.txt_ConfirmNewPW.Text = "Confirm New Password";
            this.txt_ConfirmNewPW.Enter += new System.EventHandler(this.txt_ConfirmNewPW_Enter);
            this.txt_ConfirmNewPW.Leave += new System.EventHandler(this.txt_ConfirmNewPW_Leave);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_username.Location = new System.Drawing.Point(366, 183);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(126, 46);
            this.lbl_username.TabIndex = 7;
            this.lbl_username.Text = "label1";
            // 
            // btn_ChgPW
            // 
            this.btn_ChgPW.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_ChgPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChgPW.Location = new System.Drawing.Point(465, 629);
            this.btn_ChgPW.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ChgPW.Name = "btn_ChgPW";
            this.btn_ChgPW.Size = new System.Drawing.Size(494, 93);
            this.btn_ChgPW.TabIndex = 8;
            this.btn_ChgPW.Text = "Change Password";
            this.btn_ChgPW.UseVisualStyleBackColor = false;
            this.btn_ChgPW.Click += new System.EventHandler(this.Btn_ChgPW_Click);
            // 
            // btn_NotYou
            // 
            this.btn_NotYou.BackColor = System.Drawing.Color.Green;
            this.btn_NotYou.Location = new System.Drawing.Point(558, 870);
            this.btn_NotYou.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NotYou.Name = "btn_NotYou";
            this.btn_NotYou.Size = new System.Drawing.Size(260, 95);
            this.btn_NotYou.TabIndex = 9;
            this.btn_NotYou.Text = "Not You?";
            this.btn_NotYou.UseVisualStyleBackColor = false;
            this.btn_NotYou.Click += new System.EventHandler(this.Btn_NotYou_Click);
            // 
            // lbl_logout
            // 
            this.lbl_logout.AutoSize = true;
            this.lbl_logout.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logout.Location = new System.Drawing.Point(1436, 0);
            this.lbl_logout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_logout.Name = "lbl_logout";
            this.lbl_logout.Size = new System.Drawing.Size(54, 54);
            this.lbl_logout.TabIndex = 10;
            this.lbl_logout.Text = "X";
            this.lbl_logout.Click += new System.EventHandler(this.Lbl_logout_Click);
            // 
            // lbl_Previous
            // 
            this.lbl_Previous.AutoSize = true;
            this.lbl_Previous.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl_Previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Previous.Location = new System.Drawing.Point(1214, 0);
            this.lbl_Previous.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Previous.Name = "lbl_Previous";
            this.lbl_Previous.Size = new System.Drawing.Size(206, 54);
            this.lbl_Previous.TabIndex = 11;
            this.lbl_Previous.Text = "Previous";
            this.lbl_Previous.Click += new System.EventHandler(this.Lbl_Previous_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_date.Location = new System.Drawing.Point(865, 135);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(223, 32);
            this.lbl_date.TabIndex = 12;
            this.lbl_date.Text = "Today\'s Date is: ";
            // 
            // lbl_titlePage
            // 
            this.lbl_titlePage.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl_titlePage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_titlePage.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titlePage.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbl_titlePage.Location = new System.Drawing.Point(0, 0);
            this.lbl_titlePage.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lbl_titlePage.Name = "lbl_titlePage";
            this.lbl_titlePage.Size = new System.Drawing.Size(1496, 167);
            this.lbl_titlePage.TabIndex = 13;
            this.lbl_titlePage.Text = "Change Your Password";
            this.lbl_titlePage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.PapayaWhip;
            this.pictureBox3.Image = global::login.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(210, 167);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // checkBox_show_hide
            // 
            this.checkBox_show_hide.AutoSize = true;
            this.checkBox_show_hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_show_hide.Location = new System.Drawing.Point(1098, 448);
            this.checkBox_show_hide.Margin = new System.Windows.Forms.Padding(6);
            this.checkBox_show_hide.Name = "checkBox_show_hide";
            this.checkBox_show_hide.Size = new System.Drawing.Size(154, 46);
            this.checkBox_show_hide.TabIndex = 15;
            this.checkBox_show_hide.Text = "Show";
            this.checkBox_show_hide.UseVisualStyleBackColor = true;
            this.checkBox_show_hide.CheckedChanged += new System.EventHandler(this.checkBox_show_hide_CheckedChanged);
            // 
            // ChangePW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1496, 990);
            this.Controls.Add(this.checkBox_show_hide);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_Previous);
            this.Controls.Add(this.lbl_logout);
            this.Controls.Add(this.btn_NotYou);
            this.Controls.Add(this.btn_ChgPW);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_ConfirmNewPW);
            this.Controls.Add(this.txt_NewPW);
            this.Controls.Add(this.txt_CurrentPW);
            this.Controls.Add(this.lbl_DisplayUsername);
            this.Controls.Add(this.lbl_titlePage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChangePW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePW";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DisplayUsername;
        private System.Windows.Forms.TextBox txt_CurrentPW;
        private System.Windows.Forms.TextBox txt_NewPW;
        private System.Windows.Forms.TextBox txt_ConfirmNewPW;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_ChgPW;
        private System.Windows.Forms.Button btn_NotYou;
        private System.Windows.Forms.Label lbl_logout;
        private System.Windows.Forms.Label lbl_Previous;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_titlePage;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox checkBox_show_hide;
    }
}