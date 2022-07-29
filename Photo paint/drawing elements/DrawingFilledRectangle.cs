﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_paint
{
    public class DrawingFilledRectangle : SizeFigures, IBrushDrawing
    {
        public Brush Brush { get; set; }

        public DrawingFilledRectangle(int x, int y, Brush brush) : base(x, y)
        {
            Brush = brush;
        }

        public override void Draw(Graphics g)
        {
            g.FillRectangle(Brush, X1, Y1, Width, Height);
        }
    }
}
