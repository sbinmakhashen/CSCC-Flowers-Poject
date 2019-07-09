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
    public partial class AccountingInformationForm : Form
    {

        bool receiving = false, payable=false;

        public AccountingInformationForm()
        {
            InitializeComponent();
            lbl_StoreName.Text = SQL.DefaultStore;
            lbl_TableViewing.Text = "";
            lbl_Date.Text = "Today's Date is: " + DateTime.Today.ToString("dddd, dd MMMM yyyy");

        }



        private void labelClose_Click(object sender, EventArgs e)
        {
            SQL.Cleanup();
            var login = new LoginForm();
            this.Hide();
            login.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MainForm = new MainForm();
            MainForm.Show();
        }

        

       
        

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if(receiving)
            {
                dgv_accounting.DataSource = null;
                DisplayRecievableData();
            } else if(payable)
            {
                dgv_accounting.DataSource = null;
                DisplayPayableData();
            }
            

        }

        private void AccountingInformationForm_Load(object sender, EventArgs e)
        {
            
           
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            String fname = textBoxSearch.Text;
            if (fname.ToLower().Trim().Equals("search here...."))
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black;
            }
        }

        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            String fname = textBoxSearch.Text;
            if (fname.ToLower().Trim().Equals("search here....") || fname.Trim().Equals(""))
            {
                textBoxSearch.Text = "Search Here....";
                textBoxSearch.ForeColor = Color.IndianRed;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_AcctPay_Click(object sender, EventArgs e)
        {
            DisplayPayableData();
        }



        public void DisplayPayableData()
        {
            var data = new DataTable();

            data = SQL.AcctPay();
            dgv_accounting.DataSource = data;
            lbl_TableViewing.Text = "Accounts Payable";

            dgv_accounting.Columns[0].HeaderText = "ID Number";
            dgv_accounting.Columns[0].Visible = false;
            dgv_accounting.Columns[1].HeaderText = "Invoice #";
            dgv_accounting.Columns[2].HeaderText = "Vendor";
            dgv_accounting.Columns[3].HeaderText = "Total";
            dgv_accounting.Columns[4].HeaderText = "Amt Paid";
            dgv_accounting.Columns[5].HeaderText = "Remaining";
            dgv_accounting.Columns[6].HeaderText = "Location";
            dgv_accounting.Columns[6].Visible = false;
            dgv_accounting.Columns[7].HeaderText = "Due By";
            dgv_accounting.Columns[8].HeaderText = "Paid On";
            dgv_accounting.Sort(dgv_accounting.Columns[7], ListSortDirection.Descending);

            //flags for knowing what table we are in for the buttons to work with either.
            payable = true;
            receiving = false;
        }

        private void Btn_AcctRec_Click(object sender, EventArgs e)
        {
            DisplayRecievableData();
        }

        public void DisplayRecievableData()
        {
            var data = new DataTable();

            data = SQL.GetAcRec();
            dgv_accounting.DataSource = data;
            lbl_TableViewing.Text = "Accounts Receivable";

            dgv_accounting.Columns[0].HeaderText = "Invoice #";
            dgv_accounting.Columns[1].HeaderText = "Order #";
            dgv_accounting.Columns[2].HeaderText = "Customer #";
            dgv_accounting.Columns[3].HeaderText = "Total";
            dgv_accounting.Columns[4].HeaderText = "Amt Paid";
            dgv_accounting.Columns[5].HeaderText = "Remaining";
            dgv_accounting.Columns[6].HeaderText = "Location";
            dgv_accounting.Columns[6].Visible = false;
            dgv_accounting.Columns[7].HeaderText = "Due By";
            dgv_accounting.Columns[8].HeaderText = "Paid On";
            dgv_accounting.Sort(dgv_accounting.Columns[7], ListSortDirection.Descending);


            //flags for what table we are in to know what the buttons should do.
            receiving = true;
            payable = false;
        }
    }
}
