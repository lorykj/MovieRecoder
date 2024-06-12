using System.Data.SqlClient;
using System.Windows.Forms;
using Sunny.UI;

namespace MovieRecoder
{
    internal class WriteData
    {
        // ------------------将选择的某个电影写入collect数据库-------------------
        public void writecollect(int index, bool isChecked, string name)
        {
            if (isChecked)
            {
                string sql = $"select * from [collect] where uname='{global.uname}' and mname='{name}'";
                if (SqlHelper.ExecuteScalar(sql) != null)
                {
                    UIMessageBox.ShowError($"电影 {name} 已在您的收藏夹中");
                    return;
                }
                try
                {
                    sql = $"insert into collect values('{global.uname}', '{name}')";
                    //UIMessageBox.ShowInfo(sql);
                    if (SqlHelper.ExecuteNonQuery(sql) > 0)
                        UIMessageBox.ShowSuccess($"收藏成功 (电影 {name})");
                    else
                        UIMessageBox.ShowError($"电影 {name} 已在您的收藏夹");
                }
                catch (SqlException ex)
                {
                    // 处理 SQL 异常
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
            }
        }
        // ------------------将选择的某个电影写入memory数据库-------------------
        public void writememory(int index, bool isChecked, string name)
        {
            if (isChecked)
            {
                string sql = $"select * from [memory] where uname='{global.uname}' and movie='{name}'";
                if (SqlHelper.ExecuteScalar(sql) != null)
                {
                    UIMessageBox.ShowError($"电影 {name} 已在您待看列表中");
                    return;
                }
                try
                {
                    sql = $"insert into [memory] (uname, movie) values ('{global.uname}', '{name}')";
                    if (SqlHelper.ExecuteNonQuery(sql) > 0)
                    {
                        UIMessageBox.ShowSuccess($"添加成功 (电影 {name})");
                    }
                    else
                    {
                        UIMessageBox.ShowError($"电影 {name} 已在您待看列表中");
                    }
                }
                catch (SqlException ex)
                {
                    // 处理 SQL 异常
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
            }
        }

    }
}
