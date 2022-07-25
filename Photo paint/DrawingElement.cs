using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_paint
{
    public class DrawingElement
    {
        public ElementType ElementType { get; set; }
        public Brush Brush { get; set; }
        public float Thickness { get; set; }

        public Point CenterPosition { get; set; }

        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }


        public DrawingElement(ElementType elementType, Brush brush, float thickness, int x, int y)
        {
            ElementType = elementType;
            Brush = brush;
            Thickness = thickness;
            CenterPosition = new Point(x, y);
            X1 = x;
            X2 = x;
            Y1 = y;
            Y2 = y;
        }

        public void SetCoords(int x, int y)
        {
            if(ElementType == ElementType.Line)
            {
                X1 = CenterPosition.X;
                Y1 = CenterPosition.Y;
                X2 = x;
                Y2 = y;
            }
            else
            {
                X1 = Math.Min(x, CenterPosition.X);
                X2 = Math.Max(x, CenterPosition.X);
                Y1 = Math.Min(y, CenterPosition.Y);
                Y2 = Math.Max(y, CenterPosition.Y);
            }
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Brush, Thickness);

            int width = X2 - X1;
            int height = Y2 - Y1;

            switch (ElementType)
            {
                case ElementType.Line:
                    g.DrawLine(pen, X1, Y1, X2, Y2);
                    break;
                case ElementType.Rectangle:
                    g.DrawRectangle(pen, X1, Y1, width, height);
                    break;
                case ElementType.FilledRectangle:
                    g.FillRectangle(Brush, X1, Y1, width, height);
                    break;
                case ElementType.Ellipse:
                    g.DrawEllipse(pen, X1, Y1, width, height);
                    break;
                case ElementType.FilledEllipse:
                    g.FillEllipse(Brush, X1, Y1, width, height);
                    break;
            }
        }
    }
}
