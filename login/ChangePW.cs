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
    }
}
