using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_paint
{
    public abstract class MultiDots : DrawingElement
    {
        public List<Point> Points { get; set; }
        public override bool KeepDrawing => true;

        public MultiDots(int x, int y) : base(x, y)
        {
            Points = new List<Point>();
        }

        public override void SetCoords(int x, int y)
        {
            Points.Add(new Point(x, y));
        }
    }
}
