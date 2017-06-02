using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

/// <summary>
/// SqlHelper 的摘要说明
/// </summary>
public class SqlHelper
{
    public SqlHelper()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    private SqlConnection con = null;
    private string sql = ConfigurationManager.ConnectionStrings["SQLLine"].ConnectionString;
    private void Connection()
    {
        if (con == null)
        {
            con = new SqlConnection(sql);
        }
        else if (con.State == ConnectionState.Open)
        {
            return;
        }
        con.Open();
    }
    private  SqlCommand GetCommand(string sqlString)
    {
        Connection();
        SqlCommand com = new SqlCommand(sqlString, con);
        return com;
    }

    public DataSet GetDataSet(string sqlString, SqlParameter[] values = null)//参数可空
    {
        DataSet ds = new DataSet();
        SqlCommand com = GetCommand(sqlString);
        if (values != null)
        {
            foreach (var item in values)
            {
                com.Parameters.Add(item);
            }
        }
        SqlDataAdapter sda = new SqlDataAdapter(com);
        sda.Fill(ds);
        if (ds.Tables[0].Rows.Count == 0)
        {
            object[] data = new object[ds.Tables[0].Columns.Count];
            for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
            {
                data[i] = null;
            }
            ds.Tables[0].Rows.Add(data);
        }
        return ds;
    }
    public  SqlDataReader GetDataReader(string sql, SqlParameter[] values)
    {
        SqlCommand com = GetCommand(sql);
        foreach (var item in values)
        {
            com.Parameters.Add(item);
        }
        SqlDataReader dr = com.ExecuteReader();
        return dr;
    }
    #region 执行不带参数sql语句，返回一个DataTable对象

    public DataTable GetDataTable(string sql)
    {

        SqlDataReader dr;
        DataTable dt = new DataTable();
        try
        {
            SqlCommand com = GetCommand(sql);
            dr = com.ExecuteReader(CommandBehavior.CloseConnection);
            dt.Load(dr);
            dr.Close();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        return dt;
    }
    #endregion

    #region 执行带参数的sql语句或存储过程，返回一个DataTable对象
    public DataTable GetDataTable(string sql, CommandType cmdType, SqlParameter[] cmdParms)
    {
        SqlDataReader reader;
        DataTable dt = new DataTable();
        try
        {
            SqlCommand com = GetCommand(sql);
            reader = com.ExecuteReader(CommandBehavior.CloseConnection);
            dt.Load(reader);
            reader.Close();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        return dt;
    }
    #endregion
    public bool GetExist(string sqlString, SqlParameter[] values)
    {
        try
        {
            SqlCommand com = GetCommand(sqlString);
            foreach (var item in values)
            {
                com.Parameters.Add(item);
            }
            int i = int.Parse(com.ExecuteScalar().ToString());
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception)
        {
            return false;
        }
    }

    public bool GetInsert(string sqlString, SqlParameter[] values)
    {
        try
        {
            SqlCommand com = GetCommand(sqlString);
            foreach (var item in values)
            {
                com.Parameters.Add(item);
            }
            int i = com.ExecuteNonQuery();
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception)
        {
            return false;
        }
    }
    public string GetInsertID(string sqlString, SqlParameter[] values)
    {
        try
        {
            sqlString += " select @@identity ";
            SqlCommand com = GetCommand(sqlString);

            foreach (var item in values)
            {
                com.Parameters.Add(item);
            }
            string i = com.ExecuteScalar().ToString();
            if (!string.IsNullOrWhiteSpace(i))
            {
                return i;
            }
            else
            {
                return "";
            }

        }
        catch (Exception)
        {
            return "";
        }

    }
    public bool GetDelete(string sqlString, SqlParameter[] values)
    {
        try
        {
            SqlCommand com = GetCommand(sqlString);
            foreach (var item in values)
            {
                com.Parameters.Add(item);
            }
            int i = com.ExecuteNonQuery();
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        catch (Exception)
        {
            return false;
        }
    }

    public int GetUpdate(string sqlString, SqlParameter[] values)
    {
        try
        {
            SqlCommand com = GetCommand(sqlString);
            foreach (var item in values)
            {
                com.Parameters.Add(item);
            }
            int i = com.ExecuteNonQuery();
            if (i > 0)
            {
                return i;
            }
            else
            {
                return 0;
            }
        }
        catch (Exception)
        {
            return 0;
        }
    }

}