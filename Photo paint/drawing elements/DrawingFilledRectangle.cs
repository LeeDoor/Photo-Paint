using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_paint
{
    public class DrawingFilledRectangle : SizeFigures, IBrushDrawing
    {
        public SolidBrush Brush { get; set; }

        public override Color Color
        {
            get => Brush.Color;
            set => Brush.Color = value;
        }

        public DrawingFilledRectangle(int x, int y, SolidBrush brush) : base(x, y)
        {
            Brush = brush;
        }

        public override void Draw(Graphics g)
        {
            g.FillRectangle(Brush, X1, Y1, Width, Height);
        }
    }
}
