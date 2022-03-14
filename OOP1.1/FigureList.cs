using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1._1
{
    internal class FigureList
    {
        private List<Figure> figures;
        private const int min = 30, maxX = 1200, maxY = 530,
            maxWidth = 100, maxHeight = 70;
        public FigureList() { 
          /*  Random random = new Random();
            figures = new List<Figure>();
            figures.Add(new Circle(random.Next(min, maxX), random.Next(min, maxY),
                random.Next(min, maxWidth)));
            figures.Add(new Ellipse(random.Next(min, maxX), random.Next(min, maxY),
                random.Next(min, maxWidth), random.Next(min, maxHeight)));
            figures.Add(new Square(random.Next(min, maxX), random.Next(min, maxY),
                random.Next(min, maxWidth)));
            figures.Add(new Line(random.Next(min, maxX), random.Next(min, maxY),
                random.Next(min, maxWidth), random.Next(min, maxHeight)));
            figures.Add(new Triangle(random.Next(min, maxX), random.Next(min, maxY),
                random.Next(min, maxWidth), random.Next(min, maxHeight)));
            figures.Add(new Rectangle(random.Next(min, maxX), random.Next(min, maxY),
                random.Next(min, maxWidth), random.Next(min, maxHeight)));*/
        }
        public List<Figure> GetFigures() { 
            return figures;
        }
    }
}
