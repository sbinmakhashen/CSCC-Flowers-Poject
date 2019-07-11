using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CcnSession;
using login.Resources;

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
                if (SQL.ChkPassword(txt_CurrentPW.Text))
                {
                    
                    if(txt_NewPW.Text == txt_CurrentPW.Text)
                    {
                        throw new Exception("New Password must be different than current.");
                    }
                    if (!uF.CheckPWValid(txt_NewPW.Text))
                    {
                        throw new Exception("New Password must be between 8 and 15 characters, and containe a number, a special character, and both lower and upper case characters.");
                    }
                    if (txt_NewPW.Text == txt_ConfirmNewPW.Text)
                    {
                        SQL.ChangePassword(txt_NewPW.Text);
                        DialogResult result = MessageBox.Show("Your password has been succesfully changed", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if(result == DialogResult.OK)
                        {
                            SQL.Cleanup();
                            this.Hide();
                            LoginForm login = new LoginForm();
                            login.Show();
                        }
                    } else
                    {
                        throw new Exception("New Password and Confirm Password do not match.");
                    }

                } else
                {
                    throw new Exception("Your current password is incorrect");
                }

            } catch (Exception ex)
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

           String CNP = txt_ConfirmNewPW.Text;
            if (CNP.ToLower().Trim().Equals("confirm new password") || CNP.Trim().Equals(""))
            {
                txt_ConfirmNewPW.Text = "confirm new password";
                txt_ConfirmNewPW.ForeColor = Color.LightSeaGreen;
            }

        }

        private void Btn_NotYou_Click(object sender, EventArgs e)
        {
            this.Hide();
            SQL.Cleanup();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void Lbl_logout_Click(object sender, EventArgs e)
        {
            SQL.Cleanup();
            this.Hide();
            var login = new LoginForm();
            login.Show();
        }

        private void Lbl_Previous_Click(object sender, EventArgs e)
        {
            this.Hide();
            var main = new MainForm();
            main.Show();
        }

        private void txt_CurrentPW_Enter(object sender, EventArgs e)
        {
            String CP = txt_CurrentPW.Text;
            if (CP.ToLower().Trim().Equals("current password"))
            {
                txt_CurrentPW.Text = "";
                txt_CurrentPW.ForeColor = Color.Black;
            }
        }

        private void txt_CurrentPW_Leave(object sender, EventArgs e)
        {
            String CP = txt_CurrentPW.Text;
            if (CP.ToLower().Trim().Equals("current password") || CP.Trim().Equals(""))
            {
                txt_CurrentPW.Text = "current password";
                txt_CurrentPW.ForeColor = Color.LightSeaGreen;
            }
        }

        private void txt_NewPW_Enter(object sender, EventArgs e)
        {
            String NP = txt_NewPW.Text;
            if (NP.ToLower().Trim().Equals("new password"))
            {
                txt_NewPW.Text = "";
                txt_NewPW.ForeColor = Color.Black;
            }
        }

        private void txt_NewPW_Leave(object sender, EventArgs e)
        {
            String NP = txt_NewPW.Text;
            if (NP.ToLower().Trim().Equals("new password") || NP.Trim().Equals(""))
            {
                txt_NewPW.Text = "new password";
                txt_NewPW.ForeColor = Color.LightSeaGreen;
            }
        }

        private void txt_ConfirmNewPW_Enter(object sender, EventArgs e)
        {
            String CNP = txt_ConfirmNewPW.Text;
            if (CNP.ToLower().Trim().Equals("confirm new password"))
            {
                txt_ConfirmNewPW.Text = "";
                txt_ConfirmNewPW.ForeColor = Color.Black;
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
    

