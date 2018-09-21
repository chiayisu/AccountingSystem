using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace 記帳SQLServer
{
    class CCalculation
    {
        #region Variable
        protected string year;
        protected string month;
        protected string sSQL;
        protected int Expense = 0;
        protected int Income = 0;
        protected int NetIncome = 0;
        protected SqlConnection oConn;
        protected int totalIncomeandExpense = 0;
        #endregion

        #region Constructor
        public CCalculation() { }
        #endregion

        #region Property
        public string Year
        {
            set
            {
                year = value;
            }
        }

        public string Month
        {
            set
            {
                month = value;
            }
        }
  
        public virtual int CalculateIncome()
        {
            return Income;
        }

        public virtual int CalculateExpense() 
        {
            return Expense;
        }

        public int CalculateNetIncome() 
        {
            CalculateIncome();
            CalculateExpense();
            NetIncome = Income - Expense;
            return NetIncome;
        }

        public int CalculateTotalIncomeandExpense() 
        {
            CalculateIncome();
            CalculateExpense();
            totalIncomeandExpense = Expense + Income;
            return totalIncomeandExpense;
        }
        #endregion

    }


    class CMonthCalculation : CCalculation
    {
        #region Variable
        private int TotalPreLend = 0;
        private int PersonalPrelend = 0;
        #endregion

        #region Constructor
        public CMonthCalculation(string oyear, string omonth)
        {
            year = oyear;
            month = omonth;
        }
        #endregion

        #region Property
        public override int CalculateIncome()
        {
            sSQL = "SELECT SUM(金額) FROM ACCOUNT WHERE 月份=N'" + month + "'" +
               "AND " + "收入或支出=N'收入'" + " AND " + "年份=N'" + year + "'";
            oConn = Function.Conn(ConnectionString.AccountDB);
            Income = Function.CalculateTotal(sSQL, oConn);
            return Income;
        }

        public override int CalculateExpense()
        {
            sSQL = "SELECT SUM(金額) FROM ACCOUNT WHERE 月份=N'" + month + "'" +
                "AND " + "收入或支出=N'支出'" + " AND " + "年份=N'" + year + "'";
            oConn = Function.Conn(ConnectionString.AccountDB);
            Expense = Function.CalculateTotal(sSQL, oConn);
            return Expense;
        }

        public int CalculatePreLend()
        {
            sSQL = "SELECT SUM(金額) FROM ACCOUNT WHERE 月份=N'" + month + "'" +
                   "AND " + "收入或支出=N'" + "預借現金" + "'" + " AND " + "年份=N'" + 
                   year + "'";
            oConn = Function.Conn(ConnectionString.AccountDB);
            TotalPreLend = Function.CalculateTotal(sSQL, oConn);
            return TotalPreLend;
        }

        public int CalculatePersonalPreLend(string name)
        {
            sSQL = "SELECT SUM(金額) FROM ACCOUNT WHERE 收入或支出=N'" + "預借現金" + "'" + 
                   " AND " + "月份=N'" + month + "'" + " AND " + "年份=N'" + year + "'" +
                   " AND " + "項目 LIKE N'" + name + "%'";
            oConn = Function.Conn(ConnectionString.AccountDB);
            PersonalPrelend = Function.CalculateTotal(sSQL, oConn);
            return PersonalPrelend;
        }
        #endregion
    }

    class CYearCalculation : CCalculation
    {
        #region Variable
        private int average = 0;
        #endregion

        #region Constructor
        public CYearCalculation(string oyear)
        {
            year = oyear;
        }
        #endregion

        #region Property
        public  override int CalculateIncome()
        {
            sSQL = "SELECT SUM(金額) FROM ACCOUNT WHERE 收入或支出=N'收入'" + " AND "
                + "年份=N'" + year + "'";
            oConn = Function.Conn(ConnectionString.AccountDB);
            Income = Function.CalculateTotal(sSQL, oConn);
            return Income;
        }

        public override int CalculateExpense()
        {
            sSQL = "SELECT SUM(金額) FROM ACCOUNT WHERE 收入或支出=N'支出'" + " AND " +
                "年份=N'" + year + "'";
            oConn = Function.Conn(ConnectionString.AccountDB);
            Expense = Function.CalculateTotal(sSQL, oConn);
            return Expense;
        }

        public int CalculateAverage()
        {
            CalculateTotalIncomeandExpense();
            average = totalIncomeandExpense / 12;
            return average;
        }
        #endregion
    }
}
