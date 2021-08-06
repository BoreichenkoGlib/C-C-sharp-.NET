using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ClassDraw
{
    public class Point : Сharacter
    {
        public override void Draw(Graphics graphics)
        {
            DrawPoint(graphics, GetRandomCoordinate());
        }
        protected void DrawPoint(Graphics graphics, Coordinate cord)
        {
            Pen pen = new Pen(Color.Black, 4);
            graphics.DrawEllipse(pen, cord.x - 2, cord.y - 2, 4, 4);
        }
    }
}