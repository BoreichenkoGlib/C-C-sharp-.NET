using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ClassDraw
{
    public class Circle : Point
    {
        public override void Draw(Graphics graphics)
        {
            Coordinate coord1;
            Coordinate coord2;
            do
            {
                coord1 = GetRandomCoordinate();
                coord2 = GetRandomCoordinate();
            } while (coord1.x > PictireboxSize.Height && coord1.x > PictireboxSize.Width && coord2.x > PictireboxSize.Height && coord2.x > PictireboxSize.Width);
            graphics.FillEllipse(new SolidBrush(GetRandomColor()), coord1.x, coord1.y, coord2.x, coord2.y);
            graphics.DrawEllipse(new Pen(Color.Black, 2), coord1.x, coord1.y, coord2.x, coord2.y);
        }
    }

}