﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1._1
{
    internal class Figure
    {
        protected int x, y, width, height;
        public virtual void Draw(Graphics graphics, Color fillColor, Color lineColor, int pen_width, bool isFilled, bool isLined) { }
    }
}
    