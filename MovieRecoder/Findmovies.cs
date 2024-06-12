using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using Sunny.UI;

namespace MovieRecoder
{
    public partial class Findmovies : UIPage
    {
        // 声明线程
        private Thread th;
        // 设置成员变量   
        private int currentPage = 1;            //当前页数
        private readonly int maxpage = global.recode / 4;//最大页数：每页四条数据
        private readonly int pageSize = 4;      // 每页显示4个记录
        private bool ischeck1 = false;          // 记录四个复选框是否被选择的变量
        private bool ischeck2 = false;
        private bool ischeck3 = false;
        private bool ischeck4 = false;
        private string name1 = "未知";          // 记录四个标题文本框的内容
        private string name2 = "未知";
        private string name3 = "未知";
        private string name4 = "未知";
        private string myorder = "ORDER BY mname";  // 用于修改sql查询语句的条件

        // -----------------获取当前页数：约束最大页数和最小页数---------------
        public int Getpage()
        {
            if (currentPage > maxpage)
                return maxpage;
            else if (currentPage < 1)
                return 1;
            return currentPage;
        }
        public Findmovies()
        {
            InitializeComponent();
            FillPanels(myorder);
        }
        // -----------------------填充页面内容-----------------------------
        public void FillPanels(string order)
        {
            // 页码文本框内容为当前页码
            pagebox.Text = currentPage.ToString();
            // 根据当前页数来偏移数据行数：比如第2页就偏移4行
            int offset = (currentPage - 1) * pageSize;
            string sql = $@"
                SELECT 
                    m.mname, m.year, m.area, m.genres, m.vote, m.image, i.director, i.actor, i.date
                FROM 
                    [MovieDB].[dbo].[Movie] m
                JOIN 
                    [MovieDB].[dbo].[Info] i ON m.mname = i.iname
                {order}
                OFFSET {offset} ROWS
                FETCH NEXT {pageSize} ROWS ONLY;";
            // 读取数据
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(sql);
                int panelIndex = 1;
                // 依次读取四行所需的单元内容
                while (reader.Read() && panelIndex <= 4)
                {
                    // 电影名
                    string name = reader["mname"].ToString();
                    // 年份+地区
                    string yeararea = reader["year"].ToString() + '/' + reader["area"].ToString();
                    // 类型
                    string genres = reader["genres"].ToString().Replace(" ", "");
                    // 评分
                    string vote = reader["vote"].ToString();
                    // 导演和演员
                    string actor = reader["director"].ToString() + '/' + reader["actor"].ToString();
                    // 图片从本地读取：命名与电影名相同
                    string path = global.path+$@"\{name}.jpg";
                    // 调用填充单个panel的函数依次填充四个板块
                    FillPanelData(panelIndex, name, yeararea, genres, actor, vote, path);
                    if (System.IO.File.Exists(path))
                    {
                        FillPanelData(panelIndex, name, yeararea, genres, actor, vote, path);
                    }
                    else
                    {
                        FillPanelData(panelIndex, name, yeararea, genres, actor, vote, null);
                        UIMessageBox.ShowError("文件不存在：" + path);
                    }
                    panelIndex++;
                }
            }
            catch (SqlException ex)
            {
                // 处理SQL异常
                MessageBox.Show("SQL Error: " + ex.Message);
            }
        }
        // -------------------用数据填充四个中某个板块------------------------
        private void FillPanelData(int panelIndex, string name, string year, string genre, string actor, string vote, string imageUrl)
        {
            switch (panelIndex)
            {
                case 1:
                    name_Panel1.Text = name;
                    yeararea_Panel1.Text = year;
                    genrelebal_Panel1.Text = genre;
                    actorlabel_Panel1.Text = actor;
                    votelabel_Panel1.Text = vote;
                    if (imageUrl != null)
                    {
                        pictureBox1.ImageLocation = imageUrl;
                    }
                    name1 = name;
                    break;

                case 2:
                    name_Panel2.Text = name;
                    yeararea_Panel2.Text = year;
                    genrelebal_Panel2.Text = genre;
                    actorlabel_Panel2.Text = actor;
                    votelabel_Panel2.Text = vote;
                    if (imageUrl != null)
                        pictureBox2.ImageLocation = imageUrl;
                    name2 = name;
                    break;

                case 3:
                    name_Panel3.Text = name;
                    yeararea_Panel3.Text = year;
                    genrelebal_Panel3.Text = genre;
                    actorlabel_Panel3.Text = actor;
                    votelabel_Panel3.Text = vote;
                    if (imageUrl != null)
                        pictureBox3.ImageLocation = imageUrl;
                    name3 = name;
                    break;

                case 4:
                    name_Panel4.Text = name;
                    yeararea_Panel4.Text = year;
                    genrelebal_Panel4.Text = genre;
                    actorlabel_Panel4.Text = actor;
                    votelabel_Panel4.Text = vote;
                    if (imageUrl != null)
                        pictureBox4.ImageLocation = imageUrl;
                    name4 = name;
                    break;

                default:
                    throw new ArgumentException("Invalid panel index");
            }
        }
        // --------------获取四个复选框的选择值并调整变量值, 并清空选择状态------------------
        private void getChecked(int panelIndex)
        {
            switch (panelIndex)
            {
                case 1:
                    ischeck1 = uiCheckBox1.Checked;
                    uiCheckBox1.Checked = false;
                    break;
                case 2:
                    ischeck2 = uiCheckBox2.Checked;
                    uiCheckBox2.Checked = false;
                    break;
                case 3:
                    ischeck3 = uiCheckBox3.Checked;
                    uiCheckBox3.Checked = false;
                    break;
                case 4:
                    ischeck4 = uiCheckBox4.Checked;
                    uiCheckBox4.Checked = false;
                    break;
                default:
                    throw new ArgumentException("Invalid panel index");
            }
        }
        // -----------------到上一页------------------
        private void left_Click_1(object sender, EventArgs e)
        {
            int panelIndex = 1;
            while (panelIndex <= 4)
            {
                getChecked(panelIndex);
                panelIndex++;
            }
            if (currentPage > 1)
            {
                currentPage--;
                currentPage = Getpage();
                FillPanels(myorder);
            }
        }
        // -----------------到下一页--------------------
        private void right_Click_1(object sender, EventArgs e)
        {
            int panelIndex = 1;
            while (panelIndex <= 4)
            {
                getChecked(panelIndex);
                panelIndex++;
            }
            currentPage++;
            currentPage = Getpage();
            FillPanels(myorder);
        }
        // -------------------------点击上方的导航栏：根据点击的内容来排序------------------
        private void uiNavBar1_MenuItemClick(string itemText, int menuIndex, int pageIndex)
        {
            switch (itemText)
            {
                case "高分优先":
                    // 将order by 后的内容更改为按照vote降序
                    myorder = myorder.Substring(0, myorder.IndexOf("ORDER BY") + 8) + " vote DESC";
                    break;
                case "默认":
                    myorder = myorder.Substring(0, myorder.IndexOf("ORDER BY") + 8) + " mname";
                    break;
                case "首映时间":
                    myorder = myorder.Substring(0, myorder.IndexOf("ORDER BY") + 8) + " date DESC";
                    break;
                case "剧情":
                case "科幻":
                case "动作":
                case "爱情":
                case "冒险":
                    // 如果还没有条件where，则添加第一个条件
                    if (!myorder.Contains("WHERE"))
                        myorder = "WHERE genres LIKE '%" + itemText + "%' " + myorder;
                    else
                        //如果已经有where，则在前面的条件后面增加一个条件：找到%'，在后面加and
                        myorder = myorder.Insert(myorder.IndexOf("%'") + 2, " AND genres LIKE '%" + itemText + "%' ");
                    //UIMessageBox.ShowInfo(myorder);
                    break;
                case "中国大陆":
                case "中国香港":
                case "中国台湾":
                case "日本":
                    if (!myorder.Contains("WHERE"))
                        myorder = "WHERE area LIKE '%" + itemText + "%' " + myorder;
                    else
                        myorder = myorder.Insert(myorder.IndexOf("%'") + 2, " AND area LIKE '%" + itemText + "%' ");
                    break;
                // 这里要单独处理，因为内容不是按照欧美来查询
                case "欧美":
                    if (!myorder.Contains("WHERE"))
                        myorder = "WHERE (area LIKE '%美国%' OR area LIKE '%英国%' OR area LIKE '%加拿大%' OR area LIKE '%法国%') " + myorder;
                    else
                        myorder = myorder.Insert(myorder.IndexOf("%'") + 2, " AND (area LIKE '%美国%' OR area LIKE '%英国%' OR area LIKE '%加拿大%' OR area LIKE '%法国%') ");
                    break;
                default:
                    throw new ArgumentException("Invalid choice");
            }
            currentPage = 1;
            // 传入条件进行填充
            FillPanels(myorder);
        }
        // --------------------------在页码框中输入页码---------------------
        private void pagebox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == '\r')
                currentPage = int.Parse(pagebox.Text);
            currentPage = Getpage();
            // 根据页码调整偏移填充
            FillPanels(myorder);
        }
        // 创建写入数据表的类实例
        WriteData wd = new WriteData();
        // ---------------------------点击收藏按钮------------------------
        private void collect(object sender, EventArgs e)
        {
            // 遍历每个 Panel 获取选择
            for (int panelIndex = 1; panelIndex <= 4; panelIndex++)
            {
                getChecked(panelIndex);
            }
            // 根据成员变量获取是否选择的信息，将选择的依次写入数据库
            wd.writecollect(1, ischeck1, name1);
            wd.writecollect(2, ischeck2, name2);
            wd.writecollect(3, ischeck3, name3);
            wd.writecollect(4, ischeck4, name4);
        }
        // -----------------------重置为默认排序---------------------
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            myorder = "ORDER BY mname";
            currentPage = 1; 
            FillPanels(myorder);
        }
        // ------------------------加入待看-------------------------
        private void uiButton1_Click(object sender, EventArgs e)
        {
            // 遍历每个 Panel 获取选择
            for (int panelIndex = 1; panelIndex <= 4; panelIndex++)
            {
                getChecked(panelIndex);
            }
            // 写入数据库
            wd.writememory(1, ischeck1, name1);
            wd.writememory(2, ischeck2, name2);
            wd.writememory(3, ischeck3, name3);
            wd.writememory(4, ischeck4, name4);
        }
        
        private void Opendetail(string label)
        {
            global.movie = label;
            // 创建并显示新的 Detail 窗口
            Detail detail = new Detail();
            detail.Show();
        }
        // -------------------点击标题生成详情页------------------
        private void Name_Panel1_Click(object sender, EventArgs e)
        {
            Opendetail(name_Panel1.Text);
        }

        private void name_Panel2_Click(object sender, EventArgs e)
        {
            Opendetail(name_Panel2.Text);
        }

        private void name_Panel3_Click(object sender, EventArgs e)
        {
            Opendetail(name_Panel3.Text);
        }

        private void name_Panel4_Click_1(object sender, EventArgs e)
        {
            Opendetail(name_Panel4.Text);
        }
    }
}
