namespace CV
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.oldImg = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenImg = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseImg = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.newImg = new System.Windows.Forms.PictureBox();
            this.ExitWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.基本处理BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.几何变换JToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.灰度变换HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PingYI = new System.Windows.Forms.ToolStripMenuItem();
            this.镜像XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShuiPing = new System.Windows.Forms.ToolStripMenuItem();
            this.ChuiZhi = new System.Windows.Forms.ToolStripMenuItem();
            this.灰度化处理DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oldImg)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.oldImg);
            this.panel1.Location = new System.Drawing.Point(3, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 545);
            this.panel1.TabIndex = 0;
            // 
            // oldImg
            // 
            this.oldImg.Location = new System.Drawing.Point(3, 3);
            this.oldImg.Name = "oldImg";
            this.oldImg.Size = new System.Drawing.Size(485, 539);
            this.oldImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oldImg.TabIndex = 0;
            this.oldImg.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.基本处理BToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenImg,
            this.CloseImg,
            this.ExitWindow});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // OpenImg
            // 
            this.OpenImg.Name = "OpenImg";
            this.OpenImg.Size = new System.Drawing.Size(180, 22);
            this.OpenImg.Text = "打开(&O)";
            this.OpenImg.Click += new System.EventHandler(this.OpenImg_Click);
            // 
            // CloseImg
            // 
            this.CloseImg.Name = "CloseImg";
            this.CloseImg.Size = new System.Drawing.Size(180, 22);
            this.CloseImg.Text = "关闭(&C)";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.newImg);
            this.panel2.Location = new System.Drawing.Point(528, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 545);
            this.panel2.TabIndex = 2;
            // 
            // newImg
            // 
            this.newImg.Location = new System.Drawing.Point(3, 3);
            this.newImg.Name = "newImg";
            this.newImg.Size = new System.Drawing.Size(478, 542);
            this.newImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newImg.TabIndex = 0;
            this.newImg.TabStop = false;
            // 
            // ExitWindow
            // 
            this.ExitWindow.Name = "ExitWindow";
            this.ExitWindow.Size = new System.Drawing.Size(180, 22);
            this.ExitWindow.Text = "退出(&E)";
            this.ExitWindow.Click += new System.EventHandler(this.ExitWindow_Click);
            // 
            // 基本处理BToolStripMenuItem
            // 
            this.基本处理BToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.几何变换JToolStripMenuItem,
            this.灰度变换HToolStripMenuItem});
            this.基本处理BToolStripMenuItem.Name = "基本处理BToolStripMenuItem";
            this.基本处理BToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.基本处理BToolStripMenuItem.Text = "基本处理(&B)";
            // 
            // 几何变换JToolStripMenuItem
            // 
            this.几何变换JToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PingYI,
            this.镜像XToolStripMenuItem});
            this.几何变换JToolStripMenuItem.Name = "几何变换JToolStripMenuItem";
            this.几何变换JToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.几何变换JToolStripMenuItem.Text = "几何变换(&J)";
            // 
            // 灰度变换HToolStripMenuItem
            // 
            this.灰度变换HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.灰度化处理DToolStripMenuItem});
            this.灰度变换HToolStripMenuItem.Name = "灰度变换HToolStripMenuItem";
            this.灰度变换HToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.灰度变换HToolStripMenuItem.Text = "灰度变换(&H)";
            // 
            // PingYI
            // 
            this.PingYI.Name = "PingYI";
            this.PingYI.Size = new System.Drawing.Size(180, 22);
            this.PingYI.Text = "平移(&P)";
            this.PingYI.Click += new System.EventHandler(this.PingYI_Click);
            // 
            // 镜像XToolStripMenuItem
            // 
            this.镜像XToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShuiPing,
            this.ChuiZhi});
            this.镜像XToolStripMenuItem.Name = "镜像XToolStripMenuItem";
            this.镜像XToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.镜像XToolStripMenuItem.Text = "镜像(X)";
            // 
            // ShuiPing
            // 
            this.ShuiPing.Name = "ShuiPing";
            this.ShuiPing.Size = new System.Drawing.Size(180, 22);
            this.ShuiPing.Text = "水平镜像(&S)";
            // 
            // ChuiZhi
            // 
            this.ChuiZhi.Name = "ChuiZhi";
            this.ChuiZhi.Size = new System.Drawing.Size(180, 22);
            this.ChuiZhi.Text = "垂直镜像(&C)";
            // 
            // 灰度化处理DToolStripMenuItem
            // 
            this.灰度化处理DToolStripMenuItem.Name = "灰度化处理DToolStripMenuItem";
            this.灰度化处理DToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.灰度化处理DToolStripMenuItem.Text = "灰度化处理(&D)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 575);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "图像处理";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oldImg)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox oldImg;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenImg;
        private System.Windows.Forms.ToolStripMenuItem CloseImg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox newImg;
        private System.Windows.Forms.ToolStripMenuItem ExitWindow;
        private System.Windows.Forms.ToolStripMenuItem 基本处理BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 几何变换JToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 灰度变换HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PingYI;
        private System.Windows.Forms.ToolStripMenuItem 镜像XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShuiPing;
        private System.Windows.Forms.ToolStripMenuItem ChuiZhi;
        private System.Windows.Forms.ToolStripMenuItem 灰度化处理DToolStripMenuItem;
    }
}

