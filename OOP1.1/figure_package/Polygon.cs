using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OOP1._1
{
    internal class Polygon : ClosedFigure
    {
        protected Point[] points;
        public override void Draw(Graphics graphics, Color fillColor, Color lineColor, int pen_width, bool isFilled, bool isLined)
        {
            Pen pen = new Pen(lineColor, pen_width);
            SolidBrush brush = new SolidBrush(fillColor);
            if (isFilled)
            {
                graphics.FillPolygon(brush, points);
            }
            if (isLined)
            {
                graphics.DrawPolygon(pen, points);
            }
        }
        public Polygon(int x, int y, int width, int height) {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
        public Polygon(Point[] points) {
            this.points = points;
        }
    }
}
