using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1._1
{
    internal class Square : Rectangle
    {
        public Square(int x, int y, int width) : base(x, y, width, width){
            points = new Point[] { new Point(x, y), new Point(x + width, y), new Point(x + width, y + width), new Point(x, y + width) };
        }
    }
}
