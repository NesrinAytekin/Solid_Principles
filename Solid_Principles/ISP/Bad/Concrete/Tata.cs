using Solid_Principles.ISP.Bad.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.ISP.Bad.Concrete
{
    public class Tata : ICar
    {
        public string ABS()
        {
            return "ABS not available on This Car";
        }

        public string Fast()
        {
            return "Maximum speed 100 km";
        }

        public string Sunroof()
        {
            return "Sunroof not available on this old car";
        }
    }
}
