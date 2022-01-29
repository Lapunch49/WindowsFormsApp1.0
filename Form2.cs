using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1._0
{
    public partial class Paint : Form
    {
        public Paint()
        {
            InitializeComponent();
            SetSize();
        }
        private bool isMouse = false;
        private class ArrPoints
        {
            private int index = 0;
            private Point[] points;

            public ArrPoints(int size)
            {
                if (size <= 0) size = 2;
                points = new Point[size];
            }
            public void SetPoint(int x, int y)
            {
                if (index >= points.Length)
                {
                    index = 0;
                }
                points[index++] = new Point(x, y);
            }
            public void ResetPoints()
            {
                index = 0;
            }
            public int GetCountPoints()
            {
                return index;
            }
            public Point[] GetPoints()
            {
                return points;
            }
        }
        private ArrPoints arrPoints = new ArrPoints(2);
        Bitmap bmp;
        Graphics g;
        Pen pen = new Pen(Color.Black, 3f);
        private void SetSize()
        {
            Rectangle rec = Screen.PrimaryScreen.Bounds;
            bmp = new Bitmap(rec.Width, rec.Height);
            g = Graphics.FromImage(bmp);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            g.Clear(pictureBox1.BackColor);
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse = false;
            arrPoints.ResetPoints();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouse) { return;}
            arrPoints.SetPoint(e.X, e.Y);
            if (arrPoints.GetCountPoints() >= 2)
            {
                g.DrawLines(pen, arrPoints.GetPoints());
                pictureBox1.Image = bmp;
                arrPoints.SetPoint(e.X, e.Y);
            }
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }

        private void btn_other_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                ((Button)sender).BackColor = pen.Color;
            }
        }

        private void trackBar_pencil_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = trackBar_pencil.Value;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG(*.JPG)|*.jpg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Save(saveFileDialog1.FileName);
                }
            }
        }
    }
}
