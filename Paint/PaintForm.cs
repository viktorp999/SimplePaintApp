using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;

namespace Paint
{
    public partial class PaintForm : Form
    {
        Bitmap bm;
        Graphics gp;
        Point px, py;
        Pen pen;
        Pen er;
        Color newColor;
        ColorDialog cd;
        SaveFileDialog sv;
        bool paint;
        int index;
        int x, y, sx, sy, cx, cy;

        public PaintForm()
        {
            InitializeComponent();
            pen = new Pen(Color.Black, 1);
            er = new Pen(Color.White, 10);
            paint = false;
            bm = new Bitmap(PaintBox.Width, PaintBox.Height);
            gp = Graphics.FromImage(bm);
            gp.Clear(Color.White);
            PaintBox.Image = bm;
            cd = new ColorDialog();
            sv = new SaveFileDialog
            {
                Filter = "Image(*.jpg)|*.jpg|(*.*)|*.*"
            };
        }

        private void FillB_MouseClick(object sender, MouseEventArgs e)
        {
            index = 6;
        }

        private void RectangleB_MouseClick(object sender, MouseEventArgs e)
        {
            index = 5;
        }

        private void EllipseB_MouseClick(object sender, MouseEventArgs e)
        {
            index = 4;
        }

        private void LineB_MouseClick(object sender, MouseEventArgs e)
        {
            index = 3;
        }

        private void EraserB_MouseClick(object sender, MouseEventArgs e)
        {
            index = 2;
        }

        private void PencilB_MouseClick(object sender, MouseEventArgs e)
        {
            index = 1;
        }

        private void ColorB_MouseClick(object sender, MouseEventArgs e)
        {
            cd.ShowDialog();
            newColor = cd.Color;
            PaintBox.BackColor = cd.Color;
            pen.Color = cd.Color;
        }

        private void PaintBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 6)
            {
                Point point = SetPoint(PaintBox, e.Location);
                Fill(bm, point.X, point.Y, newColor);
            }
        }

        private void PaintBox_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            cx = e.X;
            cy = e.Y;
        }

        private void PaintBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    gp.DrawLine(pen, px, py);
                    py = px;
                }

                if (index == 2)
                {
                    px = e.Location;
                    gp.DrawLine(er, px, py);
                    py = px;
                }

                PaintBox.Refresh();
                x = e.X;
                y = e.Y;
                sx = e.X - cx;
                sy = e.Y - cy;
            }
        }

        private void PaintBox_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sx = x - cx;
            sy = y - cy;

            if (index == 3)
            {
                gp.DrawLine(pen, cx, cy, x, y);
            }

            if (index == 4)
            {
                gp.DrawEllipse(pen, cx, cy, sx, sy);
            }

            if (index == 5)
            {
                gp.DrawRectangle(pen, cx, cy, sx, sy);
            }
        }

        private void PaintBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (index == 3)
            {
                g.DrawLine(pen, cx, cy, x, y);
            }

            if (index == 4)
            {
                g.DrawEllipse(pen, cx, cy, sx, sy);
            }

            if (index == 5)
            {
                g.DrawRectangle(pen, cx, cy, sx, sy);
            }
        }

        private void ClearB_Click(object sender, System.EventArgs e)
        {
            gp.Clear(Color.White);
            PaintBox.Image = bm;
            index = 0;
        }

        private void SaveB_Click(object sender, System.EventArgs e)
        {
            if (sv.ShowDialog() == DialogResult.OK)
            {
                Bitmap b = bm.Clone(new Rectangle(0, 0, PaintBox.Width, PaintBox.Height), bm.PixelFormat);
                b.Save(sv.FileName, ImageFormat.Jpeg);
            }
        }

        private static Point SetPoint(PictureBox pb, Point p)
        {
            float px = 1f * pb.Width / pb.Width;
            float py = 1f * pb.Height / pb.Height;

            return new Point((int)(p.X * px),(int)(p.Y * py));
        }

        private void VAlidate(Bitmap bm, Stack<Point> sp, int x, int y, Color oldColor, Color newColor)
        {
            Color c = bm.GetPixel(x, y);

            if (c == oldColor)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, newColor);
            }
        }

        public void Fill(Bitmap bm, int x, int y, Color newClr)
        {
            Color oldClr = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, newClr);

            if (oldClr == newClr)
            {
                return;
            }

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();

                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    VAlidate(bm, pixel, pt.X - 1, pt.Y, oldClr, newClr);
                    VAlidate(bm, pixel, pt.X, pt.Y - 1, oldClr, newClr);
                    VAlidate(bm, pixel, pt.X + 1, pt.Y, oldClr, newClr);
                    VAlidate(bm, pixel, pt.X, pt.Y + 1, oldClr, newClr);
                }
            }
        }
    }
}
