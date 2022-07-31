using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Photo_paint
{
    /// <summary>
    /// interface defining objects to be 
    /// drawn with a brush (shapes with fill)
    /// </summary>
    public interface IBrushDrawing
    {
        public Brush Brush { get; set; }
    }
}
