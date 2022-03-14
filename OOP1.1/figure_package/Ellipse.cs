using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1._1
{
    internal class Ellipse : ClosedFigure
    {
        public override void Draw(Graphics graphics, Color fillColor, Color lineColor, int pen_width, bool isFilled, bool isLined) {
            Pen pen = new Pen(lineColor, pen_width);
            SolidBrush brush = new SolidBrush(fillColor);
            if (isFilled)
            {
                graphics.FillEllipse(brush, x, y, width, height);
            }
            if (isLined) {
                graphics.DrawEllipse(pen, x, y, width, height);
            }            
        }
        public Ellipse(int x, int y, int width, int height) {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
    }
}
