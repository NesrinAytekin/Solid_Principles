using Solid_Principles.LSP.Good.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.LSP.Good.Concrete
{
    public class Square:Shape
    {
        public int Width { get; set; }

        public double SquareArea()
        {
            return Width * Width;
        }
    }
}
