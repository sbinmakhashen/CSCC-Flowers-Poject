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
    public partial class InventoryManagement : Form
    {

        int ProductID; // stores the ItemID being adjusted
        int tempQty; // for use in error checking against moving/deleting too much item
        string viewStore; // stores the store being currently viewed
        string ItemName; // stores the name of the item being adjusted
        bool isHomeStore = true; // flag for if viewing home store (and allowing the doubleclick on the grid)
        DataTable inventoryData = new DataTable();

        public InventoryManagement()
        {
            InitializeComponent();
            lbl_name.Text = "";
            
            viewStore = SQL.DefaultStore;
            isHomeStore = true;


            var date = DateTime.Today.ToString("dddd, dd MMMM yyyy");
            

            var data = new DataTable();
            data = SQL.GetEmployee(SQL.GetEmpNum(SQL.Username));

            string fname = data.Rows[0]["first_name"].ToString();
            lbl_date.Text = "Today's Date is: " + DateTime.Today.ToString("dddd, dd MMMM yyyy");

            // Check for empty string.  
            if (string.IsNullOrEmpty(fname))
            {
                fname = "User";
            }
            else
            {
                fname = char.ToUpper(fname[0]) + fname.Substring(1);
            }

            

            if (SQL.IsManager)
            {
                lbl_loginInfo.Text = "Hello "+fname+". You are logged in as " + SQL.Username + ", a Manager.";
                btn_IncreaseQty.Show();
                lbl_product.Show();
                lbl_stock.Show();
                textBoxStockQty.Show();
                lbl_name.Hide();
                lbl_ChangeQty.Show();
                txt_ChangeQty.Show();
                btn_IncreaseQty.Show();
                btn_Send2Store.Hide();
                Store_DropDown.Show();
            } else
            {
                lbl_loginInfo.Text = "Hello " + fname + ". You are logged in as " + SQL.Username + ", a Employee. Todays Date is " + date + ".";
                btn_IncreaseQty.Hide();
                lbl_product.Hide();
                lbl_stock.Hide();
                lbl_name.Hide();
                textBoxStockQty.Hide();
                lbl_ChangeQty.Hide();
                txt_ChangeQty.Hide();
                btn_IncreaseQty.Hide();
                btn_Send2Store.Hide();
                Store_DropDown.Show();
            }


            DispData();
        }

        public void DispData()
        {
            inventoryData = SQL.GetInventory(viewStore);
            lbl_StoreName.Text = viewStore;
            dataGridView1.DataSource = inventoryData;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Columns[0].HeaderText = "Type";
            dataGridView1.Columns[1].HeaderText = "Item Name";
            dataGridView1.Columns[2].HeaderText = "Purchase Cost";
            dataGridView1.Columns[2].DefaultCellStyle.Format = "c2";
            dataGridView1.Columns[3].HeaderText = "Sell Price";
            dataGridView1.Columns[3].DefaultCellStyle.Format = "c2";
            dataGridView1.Columns[4].HeaderText = "Category";
            dataGridView1.Columns[5].HeaderText = "Quantity";
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);
        }


        private void labelClose_Click(object sender, EventArgs e)
        {
            SQL.Cleanup();
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void InventoryManagement_Load(object sender, EventArgs e)
        {
            DispData();
            Clear();
        }
       

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MainForm = new MainForm();
            MainForm.Show();
        }



        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            viewStore = Store_DropDown.Text;
            
            
            if(viewStore == SQL.DefaultStore)
            {
                btn_IncreaseQty.Show();
                btn_Send2Store.Hide();
                isHomeStore = true;
                Clear();
            }
            else
            {
                btn_Send2Store.Show();
                btn_IncreaseQty.Hide();
                isHomeStore = false;
            }

            DispData();
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    if(!isHomeStore)
                    {
                        // don't let them manipulate qty's of stores not their own.
                        throw new InvalidOperationException("Cannot select an item from a store not your own.\nWould you like to view your home store now?");
                    }
                    if(SQL.IsManager)
                    {
                        ItemName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        lbl_name.Text = ItemName;
                        lbl_name.Show();
                        textBoxStockQty.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                        txt_ChangeQty.Text = "";
                        int.TryParse(textBoxStockQty.Text, out tempQty);
                        ProductID = SQL.GetItemId(ItemName);
                        btn_IncreaseQty.Show();
                    }else
                    {
                        btn_IncreaseQty.Hide();
                        ItemName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        lbl_name.Text = ItemName;
                        lbl_name.Show();
                    }

                    



                }
            }
            catch (InvalidOperationException ex)
            {
                // if they double click in the grid when its not the default store, then error
                // and ask if they want to view their default store

                DialogResult result =  MessageBox.Show(ex.Message, "Not Home Store", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(result == DialogResult.Yes)
                {
                    isHomeStore = true;
                    viewStore = SQL.DefaultStore;
                    btn_Send2Store.Hide();
                    btn_IncreaseQty.Show();

                    Clear();
                    DispData();
                }
            }

            catch
            {
                //safety catch - will throw an exception if the dataGridView is empty.
                // this refreshes it tries a second time.
                // sometimes hitting the buttons to quickly causes it to not have the data
                // yet and so it needs to catch

                // we can do this because there should ALWAYS be inventory for each store, so
                // yeah. we're cheating. Sorry.


                dataGridView1.DataSource = inventoryData;
                ItemName = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                lbl_name.Text = ItemName;
                lbl_name.Show();
                textBoxStockQty.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_ChangeQty.Text = "";
                int.TryParse(textBoxStockQty.Text, out tempQty);
                ProductID = SQL.GetItemId(ItemName);
                btn_IncreaseQty.Show();
            } 
            
        }
        void Clear()
        {
            textBoxStockQty.Text = lbl_name.Text = "";
            ProductID = -1;// only safe value for productID, as the table starts at 0.
            lbl_name.Hide();
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            String searchText = textBoxSearch.Text;
            if (searchText.ToLower().Trim().Equals("search here...."))
            {
                textBoxSearch.Text = "";
                textBoxSearch.ForeColor = Color.Black;
            }
        }

       private void textBoxSearch_Leave(object sender, EventArgs e)
        {
            String searchTxt = textBoxSearch.Text;
            if (dataGridView1.DataSource == null)
            {
                //safety catch. If user is moving to fast, reset the data whent hey leave the searchbox
                dataGridView1.DataSource = inventoryData;
            }
            
            if (searchTxt.ToLower().Trim().Equals("search here....") || searchTxt.Trim().Equals(""))
            {
                textBoxSearch.Text = "Search Here....";
                textBoxSearch.ForeColor = Color.MediumBlue;
                dataGridView1.DataSource = inventoryData;
               
            }
            
        }
        
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

            var dv = new DataView(inventoryData);
            dv.RowFilter = string.Format("item_name LIKE '%{0}%'", textBoxSearch.Text);

            dataGridView1.DataSource = dv;

        }

        private void Btn_NewItem_Click(object sender, EventArgs e)
        {
            /* TO DO
             * 
             * go to new form for inputing a new item into the items database
             * 
             */

            // Out of Current Project Scope

            
        }

        private void btn_IncreseQty(object sender, EventArgs e)
        {

            


            int.TryParse(textBoxStockQty.Text, out int changedTotalQty);
            int.TryParse(txt_ChangeQty.Text, out int adjustQtyBy);

            if(textBoxStockQty.Text.Trim().ToLower() == "")
            {
                MessageBox.Show("Please select an item to change first.", "Quantity Not Changed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tempQty == changedTotalQty && tempQty+adjustQtyBy > 0 && adjustQtyBy != 0)
            {
                /* this part looks to see if the Qty box is still the same as when the item was selected
                 * and if the adjustment is still above 0 qty (can't have negitive stock). There also needs to be a non
                 * zero value in the adjustByQty box
                 */
                try
                {
                    SQL.ChangeQty(ProductID, tempQty+adjustQtyBy);
                    MessageBox.Show("Changed quantity by " + adjustQtyBy + ". New total quantity is " + (tempQty + adjustQtyBy) + ".", "Quantity Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DispData();
                    tempQty += adjustQtyBy;
                    textBoxStockQty.Text = tempQty.ToString();
                    txt_ChangeQty.Text = "";
                    btn_IncreaseQty.Hide();
                    textBoxStockQty.Text = "";
                    txt_ChangeQty.Text = "";
                    lbl_name.Text = "";
                
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    textBoxStockQty.Text = tempQty.ToString();
                    txt_ChangeQty.Text = "";
                }

            } else if (tempQty != changedTotalQty && changedTotalQty >= 0 && adjustQtyBy == 0)
            {
                /* this looks to see if the Qty box is different than originally selected, and still greater
                 * than 0, and that the Adjust Qty box is also 0 (or blank)
                 */
                try
                {
                    SQL.ChangeQty(ProductID, (tempQty+(changedTotalQty-tempQty)));
                    MessageBox.Show("Changed quantity by "+ (changedTotalQty - tempQty)+". New total quantity is "+(tempQty+ (changedTotalQty - tempQty))+".", "Quantity Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DispData();
                    tempQty = changedTotalQty;
                    btn_IncreaseQty.Hide();
                    textBoxStockQty.Text = "";
                    txt_ChangeQty.Text = "";
                    lbl_name.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Entry", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    textBoxStockQty.Text = tempQty.ToString();
                    txt_ChangeQty.Text = "";
                    textBoxStockQty.Text = tempQty.ToString();

                }
            } else if( tempQty == changedTotalQty && adjustQtyBy == 0)
            {
                /* If the qty hasn't been changed and there is no qty adjustment value, then they need to enter before hitting button
                 */
                MessageBox.Show("Please enter either a new total quantity or an amount to change by.", "Quantity Not Changed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxStockQty.Text = tempQty.ToString();
                txt_ChangeQty.Text = "";
            } else if(changedTotalQty < 0 || (tempQty + adjustQtyBy) < 0)
            {
                /* if they try to enter a - total qty, or adjust by an amount that is more than the total, give an error
                 */
                MessageBox.Show("Cannot have a negitive amount of stock.", "Quantity Not Changed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxStockQty.Text = tempQty.ToString();
                txt_ChangeQty.Text = "";
            } else if (tempQty != changedTotalQty && adjustQtyBy > 0)
            {
                /* if they try to change both the total qty and the adjustQty, ask them to pick one
                 */
                MessageBox.Show("Please choose either to adjust the total quantity or an amount to adjust, not both.", "Quantity Not Changed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxStockQty.Text = tempQty.ToString();
                txt_ChangeQty.Text = "";
            } else
            {
                MessageBox.Show("Something went wrong. Quantity not changed.", "Quantity Not Changed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxStockQty.Text = tempQty.ToString();
                txt_ChangeQty.Text = "";
            }


            
        }

        private void Previous_pic_Click(object sender, EventArgs e)
        {

        }

        private void Close_pic_Click(object sender, EventArgs e)
        {
            SQL.Cleanup();
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void Previous_pic_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MainForm = new MainForm();
            MainForm.Show();
        }

        private void Store_DropDown_Enter(object sender, EventArgs e)
        {
            String SDD = Store_DropDown.Text;
            if (SDD.ToLower().Trim().Equals("select a store"))
            {
                Store_DropDown.Text = "";
                Store_DropDown.ForeColor = Color.Black;
            }
        }

        private void Store_DropDown_Leave(object sender, EventArgs e)
        {
            String SDD = Store_DropDown.Text;
            if (SDD.ToLower().Trim().Equals("select a store"))
            {
                Store_DropDown.Text = "";
                Store_DropDown.ForeColor = Color.SeaGreen;
            }
        }

        private void btn_Send2Store_Click(object sender, EventArgs e)
        {
            string StoreDD = Store_DropDown.Text;
            viewStore = StoreDD;
            int.TryParse(txt_ChangeQty.Text, out int xferAmt);

            try
            {

            /* Error Checking Requirements - put them here and delete this comment when you're done.
             *
             * Check that ProductId != -1 (what we set it to if no item is selected)
             * (error message: "Please select an item while viewing your store first"
             * 
             * Check that txt_ChangeQty <= tempQty 
             * (error: Can't Send more than in current Inventory.)
             * 
             * Check that txt_ChangeQty has a number in it and it is not negative
             * (error: Please enter a valid Number.)
             * 
             * Check that textBoxStockQty is still the same as tempQty
             * (Please only use the Adjust Quantity field.)
             * 
             * Check to make sure StoreDD != SQL.DefaultStore
             * (Can't move items from your own store to your own store)
             * 
             * use individual If statements with a Throw in each one
             * 
             * Throw new Exception("Error Message Here)
             * 
             * no else statements
             */

                SQL.ItemChgStore(ProductID, StoreDD, xferAmt);
                DispData();

                DialogResult result = MessageBox.Show("Successfully Moved " + xferAmt + " of " + ItemName + " to store " + viewStore + ".\nWould you like to return to your own store?", "Item Moved", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    isHomeStore = true;
                    viewStore = SQL.DefaultStore;

                    Clear();
                    DispData();
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




        }
    }
}
