using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.LSP.Bad
{
    public class BadRectangle //Base class
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
    }
}
