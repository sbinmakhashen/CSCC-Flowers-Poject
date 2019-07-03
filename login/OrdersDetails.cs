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
        int claimedEmpNum = 0;
        DataTable orderData = new DataTable();
        string claimedFName = "Not Claimed";
        string claimedUName = null;
        string curStatus = "No Status";

        public OrdersDetails(int oN)
        {
            orderNum = oN;
            InitializeComponent();
            DisplayData();
            lbl_date.Text = "Today's Date is: " +DateTime.Today.ToString("dddd, dd MMMM yyyy");




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


        /* These buttons set the status of the order. The statuses are:
         * 
         * Ordered - The customer has put the order in the website. Nothing has been done at the store.
         * Recieved - An employee has claimed the order and is working on it.
         * Processed - The order is finished, and waiting for the delivery drivers
         * Out for Delivery - The order is on the truck.
         * Delivered  - The order has been delivered
         * Canceled - The customer canceled the order
         */

        private void Btn_Processing_Click(object sender, EventArgs e)
        {
            /* Order at this point should be status of Ordered and claimed by 0 (no one)
             * 
             * so just in case, we check to see if you've already claimed it (first if)
             * 
             * then if its Received (claimed) and the empNum isnt the current and isnt 0
             * 
             * then if the status is something further along
             */

            if(claimedEmpNum == SQL.LoggedInEmpNum)
            {
                MessageBox.Show("You already have claimed this order.", "Already Claimed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else if (curStatus =="Received" && claimedEmpNum != SQL.LoggedInEmpNum && claimedEmpNum != 0)
            {
                DialogResult result = MessageBox.Show("This order is already claimed by " + claimedUName + ". Are you sure you want to claim it?", "Already Claimed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                ChangeStatus(result, "Received");
            }


            else if (curStatus == "Processed" || curStatus == "Canceled" || curStatus == "Out For Delivery" || curStatus == "Delivered")
            {
               DialogResult result= MessageBox.Show("This order currently has the status of " + curStatus + ". Are you sure you want to change that?", "Order Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                ChangeStatus(result, "Received");
            }
        }





        

        private void Btn_Unclaim_Click(object sender, EventArgs e)
        {
            if (claimedEmpNum != SQL.LoggedInEmpNum && claimedEmpNum !=0)
            {
                DialogResult result = MessageBox.Show("You do not have this order. Do you want to unclaim it?", "Already Claimed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChangeStatus(result, 0);

            }
            else if (curStatus == "Ordered"  || claimedEmpNum == 0)
            {
                DialogResult result = MessageBox.Show("This order is not yet claimed. Please claim it before unclaiming.", "Not Yet Claimed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


            else if (curStatus == "Processed" || curStatus == "Canceled" || curStatus == "Out For Delivery")
            {
                DialogResult result = MessageBox.Show("This order currently has the status of " + curStatus + ". Are you sure you want to change that?", "Order Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                ChangeStatus(result, 0);
            }
        }

        private void Btn_SetComplete_Click(object sender, EventArgs e)
        {
            if (claimedEmpNum != SQL.LoggedInEmpNum && claimedEmpNum != 0)
            {
                DialogResult result = MessageBox.Show("You do not have this order. Do you want to set its status as Ready for delivery?", "Already Claimed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChangeStatus(result, "Processed");

            }
            else if (curStatus == "Ordered" || claimedEmpNum == 0)
            {
                DialogResult result = MessageBox.Show("This order is not yet claimed. Please claim it before continuing.", "Not Yet Claimed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (curStatus == "Received" || curStatus == "Canceled" || curStatus == "Out For Delivery")
            {
                DialogResult result = MessageBox.Show("This order currently has the status of " + curStatus + ". Are you sure you want to change that?", "Order Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                ChangeStatus(result, "Processed");
            }
        }

        private void Btn_outDel_Click(object sender, EventArgs e)
        {
            if(claimedEmpNum != SQL.LoggedInEmpNum && claimedEmpNum != 0)
            {
                DialogResult result = MessageBox.Show("You do not have this order. Do you want to set its status as On the Truck?", "Already Claimed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChangeStatus(result, "Out for Delivery");

            }
            else if (curStatus == "Ordered" || claimedEmpNum == 0)
            {
                DialogResult result = MessageBox.Show("This order is not yet claimed. Please claim it before continuing.", "Not Yet Claimed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (curStatus == "Received" || curStatus == "Canceled" || curStatus == "Processed")
            {
                DialogResult result = MessageBox.Show("This order currently has the status of " + curStatus + ". Are you sure you want to change that?", "Order Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                ChangeStatus(result, "Out For Delivery");
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            if (claimedEmpNum != SQL.LoggedInEmpNum && claimedEmpNum != 0)
            {
                DialogResult result = MessageBox.Show("You do not have this order. Do you want to set its status as Canceled", "Already Claimed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ChangeStatus(result, "Canceled");

            }
            else if (curStatus == "Ordered" || claimedEmpNum == 0)
            {
                DialogResult result = MessageBox.Show("This order is not yet claimed. Please claim it before continuing.", "Not Yet Claimed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (curStatus == "Canceled")
            {
                MessageBox.Show("This Order is already canceled", "No Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                DialogResult result = MessageBox.Show("This order currently has the status of " + curStatus + ". Are you sure you want to change that?", "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                ChangeStatus(result, "Canceled");
            }
        }





        private void ChangeStatus(DialogResult result, string status)
        {
            if (result == DialogResult.Yes)
            {

                try
                {
                    SQL.ChangeStatus(orderNum, status);
                    MessageBox.Show("Order Status updated to " + status + ".", "Order Status Changed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisplayData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("The order status was not changed. It is still" + curStatus + ".", "No change made", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ChangeStatus(DialogResult result, int emp)
        {
            if (result == DialogResult.Yes)
            {

                try
                {
                    SQL.ChangeStatus(orderNum, emp);

                    if(emp == 0)
                    {
                        MessageBox.Show("Order status reverted to unclaimed.", "Order Status Changed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else
                    {
                        var data = new DataTable();
                        data = SQL.GetEmployee(emp);
                        string empFName = data.Rows[0]["first_name"].ToString();
                        string empUName = data.Rows[0]["username"].ToString();
                        MessageBox.Show("Order Status assigned to "+empUName+", "+empFName+".", "Order Status Changed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    DisplayData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("The order status was not changed. It is still" + curStatus + ".", "No change made", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DisplayData()
        {
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
            dgv_OrderItems.Columns[8].Visible = false;
            dgv_OrderItems.Columns[8].HeaderText = "Claimed By";
            try
            {
                int.TryParse(dgv_OrderItems.Rows[0].Cells["emp_num"].Value.ToString(), out claimedEmpNum);

                if(claimedEmpNum!=0)//ie: the order is actually claimed
                {
                    var data = new DataTable();
                    data = SQL.GetEmployee(claimedEmpNum);
                    claimedFName = data.Rows[0]["first_name"].ToString();
                    claimedUName = data.Rows[0]["username"].ToString();
                    lbl_empClaimed.Text = "Claimed By: " + claimedFName + ", Username: " + claimedUName;
                } else //order unclaimed, hence 0 emp_num
                {
                    lbl_empClaimed.Text = "Claimed By: Unclaimed";
                }

                curStatus = dgv_OrderItems.Rows[0].Cells["order_status"].Value.ToString();
                lbl_OrderNumber.Text = "Order Number: " + dgv_OrderItems.Rows[0].Cells["order_num"].Value.ToString();
                lbl_Paid.Text = "Paid? " + dgv_OrderItems.Rows[0].Cells["pay_rec"].Value.ToString();
                lbl_Total.Text = "Total: " + dgv_OrderItems.Rows[0].Cells["total"].Value.ToString();
                lbl_delAdd.Text = "Delivery Address:\n" + dgv_OrderItems.Rows[0].Cells["del_addy"].Value.ToString();
                lbl_DelDate.Text = "Delivery Date: " + dgv_OrderItems.Rows[0].Cells["del_date"].Value.ToString();
                lbl_OrderStatus.Text = "Order Status: " + dgv_OrderItems.Rows[0].Cells["order_status"].Value.ToString();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
