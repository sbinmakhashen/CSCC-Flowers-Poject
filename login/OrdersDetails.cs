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
    public partial class OrdersDetails : Form
    {
        int orderNum = 0;
        DataTable orderData = new DataTable();
        public OrdersDetails(int oN)
        {
            orderNum = oN;
            InitializeComponent();
            orderData = SQL.GetOrderItems(orderNum);
            dgv_OrderItems.DataSource = orderData;

            dgv_OrderItems.Columns[0].HeaderText = "Order Number";
            dgv_OrderItems.Columns[0].Visible = false;
            dgv_OrderItems.Columns[1].HeaderText = "Item Name";
            dgv_OrderItems.Columns[2].HeaderText = "Quantity";
            dgv_OrderItems.Columns[3].HeaderText = "Total";
            dgv_OrderItems.Columns[3].Visible = false;
            dgv_OrderItems.Columns[4].HeaderText = "Paid?";
            dgv_OrderItems.Columns[4].Visible = false;
            dgv_OrderItems.Columns[5].HeaderText = "Delivery Date";
            dgv_OrderItems.Columns[5].Visible = false;
            dgv_OrderItems.Columns[6].HeaderText = "Order Status";
            dgv_OrderItems.Columns[6].Visible = false;
            dgv_OrderItems.Columns[7].HeaderText = "Delivery Address";
            dgv_OrderItems.Columns[7].Visible = false;
            try
            {
                lbl_OrderNumber.Text ="Order Number: "+ dgv_OrderItems.Rows[0].Cells["order_num"].Value.ToString();
                lbl_Paid.Text ="Paid? "+ dgv_OrderItems.Rows[0].Cells["pay_rec"].Value.ToString();
                lbl_Total.Text ="Total: "+ dgv_OrderItems.Rows[0].Cells["total"].Value.ToString();
                lbl_delAdd.Text ="Delivery Address:\n"+ dgv_OrderItems.Rows[0].Cells["del_addy"].Value.ToString();
                lbl_DelDate.Text ="Delivery Date: "+ dgv_OrderItems.Rows[0].Cells["del_date"].Value.ToString();
                lbl_OrderStatus.Text ="Order Status: "+ dgv_OrderItems.Rows[0].Cells["order_status"].Value.ToString();
                
            } catch
            {
                
            }
            
            
            
        }

        private void Lbl_logout_Click(object sender, EventArgs e)
        {
            SQL.Cleanup();
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void Lbl_previous_Click(object sender, EventArgs e)
        {
            this.Hide();
            var orderHistory = new OrderReviewForm();
            orderHistory.Show();
        }
    }
}
