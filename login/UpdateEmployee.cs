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
using MySql.Data.MySqlClient;

namespace login
{
    public partial class UpdateEmployee : Form
    {
        int accountNum = 0;
        public UpdateEmployee()
        {
            
            InitializeComponent();
            lbl_terminated.Hide();
            var date = DateTime.Today.ToString("dddd, dd MMMM yyyy");
            lbl_date.Text = "Today's Date: " + date;
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (text_Username == null)
            {
                MessageBox.Show("Please enter a username to search for. Usernames are First Initial+LastName(+ A Number, optional)", "Enter Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    accountNum = SQL.GetEmpNum(text_Username.Text);

                    var data = new DataTable();
                    data = SQL.GetEmployee(accountNum);

                    txt_FName.Text = data.Rows[0]["first_name"].ToString();
                    txt_LName.Text = data.Rows[0]["last_name"].ToString();
                    txt_Street.Text = data.Rows[0]["street"].ToString();
                    txt_city.Text = data.Rows[0]["city"].ToString();
                    txt_Zip.Text = data.Rows[0]["zip"].ToString();
                    txt_Pay.Text = data.Rows[0]["pay"].ToString();
                    drpd_State.SelectedIndex = drpd_State.FindStringExact(data.Rows[0]["state"].ToString().ToUpper());
                    drpd_store.SelectedIndex = drpd_store.FindStringExact(data.Rows[0]["location"].ToString());
                    lbl_username.Text = "Username: " + data.Rows[0]["username"].ToString();
                    lbl_hired.Text = "Hire Date: " + data.Rows[0]["hired"].ToString();
                    lbl_type.Text = "Type: " + data.Rows[0]["type"].ToString();
                    if (data.Rows[0]["terminated"].ToString().Substring(0,1) == "0")
                    {
                        lbl_terminated.Hide();
                    } else
                    {
                        lbl_terminated.Show();
                        lbl_terminated.ForeColor = Color.Red;
                        lbl_terminated.Text = "Terminated: " + data.Rows[0]["terminated"].ToString();
                    }
                    
                    


                }
                catch
                {
                    MessageBox.Show("No User by that username. Please Try Again.", "Enter Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }


            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                accountNum = SQL.GetEmpNum(text_Username.Text);
                /* Being a little lazy in the Try-Catch here. If this can't find a Username and throws an error
                 * then the catch will error out before even getting to the rest, so we can use just a generic
                 * catch below
                 */

                var data = new DataTable();
                data = SQL.GetEmployee(accountNum);
                bool fNameFlag = false, lNameFlag = false, streetFlag = false, cityFlag = false, zipFlag = false, stateFlag = false, storeFlag = false, payFlag = false;

                string whatUpdated="";

                /* make sure the fields are not their default values AND the value in the field is DIFFERENT
                 * from the value stored in the database that we just pulled from, then go ahead and update.
                 * 
                 * sets flags for a final message box to let the user know what was updated.
                 * 
                 * throws exception strings if default or empty boxes.
                 */

                //easiest way to figure out if there is a date in terminated or if its 0. if 0, still a current employee.
                if(data.Rows[0]["terminated"].ToString().Substring(0, 1) == "0")
                {
                    try
                    {


                        if (txt_FName.Text.ToLower() == "first name" || txt_FName.Text.Length == 0)
                        {

                            throw new Exception("First Name field must be entered to continue.");

                        }
                        else if (txt_FName.Text != data.Rows[0]["first_name"].ToString())
                        {
                            SQL.UpdateFname(accountNum, txt_FName.Text);
                            fNameFlag = true;
                        }
                        else
                        {
                            fNameFlag = false;
                        }
                        if (txt_LName.Text.ToLower() == "last name" || txt_LName.Text.Length == 0)
                        {

                            throw new Exception("Last Name field must be entered to continue.");

                        }
                        else if (txt_LName.Text != data.Rows[0]["last_name"].ToString())
                        {
                            SQL.UpdateLname(accountNum, txt_LName.Text);
                            lNameFlag = true;
                        }
                        else
                        {
                            lNameFlag = false;
                        }
                        if (txt_Street.Text.ToLower() == "street" || txt_Street.Text.Length == 0)
                        {

                            throw new Exception("Street field must be entered to continue.");

                        }
                        else if (txt_Street.Text != data.Rows[0]["street"].ToString())
                        {
                            SQL.UpdateStreet(accountNum, txt_Street.Text);
                            streetFlag = true;
                        }
                        else
                        {
                            streetFlag = false;
                        }
                        if (txt_city.Text.ToLower() == "city" || txt_city.Text.Length == 0)
                        {

                            throw new Exception("City field must be entered to continue.");

                        }
                        else if (txt_city.Text != data.Rows[0]["city"].ToString())
                        {
                            SQL.UpdateCity(accountNum, txt_city.Text);
                            cityFlag = true;
                        }
                        else
                        {
                            cityFlag = false;
                        }
                        if (drpd_State.SelectedItem == null)
                        {
                            throw new Exception("Please select a State to continue.");

                        }
                        else if (drpd_State.SelectedIndex != drpd_State.FindStringExact(data.Rows[0]["state"].ToString().ToUpper()))
                        {
                            SQL.UpdateState(accountNum, drpd_State.Text);
                            stateFlag = true;
                        }
                        else
                        {
                            stateFlag = false;
                        }

                        if (txt_Zip.Text.ToLower() == "zip" || txt_Zip.Text.Length == 0)
                        {

                            throw new Exception("Zip Code field must be entered to continue.");

                        }
                        else if (txt_Zip.Text != data.Rows[0]["zip"].ToString())
                        {
                            if (uF.ZipValidate(txt_Zip.Text))
                            {
                                if (txt_Zip.Text.Length == 10)
                                {
                                    // if the ZipValidate comes back as True, and its 10 long, then it has a -.
                                    // ZipHyphen removes the -.
                                    int.TryParse(uF.ZipHyphen(txt_Zip.Text), out int zCode);
                                    SQL.UpdateZip(accountNum, zCode);
                                    zipFlag = true;

                                }
                                else
                                {
                                    // else it has to be either 5 or 9 long, so no need to call ZipHyphen.
                                    int.TryParse(txt_Zip.Text, out int zCode);
                                    SQL.UpdateZip(accountNum, zCode);
                                    zipFlag = true;
                                }
                            }
                            else
                            {
                                zipFlag = false;
                                throw new Exception("Zip Code must be 5 or 9 numbers.");
                            }
                        }
                        else
                        {
                            zipFlag = false;
                        }

                        if (drpd_store.SelectedItem == null)
                        {
                            throw new Exception("Please select a store location to continue.");

                        }
                        else if (drpd_store.SelectedIndex != drpd_store.FindStringExact(data.Rows[0]["location"].ToString()))
                        {
                            if(text_Username.Text == SQL.Username)
                            {
                                throw new Exception("You cannot change your own store. Please contact HR to do so");
                            }
                            else
                            {
                                SQL.Changestore(accountNum, drpd_store.Text);
                                storeFlag = true;
                            }
                            
                        }
                        else
                        {
                            storeFlag = false;
                        }

                        if (txt_Pay.Text.ToLower() == "pay rate" || txt_Pay.Text.Length == 0)
                        {
                            throw new Exception("Pay Rate field must be entered to continue.");

                        }
                        else if (txt_Pay.Text != data.Rows[0]["pay"].ToString())
                        {

                            try
                            {
                                double.TryParse(txt_Pay.Text, out double nPay);
                                if (nPay == 0)
                                {
                                    throw new Exception();
                                }

                                SQL.ChangePay(accountNum, nPay);
                                payFlag = true;
                            }
                            catch
                            {
                                throw new Exception("Pay Rate is not a valid number.");
                            }


                        }
                        else
                        {
                            payFlag = false;
                        }






                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error in Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }

                    if (fNameFlag)
                    {
                        whatUpdated += "First Name, ";
                    }
                    if (lNameFlag)
                    {
                        whatUpdated += "Last Name, ";
                    }
                    if (streetFlag)
                    {
                        whatUpdated += "Street Address, ";
                    }
                    if (cityFlag)
                    {
                        whatUpdated += "City, ";
                    }
                    if (stateFlag)
                    {
                        whatUpdated += "State, ";
                    }
                    if (zipFlag)
                    {
                        whatUpdated += "Zip, ";
                    }
                    if (storeFlag)
                    {
                        whatUpdated += "Store Location, ";
                    }
                    if (payFlag)
                    {
                        whatUpdated += "Pay Rate, ";
                    }

                    if (whatUpdated.Length >= 3) // zip is shortest at 3 excactly.
                    {
                        whatUpdated = whatUpdated.Substring(0, whatUpdated.Length - 2);
                        whatUpdated += ".";

                        MessageBox.Show("The Following was updated: " + whatUpdated, "Update Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nothing was updated", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("This Employee is currently Terminated. Please contact HR to update any records.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                


                

                

            }
            catch
            {
                MessageBox.Show("No User by that username. Please Try Again.", "Enter Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void Btn_Terminate_Click(object sender, EventArgs e)
        {
            try
            {
                accountNum = SQL.GetEmpNum(text_Username.Text);
                

                var data = new DataTable();
                data = SQL.GetEmployee(accountNum);

                if(accountNum == SQL.LoggedInEmpNum )
                {
                    MessageBox.Show("You Cannot terminate yourself", "Illegal Action", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    
                }else if (data.Rows[0]["terminated"].ToString().Substring(0, 1) == "0")
                {
                    DialogResult result = MessageBox.Show("Are you sure you wish to terminate employee " + data.Rows[0]["username"].ToString() + ": " + data.Rows[0]["first_name"].ToString() + " " + data.Rows[0]["last_name"].ToString() + "? Only HR can reverse this.", "Terminate Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        var today = DateTime.Today.ToString("yyyy-MM-dd");
                        SQL.Terminate(accountNum);
                        MessageBox.Show("Employee " + data.Rows[0]["username"].ToString() + ": " + data.Rows[0]["first_name"].ToString() + " " + data.Rows[0]["last_name"].ToString() + " Terminated as of " + today + ".", "No Termination", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Employee not Terminated.", "No Termination", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else
                {
                    MessageBox.Show("That Employee is Already Terminated. Please Contact HR to make any changes.", "No Termination", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                    
            }
            catch
            {
                MessageBox.Show("No User by that username. Please Try Again.", "Enter Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MainForm = new MainForm();
            MainForm.Show();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            SQL.Cleanup();
            this.Hide();
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
        }

        //text boxes show effect

        private void txt_FName_Enter(object sender, EventArgs e)
        {
            String fn = txt_FName.Text;
            if (fn.ToLower().Trim().Equals("first name"))
            {
                txt_FName.Text = "";
                txt_FName.ForeColor = Color.Black;
            }
        }

        private void txt_LName_Enter(object sender, EventArgs e)
        {
            String ln = txt_LName.Text;
            if (ln.ToLower().Trim().Equals("last name"))
            {
                txt_LName.Text = "";
                txt_LName.ForeColor = Color.Black;
            }
        }

        private void txt_Street_Enter(object sender, EventArgs e)
        {
            String street = txt_Street.Text;
            if (street.ToLower().Trim().Equals("street"))
            {
                txt_Street.Text = "";
                txt_Street.ForeColor = Color.Black;
            }
        }

        private void txt_city_Enter(object sender, EventArgs e)
        {
            String city = txt_city.Text;
            if (city.ToLower().Trim().Equals("city"))
            {
                txt_city.Text = "";
                txt_city.ForeColor = Color.Black;
            }
        }

        private void drpd_State_Enter(object sender, EventArgs e)
        {
            String state = drpd_State.Text;
            if (state.ToLower().Trim().Equals("state"))
            {
                drpd_State.Text = "";
                drpd_State.ForeColor = Color.Black;
            }
        }
        private void txt_Zip_Enter(object sender, EventArgs e)
        {
            String zip = txt_Zip.Text;
            if (zip.ToLower().Trim().Equals("zip"))
            {
                txt_Zip.Text = "";
                txt_Zip.ForeColor = Color.Black;
            }
        }

        private void drpd_store_Enter(object sender, EventArgs e)
        {
            String store = drpd_store.Text;
            if (store.ToLower().Trim().Equals("store"))
            {
                drpd_store.Text = "";
                drpd_store.ForeColor = Color.Black;
            }
        }

        private void txt_Pay_Enter(object sender, EventArgs e)
        {
            String pay = txt_Pay.Text;
            if (pay.ToLower().Trim().Equals("pay rate"))
            {
                txt_Pay.Text = "";
                txt_Pay.ForeColor = Color.Black;
            }
        }

        private void text_Username_Enter(object sender, EventArgs e)
        {
            String user = text_Username.Text;
            if (user.ToLower().Trim().Equals("username"))
            {
                text_Username.Text = "";
                text_Username.ForeColor = Color.Black;
            }
        }

        private void txt_FName_Leave(object sender, EventArgs e)
        {
            String street = txt_FName.Text;
            if (street.ToLower().Trim().Equals("first name") || street.Trim().Equals(""))
            {
                txt_FName.Text = "first name";
                txt_FName.ForeColor = Color.LightSeaGreen;
            }
        }

        private void txt_LName_Leave(object sender, EventArgs e)
        {
            String street = txt_LName.Text;
            if (street.ToLower().Trim().Equals("last name") || street.Trim().Equals(""))
            {
                txt_LName.Text = "last name";
                txt_LName.ForeColor = Color.LightSeaGreen;
            }

        }

        private void txt_Street_Leave(object sender, EventArgs e)
        {
            String street = txt_Street.Text;
            if (street.ToLower().Trim().Equals("street") || street.Trim().Equals(""))
            {
                txt_Street.Text = "street";
                txt_Street.ForeColor = Color.LightSeaGreen;
            }
        }

        private void txt_city_Leave(object sender, EventArgs e)
        {
            String street = txt_city.Text;
            if (street.ToLower().Trim().Equals("city") || street.Trim().Equals(""))
            {
                txt_city.Text = "city";
                txt_city.ForeColor = Color.LightSeaGreen;
            }
        }

        private void drpd_State_Leave(object sender, EventArgs e)
        {
            String street = drpd_State.Text;
            if (street.ToLower().Trim().Equals("state") || street.Trim().Equals(""))
            {
                drpd_State.Text = "state";
                drpd_State.ForeColor = Color.LightSeaGreen;
            }
        }

        private void txt_Zip_Leave(object sender, EventArgs e)
        {
            String street = txt_Zip.Text;
            if (street.ToLower().Trim().Equals("zip") || street.Trim().Equals(""))
            {
                txt_Zip.Text = "zip";
                txt_Zip.ForeColor = Color.LightSeaGreen;
            }
        }

        private void drpd_store_Leave(object sender, EventArgs e)
        {
            String street = drpd_store.Text;
            if (street.ToLower().Trim().Equals("store") || street.Trim().Equals(""))
            {
                drpd_store.Text = "store";
                drpd_store.ForeColor = Color.LightSeaGreen;
            }
        }

        private void text_Username_Leave(object sender, EventArgs e)
        {
            String street = text_Username.Text;
            if (street.ToLower().Trim().Equals("username") || street.Trim().Equals(""))
            {
                text_Username.Text = "username";
                text_Username.ForeColor = Color.LightSeaGreen;
            }
        }

        private void txt_Pay_Leave(object sender, EventArgs e)
        {
            String street = txt_Pay.Text;
            double.TryParse(txt_Pay.Text, out double pay);
            if (street.ToLower().Trim().Equals("pay rate") || street.Trim().Equals(""))
            {
                txt_Pay.Text = "pay rate";
                txt_Pay.ForeColor = Color.LightSeaGreen;
            } else if (pay == 0)
            {
                MessageBox.Show("Pay must be a proper number.", "Pay Rate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void txt_FName_Click(object sender, EventArgs e)
        {
            txt_FName.ForeColor = Color.Red;
        }

        private void txt_LName_Click(object sender, EventArgs e)
        {
            txt_LName.ForeColor = Color.Red;
        }

        private void txt_Street_Click(object sender, EventArgs e)
        {
            txt_Street.ForeColor = Color.Red;
        }

        private void txt_city_Click(object sender, EventArgs e)
        {
            txt_city.ForeColor = Color.Red;
        }

        private void drpd_State_Click(object sender, EventArgs e)
        {
            drpd_State.ForeColor = Color.Red;
        }

        private void txt_Zip_Click(object sender, EventArgs e)
        {
            txt_Zip.ForeColor = Color.Red;
        }

        private void drpd_store_Click(object sender, EventArgs e)
        {
            drpd_store.ForeColor = Color.Red;
        }

        private void txt_Pay_Click(object sender, EventArgs e)
        {
            txt_Pay.ForeColor = Color.Red;
        }
    }
}
