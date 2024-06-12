using Sunny.UI;

namespace MovieRecoder
{
    public partial class Main : UIHeaderAsideMainFrame
    {
        public Main()
        {
            InitializeComponent();
            userlabel.Text = "用户：" + global.uname;
            // 添加边栏控制页面
            Aside.TabControl = MainTabControl;
            AddPage(new Lastest(), 1001);
            AddPage(new Findmovies(), 1002);
            AddPage(new Collect(), 1003);
            AddPage(new Memory(), 1004);
            AddPage(new Myrate(), 1005);
            AddPage(new Personal(), 1006);


            Aside.TabControl = MainTabControl;

            Aside.SetNodePageIndex(Aside.Nodes[0], 1001);
            Aside.SetNodePageIndex(Aside.Nodes[1], 1002);
            Aside.SetNodePageIndex(Aside.Nodes[2], 1003);
            Aside.SetNodePageIndex(Aside.Nodes[3], 1004);
            Aside.SetNodePageIndex(Aside.Nodes[4], 1005);
            Aside.SetNodePageIndex(Aside.Nodes[5], 1006);
        }
    }
}
