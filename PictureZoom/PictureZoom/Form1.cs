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
            this.pictureBoxBottom.MouseDown +=new MouseEventHandler(pb_MouseDown);
            this.pictureBoxBottom.MouseUp += new MouseEventHandler(pb_MouseUp);
            this.KeyDown += new KeyEventHandler(CtrlDown);
            this.pictureBoxBottom.MouseMove +=new MouseEventHandler(pb_MouseMove);
        }

        private void pb_MouseMove(object sender, MouseEventArgs e)
        {
            this.mousePoint = new Point(e.X, e.Y);
            selectPartofThePicture(pictureBoxBottom);
        }

        private void CtrlDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Control)
                selectPartofThePicture(pictureBoxBottom);
        }

        private void pb_MouseDown(object sender, MouseEventArgs e) 
        {
        }

        private void pb_MouseUp(object sender, MouseEventArgs e)
        {
            deleteZoomPicture();
        }

        private void MyMouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right || e.Button == MouseButtons.Left)
            {
                Point p = MousePosition;//获取位置
                //其他需要执行的代码
            }
        }
    }
}
