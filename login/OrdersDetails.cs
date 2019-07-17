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
        int acctID = 0;

        public OrdersDetails(int oN)
        {
            acctID = 0;
            orderNum = oN;
            InitializeComponent();
            DisplayData();
            lbl_date.Text = "Today's Date is: " +DateTime.Today.ToString("dddd, dd MMMM yyyy");




        }

        public OrdersDetails(int oN, int from)
        {
            acctID = from;
            orderNum = oN;
            InitializeComponent();
            DisplayData();
            lbl_date.Text = "Today's Date is: " + DateTime.Today.ToString("dddd, dd MMMM yyyy");




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
            if(acctID != 0)
            {
                this.Hide();
                var acctDet = new AcctDetails(acctID, false);
                acctDet.Show();
            }
            else
            {
                this.Hide();
                var orderHistory = new OrderReviewForm();
                orderHistory.Show();
            }
            
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

        private void btn_SetRecieved_Click(object sender, EventArgs e)
        {
            /* Order at this point should be status of Ordered and claimed by 0 (no one)
             * 
             * so just in case, we check to see if you've already claimed it (first if)
             * 
             * then if its Received (claimed) and the empNum isnt the current and isnt 0
             * 
             * then if the status is something further along
             */
            DialogResult result;

            if(claimedEmpNum == SQL.LoggedInEmpNum)
            {
                result = MessageBox.Show("You already have claimed this order. Do you want it set it back to just Received?.", "Already Claimed", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
            } else if (curStatus =="Received" && claimedEmpNum != SQL.LoggedInEmpNum && claimedEmpNum != 0)
            {
                result = MessageBox.Show("This order is already claimed by " + claimedUName + ". Are you sure you want to claim it?", "Already Claimed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            }
            else if (curStatus == "Received" && claimedEmpNum != SQL.LoggedInEmpNum && claimedEmpNum == 0)
            {
                result = MessageBox.Show("This order is already set as Recieved, but unclaimed. Are you sure you want to claim it?", "Already Claimed", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            }

            else if (curStatus == "Processed" || curStatus == "Out For Delivery" || curStatus == "Delivered")
            {
                result = MessageBox.Show("This order currently has the status of " + curStatus + ". Are you sure you want to change that?", "Order Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                ReAddQty();
                
            } else if(curStatus == "Canceled" )
            {
                result = MessageBox.Show("This order currently has the status of " + curStatus + ". Are you sure you want to change that?", "Order Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            }
            else
            {

                result = DialogResult.Yes;
            }

            SetNewStatus(result, "Received");
        }





        

        private void btn_SetUnClaimed_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (claimedEmpNum != SQL.LoggedInEmpNum && claimedEmpNum !=0)
            {
                result = MessageBox.Show("You do not have this order. Do you want to remove the current claim?", "Already Claimed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (curStatus == "Ordered"  || claimedEmpNum == 0)
            {
                result = MessageBox.Show("This order is not yet claimed. There is no need to Unclaim it.", "Not Yet Claimed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (curStatus == "Received" ||  curStatus == "Canceled" )
            {
                result = MessageBox.Show("This order currently has the status of " + curStatus + ".\nThis will return the status to Unclaimed and Not Yet Recieved.\nAre you sure you want to change that?", "Order Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            }else if(curStatus == "Processed" || curStatus == "Out For Delivery")
            {
                result = MessageBox.Show("This order currently has the status of " + curStatus + ".\nThis will return the status to Unclaimed and Not Yet Recieved.\nAre you sure you want to change that?", "Order Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                ReAddQty();
            }
            else
            {

                result = DialogResult.Yes;
            }

            SetNewStatus(result, "Ordered");
        }

        private void btn_SetProcessed_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (claimedEmpNum != SQL.LoggedInEmpNum && claimedEmpNum != 0)
            {
                result = MessageBox.Show("You are not the Processor of this Order. Do you want to set its status as Ready for delivery?", "Already Claimed", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                

            }
            else if (curStatus == "Ordered" || claimedEmpNum == 0)
            {
                result = MessageBox.Show("This order is not yet claimed. Please claim it before continuing.", "Not Yet Claimed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (curStatus == "Received" || curStatus == "Canceled")
            {
                result = MessageBox.Show("This order currently has the status of " + curStatus + ". Are you sure you want to change that?", "Order Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                DeductQty();
            }
            else if(curStatus == "Out For Delivery")
            {
                result = MessageBox.Show("This order currently has the status of " + curStatus + ". Are you sure you want to change that?", "Order Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
            }
            else
            {

                result = DialogResult.Yes;
                DeductQty();
            }

            SetNewStatus(result, "Processed");
            
        }

        private void btn_SetOutForDelivery_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (claimedEmpNum != SQL.LoggedInEmpNum && claimedEmpNum != 0)
            {
                result = MessageBox.Show("You do not have this order. Do you want to set its status as On the Truck?", "Already Claimed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            else if (curStatus == "Ordered" || claimedEmpNum == 0)
            {
                result = MessageBox.Show("This order is not yet claimed. Please claim it before continuing.", "Not Yet Claimed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (curStatus == "Received" )
            {
                result = MessageBox.Show("This order currently has the status of " + curStatus + ". Are you sure you want to change that?", "Order Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                DeductQty();

            }else if (curStatus == "Processed" || curStatus == "Canceled")
            {
                result = MessageBox.Show("This order currently has the status of " + curStatus + ". Are you sure you want to change that?", "Order Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
            }
            else
            {

                result = DialogResult.Yes;
            }

            SetNewStatus(result, "Out for Delivery");
        }

        private void btn_SetCancel_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (claimedEmpNum != SQL.LoggedInEmpNum && claimedEmpNum != 0)
            {
                result = MessageBox.Show("You do not have this order. Do you want to set its status as Canceled", "Already Claimed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (curStatus == "Ordered" || claimedEmpNum == 0)
            {
                result = MessageBox.Show("This order is not yet claimed. Please claim it before continuing.", "Not Yet Claimed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (curStatus == "Canceled")
            {
                result = MessageBox.Show("This Order is already canceled", "No Change", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                result = MessageBox.Show("This order currently has the status of " + curStatus + ". Are you sure you want to change that?", "Cancel Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            }

            SetNewStatus(result, "Canceled");
        }





        private void SetNewStatus(DialogResult result, string newStatus)
        {
            if (result == DialogResult.Yes)
            {

                try
                {
                    if(newStatus == "Ordered")
                    {
                        UnClaim(DialogResult.Yes, 0);
                        SQL.ChangeStatus(orderNum, 0);
                    }
                    else
                    {
                        SQL.ChangeStatus(orderNum, newStatus);
                        MessageBox.Show("Order Status updated to " + newStatus + ".", "Order Status Changed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayData();
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("The order status was not changed. It is still " + curStatus + ".", "No change made", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UnClaim(DialogResult result, int emp)
        {
            if (result == DialogResult.Yes)
            {

                try
                {
                    SQL.ChangeStatus(orderNum, emp);

                    if(emp == 0)
                    {
                        MessageBox.Show("Order status reverted to unclaimed.", "Order Status Changed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lbl_OrderStatus.Text = "Ordered";
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

        private void Close_pic_Click(object sender, EventArgs e)
        {
            SQL.Cleanup();
            this.Hide();
            var loginForm = new LoginForm();
            loginForm.Show();
        }

        private void Previous_pic_Click(object sender, EventArgs e)
        {
            if (acctID != 0)
            {
                this.Hide();
                var acctDet = new AcctDetails(acctID, false);
                acctDet.Show();
            }
            else
            {
                this.Hide();
                var orderHistory = new OrderReviewForm();
                orderHistory.Show();
            }
        }


        private void DeductQty()
        {
            foreach (DataGridViewRow row in dgv_OrderItems.Rows)
            {
                int productID = SQL.GetItemId(row.Cells["item_name"].Value.ToString());
                int.TryParse(row.Cells["qty"].Value.ToString(), out int orderQty);
                int curStock = SQL.CheckStock(productID);
                try
                {
                    if(orderQty > curStock)
                    {
                        throw new Exception("There is not enough stock to complete this item.");
                    }
                    else
                    {
                        SQL.ChangeQty(productID, curStock - orderQty);
                    }

                    

                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
        }

        private void ReAddQty()
        {
            {
                foreach (DataGridViewRow row in dgv_OrderItems.Rows)
                {
                    int productID = SQL.GetItemId(row.Cells["item_name"].Value.ToString());
                    int.TryParse(row.Cells["qty"].Value.ToString(), out int orderQty);
                    int curStock = SQL.CheckStock(productID);
                    try
                    {
                        
                        {
                            SQL.ChangeQty(productID, curStock + orderQty);
                        }



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
        }
    }
}
