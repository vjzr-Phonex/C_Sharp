using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PictureZoom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.pb.MouseClick += new MouseEventHandler(MyMouseClick);
            this.MouseWheel += new MouseEventHandler(MyMouseWheel);
            //this.pb.Paint +=new PaintEventHandler(pb_Paint);
        }

        private void pb_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Image image = bit;
            g.DrawImage(image, new Point(20, 10));
        }

        private void MyMouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                MessageBox.Show("滚轮向前滚动");
            }
            else
            {
                MessageBox.Show("滚轮向后滚动");
            }
        }

        private void MyMouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            selectPartofThePicture(pb);
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                Point p = MousePosition;//获取位置
                //其他需要执行的代码

            }

        }

    }
}
