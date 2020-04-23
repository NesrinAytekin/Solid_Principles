using Solid_Principles.ISP.Good.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.ISP.Good.Concrete
{
    public class Tata : IAllCar
    {
        public string Fast()
        {
            return "Maximum speed 100 km";
        }
    }
}
