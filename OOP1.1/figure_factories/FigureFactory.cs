using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1._1.figure_factories
{
    internal abstract class FigureFactory
    {
        public abstract Figure CreateFigure(Graphics g, Point[] points);
    }
}
