using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1._1
{
    internal class PointsArray
    {
        private int i = 0;
        private Point[] points;
        public PointsArray(int size) {
            if (size <= 0) {
                size = 2;
            }
            points = new Point[size];
        }
        public void SetPoint(int x, int y) {
            if (i >= points.Length) {
                i = 0;
            }
            points[i] = new Point(x, y);
            i++;
        }
        public void ResetArray() {
            i = 0;
        }
        public int GetPointCount()
        {
            return i;
        }
        public Point[] GetPoints()
        {
            return points;
        }
    }
}
