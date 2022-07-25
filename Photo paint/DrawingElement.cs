using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_paint
{
    public class DrawingElement
    {
        public ElementType ElementType { get; }
        public Brush Brush { get; }
        public float Thickness { get; }
        public int X { get; }
        public int Y { get; }
        public int Width { get; }
        public int Height { get; }

        public DrawingElement(ElementType elementType, Brush brush, float thickness, int x, int y, int width, int height)
        {
            ElementType = elementType;
            Brush = brush;
            Thickness = thickness;
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Brush, Thickness);
            switch (ElementType)
            {
                case ElementType.Line:
                    g.DrawLine(pen, X, Y, Width + X, Height + Y);
                    break;
                case ElementType.Rectangle:
                    g.DrawRectangle(pen, X, Y, Width, Height);
                    break;
                case ElementType.FilledRectangle:
                    g.FillRectangle(Brush, X, Y, Width, Height);
                    break;
                case ElementType.Ellipse:
                    g.DrawEllipse(pen, X, Y, Width, Height);
                    break;
                case ElementType.FilledEllipse:
                    g.FillEllipse(Brush, X, Y, Width, Height);
                    break;
            }
        }
    }
}
