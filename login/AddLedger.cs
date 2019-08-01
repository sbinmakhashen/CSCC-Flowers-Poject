using CcnSession;
using System;
using System.Data;
using System.Windows.Forms;

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
            

            try
            {
                if (index == 0)
                {
                    particular = "Cash Sales for " + monthYr;
                }
                else if (index == 1)
                {
                    if (cmb_Particular.SelectedIndex == -1)
                    {
                        throw new Exception("Please Select a reason for the expense");
                    }
                    particular = cmb_Particular.SelectedItem.ToString();

                }
                else if (index == 2)
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

                if (cmb_Particular.SelectedIndex == 1)
                {
                    reason = cmb_Detail.SelectedItem.ToString();
                    particular += "(" + reason + ")";
                }

                double.TryParse(txt_Amt.Text, out double amount);

                if (cmb_Type.SelectedIndex == -1)
                {
                    throw new Exception("Please fill out all fields");
                }
                if (txt_Amt.Text.ToLower() == "amount" || txt_Amt.Text.Length == 0)
                {
                    throw new Exception("Amount field must be entered to continue.");

                }
                if (!double.TryParse(txt_Amt.Text, out amount) || amount ==0)
                {
                    throw new Exception("That is not a valid number");

                }

                if (index==1 && cmb_Particular.SelectedIndex == -1)
                {
                    throw new Exception("Please fill out all fields");
                }

                if (cmb_Particular.SelectedIndex==1 && cmb_Detail.SelectedIndex == -1)
                {
                    throw new Exception("Please fill out all fields");
                }

                SQL.NewLedgerEntry(type, particular, amount);

                /* what... was this for?
                var data = new DataTable();
                cmb_Type.SelectedIndex = cmb_Type.FindStringExact(data.Rows[0]["type"].ToString());
                cmb_Particular.SelectedIndex = cmb_Particular.FindStringExact(data.Rows[0]["particular"].ToString());
                txt_ItemID.Text = data.Rows[0]["inventory_item"].ToString();
                cmb_Detail.SelectedIndex = cmb_Detail.FindStringExact(data.Rows[0]["detail"].ToString());
                txt_Amt.Text = data.Rows[0]["amount"].ToString();
                txt_Correction.Text = data.Rows[0]["correction_reason"].ToString();
                */

                MessageBox.Show("Succesfully added entry of:\n" + type + ", " + particular + ", for amount of " + amount + ".", "Entry Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
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
