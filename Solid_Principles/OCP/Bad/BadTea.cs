using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.OCP.Bad
{
    public enum TeaType
    {
        EnglishBreakfast,
        GreenTea,
        WhiteTea
    }
   public  class BadTea
    {
        public double GetTotalPrice(double amount , TeaType teaType)
        {
            double TotalPrice = 0;

            if (teaType==TeaType.EnglishBreakfast)
            {
                TotalPrice+= amount*10;
            }
            else if (teaType==TeaType.GreenTea)
            {
                TotalPrice += amount * 5;
            }
            else if (teaType==TeaType.WhiteTea)
            {
                TotalPrice += amount * 8;
            }
            return TotalPrice;
        }

    }
}
