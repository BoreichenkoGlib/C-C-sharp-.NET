using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicPlotter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            one();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            one();
        }
        void one()
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            Pen a = new Pen(Color.Blue, 1);
            Pen b = new Pen(Color.Green, 2);
            Font drawFoint = new Font("Arial", 12);
            Font signatureFont = new Font("Arial", 7);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            int sizeWidth = Form1.ActiveForm.Width;
            int sizeHeight = Form1.ActiveForm.Height;
            Point center = new Point(((int)(sizeWidth / 2) - 8), (int)((sizeHeight / 2) - 19));

            g.DrawLine(a, 10, center.Y, center.X, center.Y); //x-
            g.DrawLine(a, center.X, center.Y, 2 * center.X - 10, center.Y);//x+
            g.DrawLine(a, center.X, 10, center.X, center.Y);//y+
            g.DrawLine(a, center.X, center.Y, center.X, 2 * center.Y - 10);//y-
            g.DrawString("X", drawFoint, drawBrush, new PointF(2 * center.X - 5, center.Y + 10), drawFormat);
            g.DrawString("Y", drawFoint, drawBrush, new PointF(center.X + 30, 5), drawFormat);
            g.DrawString("0", drawFoint, drawBrush, new PointF(center.X - 5, center.Y + 10), drawFormat);
            //0
            g.DrawLine(a, center.X, 10, center.X + 5, 20);//y+
            g.DrawLine(a, center.X, 10, center.X - 5, 20);//y-
            g.DrawLine(a, 2 * center.X - 10, center.Y, 2 * center.X - 20, center.Y - 5);
            g.DrawLine(a, 2 * center.X - 10, center.Y, 2 * center.X - 20, center.Y + 5);



            int stepForAxes = 25;
            int lenghtShtrih = 3;
            int maxValueForAxesX = 16;
            int maxValueForAxesY = 16;

            float oneDelenieX = (float)maxValueForAxesX / ((float)center.X / (float)stepForAxes);
            float oneDelenieY = (float)maxValueForAxesY / ((float)center.Y / (float)stepForAxes);
            for (int i = center.X, j = center.X, k = 1; i < 2 * center.X - 30; j -= stepForAxes, i += stepForAxes, k++)
            {
                g.DrawLine(a, i, center.Y - lenghtShtrih, i, center.Y + lenghtShtrih);
                g.DrawLine(a, j, center.Y - lenghtShtrih, j, center.Y + lenghtShtrih);
                if (i < 2 * center.X - 55)
                {
                    g.DrawString((k * oneDelenieX).ToString("0.0"), signatureFont, drawBrush, new Point(i + stepForAxes + 9, center.Y + 6), drawFormat);
                    g.DrawString(((k * oneDelenieX).ToString("0.0").ToString() + "-"), signatureFont, drawBrush, new PointF(j - stepForAxes + 9, center.Y + 6), drawFormat);
                }
            }
            for (int i = center.Y, j = center.Y, k = 1; i < 2 * center.Y - 30; j -= stepForAxes, i += stepForAxes, k++)
            {
                if (i < 2 * center.Y - 55)
                    g.DrawLine(a, center.X - lenghtShtrih, i, center.X + lenghtShtrih, i);
                g.DrawLine(a, center.X - lenghtShtrih, j, center.X + lenghtShtrih, j);
                if (i < 2 * center.Y - 55)
                {
                    g.DrawString((k * oneDelenieY).ToString("F1"), signatureFont, drawBrush, new PointF(center.X + 25, j - stepForAxes - 2), drawFormat);
                    if (i < 2 * center.Y - 55)
                        g.DrawString(((k * oneDelenieY).ToString("F1").ToString() + "-"), signatureFont, drawBrush, new PointF(center.X + 25, i + stepForAxes - 2), drawFormat);
                }
            }
            //тут мають бути штрихи у
            int numOfPoint = 100;
            float[] first = new float[numOfPoint];
            float[] second = new float[numOfPoint];
            for (int i = 0; i < numOfPoint; i++)
            {
                first[i] = (float)maxValueForAxesX / (float)numOfPoint * (i + 1) - (float)(maxValueForAxesX / 2);
            }

            for (int i = 0; i < numOfPoint; i++)
            {

                //second[i] = (float)Math.Pow(first[i], 3);
                second[i] = Convert.ToSingle((first[i] / 5) + first[i] * Math.Cos(first[i]) * Math.Sin(first[i]));
                chart1.Series[0].Points.AddXY(first[i], second[i]);
            }

            Point[] pointOne = new Point[numOfPoint];
            float tempX = 1 / oneDelenieX * stepForAxes;
            float tempY = 1 / oneDelenieY * stepForAxes;
            for (int i = 0; i < numOfPoint; i++)
            {
                pointOne[i].X = center.X + (int)(first[i] * tempX);
                pointOne[i].Y = center.Y - (int)(second[i] * tempY);
            }
            g.DrawLines(b, pointOne);
            g.DrawCurve(b, pointOne);
        }
    }
}
