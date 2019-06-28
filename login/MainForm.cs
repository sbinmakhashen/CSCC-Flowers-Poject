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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            var date = DateTime.Today.ToString("dddd, dd MMMM yyyy");
            lbl_date.Text = "Today's Date: " + date;

            var data = new DataTable();
            data = SQL.GetEmployee(SQL.GetEmpNum(SQL.Username));

            string fname = data.Rows[0]["first_name"].ToString();

            // Check for empty string.  
            if (string.IsNullOrEmpty(fname))
            {
                fname = "User";
            }else
            {
                fname = char.ToUpper(fname[0]) + fname.Substring(1);
            }
            // Return char and concat substring.  
            
         
            if (!SQL.IsManager)
            {
                lbl_username.Text = "Logged In As: Employee " + SQL.Username + ". Welcome, " + fname;
                btn_employee_setup.Hide();
                btn_accounting.Hide();
                btn_reports.Hide();
                btn_Update_Employee.Hide();
                
            }
            else
            {
                lbl_username.Text = "Logged In As: Manager " + SQL.Username + ". Welcome, " +fname;
            }
            
        }
        
        //Landing Page Go To Labels 
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQL.Cleanup();
            Application.Exit();
            
        }

        private void Btn_Employee_Setup_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewEmployeeForm registerform = new NewEmployeeForm();
            registerform.Show();
        }

        private void Btn_Employee_Setup_MouseEnter(object sender, EventArgs e)
        {
            btn_employee_setup.ForeColor = Color.Yellow;
        }

        private void Btn_Employee_Setup_MouseLeave(object sender, EventArgs e)
        {
            btn_employee_setup.ForeColor = Color.White;
        }
        
        
        private void Btn_New_Employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            UpdateEmployee updateForm = new UpdateEmployee();
            updateForm.Show();
        }

        private void Btn_New_Employee_MouseEnter(object sender, EventArgs e)
        {
            btn_employee_setup.ForeColor = Color.Yellow;
        }

        private void Btn_New_Employee_MouseLeave(object sender, EventArgs e)
        {
            btn_employee_setup.ForeColor = Color.White;
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            SQL.Cleanup();
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }
        private void Btn_Inventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryManagement InventoryManagement = new InventoryManagement();
            InventoryManagement.Show();
        }
        private void Btn_Inventory_MouseEnter(object sender, EventArgs e)
        {
            btn_inventory.ForeColor = Color.Yellow;
        }

        private void Btn_Inventory_MouseLeave(object sender, EventArgs e)
        {
            btn_inventory.ForeColor = Color.White;
        }
        private void Btn_Orders_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderReviewForm OrderReviewForm = new OrderReviewForm();
            OrderReviewForm.Show();
        }

        private void Btn_Orders_MouseEnter(object sender, EventArgs e)
        {
            btn_orders.ForeColor = Color.Yellow;
        }

        private void Btn_Orders_MouseLeave(object sender, EventArgs e)
        {
            btn_orders.ForeColor = Color.White;
        }
        private void Btn_Accounting_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountingInformationForm AccountingInformationForm = new AccountingInformationForm();
            AccountingInformationForm.Show();
        }

        private void Btn_Accounting_MouseEnter(object sender, EventArgs e)
        {
            btn_accounting.ForeColor = Color.Yellow;
        }

        private void Btn_Accounting_MouseLeave(object sender, EventArgs e)
        {
            btn_accounting.ForeColor = Color.White;
        }
        private void Btn_Reports_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportsForm ReportsForm = new ReportsForm();
            ReportsForm.Show();
        }

        private void Btn_Reports_MouseEnter(object sender, EventArgs e)
        {
            btn_reports.ForeColor = Color.Yellow;
        }

        private void Btn_Reports_MouseLeave(object sender, EventArgs e)
        {
            btn_reports.ForeColor = Color.White;
        }

        private void btn_Update_Employee_MouseEnter(object sender, EventArgs e)
        {
            btn_Update_Employee.ForeColor = Color.Yellow;
        }

        private void btn_Update_Employee_MouseLeave(object sender, EventArgs e)
        {
            btn_Update_Employee.ForeColor = Color.White;
        }

        private void Lbl_forgotPW_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePW ChangePW = new ChangePW();
            ChangePW.Show();
        }
    }
}
