using System;
using System.Data;
using System.Windows.Forms;
using Sunny.UI;

namespace MovieRecoder
{
    public partial class Collect : UIPage
    {
        public Collect()
        {
            InitializeComponent();
        }
        // ----------------------------加载数据-----------------------
        private void Collect_Initialize(object sender, EventArgs e)
        {
            LoadData();
        }
        // -------------------------将数据表加载出来----------------------
        private void LoadData()
        {
            string sql = $@"SELECT 
	            m.mname as '电影名', i.date as '上映时间', m.area as '制片地区', m.genres as '类型', language as '语言', director as '导演', i.actor, m.vote, i.vote_cnt
            FROM 
                [MovieDB].[dbo].[collect] c
            INNER JOIN  
                [MovieDB].[dbo].[Movie] m ON c.mname = m.mname
            INNER JOIN 
	            [MovieDB].[dbo].[Info] i ON c.mname = i.iname
            where c.uname = '{global.uname}'";
            DataTable dataTable = SqlHelper.ExecuteDataTable(sql);
            uiDataGridView1.DataSource = dataTable;
            // 设置页脚：统计记录数量和写上列名
            int cnt = uiDataGridView1.RowCount;
            uiDataGridViewFooter1.Clear();
            uiDataGridViewFooter1["电影名"] = "合计：" + cnt;
            uiDataGridViewFooter1["上映时间"] = "上映日期";
            uiDataGridViewFooter1["制片地区"] = "地区";
            uiDataGridViewFooter1["类型"] = "类型";
            uiDataGridViewFooter1["语言"] = "语言";
            uiDataGridViewFooter1["导演"] = "导演";
            uiDataGridViewFooter1["actor"] = "主演";
            uiDataGridViewFooter1["vote"] = "评分";
            uiDataGridViewFooter1["vote_cnt"] = "评分人数";
        }
        // -----------------------搜索功能：不符合条件的进行隐藏-------------------
        private void uiTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[uiDataGridView1.DataSource];
            cm.SuspendBinding(); // 挂起数据绑定
            uiDataGridView1.ReadOnly = true; // 只读
            cm.ResumeBinding();  // 继续数据绑定
            // 检查搜索框内容是否为空
            if (!string.IsNullOrEmpty(searchbox.Text))
            {
                foreach (DataGridViewRow row in uiDataGridView1.Rows)
                {
                    // 如果行是未提交的新行，则跳过
                    if (row.IsNewRow || row.DataBoundItem == null)
                        continue;
                    // 是否匹配变量
                    bool rowMatches = false;
                    // 遍历每个单元格
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // 检查单元格值是否为 null 并转换为字符串
                        if (cell.Value != null && cell.Value.ToString().Contains(searchbox.Text))
                        {
                            rowMatches = true;
                            break; // 一旦找到匹配项就跳出循环
                        }
                    }
                    // 根据匹配结果设置行的可见性
                    row.Visible = rowMatches;
                }
            }
            else
            {
                // 如果搜索框为空，则显示所有行
                foreach (DataGridViewRow row in uiDataGridView1.Rows)
                {
                    // 如果行是未提交的新行，则跳过
                    if (row.IsNewRow || row.DataBoundItem == null)
                        continue;
                    row.Visible = true;
                }
            }
        }
        // -------------------移除电影--------------------
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            if (uiDataGridView1.CurrentRow == null)
            {
                UIMessageBox.ShowError("您无法删除空值");
                return;
            }
            string chosen = uiDataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (this.ShowAskDialog("确认移除《" + chosen + "》吗？"))
            {
                string sql = $"delete collect where mname = '{chosen}' and uname = '{global.uname}'";
                if (SqlHelper.ExecuteNonQuery(sql) > 0)
                {
                    UIMessageBox.ShowSuccess("移除成功");
                }
                else
                {
                    UIMessageBox.ShowError("移除失败");
                }
                LoadData();
            }
        }
        // -----------------禁止编辑：若编辑则自动刷新顶替----------------
        private void uiDataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // 结束编辑并刷新数据
            uiDataGridView1.EndEdit();
            LoadData();
        }
    }
}
