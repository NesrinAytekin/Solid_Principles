using Solid_Principles.OCP.Good.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.OCP.Good.Concrete
{
    public class GreenTea:GoodTea
    {
        public override double GetTotalPrice(double amount)
        {
            return amount * 5;
        }
    }
}
