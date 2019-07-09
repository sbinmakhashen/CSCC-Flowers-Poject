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
    public partial class ReportsForm : Form
    {
        MySqlConnection con = new MySqlConnection(@"server=remotemysql.com;port=3306;username=7903HxBTF8;password=U89DjsTnQO;database=7903HxBTF8");
        int ProductID = 0;

        public ReportsForm()
        {
            InitializeComponent();
            disp_data();
        }
        public void disp_data()
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Reports";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter dat = new MySqlDataAdapter(cmd);
            dat.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
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

        private void buttonInsert_Click(object sender, EventArgs e)
        {

            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Reports(General_Ledger,General_Journal) values('" + this.textBoxGL.Text + "','" + this.textBoxGJ.Text + "');";
            cmd.ExecuteNonQuery();
            con.Close();
            textBoxGL.Text = "";
            textBoxGJ.Text = "";
            disp_data();
            Clear();
            MessageBox.Show("record inserted successfully");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Reports WHERE General_Journal = '" + textBoxGJ.Text + "' AND General_Ledger = '" + textBoxGL.Text + "'";
            cmd.ExecuteNonQuery();
            textBoxGL.Text = "";
            textBoxGJ.Text = "";

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
            cmd.CommandText = "UPDATE `Reports` SET `General_Ledger`='" + textBoxGL.Text + "' WHERE General_Journal = '" + textBoxGJ.Text + "'";
            cmd.ExecuteNonQuery();
            textBoxGL.Text = "";
            textBoxGJ.Text = "";
            con.Close();
            disp_data();
            MessageBox.Show("record updated successfully");
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                textBoxGL.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBoxGJ.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
               // textBoxBlalance.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                ProductID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                buttonEdit.Text = "Update";
                buttonDelete.Enabled = Enabled;
                buttonEdit.Enabled = Enabled;
                buttonInsert.Enabled = Enabled;

            }
        }
        void Clear()
        {
            textBoxGL.Text = textBoxGJ.Text = "";
            ProductID = 0;
            buttonInsert.Text = "Insert";
            buttonDelete.Enabled = true;
        }

        private void buttonReset_Click(object sender, EventArgs e)
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
                textBoxSearch.ForeColor = Color.MediumBlue;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Reports WHERE CONCAT(id,General_Ledger,General_Journal) LIKE '%" + textBoxSearch.Text + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter dat = new MySqlDataAdapter(cmd);
            dat.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void textBoxGL_Enter(object sender, EventArgs e)
        {
            String GL = textBoxGL.Text;
            if (GL.ToLower().Trim().Equals("general ledger"))
            {
                textBoxGL.Text = "";
                textBoxGL.ForeColor = Color.Black;
            }
        }

        private void textBoxGL_Leave(object sender, EventArgs e)
        {
            String GL = textBoxGL.Text;
            if (GL.ToLower().Trim().Equals("general ledger") || GL.Trim().Equals(""))
            {
                textBoxGL.Text = "general ledger";
                textBoxGL.ForeColor = Color.MediumBlue;
            }
        }

        private void textBoxGJ_Enter(object sender, EventArgs e)
        {
            String GJ = textBoxGJ.Text;
            if (GJ.ToLower().Trim().Equals("general journal"))
            {
                textBoxGJ.Text = "";
                textBoxGJ.ForeColor = Color.Black;
            }
        }

        private void textBoxGJ_Leave(object sender, EventArgs e)
        {
            String GJ = textBoxGJ.Text;
            if (GJ.ToLower().Trim().Equals("general journal") || GJ.Trim().Equals(""))
            {
                textBoxGJ.Text = "general journal";
                textBoxGJ.ForeColor = Color.MediumBlue;
            }
        }
    }
}
