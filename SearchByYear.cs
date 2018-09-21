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
    public partial class SearchByYear : Form
    {
        public SearchByYear()
        {
            InitializeComponent();
        }

        #region Variable
        CDate date = new CDate();
        string sSQL;
        SqlConnection oConn;
        CYearCalculation calculation;
        #endregion

        private void Year_Load(object sender, EventArgs e)
        {
            string year = date.Year.ToString();
            getYearData(year);
            YearTextBox.Text = year; 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            calculation = new CYearCalculation(YearTextBox.Text);
            int TotalIncome = calculation.CalculateIncome();

            if (!(IsCalculationError(TotalIncome)))
            {
                label4.Text = YearTextBox.Text + "年總計收入" + TotalIncome.ToString() + "元";
                showData(Income.Text);
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
            calculation = new CYearCalculation(YearTextBox.Text);
            int TotalExpense = calculation.CalculateExpense();
            if (!(IsCalculationError(TotalExpense)))
            {
                label2.Text = YearTextBox.Text + "年總計支出" + TotalExpense.ToString() + "元";
                showData(button5.Text);
            }
            else
                label2.Text = CMessage.SystemError;
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            calculation = new CYearCalculation(YearTextBox.Text);
            int Average = calculation.CalculateAverage();
            if (!(IsCalculationError(Average)))
            {
                label3.Text = YearTextBox.Text + "年總計平均為" + Average.ToString() + "元";
                showDataExceptPreLend();           
            }
            else
                label3.Text = CMessage.SystemError;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int Expense = 0, Income = 0, NetIncome = 0;
            label5.Text = "";
            calculation = new CYearCalculation(YearTextBox.Text);
            Expense = calculation.CalculateExpense();
            Income = calculation.CalculateIncome();

            if ((IsCalculationError(Expense)) || (IsCalculationError(Income)))
            {
                label5.Text = CMessage.SystemError;
                return;
            }
            else
                NetIncome = Income - Expense;

            if (NetIncome > 0)
            {
                label5.Text = YearTextBox.Text + "年賺了" + NetIncome + "元";
                showDataExceptPreLend();
            }
            else if (NetIncome < 0)
            {
                label5.Text = YearTextBox.Text + "=年賠了" + Math.Abs(NetIncome) + "元";
                showDataExceptPreLend();
            }
            else if (NetIncome == 0)
            {
                label5.Text = YearTextBox.Text + "年 0 元 ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string year = YearTextBox.Text;
            getYearData(year);   
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            calculation = new CYearCalculation(YearTextBox.Text);
            int total = calculation.CalculateTotalIncomeandExpense();
            if (!IsCalculationError(total))
            {
                label7.Text = YearTextBox.Text + "年總計為" + total.ToString();
                showDataExceptPreLend();
            }
            else
            {
                label7.Text = CMessage.SystemError;
            }
        }   
   
        void getYearData(string year)
        {
            dataGridView1.DataSource = null;
            oConn = new SqlConnection(ConnectionString.AccountDB);
            sSQL = "SELECT * FROM ACCOUNT WHERE 年份='" + year + "'"+"ORDER BY 月份 ASC";
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
            sSQL = "SELECT * FROM ACCOUNT WHERE 收入或支出=N'" + DataType + "'" +  " AND " +
              "年份='" + YearTextBox.Text + "'"+"ORDER BY 月份 ASC"; 
            ds = Function.Retrieve(sSQL, oConn);
            dataGridView1.DataSource = ds.Tables[0];
        }

        void showDataExceptPreLend()
        {
            DataSet ds;
            oConn = Function.Conn(ConnectionString.AccountDB);
            sSQL = "SELECT * FROM ACCOUNT WHERE 收入或支出<>N'" + "預借現金" + "'"  + " AND " +
              "年份='" + YearTextBox.Text + "'" + "ORDER BY 月份 ASC";
            ds = Function.Retrieve(sSQL, oConn);
            dataGridView1.DataSource = ds.Tables[0];
        }

    }
}
