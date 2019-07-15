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
        DataTable balance = new DataTable();
        

        public ReportsForm()
        {
            InitializeComponent();
            GeneralDisplay();
            lbl_StoreName.Text = SQL.DefaultStore;
            lbl_date.Text = "Today's Date is: " + DateTime.Today.ToString("dddd, dd MMMM yyyy");
        }

        public void ProftLossFormat(PLState statement)
        {
            title_TotalRevenue.Text = "Total Cash Sales Revenue";
            title_ActRec.Text = "Accounts Receivable Collected";
            title_Inventory.Text = "Cost of Goods Sold";
            title_Gross.Text = "Gross Profit";
            title_Asset.Hide();
            title_AssetTotal.Hide();
            lbl_totalAssets.Hide();
            title_Intang.Hide();
            title_tradeName.Hide();
            lbl_tradeName.Hide();
            title_OperProf.Text = "Operating Profit (EBT)";
            title_NetIncome.Text = "Net Income";
            title_TotalPositive.Hide();
            lbl_TotalPositive.Hide();
            Title_OperExpensesCategory.Text = "Operating Expenses";
            title_AcctPay.Text = "Accounts Payable Paid Out";
            title_Utilities.Text = "Operating Expenses";
            title_Marketing.Text = "Marketing";
            title_Expenses.Show();
            lbl_expenses.Show();
            title_TotalOpCost.Text = "Total Operating Costs";
            title_Taxes.Text = "Taxes";
            title_totalLiable.Hide();
            lbl_totalLiable.Hide();

            lbl_ReportName.Text = "Profit / Loss Report";
            dgv_reports.Hide();
            grp_StatementDisplay.Show();
            grp_StatementDisplay.Text = "Profit / Loss Report";

            if(statement.Month !=0 && statement.Year !=0)
            {
                lbl_StateDate.Text = "Report for " + statement.LongMonth + " " + statement.Year;
            } else if (statement.Month == 0 && statement.Year != 0)
            {
                if (statement.Year == DateTime.Today.Year)
                {
                    lbl_StateDate.Text = "Report for the year of "+statement.Year+ " through the month of "+DateTime.Today.ToString("MMMM");
                }
                else
                {
                    lbl_StateDate.Text = "Report for the year of " + statement.Year;
                }
            } else if (statement.Month == 0  && statement.Year == 0)
            {
                lbl_StateDate.Text = "Full Life of Store (From Jan 2010 to Now)";
            }


            lbl_acctRec.Show();
            title_ActRec.Show();
            lbl_actPay.Show();
            title_AcctPay.Show();
            lbl_operatingProfit.Show();
            title_OperProf.Show();
            lbl_Taxes.Show();
            title_Taxes.Show();

            lbl_acctRec.Text = statement.Receivable.ToString("c2");
            lbl_revenue.Text = statement.Sales.ToString("c2");
            lbl_inventory.Text = statement.Inventory.ToString("c2");
            double grossProft = statement.Sales + statement.Inventory + statement.Receivable;
            lbl_gross.Text = grossProft.ToString("c2");
            lbl_payroll.Text = statement.Payroll.ToString("c2");
            lbl_utilities.Text = statement.Utilities.ToString("c2");
            lbl_expenses.Text = statement.Expenses.ToString("c2");
            lbl_actPay.Text = statement.Vendor.ToString("c2");
            lbl_Marketing.Text = statement.Marketing.ToString("c2");

            double totalExpense = statement.Payroll + statement.Utilities + statement.Expenses +statement.Marketing +statement.Vendor;
            lbl_TotalExpense.Text = totalExpense.ToString("c2");
            double operatingProfit = grossProft + totalExpense;
            lbl_operatingProfit.Text = operatingProfit.ToString("c2");
            double taxes = statement.Sales * -.055;  
            lbl_Taxes.Text = taxes.ToString("c2");
            double net = operatingProfit + taxes;
            lbl_NetIncome.Text = net.ToString("c2");
            title_NetIncome.Text = "Net Income";


        }

        public void ProfitDisplay()
        {
            var totalPL = new PLState();
            totalPL = SQL.ProfitLossReport();
            ProftLossFormat(totalPL);
        }

        public void ProfitDisplay(string date)
        {
            var monthPL = new PLState();

            monthPL = SQL.ProfitLossReport(date, cmBx_Month.SelectedIndex + 1);
            ProftLossFormat(monthPL);
        }

        public void ProfitDisplay(int year)
        {
            var yearPL = new PLState();

            yearPL = SQL.ProfitLossReport(year);
            ProftLossFormat(yearPL);
        }


        public void CashFlowFormat(PLState statement)
        {

            title_TotalRevenue.Text = "Total Cash Sales Revenue";
            title_ActRec.Text = "Accounts Receivable Collected";
            title_Inventory.Text = "Cost of Goods Sold";
            title_Gross.Text = "Gross Profit";
            title_Asset.Hide();
            title_AssetTotal.Hide();
            lbl_totalAssets.Hide();
            title_Intang.Hide();
            title_tradeName.Hide();
            lbl_tradeName.Hide();
            title_OperProf.Text = "Operating Profit (EBT)";
            title_NetIncome.Text = "Net Income";
            title_TotalPositive.Hide();
            lbl_TotalPositive.Hide();
            Title_OperExpensesCategory.Text = "Operating Expenses";
            title_AcctPay.Text = "Accounts Payable Paid Out";
            title_Utilities.Text = "Operating Expenses";
            title_Marketing.Text = "Marketing";
            title_Expenses.Show();
            lbl_expenses.Show();
            title_TotalOpCost.Text = "Total Operating Costs";
            title_Taxes.Text = "Taxes";
            title_totalLiable.Hide();
            lbl_totalLiable.Hide();


            lbl_ReportName.Text = "Cash Flow Report";
            dgv_reports.Hide();
            grp_StatementDisplay.Show();
            grp_StatementDisplay.Text = "Cash Flow Report";

            if (statement.Month != 0 && statement.Year != 0)
            {
                lbl_StateDate.Text = "Report for " + statement.LongMonth + " " + statement.Year;
            }
            else if (statement.Month == 0 && statement.Year != 0)
            {
                if (statement.Year == DateTime.Today.Year)
                {
                    lbl_StateDate.Text = "Report for the year of " + statement.Year + " through the month of " + DateTime.Today.ToString("MMMM");
                }
                else
                {
                    lbl_StateDate.Text = "Report for the year of " + statement.Year;
                }
            }
            else if (statement.Month == 0 && statement.Year == 0)
            {
                lbl_StateDate.Text = "Full Life of Store (From Jan 2010 to Now)";
            }

            lbl_acctRec.Hide();
            title_ActRec.Hide();
            lbl_revenue.Text = statement.Sales.ToString("c2");
            lbl_inventory.Text = statement.Inventory.ToString("c2");
            double grossProft = statement.Sales + statement.Inventory;
            lbl_gross.Text = grossProft.ToString("c2");
            lbl_payroll.Text = statement.Payroll.ToString("c2");
            lbl_utilities.Text = statement.Utilities.ToString("c2");
            lbl_expenses.Text = statement.Expenses.ToString("c2");
            lbl_actPay.Hide();
            title_AcctPay.Hide();
            lbl_Marketing.Text = statement.Marketing.ToString("c2");

            double totalExpense = statement.Payroll + statement.Utilities + statement.Expenses + statement.Marketing;
            lbl_TotalExpense.Text = totalExpense.ToString("c2");
            double operatingProfit = grossProft + totalExpense;
            lbl_operatingProfit.Hide();
            title_OperProf.Hide();

            double taxes = statement.Sales * -.055;
            lbl_Taxes.Hide();
            title_Taxes.Hide();
            double net = operatingProfit;
            lbl_NetIncome.Text = net.ToString("c2");
            title_NetIncome.Text = "Cash Flow";


        }


        public void CashFlowDisplay()
        {
            var totalPL = new PLState();
            totalPL = SQL.CashFlowReport();
            CashFlowFormat(totalPL);
        }

        public void CashFlowDisplay(string date)
        {
            var monthPL = new PLState();

            monthPL = SQL.CashFlowReport(date, cmBx_Month.SelectedIndex + 1);
            CashFlowFormat(monthPL);
        }

        public void CashFlowDisplay(int year)
        {
            var yearPL = new PLState();

            yearPL = SQL.CashFlowReport(year);
            CashFlowFormat(yearPL);
        }




        public void GeneralFormat()
        {
            lbl_ReportName.Text = "General Ledger";
            grp_StatementDisplay.Text = "";


            dgv_reports.Show();
            dgv_reports.Columns[0].HeaderText = "Transaction ID";
            dgv_reports.Columns[0].Visible = false;
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
            GeneralFormat();
            
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




        public void BalanceFormat()
        {
           
            
            
            dgv_reports.Show();
            lbl_ReportName.Text = "Balance Sheet Full List";
            grp_StatementDisplay.Text = "";

        }

        



        public void BalanceDisplay()
        {
            dgv_reports.DataSource = SQL.BalanceSheetReport();
            BalanceFormat();

        }
        public void BalanceDisplay(string date)
        {
            dgv_reports.DataSource = SQL.BalanceSheetReport(date);
            BalanceFormat();
        }

        public void BalanceDisplay(int year)
        {
           dgv_reports.DataSource = SQL.BalanceSheetReport(year);
            BalanceFormat();
        }


        public void BalanceSheetFormat(string date, DataTable data)
        {

            


            var b = new balanceData();

            

            b = SQL.BalanceCompile(data);
            double futureRec = SQL.FutureRec(date);

            dgv_reports.Hide();
            lbl_ReportName.Text = "Balance Sheet Report";
            grp_StatementDisplay.Text = "Balance Sheet";


            int.TryParse(txt_Year.Text, out int y);

            b.Month = cmBx_Month.SelectedIndex + 1;
            b.Year = y;

            b.SetMonth(b.Month);

            if (b.Month != 0 && b.Year != 0)
            {
                lbl_StateDate.Text = "Report for " + b.LongMonth + " " + b.Year;
            }
            else if (b.Month == 0 && b.Year != 0)
            {
                if (b.Year == DateTime.Today.Year)
                {
                    lbl_StateDate.Text = "Report for the year of " + b.Year + " through the month of " + DateTime.Today.ToString("MMMM");
                }
                else
                {
                    lbl_StateDate.Text = "Report for the year of " + b.Year;
                }
            }
            else if (b.Month == 0 && b.Year == 0)
            {
                lbl_StateDate.Text = "Full Life of Store (From Jan 2010 to Now)";
            }

            title_TotalRevenue.Text = "Assets";
            lbl_revenue.Hide();
            title_Asset.Show();
            title_ActRec.Show();
            title_ActRec.Text = "Cash";
            lbl_acctRec.Show();
            lbl_acctRec.Text = b.Cash.ToString("c2");
            title_Inventory.Text = "Inventory";
            lbl_inventory.Text = b.Inventory.ToString("c2");
            title_Gross.Text = "Prepaid Insurance";
            lbl_gross.Text = b.Insurance.ToString("c2");
            lbl_totalAssets.Text = b.TotalPhysAsset().ToString("c2");
            title_AssetTotal.Show();
            title_Intang.Show();
            title_tradeName.Show();
            lbl_tradeName.Text = b.Trademark.ToString("c2");
            lbl_tradeName.Show();
            lbl_totalAssets.Show();
            title_OperProf.Text = "Total Intangible Assets";
            lbl_operatingProfit.Text = b.TotalIntang().ToString("c2");
            
            title_NetIncome.Text = "Other Assets";
            lbl_NetIncome.Text = b.Other.ToString("c2");
            title_TotalPositive.Show();
            lbl_TotalPositive.Show();
            lbl_TotalPositive.Text = b.TotalAsset().ToString("c2");
            Title_OperExpensesCategory.Text = "Liabilities";
            title_AcctPay.Text = "Accounts Payable";
            lbl_actPay.Text = b.Payable.ToString("c2");
            lbl_payroll.Text = b.Payroll.ToString("c2");
            title_Utilities.Text = "Unearned Receivables";
            lbl_utilities.Text = b.Receivable.ToString("c2");
            title_Marketing.Text = "Taxes payable";
            lbl_Marketing.Text = b.Taxes.ToString("c2");
            title_Expenses.Hide();
            lbl_expenses.Hide();
            title_TotalOpCost.Text = "Current Liabilites";
            lbl_TotalExpense.Text = b.CurrLiab().ToString("c2");
            title_Taxes.Text = "Long Term Payable";
            lbl_Taxes.Text = futureRec.ToString("c2");
            title_totalLiable.Show();
            lbl_totalLiable.Show();
            lbl_totalLiable.Text = (futureRec+b.CurrLiab()).ToString("c2");


        }



        public void BalanceSheetDisplay()
        {
            
            string date = DateTime.Today.ToString("yyyy-MM-dd");
            BalanceSheetFormat(date, SQL.BalanceSheetReport());

        }
        public void BalanceSheetDisplay(string date)
        {
            
            BalanceSheetFormat(date, SQL.BalanceSheetReport(date));
        }

        public void BalanceSheetDisplay(int year)
        {
            
            string date = year + "-01-01";
            BalanceSheetFormat(date, SQL.BalanceSheetReport(year));
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

                
                // month empty, 
                if (cmBx_Month.SelectedIndex == -1)
                {
                    // combobox empty and year default, display all
                    if (txt_Year.Text.Trim().ToLower() == "year")
                    {
                        GeneralDisplay();

                    }
                    // outside of year values
                    else if (selectedYear < 2016 || selectedYear > curYear)
                    {
                        throw new Exception("That year is outside the valid range (2016 through now).");
                    }
                    else// month is empty, but year is acceptable
                    {
                        GeneralDisplay(selectedYear);
                    }


                } // if there is a value in month
                else if(cmBx_Month.SelectedIndex >= 0)
                {
                    //year outside of acceptable range
                    if (selectedYear < 2016 || selectedYear > curYear)
                    {
                        throw new Exception("Please enter a valid year (2016 through now).");
                    }// last combo box option, Full Year
                    else if (cmBx_Month.SelectedIndex >=12)
                    {
                        GeneralDisplay(selectedYear);
                    }
                    // month to far in the future
                    else if (selecteMonth+1>= curMonth && selectedYear == curYear)
                    {
                        throw new Exception("Please select a month in the past");
                    }
                    // finally, month is acceptable + year is acceptable
                    else
                    {
                        string date = selectedYear + "-" + (selecteMonth + 1) + "-01";
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
            int.TryParse(DateTime.Now.Year.ToString(), out int curYear);
            int.TryParse(DateTime.Now.Month.ToString(), out int curMonth);
            int selecteMonth = cmBx_Month.SelectedIndex;
            try
            {
                // error checking
                // - no month selected, no year selected - show whole ledger.
                int.TryParse(txt_Year.Text, out int selectedYear);


                // month empty, 
                if (cmBx_Month.SelectedIndex == -1)
                {
                    // combobox empty and year default, display all
                    if (txt_Year.Text.Trim().ToLower() == "year")
                    {
                        ProfitDisplay();

                    }
                    // outside of year values
                    else if (selectedYear < 2016 || selectedYear > curYear)
                    {
                        throw new Exception("That year is outside the valid range (2016 through now).");
                    }
                    else// month is empty, but year is acceptable
                    {
                        ProfitDisplay(selectedYear);
                    }


                } // if there is a value in month
                else if (cmBx_Month.SelectedIndex >= 0)
                {
                    //year outside of acceptable range
                    if (selectedYear < 2016 || selectedYear > curYear)
                    {
                        throw new Exception("Please enter a valid year (2016 through now).");
                    }
                    // Month box is set to the last entry, the 'Full Year'
                    else if (cmBx_Month.SelectedIndex>=12)
                    {
                        ProfitDisplay(selectedYear);
                    }
                    // month to far in the future
                    else if (selecteMonth + 1 >= curMonth && selectedYear == curYear)
                    {
                        throw new Exception("Please select a month in the past");
                    }
                    // finally, month is acceptable + year is acceptable
                    else
                    {
                        
                            string date = selectedYear + "-" + (selecteMonth + 1) + "-01";
                            ProfitDisplay(date);
                        
                        
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Not a valid Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



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

        private void Btn_CashFlow_Click(object sender, EventArgs e)
        {
            int.TryParse(DateTime.Now.Year.ToString(), out int curYear);
            int.TryParse(DateTime.Now.Month.ToString(), out int curMonth);
            int selecteMonth = cmBx_Month.SelectedIndex;
            try
            {
                // error checking
                // - no month selected, no year selected - show whole ledger.
                int.TryParse(txt_Year.Text, out int selectedYear);


                // month empty, 
                if (cmBx_Month.SelectedIndex == -1)
                {
                    // combobox empty and year default, display all
                    if (txt_Year.Text.Trim().ToLower() == "year")
                    {
                        CashFlowDisplay();

                    }
                    // outside of year values
                    else if (selectedYear < 2016 || selectedYear > curYear)
                    {
                        throw new Exception("That year is outside the valid range (2016 through now).");
                    }
                    else// month is empty, but year is acceptable
                    {
                        CashFlowDisplay(selectedYear);
                    }


                } // if there is a value in month
                else if (cmBx_Month.SelectedIndex >= 0)
                {
                    //year outside of acceptable range
                    if (selectedYear < 2016 || selectedYear > curYear)
                    {
                        throw new Exception("Please enter a valid year (2016 through now).");
                    }
                    // Month box is set to the last entry, the 'Full Year'
                    else if (cmBx_Month.SelectedIndex >= 12)
                    {
                        CashFlowDisplay(selectedYear);
                    }
                    // month to far in the future
                    else if (selecteMonth + 1 >= curMonth && selectedYear == curYear)
                    {
                        throw new Exception("Please select a month in the past");
                    }
                    // finally, month is acceptable + year is acceptable
                    else
                    {

                        string date = selectedYear + "-" + (selecteMonth + 1) + "-01";
                        CashFlowDisplay(date);


                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Not a valid Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_Balance_Click(object sender, EventArgs e)
        {
            balance = null;
            int.TryParse(DateTime.Now.Year.ToString(), out int curYear);
            int.TryParse(DateTime.Now.Month.ToString(), out int curMonth);
            int selecteMonth = cmBx_Month.SelectedIndex;
            try
            {
                // error checking
                // - no month selected, no year selected - show whole ledger.
                int.TryParse(txt_Year.Text, out int selectedYear);


                // month empty, 
                if (cmBx_Month.SelectedIndex == -1)
                {
                    // combobox empty and year default, display all
                    if (txt_Year.Text.Trim().ToLower() == "year")
                    {
                        BalanceDisplay();

                    }
                    // outside of year values
                    else if (selectedYear < 2016 || selectedYear > curYear)
                    {
                        throw new Exception("That year is outside the valid range (2016 through now).");
                    }
                    else// month is empty, but year is acceptable
                    {
                        BalanceDisplay(selectedYear);
                    }


                } // if there is a value in month
                else if (cmBx_Month.SelectedIndex >= 0)
                {
                    //year outside of acceptable range
                    if (selectedYear < 2016 || selectedYear > curYear)
                    {
                        throw new Exception("Please enter a valid year (2016 through now).");
                    }
                    // Month box is set to the last entry, the 'Full Year'
                    else if (cmBx_Month.SelectedIndex >= 12)
                    {
                        BalanceDisplay(selectedYear);
                    }
                    // month to far in the future
                    else if (selecteMonth + 1 >= curMonth && selectedYear == curYear)
                    {
                        throw new Exception("Please select a month in the past");
                    }
                    // finally, month is acceptable + year is acceptable
                    else
                    {

                        string date = selectedYear + "-" + (selecteMonth + 1) + "-01";
                        BalanceDisplay(date);


                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Not a valid Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_balanceReport_Click(object sender, EventArgs e)
        {
            balance = null;
            int.TryParse(DateTime.Now.Year.ToString(), out int curYear);
            int.TryParse(DateTime.Now.Month.ToString(), out int curMonth);
            int selecteMonth = cmBx_Month.SelectedIndex;
            try
            {
                // error checking
                // - no month selected, no year selected - show whole ledger.
                int.TryParse(txt_Year.Text, out int selectedYear);


                // month empty, 
                if (cmBx_Month.SelectedIndex == -1)
                {
                    // combobox empty and year default, display all
                    if (txt_Year.Text.Trim().ToLower() == "year")
                    {
                        BalanceSheetDisplay();
                        

                    }
                    // outside of year values
                    else if (selectedYear < 2016 || selectedYear > curYear)
                    {
                        throw new Exception("That year is outside the valid range (2016 through now).");
                    }
                    else// month is empty, but year is acceptable
                    {
                        BalanceSheetDisplay(selectedYear);
                    }


                } // if there is a value in month
                else if (cmBx_Month.SelectedIndex >= 0)
                {
                    //year outside of acceptable range
                    if (selectedYear < 2016 || selectedYear > curYear)
                    {
                        throw new Exception("Please enter a valid year (2016 through now).");
                    }
                    // Month box is set to the last entry, the 'Full Year'
                    else if (cmBx_Month.SelectedIndex >= 12)
                    {
                        BalanceSheetDisplay(selectedYear);
                    }
                    // month to far in the future
                    else if (selecteMonth + 1 >= curMonth && selectedYear == curYear)
                    {
                        throw new Exception("Please select a month in the past");
                    }
                    // finally, month is acceptable + year is acceptable
                    else
                    {

                        string date = selectedYear + "-" + (selecteMonth + 1) + "-01";
                        BalanceSheetDisplay(date);


                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Not a valid Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
    }
}
