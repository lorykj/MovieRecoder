using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Sunny.UI;

namespace MovieRecoder
{
    public partial class Detail : UIForm
    {
        public Detail()
        {
            InitializeComponent();
            fillform();
        }
        // --------------------读取数据进行填充内容-----------------
        private void fillform()
        {
            string sql = $@"
                SELECT 
                    m.mname, m.area, m.genres, m.vote, i.director, i.actor, i.date, i.vote_cnt, i.intro, i.runtime, r.rate, r.remark
                FROM 
                    [MovieDB].[dbo].[Movie] m
                JOIN 
                    [MovieDB].[dbo].[Info] i ON m.mname = i.iname
                join 
                    [rating] r on r.movie = m.mname and r.uname = '{global.uname}'
                WHERE m.mname = '{global.movie}'";
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(sql);
                if (reader.Read())
                {
                    name_Panel1.Text = reader["mname"].ToString();
                    area.Text = "制片地区：" + reader["area"].ToString();
                    genre.Text = "类型：" + reader["genres"].ToString().Replace(" ", "");
                    vote.Text = "豆瓣评分：" + reader["vote"].ToString();
                    actor.Text = "主演：" + reader["actor"].ToString();
                    director.Text = "导演：" + reader["director"].ToString();
                    vote_cnt.Text = "评分人数：" + reader["vote_cnt"].ToString();
                    runtime.Text = "片长：" + reader["runtime"].ToString();
                    string da = reader["date"].ToString();
                    date.Text = "上映日期：" + da.Substring(0, da.Length - 7);
                    string path = global.path + $@"\{global.movie}.jpg";
                    intro.Text = "简介：" + reader["intro"].ToString();
                    rate.Text = reader["rate"].ToString();
                    remark.Text = reader["remark"].ToString();
                    if (System.IO.File.Exists(path))
                    {
                        pictureBox1.ImageLocation = path;
                    }
                    else
                    {
                        UIMessageBox.ShowError("文件不存在：" + path);
                    }
                }else
                {
                    sql = $@"
                SELECT 
                    m.mname, m.area, m.genres, m.vote, i.director, i.actor, i.date, i.vote_cnt, i.intro, i.runtime
                FROM 
                    [MovieDB].[dbo].[Movie] m
                JOIN 
                    [MovieDB].[dbo].[Info] i ON m.mname = i.iname
                WHERE m.mname = '{global.movie}'";
                    reader = SqlHelper.ExecuteReader(sql);
                    if (reader.Read())
                    {
                        name_Panel1.Text = reader["mname"].ToString();
                        area.Text = "制片地区：" + reader["area"].ToString();
                        genre.Text = "类型：" + reader["genres"].ToString().Replace(" ", "");
                        vote.Text = "豆瓣评分：" + reader["vote"].ToString();
                        actor.Text = "主演：" + reader["actor"].ToString();
                        director.Text = "导演：" + reader["director"].ToString();
                        vote_cnt.Text = "评分人数：" + reader["vote_cnt"].ToString();
                        runtime.Text = "片长：" + reader["runtime"].ToString();
                        string da = reader["date"].ToString();
                        date.Text = "上映日期：" + da.Substring(0, da.Length - 7);
                        string path = global.path + $@"\{global.movie}.jpg";
                        intro.Text = "简介：" + reader["intro"].ToString();
                        pictureBox1.ImageLocation = path;
                    }  
                }
            }
            catch (SqlException ex)
            {
                // 处理SQL异常
                UIMessageBox.Show("SQL Error: " + ex.Message);
            }
        }
        // ------------------------提交评价按钮--------------------
        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            // 若没有填写则提示
            if (intro.Text == "" || rate.Text == "0-10分")
            {
                UIMessageBox.ShowError("请填写完整(评分和评价)");
                return;
            }
            // 先查询是否已经评价过，若是则进行修改，否则进行插入
            string sql = $"select * from [rating] where uname='{global.uname}' and movie='{global.movie}'";
            object result = SqlHelper.ExecuteScalar(sql);
            if (result != null)
            {
                try
                {
                    sql = $@"update [rating]
                    set rate = '{rate.Text}', remark = '{remark.Text}', time='{DateTime.Now}'
                    where movie='{global.movie}' and uname = '{global.uname}'";
                    if (SqlHelper.ExecuteNonQuery(sql) > 0)
                    {
                        this.ShowSuccessTip("评价成功");
                    }
                    else
                    {
                        UIMessageBox.ShowError("评价失败，请联系管理员");
                    }
                }
                catch (SqlException ex)
                {
                    // 处理SQL异常
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
            }
            else
            {
                // 先进行插入，否则会插入多条
                sql = $"insert into [rating] values('{global.uname}', '{global.movie}','{rate.Text}','{remark.Text}','{DateTime.Now}')";
                SqlHelper.ExecuteNonQuery(sql);
            }
        }
    }
}
