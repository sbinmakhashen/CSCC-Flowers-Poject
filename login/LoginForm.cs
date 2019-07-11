using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CcnSession;


namespace login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            //this.textBoxPassword.AutoSize = false;
            //this.textBoxPassword.Size = new Size(this.textBoxPassword.Size.Width, 115);
            var date = DateTime.Today.ToString("dddd, dd MMMM yyyy");
            lbl_date.Text = "Today's Date: " + date;
        }

      
        private void Close_pic_Click_1(object sender, EventArgs e)
        {
            //this.Close();
            SQL.Cleanup();
            Application.Exit();
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;

            //Set up the username and the Permission level for if Employee or Manager.
            // Only needs to be done THIS ONE TIME - doesn't need to be done again.

            // needs (better) exception handling!!!!


            if (username.Trim().Equals(""))
            {
                MessageBox.Show("Enter Your Username To Login", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password.Trim().Equals(""))
            {
                MessageBox.Show("Enter Your Password To Login", "Empty Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                try
                {
                    // will throw an error if it can't find the username.
                    SQL.Setup(username, password);

                    //if CurEmp is false then they have been terminated.
                    if (SQL.CurEmp)
                    {
                        if (SQL.PwCorrect)
                        {
                            this.Hide();
                            MainForm mainform = new MainForm();
                            mainform.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Our Records do not match this data. Please Try again.", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            

            

           

        }

        
    }
}
