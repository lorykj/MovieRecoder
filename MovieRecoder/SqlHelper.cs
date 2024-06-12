using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MovieRecoder
{
    public class SqlHelper
    {
        public static string GetSqlConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["sqlConnection"].ToString();
        }
        // 增删改操作: 返回影响的行数，大于0则修改成功
        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(GetSqlConnectionString()))
            {
                using (SqlCommand comm = conn.CreateCommand())
                {
                    try
                    {
                        conn.Open();
                        comm.CommandText = sql;
                        if (parameters != null)
                            comm.Parameters.AddRange(parameters);
                        return comm.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    finally
                    {
                        if (conn != null && conn.State != ConnectionState.Closed)
                            conn.Close();
                    }

                }
            }
        }
        // Adapter查询操作，返回DataTable：用于datagripview
        public static DataTable ExecuteDataTable(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(GetSqlConnectionString()))
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    //方法2
                    cmd.Parameters.AddRange(parameters);        //AddRange添加的是数组
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet dataset = new DataSet();
                    adapter.Fill(dataset);
                    return dataset.Tables[0];           //可以查询很多表，默认第一个
                }
            }
        }
        // 查询操作，返回查询结果中的第一行第一列的值，如果不为空则为存在
        public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(GetSqlConnectionString()))
            {
                using (SqlCommand comm = conn.CreateCommand())
                {
                    try
                    {
                        conn.Open();
                        comm.CommandText = sql;
                        if (parameters != null)
                            comm.Parameters.AddRange(parameters);
                        if (comm.ExecuteScalar() != null)
                        {
                            return comm.ExecuteScalar().ToString();
                        }
                        else
                        {
                            return null;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("An error occurred while executing the SQL command.", ex);
                    }
                    finally
                    {
                        if (conn != null && conn.State != ConnectionState.Closed)
                            conn.Close();
                    }
                }
            }
        }
        // 执行查询多行或多列的数据的方法：ExecuteReader
        public static SqlDataReader ExecuteReader(string sqlText)
        {
            //SqlDataReader要求，它读取数据的时候有，它独占它的SqlConnection对象，而且SqlConnection必须是Open状态
            SqlConnection conn = new SqlConnection(GetSqlConnectionString());   // 不要释放连接，因为后面还需要连接打开状态
            SqlCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd = new SqlCommand(sqlText, conn);
            SqlDataReader sdr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            return sdr;
        }
    }
}