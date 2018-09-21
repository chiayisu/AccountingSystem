using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;



public class ConnectionString
{
    public const string AccountDB = "Data Source=(LocalDB)\\v11.0;AttachDbFilename=D:\\MyDataBase\\Industrial_Server.mdf;Integrated Security=True";
}

public static class ReturnCode
{
    public const int DataExist = 0;
    public const int DataNotExist = 1;
    public const int SQLException = 2;
    public const int NotValidData = 3;
    public const int Success = 4;
}

 public class Function
 {
     public static bool IsNull(string s)
     {
         if (s == "")
             return true;
         return false;
     }

     public static SqlConnection Conn(string DB_Name)
     {
         SqlConnection oConn = new SqlConnection();
         oConn.ConnectionString = DB_Name;
         return oConn;
     }

     public static int IsDataExist(string sSQL, SqlConnection oConn)
     {

         SqlCommand cmd;
         try
         {
             oConn.Open();
             cmd = new SqlCommand(sSQL, oConn);
             if (cmd.ExecuteScalar() != null)
             {
                 return ReturnCode.DataExist;
             }
             else
             {
                 return ReturnCode.DataNotExist;
             }
         }
         catch (SqlException se)
         {
             return ReturnCode.SQLException;
         }
         finally
         {
             oConn.Close();
         }
         
     }

     public static int DBIDU(string sSQL, SqlConnection conn)
     {
         try
         {
             conn.Open();
             SqlCommand cmd = new SqlCommand(sSQL, conn);
             cmd.ExecuteNonQuery();
             cmd.Dispose();
             return ReturnCode.Success;
         }
         catch (SqlException ex)
         {
             return ReturnCode.SQLException;
         }
         finally
         {
             conn.Close();
         }
     }

     public static DataSet Retrieve(string sSQL, SqlConnection oConn)
     {
         DataSet ds = new DataSet();
         SqlDataAdapter da = new SqlDataAdapter(sSQL, oConn);
         da.Fill(ds, "ACCOUNT");
         return ds;
     }

     public static int CalculateTotal(string sSQL, SqlConnection oConn)
     {
         SqlCommand cmd;
         int total = 0;
         try
         {
             oConn.Open();
             cmd = new SqlCommand(sSQL, oConn);
             if (cmd.ExecuteScalar().ToString() != "")
                 total = Convert.ToInt32(cmd.ExecuteScalar());
             return total;
         }
         catch (SqlException)
         {
             return -1;
         }
         catch (InvalidCastException)
         {
             return -2;
         }
         finally
         {
             oConn.Close();
         }
         
     }
    
    
 
 }

 