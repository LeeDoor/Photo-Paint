using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_paint
{
    public class DrawingText : DrawingObject, IBrushDrawing
    {
        public override Color Color
        {
            get => Brush.Color;
            set => Brush.Color = value;
        }
        public string Text { get; set; }
        public SolidBrush Brush { get; set; }
        public Font Font { get; set; }
        public override bool KeepDrawing => false;


        public DrawingText(string text, Font font, int x, int y, SolidBrush brush) : base(x, y)
        {
            Text = text;
            Font = font;
            Brush = brush;
        }

        public override void Draw(Graphics g)
        {
            g.DrawString(Text, Font, Brush, new Point(X1, Y1));
        }
    }
}
