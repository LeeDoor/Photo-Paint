using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_paint
{
    public class DoubleCoords : DrawingElement
    {
        public int X2 { get; set; }
        public int Y2 { get; set; }

        public DoubleCoords(int x, int y) : base(x, y)
        {
            X2 = x;
            Y2 = y;
        }

        public override void Draw(Graphics g)
        {
            return;
        }

        public override void SetCoords(int x, int y)
        {
            X2 = x; 
            Y2 = y; 
        }

    }
}
