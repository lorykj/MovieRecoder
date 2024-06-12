using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Sunny.UI;

namespace MovieRecoder
{
    public partial class AddMemo : UIForm
    {
        // 记录是否修改的变量
        private static Boolean time1changed = false;
        private static Boolean time2changed = false;
        public AddMemo()
        {
            InitializeComponent();
            name_Panel1.Text = global.movie;
            pictureBox1.ImageLocation = global.path+$@"\{global.movie}.jpg";
        }
        // ------------------------提交修改按钮--------------------
        private void uiSymbolButton2_Click(object sender, System.EventArgs e)
        {
            // 如果没有进行修改
            if (time1changed == false && time2changed == false)
            {
                UIMessageBox.ShowError("您未进行修改");
                return;
            }
            // 检测开始时间和结束时间的差是否大于0
            DateTime start = uiDatetimePicker1.Value;
            DateTime end = uiDatetimePicker2.Value;
            TimeSpan minute = new TimeSpan(end.Ticks - start.Ticks);
            TimeSpan min = TimeSpan.Parse("0.0:00:00");
            if (minute < min)
            {
                UIMessageBox.ShowError("结束时间应晚于开始时间");
                return;
            }
            // 更新时间
            try
            {
                string sql = $@"update memory 
                    set starttime = '{start}', endtime = '{end}'
                    where movie='{name_Panel1.Text}' and uname = '{global.uname}'";
                if (SqlHelper.ExecuteNonQuery(sql) > 0)
                {
                    this.ShowSuccessTip("修改成功");
                    time1changed = false;
                    time2changed = false;
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
        // -------------根据事件是否触发来修改变量----------------
        private void uiDatetimePicker1_ValueChanged(object sender, DateTime value)
        {
            time1changed = true;
            UIMessageTip.ShowOk("开始时间编辑成功");
        }

        private void uiDatetimePicker2_ValueChanged(object sender, DateTime value)
        {
            time2changed = true;
            UIMessageTip.ShowOk("结束时间编辑成功");
        }
    }
}
