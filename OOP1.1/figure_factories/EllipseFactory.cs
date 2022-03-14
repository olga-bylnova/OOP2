using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1._1.figure_factories
{
    internal class EllipseFactory : FigureFactory
    {
        Figure figure;
        private const int startPointIndex = 0;
        private const int endPointIndex = 1;
        public override Figure CreateFigure(Graphics g, Point[] points)
        {            
            Point startPoint = points[startPointIndex];
            Point endPoint = points[endPointIndex];
            int width = Math.Abs(startPoint.X - endPoint.X);
            int height = Math.Abs(startPoint.Y - endPoint.Y);
            int x = Math.Min(startPoint.X, endPoint.X);
            int y = Math.Min(startPoint.Y, endPoint.Y);
            figure = new Ellipse(x, y, width, height);
            return figure;
        }
    }
}
