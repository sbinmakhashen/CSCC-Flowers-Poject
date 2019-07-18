using CcnSession;
using login.Resources;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace login
{
    public partial class NewEmployeeForm : Form
    {
        public NewEmployeeForm()
        {
            InitializeComponent();
            var date = DateTime.Today.ToString("dddd, dd MMMM yyyy");
            lbl_date.Text = "Today's Date: " + date;
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // remove the focus from the textboxes
            this.ActiveControl = label1;
        }

        //Text Boxes Enter and Leave Methods 
        private void textBoxFirstname_Enter(object sender, EventArgs e)
        {
            String fname = textBoxFirstname.Text;
            if (fname.ToLower().Trim().Equals("first name"))
            {
                textBoxFirstname.Text = "";
                textBoxFirstname.ForeColor = Color.Black;
            }
        }

        private void textBoxFirstname_Leave(object sender, EventArgs e)
        {
            String fname = textBoxFirstname.Text;
            if (fname.ToLower().Trim().Equals("first name") || fname.Trim().Equals(""))
            {
                textBoxFirstname.Text = "First Name";
                textBoxFirstname.ForeColor = Color.Gray;
            }
        }

        private void textBoxLastname_Enter(object sender, EventArgs e)
        {
            String lname = textBoxLastname.Text;
            if (lname.ToLower().Trim().Equals("last name"))
            {
                textBoxLastname.Text = "";
                textBoxLastname.ForeColor = Color.Black;
            }
        }

        private void textBoxLastname_Leave(object sender, EventArgs e)
        {
            String lname = textBoxLastname.Text;
            if (lname.ToLower().Trim().Equals("last name") || lname.Trim().Equals(""))
            {
                textBoxLastname.Text = "Last Name";
                textBoxLastname.ForeColor = Color.Gray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.ToLower().Trim().Equals("password"))
            {
                textBoxPassword.Text = "";
                textBoxPassword.UseSystemPasswordChar = true;
                textBoxPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            String password = textBoxPassword.Text;
            if (password.ToLower().Trim().Equals("password") || password.Trim().Equals(""))
            {
                textBoxPassword.Text = "Password";
                textBoxPassword.UseSystemPasswordChar = false;
                textBoxPassword.ForeColor = Color.Gray;
            }
        }

        private void textBoxPasswordConfirm_Enter(object sender, EventArgs e)
        {
            String cpassword = textBoxPasswordConfirm.Text;
            if (cpassword.ToLower().Trim().Equals("confirm password"))
            {
                textBoxPasswordConfirm.Text = "";
                textBoxPasswordConfirm.UseSystemPasswordChar = true;
                textBoxPasswordConfirm.ForeColor = Color.Black;
            }
        }

        private void textBoxPasswordConfirm_Leave(object sender, EventArgs e)
        {
            String cpassword = textBoxPasswordConfirm.Text;
            if (cpassword.ToLower().Trim().Equals("confirm password") ||
                cpassword.ToLower().Trim().Equals("password") ||
                cpassword.Trim().Equals(""))
            {
                textBoxPasswordConfirm.Text = "Confirm Password";
                textBoxPasswordConfirm.UseSystemPasswordChar = false;
                textBoxPasswordConfirm.ForeColor = Color.Gray;
            }
            else if (textBoxPassword.Text != textBoxPasswordConfirm.Text)
            {
                MessageBox.Show("Passwords Do Not Match", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxStreet_Enter(object sender, EventArgs e)
        {
            String street = textBoxStreet.Text;
            if (street.ToLower().Trim().Equals("street"))
            {
                textBoxStreet.Text = "";
                textBoxStreet.ForeColor = Color.Black;
            }
        }

        private void textBoxStreet_Leave(object sender, EventArgs e)
        {
            String street = textBoxStreet.Text;
            if (street.ToLower().Trim().Equals("street") || street.Trim().Equals(""))
            {
                textBoxStreet.Text = "Street";
                textBoxStreet.ForeColor = Color.Gray;
            }
        }

        private void textBoxZip_Enter(object sender, EventArgs e)
        {
            String Zip = textBoxZip.Text;
            if (Zip.ToLower().Trim().Equals("zip"))
            {
                textBoxZip.Text = "";
                textBoxZip.ForeColor = Color.Black;
            }
        }

        private void textBoxZip_Leave(object sender, EventArgs e)
        {
            String Zip = textBoxZip.Text;
            if (Zip.ToLower().Trim().Equals("zip") || Zip.Trim().Equals(""))
            {
                textBoxZip.Text = "zip";
                textBoxZip.ForeColor = Color.Gray;
            }
        }
        private void textBoxCity_Enter(object sender, EventArgs e)
        {
            String city = textBoxCity.Text;
            if (city.ToLower().Trim().Equals("city"))
            {
                textBoxCity.Text = "";
                textBoxCity.ForeColor = Color.Black;
            }
        }

        private void textBoxCity_Leave(object sender, EventArgs e)
        {

            String city = textBoxCity.Text;
            if (city.ToLower().Trim().Equals("city") || city.Trim().Equals(""))
            {
                textBoxCity.Text = "city";
                textBoxCity.ForeColor = Color.Gray;
            }
        }
        private void textBoxPay_Rate_Enter(object sender, EventArgs e)
        {
            String PR = textBoxPay_Rate.Text;
            if (PR.ToLower().Trim().Equals("pay rate"))
            {
                textBoxPay_Rate.Text = "";
                textBoxPay_Rate.ForeColor = Color.Black;
            }
        }

        private void textBoxPay_Rate_Leave(object sender, EventArgs e)
        {
            String PR = textBoxPay_Rate.Text;
            if (PR.ToLower().Trim().Equals("pay rate") || PR.Trim().Equals(""))
            {
                textBoxPay_Rate.Text = "pay rate";
                textBoxPay_Rate.ForeColor = Color.Gray;
            }
        }

        //Text Boxes Enter and Leave Methods Ends Here

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            // add a new user

            string fName = textBoxFirstname.Text;
            string lName = textBoxLastname.Text;
            string password = textBoxPassword.Text;
            string zCode = textBoxZip.Text;


            string username;

            try
            {
                double.TryParse(textBoxPay_Rate.Text, out double pay);

                if (!uF.CheckPWValid(textBoxPasswordConfirm.Text))
                {
                    throw new Exception("Password must contain between 8-15 characters, one capital, one lowercase, a number, and a special character.");
                }

                else if (checkTextBoxesValues()) //if default values in boxes, throw exception
                {
                    throw new Exception("Please complete all fields.");

                }
                else if (!textBoxPassword.Text.Equals(textBoxPasswordConfirm.Text))
                {
                    throw new Exception("Passwords do not match.");

                }
                else if (!uF.ZipValidate(zCode)) //if not a valid zip code,throw exception
                {
                    throw new Exception("Zip Code must be either 5 or 9 numbers.");

                }
                else if (pay == 0)
                {
                    throw new Exception("Pay Rate is not a valid number.");

                }
                else if (Math.Round(pay, 2) != pay)
                {
                    throw new Exception("Pay Rate cannot be a fraction of a cent.");
                }

                else
                {
                    //setup the user and get the automatically created username
                    username = SQL.CreateUser(fName, lName, password);
                    // retrieve the emp_num from the newly created row
                    int empNumber = SQL.GetEmpNum(username);

                    zCode = uF.ZipHyphen(zCode);
                    int.TryParse(zCode, out int zip);

                    //set the remaining columns of the emp_table
                    SQL.UpdateStreet(empNumber, textBoxStreet.Text);
                    SQL.UpdateCity(empNumber, textBoxCity.Text);
                    SQL.UpdateState(empNumber, comboBoxState.Text);
                    SQL.UpdateZip(empNumber, zip);
                    SQL.ChangePay(empNumber, pay);

                    MessageBox.Show("Your Account Has Been Created. Your username is " + username + ". Please remember this for your records.", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Reset all the fields to default after account created.
                    textBoxFirstname.Text = "First Name";
                    textBoxFirstname.ForeColor = Color.Gray;
                    textBoxLastname.Text = "Last Name";
                    textBoxLastname.ForeColor = Color.Gray;
                    textBoxPassword.Text = "Password";
                    textBoxPassword.UseSystemPasswordChar = false;
                    textBoxPassword.ForeColor = Color.Gray;
                    textBoxPasswordConfirm.Text = "Confirm Password";
                    textBoxPasswordConfirm.UseSystemPasswordChar = false;
                    textBoxPasswordConfirm.ForeColor = Color.Gray;
                    textBoxStreet.Text = "Street";
                    textBoxStreet.ForeColor = Color.Gray;
                    textBoxCity.Text = "City";
                    textBoxCity.ForeColor = Color.Gray;
                    comboBoxState.SelectedIndex = -1;
                    textBoxZip.Text = "Zip";
                    textBoxZip.ForeColor = Color.Gray;
                    textBoxPay_Rate.Text = "Pay Rate";
                    textBoxPay_Rate.ForeColor = Color.Gray;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Incorrect Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // check if the textboxes or dropdowns contains the default values
        public Boolean checkTextBoxesValues()
        {

            if (textBoxFirstname.Text.ToLower().Equals("first name") || textBoxLastname.Text.ToLower().Equals("last name")
                || textBoxPassword.Text.ToLower().Equals("password") || textBoxStreet.Text.ToLower().Equals("street")
                || textBoxCity.Text.ToLower().Equals("City") || comboBoxState == null || textBoxZip.Text.ToLower().Equals("zip"))
            {

                return true;
            }
            else
            {
                return false;
            }

        }

        private void Close_pic_Click(object sender, EventArgs e)
        {
            SQL.Cleanup();
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void Previous_pic_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MainForm = new MainForm();
            MainForm.Show();
        }
    }
}