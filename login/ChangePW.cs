using CcnSession;
using login.Resources;
using System;
using System.Windows.Forms;

namespace login
{
    public partial class ChangePW : Form
    {
        public ChangePW()
        {
            InitializeComponent();
            lbl_username.Text = SQL.Username;
            lbl_date.Text = "Today's Date is: " + DateTime.Today.ToString("dddd, dd MMMM yyyy");
        }
        private void Btn_ChgPW_Click(object sender, EventArgs e)
        {
            try
            {
                if (SQL.ChkPasswordNoFail(txt_CurrentPW.Text))
                {

                    if (txt_NewPW.Text == txt_CurrentPW.Text)
                    {

                        throw new Exception("New Password must be different than current.");
                    }
                    if (!uF.CheckPWValid(txt_NewPW.Text))
                    {
                        throw new Exception("New Password must be between 8 and 15 characters, and containe a number, a special character, and both lower and upper case characters.");
                    }
                    if (txt_NewPW.Text == txt_ConfirmNewPW.Text)
                    {
                        /* this throws a bunch of possibe erorrs if the new PW does not meet the 
                         * required secuirty protocols:
                         * 
                         * not used within the last 15 pws changes
                         * 
                         * not changed less than 24 hours ago
                         * 
                         * not changed in the last 90 days
                         */

                        SQL.ChangePassword(txt_NewPW.Text);

                        DialogResult result = MessageBox.Show("Your password has been succesfully changed", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            SQL.Cleanup();
                            this.Hide();
                            LoginForm login = new LoginForm();
                            login.Show();
                        }
                    }
                    else
                    {
                        throw new Exception("New Password and Confirm Password do not match.");
                    }

                }
                else
                {
                    throw new Exception("Your current password is incorrect");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txt_ConfirmNewPW_Leave(object sender, EventArgs e)
        {
            if (txt_ConfirmNewPW.Text != txt_NewPW.Text)
            {
                MessageBox.Show("Passwords Do Not Match", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_NotYou_Click(object sender, EventArgs e)
        {
            this.Hide();
            SQL.Cleanup();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void txt_CurrentPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_ChgPW.PerformClick();
            }
        }

        private void txt_NewPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_ChgPW.PerformClick();
            }
        }

        private void txt_ConfirmNewPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_ChgPW.PerformClick();
            }
        }

        private void checkBox_show_hide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_show_hide.Checked)
            {

                txt_CurrentPW.UseSystemPasswordChar = false;
                txt_NewPW.UseSystemPasswordChar = false;
                txt_ConfirmNewPW.UseSystemPasswordChar = false;

            }
            else
            {
                txt_CurrentPW.UseSystemPasswordChar = true;
                txt_NewPW.UseSystemPasswordChar = true;
                txt_ConfirmNewPW.UseSystemPasswordChar = true;

            }
        }

        private void Close_pic_Click(object sender, EventArgs e)
        {
            SQL.Cleanup();
            this.Hide();
            var login = new LoginForm();
            login.Show();
        }

        private void Previous_pic_Click(object sender, EventArgs e)
        {
            this.Hide();
            var main = new MainForm();
            main.Show();
        }
    }
}


