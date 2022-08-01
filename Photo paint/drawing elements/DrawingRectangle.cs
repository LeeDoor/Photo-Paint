using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_paint
{
    public class DrawingRectangle : SizeFigures, IPenDrawing
    {
        public Pen Pen { get; set; }

        public override Color Color
        {
            get => Pen.Color;
            set => Pen.Color = value;
        }

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
