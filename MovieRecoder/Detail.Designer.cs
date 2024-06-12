namespace MovieRecoder
{
    partial class Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detail));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vote = new Sunny.UI.UILabel();
            this.actor = new Sunny.UI.UILabel();
            this.genre = new Sunny.UI.UILabel();
            this.area = new Sunny.UI.UILabel();
            this.name_Panel1 = new Sunny.UI.UILabel();
            this.director = new Sunny.UI.UILabel();
            this.date = new Sunny.UI.UILabel();
            this.vote_cnt = new Sunny.UI.UILabel();
            this.remark = new Sunny.UI.UITextBox();
            this.myvote = new Sunny.UI.UILabel();
            this.myremark = new Sunny.UI.UILabel();
            this.intro = new Sunny.UI.UILabel();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.rate = new Sunny.UI.UIComboBox();
            this.runtime = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(13, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // vote
            // 
            this.vote.BackColor = System.Drawing.Color.Transparent;
            this.vote.Font = new System.Drawing.Font("阿里妈妈数黑体", 14.25F, System.Drawing.FontStyle.Bold);
            this.vote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.vote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.vote.Location = new System.Drawing.Point(20, 408);
            this.vote.Name = "vote";
            this.vote.Size = new System.Drawing.Size(169, 23);
            this.vote.TabIndex = 25;
            this.vote.Text = "豆瓣评分：5.5分";
            this.vote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // actor
            // 
            this.actor.BackColor = System.Drawing.Color.Transparent;
            this.actor.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.actor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.actor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.actor.Location = new System.Drawing.Point(254, 205);
            this.actor.Name = "actor";
            this.actor.Size = new System.Drawing.Size(204, 35);
            this.actor.TabIndex = 24;
            this.actor.Text = "主演：彭昱畅";
            this.actor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // genre
            // 
            this.genre.BackColor = System.Drawing.Color.Transparent;
            this.genre.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.genre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.genre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.genre.Location = new System.Drawing.Point(254, 96);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(211, 38);
            this.genre.TabIndex = 23;
            this.genre.Text = "类型：剧情/爱情/家庭";
            this.genre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // area
            // 
            this.area.BackColor = System.Drawing.Color.Transparent;
            this.area.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.area.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.area.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.area.Location = new System.Drawing.Point(254, 141);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(211, 29);
            this.area.TabIndex = 22;
            this.area.Text = "制片地区：中国大陆";
            this.area.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name_Panel1
            // 
            this.name_Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.name_Panel1.BackColor = System.Drawing.Color.Transparent;
            this.name_Panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.name_Panel1.Font = new System.Drawing.Font("阿里妈妈数黑体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name_Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.name_Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.name_Panel1.Location = new System.Drawing.Point(253, 50);
            this.name_Panel1.Name = "name_Panel1";
            this.name_Panel1.Size = new System.Drawing.Size(234, 46);
            this.name_Panel1.TabIndex = 21;
            this.name_Panel1.Text = "我们一起摇太阳";
            this.name_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // director
            // 
            this.director.BackColor = System.Drawing.Color.Transparent;
            this.director.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.director.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.director.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.director.Location = new System.Drawing.Point(254, 240);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(211, 38);
            this.director.TabIndex = 27;
            this.director.Text = "导演：韩延";
            this.director.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.Color.Transparent;
            this.date.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.date.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.date.Location = new System.Drawing.Point(254, 278);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(211, 38);
            this.date.TabIndex = 28;
            this.date.Text = "上映时间：2023-12-30";
            this.date.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vote_cnt
            // 
            this.vote_cnt.BackColor = System.Drawing.Color.Transparent;
            this.vote_cnt.Font = new System.Drawing.Font("阿里妈妈数黑体", 14.25F, System.Drawing.FontStyle.Bold);
            this.vote_cnt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.vote_cnt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.vote_cnt.Location = new System.Drawing.Point(195, 408);
            this.vote_cnt.Name = "vote_cnt";
            this.vote_cnt.Size = new System.Drawing.Size(169, 23);
            this.vote_cnt.TabIndex = 29;
            this.vote_cnt.Text = "评分人数：1000人";
            this.vote_cnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // remark
            // 
            this.remark.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.remark.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.remark.Location = new System.Drawing.Point(508, 136);
            this.remark.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.remark.MinimumSize = new System.Drawing.Size(1, 16);
            this.remark.Multiline = true;
            this.remark.Name = "remark";
            this.remark.Padding = new System.Windows.Forms.Padding(5);
            this.remark.ShowText = false;
            this.remark.Size = new System.Drawing.Size(247, 160);
            this.remark.TabIndex = 31;
            this.remark.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.remark.Watermark = "";
            // 
            // myvote
            // 
            this.myvote.BackColor = System.Drawing.Color.Transparent;
            this.myvote.Font = new System.Drawing.Font("阿里妈妈数黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myvote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.myvote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myvote.Location = new System.Drawing.Point(504, 50);
            this.myvote.Name = "myvote";
            this.myvote.Size = new System.Drawing.Size(121, 38);
            this.myvote.TabIndex = 32;
            this.myvote.Text = "我的评分：";
            this.myvote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // myremark
            // 
            this.myremark.BackColor = System.Drawing.Color.Transparent;
            this.myremark.Font = new System.Drawing.Font("阿里妈妈数黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.myremark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.myremark.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myremark.Location = new System.Drawing.Point(504, 93);
            this.myremark.Name = "myremark";
            this.myremark.Size = new System.Drawing.Size(121, 38);
            this.myremark.TabIndex = 33;
            this.myremark.Text = "我的评价：";
            this.myremark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // intro
            // 
            this.intro.BackColor = System.Drawing.Color.Transparent;
            this.intro.Font = new System.Drawing.Font("等线", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.intro.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.intro.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.intro.Location = new System.Drawing.Point(254, 316);
            this.intro.Name = "intro";
            this.intro.Size = new System.Drawing.Size(501, 73);
            this.intro.Style = Sunny.UI.UIStyle.Custom;
            this.intro.TabIndex = 34;
            this.intro.Text = "简介：";
            this.intro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.uiSymbolButton2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.uiSymbolButton2.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(97)))), ((int)(((byte)(198)))));
            this.uiSymbolButton2.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(46)))), ((int)(((byte)(147)))));
            this.uiSymbolButton2.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(46)))), ((int)(((byte)(147)))));
            this.uiSymbolButton2.Font = new System.Drawing.Font("阿里妈妈数黑体", 12F, System.Drawing.FontStyle.Bold);
            this.uiSymbolButton2.LightColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.uiSymbolButton2.Location = new System.Drawing.Point(585, 408);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.Radius = 20;
            this.uiSymbolButton2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.uiSymbolButton2.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(97)))), ((int)(((byte)(198)))));
            this.uiSymbolButton2.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(46)))), ((int)(((byte)(147)))));
            this.uiSymbolButton2.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(46)))), ((int)(((byte)(147)))));
            this.uiSymbolButton2.Size = new System.Drawing.Size(108, 29);
            this.uiSymbolButton2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton2.Symbol = 61508;
            this.uiSymbolButton2.TabIndex = 35;
            this.uiSymbolButton2.Text = "提交评价";
            this.uiSymbolButton2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton2.Click += new System.EventHandler(this.uiSymbolButton2_Click);
            // 
            // rate
            // 
            this.rate.DataSource = null;
            this.rate.FillColor = System.Drawing.Color.White;
            this.rate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rate.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.rate.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.rate.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.rate.Location = new System.Drawing.Point(605, 59);
            this.rate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rate.MaxDropDownItems = 11;
            this.rate.MinimumSize = new System.Drawing.Size(63, 0);
            this.rate.Name = "rate";
            this.rate.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.rate.Size = new System.Drawing.Size(150, 29);
            this.rate.SymbolSize = 24;
            this.rate.TabIndex = 36;
            this.rate.Text = "0-10分";
            this.rate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.rate.Watermark = "";
            // 
            // runtime
            // 
            this.runtime.BackColor = System.Drawing.Color.Transparent;
            this.runtime.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.runtime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.runtime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.runtime.Location = new System.Drawing.Point(254, 170);
            this.runtime.Name = "runtime";
            this.runtime.Size = new System.Drawing.Size(161, 38);
            this.runtime.TabIndex = 37;
            this.runtime.Text = "片长：114分钟";
            this.runtime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Detail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(97)))), ((int)(((byte)(198)))));
            this.Controls.Add(this.rate);
            this.Controls.Add(this.uiSymbolButton2);
            this.Controls.Add(this.intro);
            this.Controls.Add(this.remark);
            this.Controls.Add(this.myremark);
            this.Controls.Add(this.myvote);
            this.Controls.Add(this.vote_cnt);
            this.Controls.Add(this.date);
            this.Controls.Add(this.director);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.vote);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.area);
            this.Controls.Add(this.name_Panel1);
            this.Controls.Add(this.runtime);
            this.Controls.Add(this.actor);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Detail";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "详细信息";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.TitleFont = new System.Drawing.Font("阿里妈妈数黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UILabel vote;
        private Sunny.UI.UILabel actor;
        private Sunny.UI.UILabel genre;
        private Sunny.UI.UILabel area;
        private Sunny.UI.UILabel name_Panel1;
        private Sunny.UI.UILabel director;
        private Sunny.UI.UILabel date;
        private Sunny.UI.UILabel vote_cnt;
        private Sunny.UI.UITextBox remark;
        private Sunny.UI.UILabel myvote;
        private Sunny.UI.UILabel myremark;
        private Sunny.UI.UILabel intro;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UIComboBox rate;
        private Sunny.UI.UILabel runtime;
    }
}