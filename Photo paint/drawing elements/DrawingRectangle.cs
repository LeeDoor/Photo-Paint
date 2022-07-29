using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Photo_paint.drawing_elements;

namespace Photo_paint
{
    public class DrawingRectangle : SizeFigures, IPenDrawing
    {
        public Pen Pen { get; set; }

        public DrawingRectangle(int x, int y, Pen pen) : base(x, y)
        {
            Pen = pen;
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pen, X1, Y1, Width, Height);
        }
    }
}
