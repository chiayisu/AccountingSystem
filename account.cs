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

        CAccount Account = new CAccount();
        string sSQL;
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
            Account.Year = YearTextBox.Text;
            Account.Month = MonthtextBox.Text;
            Account.Day = DayTextBox.Text;
            Account.Item = ItemComboBox.Text;
            Account.Dollar = int.Parse(DollarTextBox.Text);
            Account.InputDataType = DecideInputType();

            if (ConfirmInfo(InputMode, Account) != DialogResult.OK)
                return;

            if (Function.IsNull(DollarTextBox.Text))
            {
                MessageBox.Show(CMessage.NULL, "注意");
                return;
            }

            sSQL = "SELECT TOP 1 年份, 月份, 日期, 項目, 金額, 收入或支出 FROM ACCOUNT WHERE 年份=N'" + Account.Year +
                   "'" + " AND " + "月份=N'" + Account.Month + "'" +"AND 日期 = N'" + Account.Day + "'" + 
                   "AND 項目=N'" + Account.Item + "'" + "AND 金額='" + Account.Dollar + "'AND 收入或支出=N'" +
                   Account.InputDataType + "'";
            oConn = Function.Conn(ConnectionString.AccountDB);
            int IsData = Function.IsDataExist(sSQL, oConn);
            if (IsData == ReturnCode.DataExist)
            {
                MessageBox.Show(CMessage.DataExist, "注意");
                return;
            }
            else if (IsData == ReturnCode.SQLException)
            {
                MessageBox.Show(CMessage.SystemError, "注意");
                return;
            }
            sSQL = "INSERT INTO ACCOUNT (年份, 月份, 日期, 項目, 金額, 收入或支出) VALUES(N'" + Account.Year +
                   "', N'" + Account.Month + "', N'" + Account.Day +"', N'" + Account.Item + 
                   "', '" + Account.Dollar + "', N'" + Account.InputDataType + "')";
            MessageBox.Show(getMessage(Function.DBIDU(sSQL, oConn)), "注意");
        }

        private void DeleteBN_Click(object sender, EventArgs e)
        {
            string InputMode = DeleteBN.Text;
            Account.Year = YearTextBox.Text;
            Account.Month = MonthtextBox.Text;
            Account.Day = DayTextBox.Text;
            Account.Item = ItemComboBox.Text;
            Account.Dollar = int.Parse(DollarTextBox.Text);
            Account.InputDataType = DecideInputType();

            if (ConfirmInfo(InputMode, Account) != DialogResult.OK)
                return;

            if (Function.IsNull(DollarTextBox.Text))
            {
                MessageBox.Show(CMessage.NULL, "注意");
                return;
            }

            sSQL = "SELECT TOP 1 年份, 月份, 日期, 項目, 金額, 收入或支出 FROM ACCOUNT WHERE 年份=N'" + 
                   Account.Year + "'" + " AND " + "月份=N'" + Account.Month + "'" + "AND 日期 = N'" + 
                   Account.Day + "'" + "AND 項目=N'" + Account.Item + "'" + "AND 金額='" + Account.Dollar + 
                   "'AND 收入或支出=N'" + Account.InputDataType + "'";
            oConn = Function.Conn(ConnectionString.AccountDB);
            int IsData = Function.IsDataExist(sSQL, oConn);
            if (IsData == ReturnCode.DataNotExist)
            {
                MessageBox.Show(CMessage.DataNotExist, "注意");
                return;
            }
            else if (IsData == ReturnCode.SQLException)
            {
                MessageBox.Show(CMessage.SystemError, "注意");
                return;
            }

            sSQL = "DELETE ACCOUNT WHERE 年份=N'" + Account.Year + "'" + " AND " + "月份=N'" + Account.Month + "'" +
                   "AND 日期 = N'" + Account.Day + "'" + "AND 項目=N'" + Account.Item + "'" + "AND 金額='" + 
                   Account.Dollar + "'AND 收入或支出=N'" + Account.InputDataType + "'";
            MessageBox.Show(getMessage(Function.DBIDU(sSQL, oConn)), "注意");

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

        string getMessage(int code)
        {
            if (code == ReturnCode.NotValidData)
            {
                return CMessage.NotValidData;
            }
            else if (code == ReturnCode.Success)
            {
                return CMessage.Sussess;
            }
            else
                return CMessage.SystemError;
        }
    }
}
