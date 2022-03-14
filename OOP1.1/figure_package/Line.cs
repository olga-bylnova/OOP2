using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1._1
{
    internal class Line : OpenFigure
    {
        private Point firstPoint;
        private Point lastPoint;
        const int firstIndex = 0;
        const int lastIndex = 1;
        public override void Draw(Graphics graphics, Color fillColor, Color lineColor, int pen_width, bool isFilled, bool isLined)
        {
            Pen pen = new Pen(lineColor, pen_width);
            graphics.DrawLine(pen, firstPoint, lastPoint);
        }

        public Line(Point[] points) {
            firstPoint = points[firstIndex];
            lastPoint = points[lastIndex];
        }
    }
}
