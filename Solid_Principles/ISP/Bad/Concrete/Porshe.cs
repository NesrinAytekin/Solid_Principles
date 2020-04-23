using Solid_Principles.ISP.Bad.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.ISP.Bad.Concrete
{
    public class Porshe : ICar
    {
        public string ABS()
        {
            return "ABS System Available";
        }

        public string Fast()
        {
            return "Maximum speed 280 km";
        }

        public string Sunroof()
        {
            return "Sunroof System Available";
        }
    }
}
