using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Sunny.UI;
namespace MovieRecoder
{
    public partial class Personal : UIPage
    {
        public Personal()
        {
            InitializeComponent();
            Infoinitial();
        }
        private void Personal_Initialize(object sender, EventArgs e)
        {
            Nearinitial();
        }
        // 最近评分初始化
        private void Nearinitial()
        {
            string sql = $@"
                SELECT top 1
                    m.mname, m.year, m.area, m.genres, m.vote, i.director, i.actor, r.rate, r.remark, r.time
                FROM 
                    [MovieDB].[dbo].[rating] r
                inner JOIN 
                    [MovieDB].[dbo].[Movie] m on mname = r.movie
                inner join
                    [MovieDB].[dbo].[Info] i ON m.mname = i.iname
                where uname = '{global.uname}' AND r.time IS NOT NULL
                order by time desc";
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(sql);
                if (reader.Read())
                {
                    // 电影名
                    string mname = reader["mname"].ToString();
                    nname.Text = mname;
                    // 年份+地区
                    yeararea.Text = reader["year"].ToString() + '/' + reader["area"].ToString(); ;
                    // 类型
                    genres.Text = reader["genres"].ToString().Replace(" ", "");
                    // 评分
                    vote.Text = reader["vote"].ToString() + "分";
                    // 导演和演员
                    actor.Text = reader["director"].ToString() + '/' + reader["actor"].ToString();
                    // 图片从本地读取：命名与电影名相同
                    string path = global.path + $@"\{mname}.jpg";
                    myrate.Text = reader["rate"].ToString() + "分";
                    myremark.Text = reader["remark"].ToString();
                    if (System.IO.File.Exists(path))
                        pictureBox1.ImageLocation = path;
                    else
                        UIMessageBox.ShowError("文件不存在：" + path);
                }
            }
            catch (SqlException ex)
            {
                // 处理SQL异常
                MessageBox.Show("SQL Error: " + ex.Message);
            }
        }
        // 个人信息初始化
        public void Infoinitial()
        {
            userTextbox.Text = global.uname;
            string sql = $"select gender, age, mail from [User] where uname = '{global.uname}'";
            // 查询User数据表获取用户的多个信息
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(sql);
                if (reader.Read())
                {
                    ageTextbox.Text = reader.IsDBNull(1) ? "0" : reader.GetInt32(1).ToString();
                    mailTextbox.Text = reader.IsDBNull(2) ? "未知" : reader.GetString(2);
                    // 信息为空则设置为未知或默认值
                    if (!reader.IsDBNull(0))
                    {
                        bool gender = reader.GetBoolean(0);
                        global.gender = gender;
                        if(gender==true)
                        {
                            uiRadioButton1.Checked = true;
                        }
                        else
                        {
                            uiRadioButton2.Checked = true;
                        } 
                    }
                }
            }
            catch (SqlException ex)
            {
                // 处理SQL异常
                MessageBox.Show("SQL Error: " + ex.Message);
            }
        } 
        // --------------------修改个人信息-------------------
        private void uiButton3_Click(object sender, EventArgs e)
        {
            // 检测新改的用户名是否重复
            string newname = userTextbox.Text;
            if (newname == global.uname)
            {
                UIMessageBox.ShowError("该用户名已被占用");
                return;
            }         
            // 单独处理性别选择
            int isfemale = 1;
            if (uiRadioButton2.Checked == true)
                isfemale = 0;
            // 更新个人信息
            try
            {
                string sql = $@"UPDATE [User] SET uname = '{newname}',
                                pwd = '{pwdTextbox.Text}',
                                gender = '{isfemale}',
                                age = {ageTextbox.Text},
                                mail = '{mailTextbox.Text}'
                             where uname='{global.uname}'";
                if (SqlHelper.ExecuteNonQuery(sql) > 0)
                {
                    this.ShowSuccessTip("信息修改成功");
                    global.uname = newname;
                }
                else
                {
                    UIMessageBox.ShowError("修改失败，请联系管理员");
                }
            }
            catch (SqlException ex)
            {
                // 处理SQL异常
                MessageBox.Show("SQL Error: " + ex.Message);
            }

        }
        // 修改密码
        private void uiButton1_Click_1(object sender, EventArgs e)
        {
            // 检测文本框是否有空
            if (originpwd.Text == "")
            {
                UIMessageBox.ShowError("请输入原始密码");
                return;
            }
            else if (pwdTextbox.Text == "")
            {
                UIMessageBox.ShowError("请输入新密码");
                return;
            }
            else if (pwdTextbox.Text == "")
            {
                UIMessageBox.ShowError("请输入确认密码");
                return;
            }
            // 获取文本框输入的内容
            string origin = originpwd.Text;
            string newpwd = pwdTextbox.Text;
            string confirm = confirmpwd.Text;
            // 检测新密码与原密码是否相同
            if (origin == newpwd)
            {
                UIMessageBox.ShowError("新密码不得与原密码一致");
                return;
            }
            // 检测确认密码与新密码是否相同
            else if (confirm != newpwd)
            {
                UIMessageBox.ShowError("请保证确认密码与新密码一致");
                return;
            }
            // 检验当前用户的原密码是否正确
            try
            {
                string sql = $"select pwd from [User] where uname='{global.uname}'";
                SqlDataReader reader = SqlHelper.ExecuteReader(sql);
                reader.Read();
                if (origin != reader["pwd"].ToString())
                {
                    UIMessageBox.ShowError("原密码不正确");
                    return;
                }
            }
            catch (SqlException ex)
            {
                // 处理SQL异常
                MessageBox.Show("SQL Error: " + ex.Message);
            }
            // 修改User数据表中的用户对应的密码
            try
            {
                string sql = $"update [User] set pwd = '{confirm}' where uname='{global.uname}'";
                if (SqlHelper.ExecuteNonQuery(sql) > 0)
                {
                    this.ShowSuccessTip("修改成功");
                }
                else
                {
                    UIMessageBox.ShowError("修改失败，请联系管理员");
                }
            }
            catch (SqlException ex)
            {
                // 处理SQL异常
                MessageBox.Show("SQL Error: " + ex.Message);
            }
        }
        // 清空文本框
        private void uiButton2_Click_1(object sender, EventArgs e)
        {
            originpwd.Text = "";
            pwdTextbox.Text = "";
            confirmpwd.Text = "";
        }
        // 显示密码
        private void uiCheckBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            // 如果 CheckBox 被选中，则显示密码；否则隐藏密码
            if (uiCheckBox1.Checked)
            {
                originpwd.PasswordChar = '\0';
                pwdTextbox.PasswordChar = '\0';
                confirmpwd.PasswordChar = '\0';
            }
            else
            {
                originpwd.PasswordChar = '*';
                pwdTextbox.PasswordChar = '*';
                confirmpwd.PasswordChar = '*';
            }
        }
    }
}
