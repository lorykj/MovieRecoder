using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using Sunny.UI;
namespace MovieRecoder
{
    public partial class Memory : UIPage
    {
        private static int mid = 1;
        public Memory()
        {
            InitializeComponent();
        }
        //-----------------------------初始化界面------------------------
        private void Memory_Initialize(object sender, EventArgs e)
        {
            // 加载数据
            LoadData();
        }
        // -------------------------将数据表加载出来----------------------
        private void LoadData()
        {
            string sql = $@"SELECT movie as '电影名', starttime as'开始时间', endtime as '结束时间'
            FROM 
                [MovieDB].[dbo].[memory]
            where uname = '{global.uname}'
            order by starttime";
            DataTable dataTable = SqlHelper.ExecuteDataTable(sql);
            uiDataGridView1.DataSource = dataTable;
        }
        // ----------------------搜索---------------------------
        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[uiDataGridView1.DataSource];
            cm.SuspendBinding(); //挂起数据绑定
            uiDataGridView1.ReadOnly = true; // 只读
            cm.ResumeBinding(); //继续数据绑定

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
                    int cnt = uiDataGridView1.RowCount;
                    uiDataGridViewFooter1["memoid"] = "合计：" + cnt;
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
        // -----------------------------移除电影------------------------------
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            if (uiDataGridView1.CurrentRow == null)
            {
                UIMessageBox.ShowError("您无法删除空值");
                return;
            }
            string chosen = uiDataGridView1.CurrentRow.Cells[1].Value.ToString();
            if (this.ShowAskDialog("确认移除《" + chosen + "》吗？"))
            {
                string sql = $"delete memory where movie = '{chosen}' and uname = '{global.uname}'";
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
        // ------------------------编辑按钮：打开设置时间界面----------------------------
        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            uiDataGridView1.CurrentRow.Cells[0].Value = mid++;
            global.movie = uiDataGridView1.CurrentRow.Cells[1].Value.ToString();
            th = new Thread(new ThreadStart(StartMainForm));
            th.Start();
        }
        [STAThread]
        private static void StartMainForm()
        {
            AddMemo add = new AddMemo();
            Application.Run(add);
        }
        private Thread th;
        // ----------------------刷新按钮：重新加载数据---------------------
        private void uiSymbolButton3_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void searchbox_TextChanged_1(object sender, EventArgs e)
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
    }
}
