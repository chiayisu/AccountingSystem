using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace 記帳SQLServer
{
    public partial class SearchByMonth : Form
    {
        public SearchByMonth()
        {
            InitializeComponent();
        }
        #region Variable
        CDate date = new CDate();
        SqlConnection oConn;
        string sSQL;
        CMonthCalculation Calculation;
        #endregion

        private void resource_Load(object sender, EventArgs e)
        {
            string month = date.Month.ToString();
            BorrowercomboBox1.SelectedIndex = 0;
            YearTextBox.Text = date.Year.ToString();
            MonthTextBox.Text = month;
            GetMonthData(month);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int Expense = 0, Income = 0, NetIncome = 0;
            label5.Text = "";
            Calculation = new CMonthCalculation(YearTextBox.Text, MonthTextBox.Text);
            Expense = Calculation.CalculateExpense();
            Income = Calculation.CalculateIncome();

            if ((IsCalculationError(Expense)) || (IsCalculationError(Income)))
            {
                label5.Text = CMessage.SystemError;
                return;
            }
            else
                NetIncome = Income - Expense;
            if (NetIncome > 0)
            {
                showDataExceptPreLend();
                label5.Text = MonthTextBox.Text + "月賺了" + NetIncome + "元";
            }
            else if (NetIncome < 0)
            {
                showDataExceptPreLend();
                label5.Text = MonthTextBox.Text + "月賠了" + Math.Abs(NetIncome)+ "元";
            }
            else if(NetIncome == 0)
            {
                label5.Text = MonthTextBox.Text + "月 0 元 ";
            }
            
        }
        
        private void button7_Click(object sender, EventArgs e)
        {

            label4.Text = "";
            Calculation = new CMonthCalculation(YearTextBox.Text, MonthTextBox.Text);
            int Income = Calculation.CalculateIncome();

            if (!(IsCalculationError(Income)))
            {
                label4.Text = MonthTextBox.Text + "月總計收入" + Income.ToString() + "元";
                showData(button7.Text);
            }
            else
            {
                label4.Text = CMessage.SystemError;
                return;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            Calculation = new CMonthCalculation(YearTextBox.Text, MonthTextBox.Text);   
            int Expense = Calculation.CalculateExpense();
            if (!(IsCalculationError(Expense)))
            {
                label2.Text = MonthTextBox.Text + "月總計支出" + Expense.ToString() + "元";
                showData(button5.Text);  
            }
            else
                label2.Text = CMessage.SystemError;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string month = MonthTextBox.Text;
            GetMonthData(month);   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            Calculation = new CMonthCalculation(YearTextBox.Text, MonthTextBox.Text);
            int total = Calculation.CalculateTotalIncomeandExpense();
            if (!IsCalculationError(total))
            {
                label3.Text = MonthTextBox.Text + "月總計為" + total.ToString();
                showDataExceptPreLend();
            }
            else
            {
                label3.Text = CMessage.SystemError;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            label6.Text = "";
            Calculation = new CMonthCalculation(YearTextBox.Text, MonthTextBox.Text);
            int PreLendTotal = Calculation.CalculatePreLend();
            if (!IsCalculationError(PreLendTotal))
            {
                label6.Text = MonthTextBox.Text + "月共預借了" + PreLendTotal.ToString();
                showData("預借現金");

            }
            else
            {
                label6.Text = "系統錯誤";
            }
        }

        private void PersonalPrelendBN_Click(object sender, EventArgs e)
        {
            int total = 0;
            label8.Text = "";
            Calculation = new CMonthCalculation(YearTextBox.Text, MonthTextBox.Text);
            total = Calculation.CalculatePersonalPreLend(BorrowercomboBox1.Text);
            if (!IsCalculationError(total))
            {
                label8.Text = MonthTextBox.Text + "月共預借了" + total.ToString();
                showData("預借現金");

            }
            else
            {
                label8.Text = CMessage.SystemError;
            }
            showPersonalPrelendData();
        }

        void GetMonthData(string mon)
        {
            dataGridView1.DataSource = null;
            oConn = new SqlConnection(ConnectionString.AccountDB);
            sSQL = "SELECT * FROM ACCOUNT WHERE 月份='" + mon + "'" + " AND " +
                  "年份='" + YearTextBox.Text + "'" + "ORDER BY 日期 ASC";
            DataSet ds = Function.Retrieve(sSQL, oConn);
            dataGridView1.DataSource = ds.Tables[0];
        }

        bool IsCalculationError(int code)
        {
            if (code == -1 || code == -2)
            {
                return true;
            }
            return false;
        }

        void showData(string DataType)
        {
            DataSet ds;
            oConn = Function.Conn(ConnectionString.AccountDB);
            sSQL = "SELECT * FROM ACCOUNT WHERE 收入或支出=N'" + DataType + "'" + " AND " +
           "月份='" + MonthTextBox.Text + "'" + " AND " +
              "年份='" + YearTextBox.Text + "'" + "ORDER BY 日期 ASC";
            ds = Function.Retrieve(sSQL, oConn);
            dataGridView1.DataSource = ds.Tables[0];
        }

        void showDataExceptPreLend()
        {
            DataSet ds;
            oConn = Function.Conn(ConnectionString.AccountDB);
            sSQL = "SELECT * FROM ACCOUNT WHERE 收入或支出<>N'" + "預借現金" + "'" + " AND " +
           "月份='" + MonthTextBox.Text + "'" + " AND " +
              "年份='" + YearTextBox.Text + "'"+"ORDER BY 日期 ASC";
            ds = Function.Retrieve(sSQL, oConn);
            dataGridView1.DataSource = ds.Tables[0];
        }

        void showPersonalPrelendData()
        {
            DataSet ds;
            oConn = Function.Conn(ConnectionString.AccountDB);
            sSQL = "SELECT * FROM ACCOUNT WHERE 收入或支出=N'" + "預借現金" + "'" + " AND " +
           "月份='" + MonthTextBox.Text + "'" + " AND " + "年份='" + YearTextBox.Text + "'" +
           " AND " + "項目 LIKE N'" + BorrowercomboBox1.Text + "%'" + "ORDER BY 日期 ASC";
            ds = Function.Retrieve(sSQL, oConn);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
