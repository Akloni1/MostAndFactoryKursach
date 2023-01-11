using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.Fuel
{
    internal static class FactoryFuel
    {
        public static IPetrol CreatePetrol(string type)
        {
            if (type.Equals("АИ-92"))
            {
                return new Petrol92();
            }
            else if (type.Equals("АИ-95"))
            {
                return new Petrol95();
            }
            else if (type.Equals("АИ-98"))
            {
                return new Petrol98();
            }
            else return null;
        }
    }
}
