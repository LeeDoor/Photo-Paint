using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_paint
{
    /// <summary>
    /// parent class that defines objects whose 
    /// coordinates can only be determined by 
    /// the coordinates of the upper-left and 
    /// lower-right points. multiplies its own 
    /// implementation of the setCoords method
    /// </summary>
    public abstract class DoubleCoords : DrawingObject
    {
        public override bool KeepDrawing => false; 

        /// <summary>
        /// lower-right point coord X
        /// </summary>
        /// 
        public int X2 { get; set; }
        /// <summary>
        /// lower-right point coord Y
        /// </summary>
        public int Y2 { get; set; }

        public DoubleCoords(int x, int y) : base(x, y)
        {
            X2 = x;
            Y2 = y;
        }

        public override void SetCoords(int x, int y)
        {
            X2 = x; 
            Y2 = y; 
        }

    }
}
