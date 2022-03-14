using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1._1
{
    internal class Rectangle : Polygon
    {
        public Rectangle(int x, int y, int width, int height) : base(x, y, width, height) {
            points = new Point[] { new Point(x, y), new Point(x + width, y), new Point(x + width, y + height), new Point(x, y + height) };
        }
    }
}
