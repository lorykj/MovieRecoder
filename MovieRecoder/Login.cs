using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using Sunny.UI;

namespace MovieRecoder
{
    public partial class Login : UIForm
    {
        // 创建线程，用于打开新窗口并同时关闭
        private Thread th;
        public Login()
        {
            InitializeComponent();
        }
        // 点击登录按钮
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            // 若文本框内未输入内容
            if (uiTextBox1.Text == "" || uiTextBox2.Text == "")
            {
                // 弹出问题框
                UIMessageBox.ShowError("用户名或密码为空");
                return;
            }
            // 获取文本框内输入的用户名和密码
            string name = uiTextBox1.Text;
            global.uname = name;
            string pwd = uiTextBox2.Text;
            // 写入数据库：插入User数据表
            try
            {
                string sql = $"select * from [User] where uname='{name}' and pwd='{pwd}'";
                object result = SqlHelper.ExecuteScalar(sql);
                if (result != null)
                {
                    this.ShowSuccessTip("登录成功");
                    th = new Thread(new ThreadStart(StartMainForm));
                    th.Start();
                    this.Close();
                }
                // 如果没有找到，说明该用户密码错误或者没注册
                else
                {
                    UIMessageBox.ShowError("用户名或密码错误");
                }
            }
            catch (SqlException ex)
            {
                // 处理SQL异常
                MessageBox.Show("SQL Error: " + ex.Message);
            }
        }
        // 启动主界面的函数
        [STAThread]
        private static void StartMainForm()
        {
            Main form2 = new Main();
            Application.Run(form2);
        }
        // 点击注册按钮
        private void uiSymbolButton2_Click_1(object sender, EventArgs e)
        {
            th = new Thread(new ThreadStart(StartSignForm));
            th.Start();
            this.Close();
        }
        // 启动注册界面的函数
        [STAThread]
        private static void StartSignForm()
        {
            Signin form3 = new Signin();
            Application.Run(form3);
        }
        // 输入回车也能登录
        private void uiTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == '\r')
            {
                uiSymbolButton1_Click(sender, e);
            }
        }
        // 显示密码和隐藏密码
        private void uiCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            // 如果 CheckBox 被选中，则显示密码；否则隐藏密码
            if (uiCheckBox1.Checked)
            {
                uiTextBox2.PasswordChar = '\0';
            }
            else
            {
                uiTextBox2.PasswordChar = '*';
            }
        }
    }
}
