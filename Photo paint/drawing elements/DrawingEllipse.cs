using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_paint
{
    public class DrawingEllipse : SizeFigures, IPenDrawing
    {
        public Pen Pen { get; set; }

        public DrawingEllipse(int x, int y, Pen pen) : base(x, y)
        {
            Pen = pen;
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(Pen, X1, Y1, Width, Height);
        }
    }
}
