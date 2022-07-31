using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_paint
{
    /// <summary>
    /// abstract class for every drawable element
    /// </summary>
    public abstract class DrawingObject
    {
        /// <summary>
        /// true if we should keep drawing element after mouse button release
        /// </summary>
        public abstract bool KeepDrawing { get; }

        /// <summary>
        /// start X coord
        /// </summary>
        public int X1 { get; set; }

        /// <summary>
        /// start Y coord
        /// </summary>
        public int Y1 { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="x">start x position</param>
        /// <param name="y">start y position</param>
        public DrawingObject(int x, int y)
        {
            X1 = x;
            Y1 = y;
        }

        /// <summary>
        /// abstract func to draw this element
        /// </summary>
        public abstract void Draw(Graphics g);

        /// <summary>
        /// updates coords for this element
        /// </summary>
        /// <param name="x">x coord</param>
        /// <param name="y">y coord</param>
        public abstract void SetCoords(int x, int y);
    }
}
