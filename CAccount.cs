using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;




public class CAccount
{
    #region variables
    private string year;
    private string month;
    private string day;
    private string item;
    private int dollar;
    private string inputDataType;

    #endregion

    #region Constructor
    public CAccount(){}
    public CAccount(string OYear, string  OMonth, string OData, string OItem, int ODollar)
    {
        year = OYear;
        month = OMonth;
        day = OData;
        item = OItem;
        dollar = ODollar;

    }
    #endregion

    #region Properties

    public string Year
    {
        set
        {
            year = value;
        }
        get
        {
            return year;
        }
    }

    public string Month
    {
        set
        {
            month = value;
        }
        get
        {
            return month;
        }
    }

    public string Day
    {
        set
        {
            day = value;
        }
        get
        {
            return day;
        }
    }

    public string Item
    {
        set
        {
            item = value;
        }
        get
        {
            return item;
        }
    }

    public int Dollar
    {
        set
        {
            dollar = value;
        }
        get
        {
            return dollar;
        }
    }

    public string InputDataType
    {
        set
        {
            inputDataType = value;
        }
        get
        {
            return inputDataType;
        }
    }
    #endregion

}

