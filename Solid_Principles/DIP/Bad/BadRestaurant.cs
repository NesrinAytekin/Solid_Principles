using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principles.DIP.Bad
{
    public class BadRestaurant
    {
        BadFish fish = new BadFish();
        BadKebab kebab = new BadKebab();

        public string GenerateInstruction()
        {
            return fish.GetFishCookingInstructions() + " " + kebab.KebabCookingInstruction();

        }
    }
}
