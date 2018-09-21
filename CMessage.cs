using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 記帳SQLServer
{

    public class CMessage
    {
        public const string NotValidData = "資料不合法。";
        public const string SystemError = "系統錯誤。";
        public const string Sussess = "成功處理資料。";
        public const string NULL = "金額為空值。";
        public const string DataExist = "資料重複，請重新輸入。";
        public const string DataNotExist = "資料不存在，請重新輸入。";
    } 
}
