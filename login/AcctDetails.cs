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
    public partial class AcctDetails : Form
    {

        int idNum = 0;

        public AcctDetails(int iN, bool Type)
        {
            idNum = iN;
            InitializeComponent();
            lbl_date.Text = "Today's Date is: " + DateTime.Today.ToString("dddd, dd MMMM yyyy");
            lbl_lateWarning.Hide();
            lbl_paidOff.Hide();

            if (Type) // flag : true == Payable, false == Receivable
            {
                DisplayPayData();
            }
            else
            {
                DisplayRecData();
            }


        }

        public void DisplayPayData()
        {
            var data = new DataTable();

            data = SQL.AcctPay(idNum);

            var due = new DateTime();

            double.TryParse(data.Rows[0]["remainder"].ToString(), out double remainder);

            lbl_Title.Text = "Accounts Payable Details";
            lbl_Vendor.Text = "Vendor: " + data.Rows[0]["vendor"].ToString();
            lbl_amtOwed.Text = "Amount still owed: " + data.Rows[0]["amt"].ToString();
            lbl_paid.Text = "Amount paid to date: " + data.Rows[0]["amt_paid"].ToString();
            lbl_remain.Text = "Amount remaining: " + remainder;
            lbl_invoice.Text = "Vendor's Invoice #: " + data.Rows[0]["invoice_num"].ToString();

            double.TryParse(data.Rows[0]["due_date"].ToString(), out double unixDate);
            


            DateTime.TryParseExact(uF.UnixTimeStampToDateTime(unixDate).ToString("yyyy -MM-dd HH:mm:ss"), "yyyy -MM-dd HH:mm:ss", null, 0, out DateTime dueDate);

            lbl_due.Text = "Due Date: " + dueDate.ToString("yyyy-MM-dd");

            if (dueDate <= DateTime.Now)
            {
                lbl_lateWarning.Show();
            }

            if(remainder == 0)
            {
                lbl_lateWarning.Hide();
                lbl_paidOff.Show();
            }
            txt_payment.Text = remainder.ToString();

        }

        public void DisplayRecData()
        {

        }

        private void Lbl_previous_Click(object sender, EventArgs e)
        {
            var accts = new AccountingInformationForm();
            accts.Show();
            this.Hide();
            
        }

        private void Lbl_close_Click(object sender, EventArgs e)
        {
            SQL.Cleanup();
            var login = new LoginForm();
            login.Show();
            this.Hide();
        }

        
    }
}
