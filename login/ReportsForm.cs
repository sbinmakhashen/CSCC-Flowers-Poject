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
    public partial class ReportsForm : Form
    {
        

        public ReportsForm()
        {
            InitializeComponent();
            GeneralDisplay();
            lbl_StoreName.Text = SQL.DefaultStore;
            lbl_date.Text = "Today's Date is: " + DateTime.Today.ToString("dddd, dd MMMM yyyy");
        }

        public void GeneralFormat()
        {
            dgv_reports.Columns[0].HeaderText = "Transaction ID";
            dgv_reports.Columns[1].HeaderText = "Location";
            dgv_reports.Columns[1].Visible = false;
            dgv_reports.Columns[2].HeaderText = "Type";
            dgv_reports.Columns[3].HeaderText = "Particulars";
            dgv_reports.Columns[4].HeaderText = "Amount";
            dgv_reports.Columns[4].DefaultCellStyle.Format = "c2";
            dgv_reports.Columns[5].HeaderText = "Entry Date";
            dgv_reports.Columns[5].DefaultCellStyle.Format = "d";
            dgv_reports.Sort(dgv_reports.Columns[5], ListSortDirection.Ascending);
        }
        public void GeneralDisplay()
        {
            dgv_reports.DataSource = SQL.GeneralLedger();
            
        }
        public void GeneralDisplay(string date)
        {
            dgv_reports.DataSource = SQL.GeneralLedger(date);
            GeneralFormat();
        }

        public void GeneralDisplay(int year)
        {
            dgv_reports.DataSource = SQL.GeneralLedger(year);
            GeneralFormat();
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

       

        

        
        /*
         * 
         * This button only sorta works. The Error checking isnt finished properly.
         * 
         */

        private void Btn_GeneralLedger_Click(object sender, EventArgs e)
        {
            int.TryParse(DateTime.Now.Year.ToString(), out int curYear);
            int.TryParse(DateTime.Now.Month.ToString(), out int curMonth);
            int selecteMonth = cmBx_Month.SelectedIndex;
            try
            {
                // error checking
                // - no month selected, no year selected - show whole ledger.
                int.TryParse(txt_Year.Text, out int selectedYear);

                if (txt_Year.Text.Trim().ToLower() == "year")
                {
                    GeneralDisplay();
                    lbl_ReportName.Text = "General Ledger";
                }
                
                // month empty, 
                else if (cmBx_Month == null)
                {
                    // outside of year values
                    if(selectedYear < 2016 || selectedYear > curYear)
                    {
                        throw new Exception("That year is outside the valid range (2016 through now).");
                    }
                    else// month is empty, but year is acceptable
                    {
                        GeneralDisplay(selectedYear);
                    }


                } // if there is a value in month
                else if(cmBx_Month != null)
                {
                    //year outside of acceptable range
                    if (selectedYear < 2016 || selectedYear > curYear)
                    {
                        throw new Exception("Please enter a valid year (2016 through now).");
                    }
                    // month to far in the future
                    else if (selecteMonth+1>= curMonth && selectedYear == curYear)
                    {
                        throw new Exception("Please select a month in the past");
                    }
                    // finally, month is acceptable + year is acceptable
                    else
                    {
                        string date = selectedYear + "-" + selecteMonth + 1 + "-31";
                        GeneralDisplay(date);
                    }
                }
                

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Not a valid Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void Btn_ProfitLoss_Click(object sender, EventArgs e)
        {
            //ProfitLossDisplay();
            lbl_ReportName.Text = "Profit / Loss Statement";
        }

        private void Previous_pic_Click(object sender, EventArgs e)
        {

        }

        private void Close_pic_Click(object sender, EventArgs e)
        {

        }

        private void Close_pic_Click_1(object sender, EventArgs e)
        {
            SQL.Cleanup();
            var login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void Previous_pic_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainForm MainForm = new MainForm();
            MainForm.Show();
        }
    }
}
