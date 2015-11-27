using System.Windows.Forms;
using System.Drawing;
namespace PictureZoom
{
    partial class Form1 : Form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private PictureBox pb = new PictureBox();
        Bitmap bit = new Bitmap(300, 300);
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
            this.Size = new Size(502,502);
       
           
            pb.MinimumSize = new Size(500,500);
            pb.Location = new Point(0,0);
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Image = Image.FromFile(@"C:\Users\Phoenix\Desktop\aaa.jpg");
            this.Controls.Add(pb);
                       
        }

        public void selectPartofThePicture(PictureBox pb)
        {
            Graphics g = Graphics.FromImage(bit);
            g.DrawImage(pb.Image, new Rectangle(0, 0, pb.Width, pb.Height), new Rectangle(300, 200, 100, 100), GraphicsUnit.Pixel);
            //Image img = Image.FromHbitmap(bit.get);
            Image img = bit;
            //g.DrawImage(pb.Image,new Point(150,150));
            PictureBox pb1 = new PictureBox();
            pb1.Location = new Point(100,100);
            pb1.Image = bit;
            
            pb1.Parent = pb;
            //this.Controls.Add(pb1);
            //pb1.Image = bit;
            //f.Controls.Add(pb1);
            //f.Show();
            bit.Save(@"C:\Users\Phoenix\Desktop\v.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            bit.Dispose();         
        }

    }
}

