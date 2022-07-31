using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_paint
{
    /// <summary>
    /// interface defining objects 
    /// drawn with a pen (contour shapes)
    /// </summary>
    public interface IPenDrawing
    {
        public Pen Pen { get; set; }
    }
}
