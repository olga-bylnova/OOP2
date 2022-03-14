using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1._1.figure_factories
{
    internal class PolygonFactory : FigureFactory
    {
        Figure figure;
        public override Figure CreateFigure(Graphics g, Point[] points)
        {
            Point[] polygonPoints = new Point[points.Length];
            Array.Copy(points, polygonPoints, points.Length);
            figure = new Polygon(polygonPoints);
            return figure;
        }
    }
}
