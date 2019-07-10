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
    public partial class AcctDetails : Form
    {

        int idNum = 0;
        bool typeFlag;
        double remainder;
        int orderNum = 0;
        

        public AcctDetails(int iN, bool flag)
        {
            idNum = iN;
            InitializeComponent();
            lbl_date.Text = "Today's Date is: " + DateTime.Today.ToString("dddd, dd MMMM yyyy");
            lbl_lateWarning.Hide();
            lbl_paidOff.Hide();
            typeFlag = flag;

            if (flag) // flag : true == Payable, false == Receivable
            {
                DisplayPayData();
                btn_viewOrder.Hide();
                lbl_recEmail.Hide();
                lbl_recAddy.Hide();
                lbl_recName.Hide();
            }
            else
            {
                DisplayRecData();
                btn_viewOrder.Show();
                lbl_recEmail.Show();
                lbl_recAddy.Show();
                lbl_recName.Show();
            }


        }

        public void DisplayPayData()
        {
            var data = new DataTable();

            data = SQL.AcctPay(idNum);


            double.TryParse(data.Rows[0]["remainder"].ToString(), out remainder);

            lbl_Title.Text = "Accounts Payable Details";
            lbl_Vendor.Text = "Vendor: " + data.Rows[0]["vendor"].ToString();
            lbl_amtOwed.Text = "Amount still owed: $" + data.Rows[0]["amt"].ToString();
            lbl_paid.Text = "Amount paid to date: $" + data.Rows[0]["amt_paid"].ToString();
            lbl_remain.Text = "Amount remaining: $" + remainder;
            lbl_invoice.Text = "Vendor's Invoice #: " + data.Rows[0]["invoice_num"].ToString();

           


            DateTime.TryParse(data.Rows[0]["due_date"].ToString(), out DateTime dueDate);
            DateTime.TryParse(data.Rows[0]["paid_Date"].ToString(), out DateTime paidDate);
            lbl_due.Text = "Due Date: " + dueDate.ToString("yyyy-MM-dd");

            if (dueDate <= DateTime.Now)
            {
                lbl_lateWarning.Show();
            }

            if(remainder == 0)
            {
                lbl_lateWarning.Hide();
                lbl_paidOff.Show();
                lbl_due.Text = "Due Date: " + dueDate.ToString("yyyy-MM-dd")+ ".\nPaid Off On: " + paidDate.ToString("yyyy-MM-dd");
            }
            txt_payment.Text = remainder.ToString();

        }

        public void DisplayRecData()
        {
            var data = new DataTable();

            data = SQL.GetAcRecDetail(idNum);
            int.TryParse(data.Rows[0]["order_num"].ToString(), out  orderNum);
            DateTime.TryParse(data.Rows[0]["due_date"].ToString(), out DateTime dueDate);
            DateTime.TryParse(data.Rows[0]["paid_Date"].ToString(), out DateTime paidDate);
            DateTime.TryParse(data.Rows[0]["trans_date"].ToString(), out DateTime transDate);
            double.TryParse(data.Rows[0]["remainder"].ToString(), out remainder);



            //order_status, pay_type, trans_date, 

            lbl_Title.Text = "Accounts Receivable Details";
            lbl_Vendor.Text = "Invoice #: " + data.Rows[0]["invoice_num"].ToString();
            lbl_amtOwed.Text = "Amount still owed: $" + data.Rows[0]["amt"].ToString();
            lbl_paid.Text = "Amount paid to date: $" + data.Rows[0]["amt_paid"].ToString();
            lbl_remain.Text = "Amount remaining: $" + remainder;
            lbl_invoice.Text = "Recievable Account Information For Order Number: " + orderNum;
            
            
            lbl_recName.Text = "Name ( #Account Number ): " + data.Rows[0]["first_name"].ToString() + " " + data.Rows[0]["last_name"].ToString() + " ( #" + data.Rows[0]["acct_num"].ToString() + " )";
            lbl_recAddy.Text = "Address:\n\n\t\t" + data.Rows[0]["street"].ToString() + "\n\t\t" + data.Rows[0]["city"].ToString() + ", " + data.Rows[0]["state"].ToString() + " " + data.Rows[0]["zip"].ToString();
            lbl_recEmail.Text = "Email: " + data.Rows[0]["email"].ToString(); 



            lbl_due.Text = "Due Date: " + dueDate.ToString("yyyy-MM-dd");

            if (dueDate <= DateTime.Now)
            {
                lbl_lateWarning.Show();
            }

            if (remainder == 0)
            {
                lbl_lateWarning.Hide();
                lbl_paidOff.Show();
                lbl_due.Text = "Due Date: " + dueDate.ToString("yyyy-MM-dd") + ".\nPaid Off On: " + paidDate.ToString("yyyy-MM-dd");
            }
            txt_payment.Text = remainder.ToString();
        }

        private void Lbl_previous_Click(object sender, EventArgs e)
        {

           
            if (typeFlag) // flag : true = Payable, false = receivable
            {
                var accts = new AccountingInformationForm(1); // 1 is a flag for the Overload, to auto put up AcctPayable
                accts.Show();
                this.Hide();
            }
            else if (!typeFlag)
            {
                var accts = new AccountingInformationForm(2); // 2 is a flag for the Overload to auto display Acct Rec
                accts.Show();
                this.Hide();
            }
            else//somehow null???
            {
                var accts = new AccountingInformationForm(); // and just in case something goes weird, here. Default form.
                accts.Show();
                this.Hide();
            }

            



        }

        private void Lbl_close_Click(object sender, EventArgs e)
        {
            SQL.Cleanup();
        
            var login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void Btn_Payment_Click(object sender, EventArgs e)
        {
         
            if (!double.TryParse(txt_payment.Text, out double payAmt))
            {
                MessageBox.Show("Payment must be a valid number.", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if(Math.Round(payAmt, 2) != payAmt)
            {
                MessageBox.Show("Cannot process fractions of a cent.", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (payAmt <0)
            {
                MessageBox.Show("Payment cannot be negative. If the balance must be changed, contact Accounting", "Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }else if (typeFlag) // flag: true = Accounts Payable
            {
                try
                {
                    
                    SQL.AcctPayPmt(idNum, payAmt);

                    MessageBox.Show("Payment of " + payAmt.ToString("$#.##") + " accepted.", "Payment Recorded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayPayData();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else if (!typeFlag) // flag : false = Accounts Rec
            {
                try
                {

                    SQL.AccRecPmt(idNum, payAmt);

                    MessageBox.Show("Payment of " + payAmt.ToString("$#.##") + " accepted.", "Payment Recorded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayRecData();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else // shouldn't be possible? But just in case something funky happens...
            {
                throw new Exception("Error: Contact IT (Error Code: NotPayRecFlag)");
            }
            
        }

        private void Btn_viewOrder_Click(object sender, EventArgs e)
        {
            OrdersDetails order = new OrdersDetails(orderNum, idNum);
            this.Hide();
            order.Show();

        }
    }
}
