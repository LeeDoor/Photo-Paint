using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_paint
{
    public class DrawingImage : DrawingObject
    {
        public override Color Color { get; set; }
        public override bool KeepDrawing => false;

        public Image Image { get; set; } 

        public DrawingImage(Image image, int x = 0, int y = 0) : base(x, y)
        {
            Image = image;
        }

        public DrawingImage(string pathToImage, int x = 0, int y = 0): 
            this(Image.FromFile(pathToImage), x, y)
        { }

        public override void Draw(Graphics g)
        {
            g.DrawImage(Image, X1, Y1);
        }

        public override void SetCoords(int x, int y)
        {
            X1 = x;
            Y1 = y;
        }
    }
}
