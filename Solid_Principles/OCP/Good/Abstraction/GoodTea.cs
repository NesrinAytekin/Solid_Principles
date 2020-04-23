using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.OCP.Good.Abstraction
{
    public abstract class GoodTea
    {
        public abstract double GetTotalPrice(double amount);
    }
}
