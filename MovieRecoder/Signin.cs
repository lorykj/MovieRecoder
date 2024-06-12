using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using Sunny.UI;

namespace MovieRecoder
{
    public partial class Signin : UIForm
    {
        // 创建线程
        private Thread th;
        public Signin()
        {
            InitializeComponent();
        }
        // 点击注册按钮
        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (userTextbox.Text == "")
            {
                UIMessageBox.ShowError("用户名为空");
                return;
            }
            else
            {
                // 检测用户是否已经注册
                try
                {
                    string sql = $"select * from [User] where uname='{userTextbox.Text}'";
                    object result = SqlHelper.ExecuteScalar(sql);
                    if (result != null)
                    {
                        UIMessageBox.ShowError("该用户名已被占用");
                        return;
                    }
                }
                catch (SqlException ex)
                {
                    // 处理SQL异常
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
            }
            // 检测是否选择了性别
            if (uiRadioButton1.Checked == false && uiRadioButton2.Checked == false)
            {
                UIMessageBox.ShowError("请选择性别");
                return;
            }// 检测是否输入年龄
            else if (ageTextbox.Text == "0")
            {
                UIMessageBox.ShowError("请输入年龄");
                return;
            }// 检测是否输入邮箱
            else if (mailTextbox.Text == "")
            {
                UIMessageBox.ShowError("请输入邮箱");
                return;
            }// 检测是否输入密码
            else if (pwdTextbox.Text == "")
            {
                UIMessageBox.ShowError("密码为空");
                return;
            }
            // 获取输入的用户名、性别等信息
            string name = userTextbox.Text;
            Boolean ismale = false;
            if (uiRadioButton1.Checked == true)
            {
                ismale = true;
            }
            string age = ageTextbox.Text;
            string pwd = pwdTextbox.Text;
            string mail = mailTextbox.Text;
            // 插入User数据表完成注册
            try
            {
                string sql = $"insert into [User] values ('{name}','{pwd}','{ismale}','{age}','{mail}')";
                if (SqlHelper.ExecuteNonQuery(sql) > 0)
                {
                    UIMessageBox.ShowSuccess("注册成功");
                }
                else
                {
                    UIMessageBox.ShowError("该用户已经存在");
                }
            }
            catch (SqlException ex)
            {
                // 处理SQL异常
                MessageBox.Show("SQL Error: " + ex.Message);
            }
        }
        // 回车注册
        private void pwdTestbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == '\r')
            {
                uiButton1_Click(sender, e);
            }
        }
        // 显示密码和隐藏密码
        private void uiCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            // 如果 CheckBox 被选中，则显示密码；否则隐藏密码
            if (uiCheckBox1.Checked)
            {
                pwdTextbox.PasswordChar = '\0';
            }
            else
            {
                pwdTextbox.PasswordChar = '*';
            }
        }
        // 点击返回按钮：返回登录界面
        private void uiButton2_Click(object sender, EventArgs e)
        {
            if (uiCheckBox2.Checked == false)
                UIMessageBox.ShowError("请先同意协议");
            else
            {
                th = new Thread(new ThreadStart(BackForm));
                th.Start();
                this.Close();
            }

        }
        // 重新打开登录界面
        [STAThread]
        private static void BackForm()
        {
            Login form2 = new Login();
            Application.Run(form2);
        }
    }
}
