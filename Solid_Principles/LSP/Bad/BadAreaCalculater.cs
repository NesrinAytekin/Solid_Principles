using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.LSP.Bad
{
   public class BadAreaCalculater
    {
        public static double CalCulateArea(BadRectangle rectangle)
        {
            return rectangle.Height * rectangle.Width;
        }
        public static double CalculateArea(BadSquare square)
        {
            return square.Width * square.Height;
        }

    }
}
