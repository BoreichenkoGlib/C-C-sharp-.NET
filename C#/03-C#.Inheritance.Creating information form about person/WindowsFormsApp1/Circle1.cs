using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ClassDraw
{
    public class Circle1 : Line
    {
        public override void Draw(Graphics graphics)
        {
            Coordinate cord1;
            Size size;
            do
            {
                cord1 = GetRandomCoordinate();
                size = GetRandomSize();
            } while (size.Height + cord1.y > PictireboxSize.Height || size.Width + cord1.x > PictireboxSize.Width);
            graphics.FillRectangle(new SolidBrush(GetRandomColor()), cord1.x, cord1.y, size.Width, size.Height);
            graphics.DrawRectangle(new Pen(Color.Black, 2), cord1.x, cord1.y, size.Width, size.Height);
        }
    }
}
