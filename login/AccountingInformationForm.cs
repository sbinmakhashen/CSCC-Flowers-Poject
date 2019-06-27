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
        MySqlConnection con = new MySqlConnection(@"server=remotemysql.com;port=3306;username=7903HxBTF8;password=U89DjsTnQO;database=7903HxBTF8");
        int ProductID = 0;

        public AccountingInformationForm()
        {
            InitializeComponent();
            disp_data();
        }

        public void disp_data()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from AcctsPay";
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
            cmd.CommandText = "insert into AcctsPay(name,location,Quantity) values('" + this.textBoxName.Text + "','" + this.textBoxLoca.Text + "','" + this.textBoxQty.Text + "');";
            cmd.ExecuteNonQuery();
            con.Close();
            textBoxName.Text = "";
            textBoxLoca.Text = "";
            textBoxQty.Text = "";
            disp_data();
            Clear();
            MessageBox.Show("record inserted successfully");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM AcctsPay WHERE location = '" + textBoxLoca.Text + "' AND name = '" + textBoxName.Text + "'";
            //cmd.Parameters.AddWithValue("@stock_qty", textBoxStockQty.Text);
            //cmd.Parameters.AddWithValue("@prod_name", textBoxProdName.Text);
            cmd.ExecuteNonQuery();
            textBoxName.Text = "";
            textBoxLoca.Text = "";
            textBoxQty.Text = "";
            con.Close();
            disp_data();
            Clear();


            MessageBox.Show("record deleted successfully");
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE `AcctsPay` SET `name`='" + textBoxName.Text + "',`location`='" + textBoxLoca.Text + "' WHERE Quantity = '" + textBoxQty.Text + "'";
            cmd.ExecuteNonQuery();
            textBoxName.Text = "";
            textBoxLoca.Text = "";
            textBoxQty.Text = "";
            con.Close();
            disp_data();
            MessageBox.Show("record updated successfully");
        }

       
        void Clear()
        {
            textBoxName.Text = textBoxLoca.Text = textBoxQty.Text = "";
            ProductID = 0;
            buttonInsert.Text = "Insert";
            buttonDelete.Enabled = true;
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBoxLoca.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBoxQty.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
               // ProductID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                buttonEdit.Text = "Update";
                buttonDelete.Enabled = Enabled;
                buttonEdit.Enabled = Enabled;
                buttonInsert.Enabled = Enabled;

            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Clear();
            disp_data();

        }

        private void AccountingInformationForm_Load(object sender, EventArgs e)
        {
            disp_data();
            Clear();
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
                textBoxSearch.ForeColor = Color.IndianRed;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM AcctsPay WHERE CONCAT(id,name,location,Quantity) LIKE '%" + textBoxSearch.Text + "%'";

            // cmd.Parameters.AddWithValue("@stock_qty", textBoxStockQty.Text);
            // cmd.Parameters.AddWithValue("@prod_name", textBoxProdName.Text);

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter dat = new MySqlDataAdapter(cmd);
            dat.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
