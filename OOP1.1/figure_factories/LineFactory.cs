using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1._1.figure_factories
{
    internal class LineFactory : FigureFactory
    {
        Figure figure;
        public override Figure CreateFigure(Graphics g, Point[] points)
        {
            figure = new Line(points);
            return figure;
        }

    }
}
