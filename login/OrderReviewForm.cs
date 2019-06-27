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
    public partial class OrderReviewForm : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=remotemysql.com;port=3306;username=7903HxBTF8;password=U89DjsTnQO;database=7903HxBTF8");
        int ProductID = 0;

        public OrderReviewForm()
        {
            InitializeComponent();

        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            SQL.Cleanup();
            Application.Exit();
        }


        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MainForm = new MainForm();
            MainForm.Show();
        }

        public void disp_data()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from CustOrder";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter dat = new MySqlDataAdapter(cmd);
            dat.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void buttonViewOrd_Click(object sender, EventArgs e)
        {
            disp_data();
        }


        private void buttonCompl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Order Completed successfully");
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
                textBoxSearch.ForeColor = Color.Maroon;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM CustOrder WHERE CONCAT(CustID,Firstname, Lastname, Productname) LIKE '%" + textBoxSearch.Text + "%'";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter dat = new MySqlDataAdapter(cmd);
            dat.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
