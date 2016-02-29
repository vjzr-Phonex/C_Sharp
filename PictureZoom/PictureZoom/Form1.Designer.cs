using System.Windows.Forms;
using System.Drawing;
using System.Threading;
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
            pictureBoxBottom.Image = Image.FromFile(@"D:\aaa.png");//背景图片巨绝对地址
            this.Controls.Add(pictureBoxBottom);//添加背景图片
                       
        }

        public void selectPartofThePicture(PictureBox pictureBoxBottom)
        {
            Graphics g = Graphics.FromImage(bitMap);
            g.DrawImage(pictureBoxBottom.Image, new Rectangle(0, 0, 300, 300), new Rectangle(mousePoint.X - 8, mousePoint.Y-57, 75, 75), GraphicsUnit.Pixel);
            
            pictureBoxFront.Location = new Point(mousePoint.X+20,mousePoint.Y-60);
            pictureBoxBottom.Size = new Size(75,75);
            pictureBoxFront.Image = bitMap;
            
            pictureBoxFront.Parent = pictureBoxBottom;
        }

        public void deleteZoomPicture()
        {
            pictureBoxFront.Parent = null;
        }

    }
}

