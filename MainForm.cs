using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV
{
    public partial class MainForm : Form
    {
        //定义：文件名
        private string curFileName;
        //定义：Bitmap对象
        private Bitmap opeBitmap = null;//原始图像（左）
        private Bitmap curBitmap = null;//当前图像（右）
        private Bitmap objBitmap = null;//操作图像
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenImg_Click(object sender, EventArgs e)
        {
            //打开窗口初始化
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = ".";
            open.Filter = "BMP文件(*.bmp)|*.bmp|JPG文件(*.jpg)|*.jpg|BMP文件(*.gif)|*.gif|PNG文件(*.png)|*.png";
            open.RestoreDirectory = true;
            //如果为”打开“选定文件
            if (open.ShowDialog() == DialogResult.OK)
            {
                //读取当前文件名
                curFileName = open.FileName;

                //使用Image.FromFile创建图像对象
                try
                {
                    //创建临时Bitmap对象来获取图像数据
                    Bitmap img = (Bitmap)Image.FromFile(curFileName);
                    //利用临时Bitmap对象构造objBitmap对象
                    objBitmap = new Bitmap(img);
                    curBitmap = new Bitmap(img);
                    opeBitmap = curBitmap;
                    //左侧窗口显示图像
                    this.oldImg.Image = objBitmap;

                    //销毁临时Bitmap对象，解除文件占用
                    img.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void ExitWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PingYI_Click(object sender, EventArgs e)
        {
            try
            {
                //加载窗体transForm
                PingYi transfrm = new PingYi();

                //定义窗体所有者
                transfrm.Owner = this;

                transfrm.ShowDialog();
                if (transfrm.flag)
                {

                    int temp_x = Convert.ToInt32(transfrm.textBoxX.Text);
                    int temp_y = Convert.ToInt32(transfrm.textBoxY.Text);

                    //图像处理操作
                    int width = opeBitmap.Width;
                    int height = opeBitmap.Height;
                    Bitmap bitmap = new Bitmap(width + temp_x, height + temp_y);

                    for (int x = 0; x < width; x++)
                    {
                        for (int y = 0; y < height; y++)
                        {
                            bitmap.SetPixel(x + temp_x, y + temp_y, opeBitmap.GetPixel(x, y));
                        }
                    }
                    curBitmap = new Bitmap(bitmap);
                    bitmap.Dispose();
                    this.newImg.Image = curBitmap;
                }

            }
            catch (Exception ex)
            {
                //错误提示
                MessageBox.Show(ex.Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ShuiPing_Click(object sender, EventArgs e)
        {
            try
            {
                int width = opeBitmap.Width;
                int height = opeBitmap.Height;
                Bitmap bitmap = new Bitmap(width, height);
                for (int x = 0;x < width;x++)
                {
                    for (int y = 0; y < height;y++)
                    {
                        bitmap.SetPixel(x,y,opeBitmap.GetPixel(width - x,y));
                    }
                }
                curBitmap = new Bitmap(bitmap);
                bitmap.Dispose();
                this.newImg.Image = curBitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"错误提示",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }

        private void ChuiZhi_Click(object sender, EventArgs e)
        {
            try
            {
                int width = opeBitmap.Width;
                int height = opeBitmap.Height;
                Bitmap bitmap = new Bitmap(width, height);
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        bitmap.SetPixel(x, y, opeBitmap.GetPixel(x, height - y));
                    }
                }
                curBitmap = new Bitmap(bitmap);
                bitmap.Dispose();
                this.newImg.Image = curBitmap;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
