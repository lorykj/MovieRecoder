namespace MovieRecoder
{
    partial class AddMemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMemo));
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.uiDatetimePicker1 = new Sunny.UI.UIDatetimePicker();
            this.uiDatetimePicker2 = new Sunny.UI.UIDatetimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.name_Panel1 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.uiSymbolButton2.Location = new System.Drawing.Point(465, 359);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.Radius = 20;
            this.uiSymbolButton2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.uiSymbolButton2.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(97)))), ((int)(((byte)(198)))));
            this.uiSymbolButton2.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(46)))), ((int)(((byte)(147)))));
            this.uiSymbolButton2.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(46)))), ((int)(((byte)(147)))));
            this.uiSymbolButton2.Size = new System.Drawing.Size(93, 44);
            this.uiSymbolButton2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton2.Symbol = 61508;
            this.uiSymbolButton2.TabIndex = 13;
            this.uiSymbolButton2.Text = "编辑";
            this.uiSymbolButton2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton2.Click += new System.EventHandler(this.uiSymbolButton2_Click);
            // 
            // uiDatetimePicker1
            // 
            this.uiDatetimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiDatetimePicker1.FillColor2 = System.Drawing.Color.White;
            this.uiDatetimePicker1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiDatetimePicker1.Location = new System.Drawing.Point(498, 88);
            this.uiDatetimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatetimePicker1.MaxLength = 19;
            this.uiDatetimePicker1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatetimePicker1.Name = "uiDatetimePicker1";
            this.uiDatetimePicker1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatetimePicker1.Radius = 10;
            this.uiDatetimePicker1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.uiDatetimePicker1.RectSize = 2;
            this.uiDatetimePicker1.Size = new System.Drawing.Size(259, 34);
            this.uiDatetimePicker1.Style = Sunny.UI.UIStyle.Custom;
            this.uiDatetimePicker1.SymbolDropDown = 61555;
            this.uiDatetimePicker1.SymbolNormal = 61555;
            this.uiDatetimePicker1.SymbolSize = 24;
            this.uiDatetimePicker1.TabIndex = 14;
            this.uiDatetimePicker1.Text = "2024-06-11 00:00:00";
            this.uiDatetimePicker1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatetimePicker1.Value = new System.DateTime(2024, 6, 11, 0, 0, 0, 0);
            this.uiDatetimePicker1.Watermark = "";
            this.uiDatetimePicker1.ValueChanged += new Sunny.UI.UIDatetimePicker.OnDateTimeChanged(this.uiDatetimePicker1_ValueChanged);
            // 
            // uiDatetimePicker2
            // 
            this.uiDatetimePicker2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiDatetimePicker2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.uiDatetimePicker2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiDatetimePicker2.Location = new System.Drawing.Point(498, 204);
            this.uiDatetimePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatetimePicker2.MaxLength = 19;
            this.uiDatetimePicker2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatetimePicker2.Name = "uiDatetimePicker2";
            this.uiDatetimePicker2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatetimePicker2.Radius = 10;
            this.uiDatetimePicker2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.uiDatetimePicker2.RectSize = 2;
            this.uiDatetimePicker2.Size = new System.Drawing.Size(259, 37);
            this.uiDatetimePicker2.Style = Sunny.UI.UIStyle.Custom;
            this.uiDatetimePicker2.SymbolDropDown = 61555;
            this.uiDatetimePicker2.SymbolNormal = 61555;
            this.uiDatetimePicker2.SymbolSize = 24;
            this.uiDatetimePicker2.TabIndex = 15;
            this.uiDatetimePicker2.Text = "2024-06-12 00:00:00";
            this.uiDatetimePicker2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatetimePicker2.Value = new System.DateTime(2024, 6, 12, 0, 0, 0, 0);
            this.uiDatetimePicker2.Watermark = "";
            this.uiDatetimePicker2.ValueChanged += new Sunny.UI.UIDatetimePicker.OnDateTimeChanged(this.uiDatetimePicker2_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(49, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // name_Panel1
            // 
            this.name_Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.name_Panel1.AutoSize = true;
            this.name_Panel1.BackColor = System.Drawing.Color.Transparent;
            this.name_Panel1.Font = new System.Drawing.Font("阿里妈妈数黑体", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.name_Panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.name_Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.name_Panel1.Location = new System.Drawing.Point(71, 376);
            this.name_Panel1.Name = "name_Panel1";
            this.name_Panel1.Size = new System.Drawing.Size(166, 27);
            this.name_Panel1.Style = Sunny.UI.UIStyle.Custom;
            this.name_Panel1.TabIndex = 21;
            this.name_Panel1.Text = "我们一起摇太阳";
            this.name_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("阿里妈妈数黑体", 14.25F, System.Drawing.FontStyle.Bold);
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uiLabel1.Location = new System.Drawing.Point(371, 88);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(120, 34);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 23;
            this.uiLabel1.Text = "开始时间";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("阿里妈妈数黑体", 14.25F, System.Drawing.FontStyle.Bold);
            this.uiLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.uiLabel2.Location = new System.Drawing.Point(371, 204);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(120, 34);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 24;
            this.uiLabel2.Text = "结束时间";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddMemo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(97)))), ((int)(((byte)(198)))));
            this.Controls.Add(this.uiDatetimePicker2);
            this.Controls.Add(this.uiDatetimePicker1);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.name_Panel1);
            this.Controls.Add(this.uiSymbolButton2);
            this.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMemo";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "编辑";
            this.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.TitleFont = new System.Drawing.Font("阿里妈妈数黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TopMost = true;
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UIDatetimePicker uiDatetimePicker1;
        private Sunny.UI.UIDatetimePicker uiDatetimePicker2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UILabel name_Panel1;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
    }
}