using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ClassDraw
{
    public class Line : Point
    {
        public override void Draw(Graphics graphics)
        {
            Coordinate cord1 = GetRandomCoordinate();
            Coordinate cord2 = GetRandomCoordinate();
            Pen pen = new Pen(GetRandomColor(), 3);
            graphics.DrawLine(pen, cord1.x, cord1.y, cord2.x, cord2.y);
        }
    }
}
