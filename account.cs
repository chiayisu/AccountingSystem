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
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }
        string sSQL;
        CAccount Account;
        SqlConnection oConn;
        CDate date = new CDate();
        private void account_Load(object sender, EventArgs e)
        {
            
            YearTextBox.Text = date.Year.ToString();
            MonthtextBox.Text = date.Month.ToString();
            DayTextBox.Text = date.Day.ToString();
            ItemComboBox.SelectedIndex = 1;
            IncomeradioButton.Select();
        }

        private void InsertionBN_Click(object sender, EventArgs e)
        {
            string InputMode = InsertionBN.Text;
            Account = new CAccount();
            Account = InitAccount(Account);
            if (ConfirmInfo(InputMode, Account) != DialogResult.OK)
                return;
            if (Function.IsNull(DollarTextBox.Text))
            {
                MessageBox.Show(CMessage.NULL, "注意");
                return;
            }
            int IsExist = performIsExist(ConnectionString.AccountDB, Account);
            if (IsExist == ReturnCode.DataNotExist)
                MessageBox.Show(InsertAccount(ConnectionString.AccountDB, Account), "注意");
            else
                MessageBox.Show(getMessage(IsExist), "注意");
        }

        private void DeleteBN_Click(object sender, EventArgs e)
        {
            string InputMode = DeleteBN.Text;
            Account = new CAccount();
            Account = InitAccount(Account);
            if (ConfirmInfo(InputMode, Account) != DialogResult.OK)
                return;
            if (Function.IsNull(DollarTextBox.Text))
            {
                MessageBox.Show(CMessage.NULL, "注意");
                return;
            }
            int IsExist = performIsExist(ConnectionString.AccountDB, Account);
            if (IsExist == ReturnCode.DataExist)
                MessageBox.Show(deleteAccount(ConnectionString.AccountDB, Account), "注意");
            else
                MessageBox.Show(getMessage(IsExist), "注意");
        }

        CAccount InitAccount(CAccount account)
        {
            account.Year = YearTextBox.Text;
            account.Month = MonthtextBox.Text;
            account.Day = DayTextBox.Text;
            account.Item = ItemComboBox.Text;
            account.Dollar = int.Parse(DollarTextBox.Text);
            account.InputDataType = DecideInputType();
            return account;
        }

        string DecideInputType()
        {
            if (IncomeradioButton.Checked == true)
                return IncomeradioButton.Text;
            else if (ExpenseradioButton.Checked == true)
                return ExpenseradioButton.Text;
            else
                return PreBorrowedMONradioButton.Text;
        }
       
        
        DialogResult ConfirmInfo(string mode, CAccount AccountInfo)
        {
            DialogResult result;
            result = MessageBox.Show("模式:" + mode + "\n" + "年份: " + AccountInfo.Year + "\n" + "月份: " + 
                     AccountInfo.Month + "\n" + "日期: " + AccountInfo.Day + "\n" + "項目: " + 
                     AccountInfo.Item + "\n" + "金額: " + AccountInfo.Dollar + 
                     "\n", "請確定資料正確", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            return result;
        }

        int performIsExist(string DB_Name, CAccount account)
        {
            sSQL = "SELECT TOP 1 年份, 月份, 日期, 項目, 金額, 收入或支出 FROM ACCOUNT WHERE 年份=N'" +
              account.Year + "'" + " AND " + "月份=N'" + account.Month + "'" + "AND 日期 = N'" +
              account.Day + "'" + "AND 項目=N'" + account.Item + "'" + "AND 金額='" + account.Dollar +
              "'AND 收入或支出=N'" + account.InputDataType + "'";
            oConn = Function.Conn(DB_Name);
            int IsData = Function.IsDataExist(sSQL, oConn);
            return IsData;
        }

        string InsertAccount(string DB_Name, CAccount account)
        {
            oConn = Function.Conn(DB_Name);
            sSQL = "INSERT INTO ACCOUNT (年份, 月份, 日期, 項目, 金額, 收入或支出) VALUES(N'" + account.Year +
                   "', N'" + account.Month + "', N'" + account.Day + "', N'" + account.Item +
                   "', '" + account.Dollar + "', N'" + account.InputDataType + "')";
            return getMessage(Function.DBIDU(sSQL, oConn));
        }

        string deleteAccount(string DB_Name, CAccount account)
        {
            oConn = Function.Conn(DB_Name);
            sSQL = "DELETE ACCOUNT WHERE 年份=N'" + account.Year + "'" + " AND " + "月份=N'" + account.Month + "'" +
               "AND 日期 = N'" + account.Day + "'" + "AND 項目=N'" + account.Item + "'" + "AND 金額='" +
               account.Dollar + "'AND 收入或支出=N'" + account.InputDataType + "'";
            return getMessage(Function.DBIDU(sSQL, oConn));
        }

        string getMessage(int code)
        {
            if (code == ReturnCode.NotValidData)
                return CMessage.NotValidData;
            else if (code == ReturnCode.Success)
                return CMessage.Sussess;
            else if (code == ReturnCode.DataExist)
                return CMessage.DataExist;
            else if (code == ReturnCode.DataNotExist)
                return CMessage.DataNotExist;
            else
                return CMessage.SystemError;
        }
    }
}
