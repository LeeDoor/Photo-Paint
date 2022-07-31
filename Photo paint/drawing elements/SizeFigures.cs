using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_paint
{
    /// <summary>
    /// родительский класс, определяющий объекты, 
    /// координаты которых могут быть определены 
    /// только координатами левой верхней точки, 
    /// ширины и высоты. содержит реализацию метода SetCoords
    /// </summary>
    public abstract class SizeFigures : DrawingObject
    {
        public override bool KeepDrawing  => false; 

        /// <summary>
        /// Center position of figure, where started drawing
        /// </summary>
        public Point CenterPosition { get; set; }

        /// <summary>
        /// Width of this figure
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Height of this figure
        /// </summary>
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
    }
}
