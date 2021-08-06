using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassDraw;
using Character = ClassDraw;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Character.Сharacter> СharacterList;
        public Form1()
        {
            InitializeComponent();
        }
        void GenerateСharacter()
        {
            СharacterList = new List<Character.Сharacter>();
            for (int i = 0; i < 20; i++)
                СharacterList.Add(Character.Сharacter.GetRandomСharacter());
        }

        public void buttonDraw_Click(object sender, EventArgs e)
        {
            GenerateСharacter();
            Character.Сharacter.PictireboxSize = new Size(pb.Width - pb.Margin.Horizontal * 2, pb.Height - pb.Margin.Vertical * 2);
            for (int i = 0; i < 20; i++)
                СharacterList[i].Draw(pb.CreateGraphics());
        }
       
        public void buttonClear_Click(object sender, EventArgs e)
        {
            pb.Refresh();
        }


    }
    //    namespace ClassDraw
    //{
    //    public struct Coordinate
    //    {
    //        public int x;
    //        public int y;
    //        public Coordinate(int x, int y)
    //        {
    //            this.x = x;
    //            this.y = y;
    //        }
    //    }
    //    public abstract class Сharacter
    //    {

    //        public abstract void Draw(Graphics graphics);
    //        static Random rnd = new Random();
    //        public static Size pBSize;
    //        public Coordinate GetRandomCoordinate()
    //        {
    //            return new Coordinate(rnd.Next(0, pBSize.Width), rnd.Next(0, pBSize.Height));
    //        }
    //        public Color GetRandomColor()
    //        {
    //            int r = rnd.Next(0, 255);
    //            int g = rnd.Next(0, 255);
    //            int b = rnd.Next(0, 255);
    //            return Color.FromArgb(r, g, b);
    //        }
    //        protected Size GetRandomSize()
    //        {
    //            int width = 0;
    //            int height = 0;
    //            switch (this)
    //            {
    //                case Rectangle rectangle:
    //                    width = rnd.Next(5, pBSize.Width);
    //                    height = rnd.Next(5, pBSize.Height);
    //                    break;
    //                case Ellipse ellispse:
    //                    width = rnd.Next(5, pBSize.Width);
    //                    height = rnd.Next(5, pBSize.Height);
    //                    break;
    //                case Circle circle:
    //                    width = rnd.Next(5, pBSize.Width);
    //                    break;
    //            }
    //            return new Size(width, height);
    //        }
    //        public static Сharacter GetRandomСharacter()
    //        {
    //            switch (rnd.Next(0, 4))
    //            {
    //                case 0: return new Point();
    //                case 1: return new Line();
    //                case 2: return new Circle();
    //                case 3: return new Rectangle();
    //                case 4: return new Ellipse();
    //                default: return null;
    //            }
    //        }
    //    }
    //    public class Point : Сharacter
    //    {
    //        public override void Draw(Graphics graphics)
    //        {
    //            DrawPoint(graphics, GetRandomCoordinate());
    //        }
    //        protected void DrawPoint(Graphics graphics, Coordinate cord)
    //        {
    //            Pen pen = new Pen(Color.Black, 4);
    //            graphics.DrawEllipse(pen, cord.x - 2, cord.y - 2, 4, 4);
    //        }
    //    }
    //    public class Line : Point
    //    {
    //        public override void Draw(Graphics graphics)
    //        {
    //            Coordinate cord1 = GetRandomCoordinate();
    //            Coordinate cord2 = GetRandomCoordinate();
    //            Pen pen = new Pen(GetRandomColor(),3);
    //            DrawPoint(graphics, cord1);
    //            DrawPoint(graphics, cord2);
    //        }
    //    }
    //    public class Rectangle : Line
    //    {
    //        public override void Draw(Graphics graphics)
    //        {
    //            Coordinate cord1;
    //            Size size;
    //            do
    //            {
    //                cord1 = GetRandomCoordinate();
    //                size = GetRandomSize();
    //            } while (size.Height + cord1.y > pBSize.Height || size.Width + cord1.x > pBSize.Width);

    //            graphics.FillRectangle(new SolidBrush(GetRandomColor()), cord1.x, cord1.y, size.Width, size.Height);
    //            graphics.DrawRectangle(new Pen(Color.Black, 2), cord1.x, cord1.y, size.Width, size.Height);
    //        }
    //    }
    //    public class Circle : Point
    //    {
    //        public override void Draw(Graphics graphics)
    //        {
    //            Coordinate cord1;
    //            Size size;
    //            do
    //            {
    //                cord1 = GetRandomCoordinate();
    //                size = GetRandomSize();
    //            } while (size.Height + cord1.y > pBSize.Height || size.Width + cord1.x > pBSize.Width);
    //            graphics.FillEllipse(new SolidBrush(GetRandomColor()), cord1.x, cord1.y, size.Width, size.Height);
    //            graphics.DrawEllipse(new Pen(Color.Black, 2), cord1.x, cord1.y, size.Width, size.Height);
    //        }
    //    }
    //    public class Ellipse : Circle
    //    {
    //        public override void Draw(Graphics graphics)
    //        { base.Draw(graphics); }
    //    }
    //}
}
