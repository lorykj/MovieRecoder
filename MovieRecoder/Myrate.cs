using System;
using System.Data;
using Sunny.UI;

namespace MovieRecoder
{
    public partial class Myrate : UIPage
    {
        public Myrate()
        {
            InitializeComponent();
        }

        private void Myrate_Initialize(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            string sql = $@"SELECT 
	            m.mname as '电影名', r.rate as '我的评分', r.remark as '我的评价', r.time as '评价时间', i.date as '上映时间', m.area, m.genres, director, i.actor, m.vote, i.vote_cnt
            FROM 
                [MovieDB].[dbo].[rating] r
            inner JOIN 
	            [MovieDB].[dbo].[Movie] m on mname = r.movie
            inner join
                [MovieDB].[dbo].[Info] i ON m.mname = i.iname
            where r.uname = '{global.uname}'
            order by '评价时间' desc";
            DataTable dataTable = SqlHelper.ExecuteDataTable(sql);
            uiDataGridView1.DataSource = dataTable;
            int cnt = uiDataGridView1.RowCount;
            uiDataGridViewFooter1.Clear();
            uiDataGridViewFooter1["电影名"] = "合计：" + cnt;
        }
    }
}
