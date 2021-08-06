using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ClassDraw
{
    public struct Coordinate
    {
        public int x;
        public int y;
        public Coordinate(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public abstract class Сharacter
    {

        public abstract void Draw(Graphics graphics);
        static Random rnd = new Random();
        public static Size PictireboxSize;
        public Coordinate GetRandomCoordinate()
        {
            return new Coordinate(rnd.Next(0, PictireboxSize.Width), rnd.Next(0, PictireboxSize.Height));
        }
        public Color GetRandomColor()
        {
            int r = rnd.Next(0, 255);
            int g = rnd.Next(0, 255);
            int b = rnd.Next(0, 255);
            return Color.FromArgb(r, g, b);
        }
        protected Size GetRandomSize()
        {
            int width = 0;
            int height = 0;
            switch (this)
            {
                case Rectangle rectangle:
                    width = rnd.Next(5, PictireboxSize.Width);
                    height = rnd.Next(5, PictireboxSize.Height);
                    break;
                case Ellipse ellispse:
                    width = rnd.Next(5, PictireboxSize.Width);
                    height = rnd.Next(5, PictireboxSize.Height);
                    break;
                case Circle circle:
                    width = rnd.Next(5, PictireboxSize.Width);
                    break;
            }
            return new Size(width, height);
        }
        public static Сharacter GetRandomСharacter()
        {
            switch (rnd.Next(0, 4))
            {
                case 0: return new Point();
                case 1: return new Line();
                case 2: return new Circle();
                case 3: return new Rectangle();
                case 4: return new Ellipse();
                default: return null;
            }
        }
    }
}
