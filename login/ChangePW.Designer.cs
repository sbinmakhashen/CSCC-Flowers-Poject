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
            this.lbl_currentPW = new System.Windows.Forms.Label();
            this.lbl_NewPW = new System.Windows.Forms.Label();
            this.lbl_ConfirmNewPW = new System.Windows.Forms.Label();
            this.txt_CurrentPW = new System.Windows.Forms.TextBox();
            this.txt_NewPW = new System.Windows.Forms.TextBox();
            this.txt_ConfirmNewPW = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_ChgPW = new System.Windows.Forms.Button();
            this.btn_NotYou = new System.Windows.Forms.Button();
            this.lbl_logout = new System.Windows.Forms.Label();
            this.lbl_Previous = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_DisplayUsername
            // 
            this.lbl_DisplayUsername.AutoSize = true;
            this.lbl_DisplayUsername.Location = new System.Drawing.Point(155, 257);
            this.lbl_DisplayUsername.Name = "lbl_DisplayUsername";
            this.lbl_DisplayUsername.Size = new System.Drawing.Size(255, 32);
            this.lbl_DisplayUsername.TabIndex = 0;
            this.lbl_DisplayUsername.Text = "Your Username is: ";
            // 
            // lbl_currentPW
            // 
            this.lbl_currentPW.AutoSize = true;
            this.lbl_currentPW.Location = new System.Drawing.Point(155, 312);
            this.lbl_currentPW.Name = "lbl_currentPW";
            this.lbl_currentPW.Size = new System.Drawing.Size(248, 32);
            this.lbl_currentPW.TabIndex = 1;
            this.lbl_currentPW.Text = "Current Password:";
            // 
            // lbl_NewPW
            // 
            this.lbl_NewPW.AutoSize = true;
            this.lbl_NewPW.Location = new System.Drawing.Point(155, 367);
            this.lbl_NewPW.Name = "lbl_NewPW";
            this.lbl_NewPW.Size = new System.Drawing.Size(217, 32);
            this.lbl_NewPW.TabIndex = 2;
            this.lbl_NewPW.Text = "New Password: ";
            // 
            // lbl_ConfirmNewPW
            // 
            this.lbl_ConfirmNewPW.AutoSize = true;
            this.lbl_ConfirmNewPW.Location = new System.Drawing.Point(155, 418);
            this.lbl_ConfirmNewPW.Name = "lbl_ConfirmNewPW";
            this.lbl_ConfirmNewPW.Size = new System.Drawing.Size(323, 32);
            this.lbl_ConfirmNewPW.TabIndex = 3;
            this.lbl_ConfirmNewPW.Text = "Confirm New Password: ";
            // 
            // txt_CurrentPW
            // 
            this.txt_CurrentPW.Location = new System.Drawing.Point(565, 312);
            this.txt_CurrentPW.Name = "txt_CurrentPW";
            this.txt_CurrentPW.Size = new System.Drawing.Size(479, 38);
            this.txt_CurrentPW.TabIndex = 4;
            // 
            // txt_NewPW
            // 
            this.txt_NewPW.Location = new System.Drawing.Point(565, 367);
            this.txt_NewPW.Name = "txt_NewPW";
            this.txt_NewPW.Size = new System.Drawing.Size(479, 38);
            this.txt_NewPW.TabIndex = 5;
            // 
            // txt_ConfirmNewPW
            // 
            this.txt_ConfirmNewPW.Location = new System.Drawing.Point(565, 418);
            this.txt_ConfirmNewPW.Name = "txt_ConfirmNewPW";
            this.txt_ConfirmNewPW.Size = new System.Drawing.Size(479, 38);
            this.txt_ConfirmNewPW.TabIndex = 6;
            this.txt_ConfirmNewPW.Leave += new System.EventHandler(this.txt_ConfirmNewPW_Leave);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(559, 257);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(93, 32);
            this.lbl_username.TabIndex = 7;
            this.lbl_username.Text = "label1";
            // 
            // btn_ChgPW
            // 
            this.btn_ChgPW.Location = new System.Drawing.Point(783, 501);
            this.btn_ChgPW.Name = "btn_ChgPW";
            this.btn_ChgPW.Size = new System.Drawing.Size(261, 95);
            this.btn_ChgPW.TabIndex = 8;
            this.btn_ChgPW.Text = "Change Password";
            this.btn_ChgPW.UseVisualStyleBackColor = true;
            this.btn_ChgPW.Click += new System.EventHandler(this.Btn_ChgPW_Click);
            // 
            // btn_NotYou
            // 
            this.btn_NotYou.Location = new System.Drawing.Point(783, 682);
            this.btn_NotYou.Name = "btn_NotYou";
            this.btn_NotYou.Size = new System.Drawing.Size(261, 95);
            this.btn_NotYou.TabIndex = 9;
            this.btn_NotYou.Text = "Not You?";
            this.btn_NotYou.UseVisualStyleBackColor = true;
            this.btn_NotYou.Click += new System.EventHandler(this.Btn_NotYou_Click);
            // 
            // lbl_logout
            // 
            this.lbl_logout.AutoSize = true;
            this.lbl_logout.Location = new System.Drawing.Point(1128, 27);
            this.lbl_logout.Name = "lbl_logout";
            this.lbl_logout.Size = new System.Drawing.Size(34, 32);
            this.lbl_logout.TabIndex = 10;
            this.lbl_logout.Text = "X";
            this.lbl_logout.Click += new System.EventHandler(this.Lbl_logout_Click);
            // 
            // lbl_Previous
            // 
            this.lbl_Previous.AutoSize = true;
            this.lbl_Previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Previous.Location = new System.Drawing.Point(980, 27);
            this.lbl_Previous.Name = "lbl_Previous";
            this.lbl_Previous.Size = new System.Drawing.Size(126, 32);
            this.lbl_Previous.TabIndex = 11;
            this.lbl_Previous.Text = "Previous";
            this.lbl_Previous.Click += new System.EventHandler(this.Lbl_Previous_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(155, 119);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(223, 32);
            this.lbl_date.TabIndex = 12;
            this.lbl_date.Text = "Today\'s Date is: ";
            // 
            // ChangePW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 820);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_Previous);
            this.Controls.Add(this.lbl_logout);
            this.Controls.Add(this.btn_NotYou);
            this.Controls.Add(this.btn_ChgPW);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.txt_ConfirmNewPW);
            this.Controls.Add(this.txt_NewPW);
            this.Controls.Add(this.txt_CurrentPW);
            this.Controls.Add(this.lbl_ConfirmNewPW);
            this.Controls.Add(this.lbl_NewPW);
            this.Controls.Add(this.lbl_currentPW);
            this.Controls.Add(this.lbl_DisplayUsername);
            this.Name = "ChangePW";
            this.Text = "ChangePW";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DisplayUsername;
        private System.Windows.Forms.Label lbl_currentPW;
        private System.Windows.Forms.Label lbl_NewPW;
        private System.Windows.Forms.Label lbl_ConfirmNewPW;
        private System.Windows.Forms.TextBox txt_CurrentPW;
        private System.Windows.Forms.TextBox txt_NewPW;
        private System.Windows.Forms.TextBox txt_ConfirmNewPW;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Button btn_ChgPW;
        private System.Windows.Forms.Button btn_NotYou;
        private System.Windows.Forms.Label lbl_logout;
        private System.Windows.Forms.Label lbl_Previous;
        private System.Windows.Forms.Label lbl_date;
    }
}