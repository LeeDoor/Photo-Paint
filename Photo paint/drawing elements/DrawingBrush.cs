using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_paint
{
    public class DrawingBrush : MultiDots, IPenDrawing
    {
        public Pen Pen { get; set; }

        public DrawingBrush(int x, int y, Pen pen) : base(x, y)
        {
            Pen = pen;
        }

        public override void Draw(Graphics g)
        {
            if (Points.Count == 0) return;

            for (int i = 0; i < Points.Count - 1; i++)
            {
                ///we need this ellipses for normal brush visualisation
                ///we draw circles at the beginning and at the end of the line
                ///and connect theese circles with line
                g.FillEllipse(Pen.Brush, new Rectangle
                {
                    X = Points[i].X - (int)Pen.Width / 2,
                    Y = Points[i].Y - (int)Pen.Width / 2,
                    Width  = (int)Pen.Width,
                    Height = (int)Pen.Width
                }) ;
                g.DrawLine(Pen, Points[i], Points[i+1]);
            }
        }
    }
}
