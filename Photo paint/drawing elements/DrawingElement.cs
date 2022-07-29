using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_paint
{
    public abstract class DrawingElement
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }


        public DrawingElement(int x, int y)
        {
            X1 = x;
            Y1 = y;
        }

        public abstract void Draw(Graphics g);
        public abstract void SetCoords(int x, int y);
    }
}
