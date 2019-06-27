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
        //string connectionString = @"server=remotemysql.com;port=3306;username=7903HxBTF8;password=U89DjsTnQO;database=7903HxBTF8";
        MySqlConnection con = new MySqlConnection(@"server=remotemysql.com;port=3306;username=7903HxBTF8;password=U89DjsTnQO;database=7903HxBTF8");
        int ProductID = 0;

        public InventoryManagement()
        {
            InitializeComponent();
            disp_data();


        }

        public void disp_data()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Inventory";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter dat = new MySqlDataAdapter(cmd);
            dat.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }


        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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



        private void buttonInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Inventory(prod_name,stock_qty,price) values('" + this.textBoxProdName.Text + "','" + this.textBoxStockQty.Text + "','" + this.textBoxPrice.Text + "');";
            cmd.ExecuteNonQuery();
            con.Close();
            textBoxProdName.Text = "";
            textBoxStockQty.Text = "";
            textBoxPrice.Text = "";
            disp_data();
            Clear();
            MessageBox.Show("record inserted successfully");
        }



        private void buttonDelete_Click(object sender, EventArgs e)
        {

            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Inventory WHERE stock_qty = '" + textBoxStockQty.Text + "' AND prod_name = '" + textBoxProdName.Text + "'";
            //cmd.Parameters.AddWithValue("@stock_qty", textBoxStockQty.Text);
            //cmd.Parameters.AddWithValue("@prod_name", textBoxProdName.Text);
            cmd.ExecuteNonQuery();
            textBoxProdName.Text = "";
            textBoxStockQty.Text = "";
            textBoxPrice.Text = "";
            con.Close();
            disp_data();
            Clear();


            MessageBox.Show("record deleted successfully");
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            disp_data();
            Clear();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE `Inventory` SET `prod_name`='"+textBoxProdName.Text+"',`stock_qty`='" + textBoxStockQty.Text+ "' WHERE price = '"+textBoxPrice.Text+"'";
            cmd.ExecuteNonQuery();
            textBoxProdName.Text = "";
            textBoxStockQty.Text = "";
            textBoxPrice.Text = "";
            con.Close();
            disp_data();
            MessageBox.Show("record updated successfully");

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                textBoxProdName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBoxStockQty.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBoxPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                ProductID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                buttonEdit.Text = "Update";
                buttonDelete.Enabled = Enabled;
                buttonEdit.Enabled = Enabled;
                buttonInsert.Enabled = Enabled;
              

            }
        }
        void Clear()
        {
            textBoxProdName.Text = textBoxStockQty.Text = textBoxPrice.Text = "";
            ProductID = 0;
           buttonInsert.Text = "Insert";
            buttonDelete.Enabled = true;
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
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Inventory WHERE CONCAT(prod_ID,prod_name, stock_qty, price) LIKE '%" + textBoxSearch.Text + "%'";

            cmd.ExecuteNonQuery();
             DataTable dt = new DataTable();
             MySqlDataAdapter dat = new MySqlDataAdapter(cmd);
            dat.Fill(dt);
             dataGridView1.DataSource = dt;
            con.Close();

        }

      
    }
}
