using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 記帳SQLServer
{
    
    public class CDate
    {
        #region variables
        private int year;
        private int month;
        private int day;
        #endregion

        #region Constructor
        public CDate()
        {

        }
        #endregion

        #region Properties

        public int Year
        {
            get
            {
                year = DateTime.Now.Year;
                return year;
            }

        }

        public int Month
        {
            get
            {
                month = DateTime.Now.Month;
                return month;
            }

        }

        public int Day
        {
            get
            {
                day = DateTime.Now.Day;
                return day;
            }
        }

        #endregion


    }
}
