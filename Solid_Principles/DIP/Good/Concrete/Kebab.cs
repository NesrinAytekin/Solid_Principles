﻿using Solid_Principles.DIP.Good.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.DIP.Good.Concrete
{
    public class Kebab : IProduct
    {
        public string GetCookingInstruction()
        {
            return " Kebab Instruction";

        }
    }
}
