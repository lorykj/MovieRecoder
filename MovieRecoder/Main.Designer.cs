namespace MovieRecoder
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("最新上映");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("选电影");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("我的收藏");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("待看电影");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("我的评分");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("个人主页");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.uiAvatar1 = new Sunny.UI.UIAvatar();
            this.uiSmoothLabel1 = new Sunny.UI.UISmoothLabel();
            this.userlabel = new Sunny.UI.UIMarkLabel();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Aside
            // 
            this.Aside.FillColor = System.Drawing.Color.Transparent;
            this.Aside.Font = new System.Drawing.Font("阿里妈妈数黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Aside.LineColor = System.Drawing.Color.White;
            this.Aside.Location = new System.Drawing.Point(2, 123);
            this.Aside.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            treeNode1.BackColor = System.Drawing.Color.White;
            treeNode1.Checked = true;
            treeNode1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            treeNode1.Name = "node1";
            treeNode1.NodeFont = new System.Drawing.Font("阿里妈妈数黑体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode1.Text = "最新上映";
            treeNode1.ToolTipText = "查看电影的信息";
            treeNode2.BackColor = System.Drawing.Color.White;
            treeNode2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            treeNode2.Name = "node2";
            treeNode2.Text = "选电影";
            treeNode3.Name = "节点2";
            treeNode3.Text = "我的收藏";
            treeNode4.Name = "节点3";
            treeNode4.Text = "待看电影";
            treeNode5.Name = "";
            treeNode5.Text = "我的评分";
            treeNode6.Name = "节点4";
            treeNode6.Text = "个人主页";
            this.Aside.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.Aside.SelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.Aside.SelectedHighColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.Aside.Size = new System.Drawing.Size(165, 551);
            this.Aside.Style = Sunny.UI.UIStyle.Custom;
            this.Aside.TipsFont = new System.Drawing.Font("阿里妈妈数黑体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // Header
            // 
            this.Header.Controls.Add(this.userlabel);
            this.Header.Controls.Add(this.uiSmoothLabel1);
            this.Header.Controls.Add(this.uiAvatar1);
            this.Header.Location = new System.Drawing.Point(2, 36);
            this.Header.Size = new System.Drawing.Size(1013, 87);
            // 
            // uiAvatar1
            // 
            this.uiAvatar1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.uiAvatar1.FillColor = System.Drawing.Color.Transparent;
            this.uiAvatar1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiAvatar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.uiAvatar1.Image = ((System.Drawing.Image)(resources.GetObject("uiAvatar1.Image")));
            this.uiAvatar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uiAvatar1.Location = new System.Drawing.Point(682, 21);
            this.uiAvatar1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAvatar1.Name = "uiAvatar1";
            this.uiAvatar1.Size = new System.Drawing.Size(51, 43);
            this.uiAvatar1.Style = Sunny.UI.UIStyle.Custom;
            this.uiAvatar1.TabIndex = 0;
            this.uiAvatar1.Text = "uiAvatar1";
            // 
            // uiSmoothLabel1
            // 
            this.uiSmoothLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSmoothLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiSmoothLabel1.Font = new System.Drawing.Font("JetBrains Mono ExtraBold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSmoothLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiSmoothLabel1.Location = new System.Drawing.Point(0, 0);
            this.uiSmoothLabel1.Name = "uiSmoothLabel1";
            this.uiSmoothLabel1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.uiSmoothLabel1.Size = new System.Drawing.Size(324, 87);
            this.uiSmoothLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSmoothLabel1.TabIndex = 1;
            this.uiSmoothLabel1.Text = "Movie Recoder";
            this.uiSmoothLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userlabel
            // 
            this.userlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userlabel.Font = new System.Drawing.Font("阿里妈妈数黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.userlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.userlabel.Location = new System.Drawing.Point(769, 30);
            this.userlabel.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.userlabel.Name = "userlabel";
            this.userlabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.userlabel.Size = new System.Drawing.Size(222, 34);
            this.userlabel.Style = Sunny.UI.UIStyle.Custom;
            this.userlabel.TabIndex = 2;
            this.userlabel.Text = "用户 ";
            this.userlabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1017, 676);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(51)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(2, 36, 2, 2);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.ShowDragStretch = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "Movie Recoder";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(0)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 800, 450);
            this.Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIAvatar uiAvatar1;
        private Sunny.UI.UISmoothLabel uiSmoothLabel1;
        private Sunny.UI.UIMarkLabel userlabel;
    }
}