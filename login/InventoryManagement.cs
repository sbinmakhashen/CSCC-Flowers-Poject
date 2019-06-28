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
        
        int ProductID = 0;
        DataTable inventoryData = new DataTable();

        public InventoryManagement()
        {
            InitializeComponent();
            lbl_name.Text = "";
            disp_data();
            

            if(SQL.IsManager)
            {
                buttonInsert.Show();
                lbl_product.Show();
                lbl_stock.Show();
                textBoxStockQty.Show();
                lbl_name.Hide();
            } else
            {
                buttonInsert.Hide();
                lbl_product.Hide();
                lbl_stock.Hide();
                lbl_name.Hide();
                textBoxStockQty.Hide();
            }

        }

        public void disp_data()
        {
            inventoryData = SQL.GetInventory();

            dataGridView1.DataSource = inventoryData;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.Columns[0].HeaderText = "Type";
            dataGridView1.Columns[1].HeaderText = "Item Name";
            dataGridView1.Columns[2].HeaderText = "Purchase Cost";
            dataGridView1.Columns[3].HeaderText = "Sell Price";
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
            disp_data();
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
            disp_data();
            Clear();
        }


        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                lbl_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                lbl_name.Show();
                textBoxStockQty.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                ProductID = SQL.GetItemId(lbl_name.Text);
              

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
                textBoxSearch.Text = "search here....";
                textBoxSearch.ForeColor = Color.MediumBlue;
            }
        }
        
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

            // this search string *should* work for linq searching, but need to work on it some
            var filtered = inventoryData.AsEnumerable()
    .Where(r => r.Field<String>("item_id").Contains(textBoxSearch.Text)
           || r.Field<String>("item_name").Contains(textBoxSearch.Text)
           || r.Field<String>("purchase_cost").Contains(textBoxSearch.Text)
           || r.Field<String>("sell_cost").Contains(textBoxSearch.Text)
           || r.Field<String>("category").Contains(textBoxSearch.Text));

            dataGridView1.DataSource = filtered;


        }

        private void Btn_NewItem_Click(object sender, EventArgs e)
        {
            /* TO DO
             * 
             * go to new form for inputing a new item into the items database
             * 
             */
            
        }

        private void ButtonInsert_Click(object sender, EventArgs e)
        {
            /* To DO
             * 
             * Display Message Box asking how much to increase the qty by
             * 
             * then increase the qty in store_inventory table using SQL.IncreaseQty
             * (which still needs to be written)
             */
        }
    }
}
