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
        private bool isMousePress = false;
        private class Line
        {
            private Point p1;
            private Point p2;
            private bool both;
            public Line(int size)
            {
                p1 = default;
                p2 = default;
                both = false;
            }
            public void SetPoint(int x, int y)
            {
                if (both == false)
                {
                    if (p1 == default)
                        p1 = new Point(x, y);
                    else
                    {
                        p2 = new Point(x, y);
                        both = true;
                    }
                }
                else { 
                    p1 = new Point(x, y); 
                    both = false; 
                }
            }
            public void ResetPoints()
            {
                both = false;
                p1 = default;
                p2 = default;
            }
            public bool GetBoth()
            {
                return both;
            }
            public Point[] GetPoints()
            {
                return new Point[] { p1,p2};
            }
            public Point GetPoint(int ind)
            {
                if (ind == 1)
                    return p1;
                else return p2;
            }
        }

        private Line line = new Line(2);
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
            isMousePress = true;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMousePress = false;
            line.ResetPoints();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMousePress) { return;}
            line.SetPoint(e.X, e.Y);
            if (line.GetBoth() == true)
            {
                g.DrawLines(pen, line.GetPoints());
                pictureBox1.Image = bmp;
                line.SetPoint(e.X, e.Y);
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
