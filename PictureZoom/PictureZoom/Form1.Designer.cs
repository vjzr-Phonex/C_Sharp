using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Drawing.Drawing2D;
namespace PictureZoom
{
    partial class Form1 : Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Point mousePoint;// 鼠标的坐标点
        private PictureBox pictureBoxBottom = new PictureBox();//背景图片
        private PictureBox pictureBoxFront = new PictureBox();//前景放大图片
        private Bitmap bitMap = new Bitmap(300, 300);

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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Form1";
            this.Size = new Size(500,500);//窗口大小
           
            pictureBoxBottom.MinimumSize = new Size(500,500);//背景图片最小规格
            pictureBoxBottom.Location = new Point(0, 0);//背景图片左上角起始点
            pictureBoxBottom.SizeMode = PictureBoxSizeMode.Zoom;//设置背景图片跟随缩放
            pictureBoxBottom.Image = Image.FromFile(@"D:\Phoenix\Desktop\aaa.jpg");//背景图片巨绝对地址
            this.Controls.Add(pictureBoxBottom);//添加背景图片
                       
        }

        public void selectPartofThePicture(PictureBox pictureBoxBottom)
        {
            Graphics g = Graphics.FromImage(bitMap);
            int x = (int)(mousePoint.X * 1.6) - 25;
            int y = (int)(mousePoint.Y * 1.6) - 160;
            g.DrawImage(pictureBoxBottom.Image, new Rectangle(0, 0, 300, 300), new Rectangle(x, y, 200, 200), GraphicsUnit.Pixel);


            
            //pictureBoxFront.Location = new Point(mousePoint.X+20,mousePoint.Y-80);
            pictureBoxFront.Location = getPictureBoxFrontLocation();
            pictureBoxFront.Size = new Size(100, 100);
            pictureBoxFront.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxFront.Image = bitMap;
            pictureBoxFront.Parent = pictureBoxBottom;
        }

        public Point getPictureBoxFrontLocation()
        { 
            Point re = new Point();
            if (500 - mousePoint.X < 130 && mousePoint.Y < 110)
            {
                re.X = mousePoint.X - 120;
                re.Y = mousePoint.Y + 20;
            }
            else if (500 - mousePoint.X < 130 && mousePoint.Y>=110)
            {
                re.X = mousePoint.X - 120;
                re.Y = mousePoint.Y - 80;
            }
            else if (500 - mousePoint.X >= 130 && mousePoint.Y < 110)
            {
                re.X = mousePoint.X + 20;
                re.Y = mousePoint.Y + 20;
            }
            else
            {
                re = new Point(mousePoint.X + 20, mousePoint.Y - 80);
            }

            return re;
        }

        public void deleteZoomPicture()
        {
            pictureBoxFront.Parent = null;
        }

    }
}

