using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Sunny.UI;

namespace MovieRecoder
{
    public partial class Lastest : UIPage
    {
        private bool ischeck1 = false;  // 记录四个复选框是否被选择的变量
        private bool ischeck2 = false;
        private bool ischeck3 = false;
        private bool ischeck4 = false;
        private string name1 = "未知";    // 记录四个标题文本框的内容
        private string name2 = "未知";
        private string name3 = "未知";
        private string name4 = "未知";

        public Lastest()
        {
            InitializeComponent();
            FillPanels();
        }
        // -----------------------填充页面内容-----------------------------
        public void FillPanels()
        {
            // 读取数据
            string sql = $@"
                SELECT top 4
                    m.mname, m.year, m.area, m.genres, m.vote, m.image, i.director, i.actor, i.date
                FROM 
                    [MovieDB].[dbo].[Movie] m
                JOIN 
                    [MovieDB].[dbo].[Info] i ON m.mname = i.iname
                order by date desc";
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(sql);
                int panelIndex = 1;
                while (reader.Read() && panelIndex <= 4)
                {
                    string name = reader["mname"].ToString();
                    string da = reader["date"].ToString();
                    string yeararea = da.Substring(0, da.Length - 8) + "/" + reader["area"].ToString();
                    
                    
                    string genres = reader["genres"].ToString().Replace(" ", "");
                    string vote = reader["vote"].ToString();
                    string actor = reader["director"].ToString() + '/' + reader["actor"].ToString();
                    string path = global.path + $@"\{name}.jpg";
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
                    // 获取第一个复选框的是否选中
                    ischeck1 = uiCheckBox1.Checked;
                    // 清空选中状态
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
        // 创建写入数据表的类实例
        WriteData wd = new WriteData();
        // ---------------------------点击收藏按钮------------------------
        private void uiButton3_Click(object sender, EventArgs e)
        {
            // 遍历每个 Panel 获取选择
            for (int panelIndex = 1; panelIndex <= 4; panelIndex++)
            {
                getChecked(panelIndex);
            }

            // 写入数据库
            wd.writecollect(1, ischeck1, name1);
            wd.writecollect(2, ischeck2, name2);
            wd.writecollect(3, ischeck3, name3);
            wd.writecollect(4, ischeck4, name4);
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
       
    }
}
