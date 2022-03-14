using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1._1.figure_factories
{
    internal class CircleFactory : FigureFactory
    {
        Figure figure;
        public override Figure CreateFigure(Graphics g, Point[] points)
        {
            Point centerPoint = points[0];
            Point radiusPoint = points[1];
            int deltaX = Math.Abs(centerPoint.X - radiusPoint.X);
            int deltaY = Math.Abs(centerPoint.Y - radiusPoint.Y);
            int radius = (int)Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            int x = centerPoint.X - radius;
            int y = centerPoint.Y - radius;
            figure = new Circle(x, y, radius * 2);
            return figure;
        }
    }
}
