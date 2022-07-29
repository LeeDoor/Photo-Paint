using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_paint
{
    public class SizeFigures : DrawingElement
    {

        public Point CenterPosition { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public SizeFigures(int x, int y) : base(x, y)
        {
            CenterPosition = new Point(x, y);
            Width = 0;
            Height = 0;
        }

        public override void SetCoords(int x, int y)
        {
            X1 = Math.Min(x, CenterPosition.X);
            Y1 = Math.Min(y, CenterPosition.Y);
            int X2 = Math.Max(x, CenterPosition.X);
            int Y2 = Math.Max(y, CenterPosition.Y);

            Width = X2 - X1;
            Height = Y2 - Y1;
        }

        public override void Draw(Graphics g)
        {
            return;
        }
    }
}
