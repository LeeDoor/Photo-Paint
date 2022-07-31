using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_paint
{
    /// <summary>
    /// a parent class that defines objects 
    /// that consist of multiple points. contains 
    /// an implementation of the setCoords method 
    /// that adds a point to a shared array
    /// </summary>
    public abstract class MultiDots : DrawingObject
    {
        /// <summary>
        /// list of points
        /// </summary>
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
