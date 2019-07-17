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
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_titlePage = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.checkBox_show_hide = new System.Windows.Forms.CheckBox();
            this.Previous_pic = new System.Windows.Forms.PictureBox();
            this.Close_pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Previous_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_DisplayUsername
            // 
            this.lbl_DisplayUsername.AutoSize = true;
            this.lbl_DisplayUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DisplayUsername.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_DisplayUsername.Location = new System.Drawing.Point(6, 94);
            this.lbl_DisplayUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DisplayUsername.Name = "lbl_DisplayUsername";
            this.lbl_DisplayUsername.Size = new System.Drawing.Size(255, 32);
            this.lbl_DisplayUsername.TabIndex = 0;
            this.lbl_DisplayUsername.Text = "Your Username is: ";
            // 
            // txt_CurrentPW
            // 
            this.txt_CurrentPW.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CurrentPW.ForeColor = System.Drawing.Color.Black;
            this.txt_CurrentPW.Location = new System.Drawing.Point(575, 274);
            this.txt_CurrentPW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_CurrentPW.Name = "txt_CurrentPW";
            this.txt_CurrentPW.Size = new System.Drawing.Size(494, 50);
            this.txt_CurrentPW.TabIndex = 4;
            this.txt_CurrentPW.UseSystemPasswordChar = true;
            this.txt_CurrentPW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_CurrentPW_KeyDown);
            // 
            // txt_NewPW
            // 
            this.txt_NewPW.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NewPW.ForeColor = System.Drawing.Color.Black;
            this.txt_NewPW.Location = new System.Drawing.Point(575, 341);
            this.txt_NewPW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_NewPW.Name = "txt_NewPW";
            this.txt_NewPW.Size = new System.Drawing.Size(494, 50);
            this.txt_NewPW.TabIndex = 5;
            this.txt_NewPW.UseSystemPasswordChar = true;
            this.txt_NewPW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NewPW_KeyDown);
            // 
            // txt_ConfirmNewPW
            // 
            this.txt_ConfirmNewPW.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmNewPW.ForeColor = System.Drawing.Color.Black;
            this.txt_ConfirmNewPW.Location = new System.Drawing.Point(575, 408);
            this.txt_ConfirmNewPW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ConfirmNewPW.Name = "txt_ConfirmNewPW";
            this.txt_ConfirmNewPW.Size = new System.Drawing.Size(494, 50);
            this.txt_ConfirmNewPW.TabIndex = 6;
            this.txt_ConfirmNewPW.UseSystemPasswordChar = true;
            this.txt_ConfirmNewPW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ConfirmNewPW_KeyDown);
            this.txt_ConfirmNewPW.Leave += new System.EventHandler(this.txt_ConfirmNewPW_Leave);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_username.Location = new System.Drawing.Point(246, 94);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(93, 32);
            this.lbl_username.TabIndex = 7;
            this.lbl_username.Text = "label1";
            // 
            // btn_ChgPW
            // 
            this.btn_ChgPW.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_ChgPW.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChgPW.Location = new System.Drawing.Point(625, 475);
            this.btn_ChgPW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ChgPW.Name = "btn_ChgPW";
            this.btn_ChgPW.Size = new System.Drawing.Size(380, 72);
            this.btn_ChgPW.TabIndex = 8;
            this.btn_ChgPW.Text = "Change Password";
            this.btn_ChgPW.UseVisualStyleBackColor = false;
            this.btn_ChgPW.Click += new System.EventHandler(this.Btn_ChgPW_Click);
            // 
            // btn_NotYou
            // 
            this.btn_NotYou.BackColor = System.Drawing.Color.Green;
            this.btn_NotYou.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NotYou.Location = new System.Drawing.Point(682, 709);
            this.btn_NotYou.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_NotYou.Name = "btn_NotYou";
            this.btn_NotYou.Size = new System.Drawing.Size(265, 75);
            this.btn_NotYou.TabIndex = 9;
            this.btn_NotYou.Text = "Not You?";
            this.btn_NotYou.UseVisualStyleBackColor = false;
            this.btn_NotYou.Click += new System.EventHandler(this.Btn_NotYou_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_date.Location = new System.Drawing.Point(1168, 66);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(136, 20);
            this.lbl_date.TabIndex = 12;
            this.lbl_date.Text = "Today\'s Date is: ";
            // 
            // lbl_titlePage
            // 
            this.lbl_titlePage.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl_titlePage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_titlePage.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titlePage.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbl_titlePage.Location = new System.Drawing.Point(0, 0);
            this.lbl_titlePage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titlePage.Name = "lbl_titlePage";
            this.lbl_titlePage.Size = new System.Drawing.Size(1572, 86);
            this.lbl_titlePage.TabIndex = 13;
            this.lbl_titlePage.Text = "Change Your Password";
            this.lbl_titlePage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.PapayaWhip;
            this.pictureBox3.Image = global::login.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(153, 86);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // checkBox_show_hide
            // 
            this.checkBox_show_hide.AutoSize = true;
            this.checkBox_show_hide.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_show_hide.Location = new System.Drawing.Point(1100, 341);
            this.checkBox_show_hide.Name = "checkBox_show_hide";
            this.checkBox_show_hide.Size = new System.Drawing.Size(142, 49);
            this.checkBox_show_hide.TabIndex = 1;
            this.checkBox_show_hide.Text = "Show";
            this.checkBox_show_hide.UseVisualStyleBackColor = true;
            this.checkBox_show_hide.CheckedChanged += new System.EventHandler(this.checkBox_show_hide_CheckedChanged);
            // 
            // Previous_pic
            // 
            this.Previous_pic.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Previous_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Previous_pic.Image = global::login.Properties.Resources.previous_blue;
            this.Previous_pic.Location = new System.Drawing.Point(1467, 0);
            this.Previous_pic.Name = "Previous_pic";
            this.Previous_pic.Size = new System.Drawing.Size(39, 40);
            this.Previous_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Previous_pic.TabIndex = 43;
            this.Previous_pic.TabStop = false;
            this.Previous_pic.Click += new System.EventHandler(this.Previous_pic_Click);
            // 
            // Close_pic
            // 
            this.Close_pic.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Close_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_pic.Image = global::login.Properties.Resources.close;
            this.Close_pic.Location = new System.Drawing.Point(1534, 0);
            this.Close_pic.Name = "Close_pic";
            this.Close_pic.Size = new System.Drawing.Size(38, 40);
            this.Close_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Close_pic.TabIndex = 42;
            this.Close_pic.TabStop = false;
            this.Close_pic.Click += new System.EventHandler(this.Close_pic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(90, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 45);
            this.label1.TabIndex = 44;
            this.label1.Text = "Current Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(90, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 45);
            this.label2.TabIndex = 45;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(90, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(444, 45);
            this.label3.TabIndex = 46;
            this.label3.Text = "Confirm New Password";
            // 
            // ChangePW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1572, 795);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Previous_pic);
            this.Controls.Add(this.Close_pic);
            this.Controls.Add(this.checkBox_show_hide);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.btn_NotYou);
            this.Controls.Add(this.btn_ChgPW);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_ConfirmNewPW);
            this.Controls.Add(this.txt_NewPW);
            this.Controls.Add(this.txt_CurrentPW);
            this.Controls.Add(this.lbl_DisplayUsername);
            this.Controls.Add(this.lbl_titlePage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChangePW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePW";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Previous_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_pic)).EndInit();
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
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_titlePage;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox checkBox_show_hide;
        private System.Windows.Forms.PictureBox Previous_pic;
        private System.Windows.Forms.PictureBox Close_pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}