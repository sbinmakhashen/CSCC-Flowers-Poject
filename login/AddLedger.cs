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

namespace login
{
    public partial class AddLedger : Form
    {
        public AddLedger()
        {
            InitializeComponent();
            lbl_StoreName.Text = SQL.DefaultStore;
            lbl_Date.Text = "Today's Date is: " + DateTime.Today.ToString("dddd, dd MMMM yyyy");


            lbl_entryParticular.Hide();
            cmb_Particular.Hide();
            lbl_entryDetail.Hide();
            cmb_Detail.Hide();
            txt_ItemID.Hide();
            lbl_entryItem.Hide();
            txt_Correction.Hide();
            lbl_entryCorrection.Hide();
        }

        private void Close_pic_Click(object sender, EventArgs e)
        {
            SQL.Cleanup();
            var login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void Previous_pic_Click(object sender, EventArgs e)
        {
            var report = new ReportsForm();
            this.Hide();
            report.Show();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            string type, particular = null, reason;

            var today = DateTime.Today;
            string monthYr = today.Month + "/" + today.Year;
            int index = cmb_Type.SelectedIndex;
            type = cmb_Type.SelectedItem.ToString();
            if (index == 0)
            {
                particular = "Cash Sales for " + monthYr;
            } else if (index == 1)
            {

                particular = cmb_Particular.SelectedItem.ToString();

            } else if (index == 2)
            {
                particular = "Utilities for " + monthYr;
            }
            else if (index == 3)
            {
                particular = "Payroll for " + monthYr;
            }
            else if (index == 4)
            {
                particular = "Inventory Purchase of Item #" + txt_ItemID.Text;
            }
            else if (index == 5)
            {
                particular = "Correction: " + txt_Correction.Text;
            }
     

            if(cmb_Particular.SelectedIndex==1)
            {
                reason = cmb_Detail.SelectedItem.ToString();
                particular += "(" + reason + ")";
            }

            double.TryParse(txt_Amt.Text, out double amount);




            try
            {

                 if (cmb_Particular.SelectedIndex >-1)
                {
                    throw new Exception("Please fill out all fields");
                }

                if (cmb_Detail.SelectedIndex >-1)
                {
                    throw new Exception("Please fill out all fileds");
                }

                if (cmb_Type.SelectedIndex >-1)
                {
                    throw new Exception("Please fill out all fileds");
                }

                if (txt_Amt.Text.ToLower() == "amount" || txt_Amt.Text.Length == 0)
                {
                    throw new Exception("Amount field must be entered to continue.");

                }
                else if (double.TryParse(txt_Amt.Text, out amount))

                {
                    Console.WriteLine(amount);

                }
                else
                {
                    throw new Exception("That is not a valid number");
                }


        SQL.NewLedgerEntry(type, particular, amount);

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private void Cmb_Particular_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Particular.SelectedIndex == 1)
            {
                lbl_entryDetail.Show();
                cmb_Detail.Show();
            }
            else
            {
                lbl_entryDetail.Hide();
                cmb_Detail.Hide();
            }
            
        }

        private void Cmb_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_entryParticular.Hide();
            cmb_Particular.Hide();
            txt_ItemID.Hide();
            lbl_entryItem.Hide();
            txt_Correction.Hide();
            lbl_entryCorrection.Hide();

            if (cmb_Type.SelectedIndex == 1)
            {
                lbl_entryParticular.Show();
                cmb_Particular.Show();
            }
            if (cmb_Type.SelectedIndex == 4)
            {
                txt_ItemID.Show();
                lbl_entryItem.Show();
            }
            if (cmb_Type.SelectedIndex == 5)
            {
                txt_Correction.Show();
                lbl_entryCorrection.Show();
            }


        }
    }
}
