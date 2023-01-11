using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.Fuel
{
    internal class Petrol95: IPetrol
    {
        public decimal Price => 51.60M;

        public string TypePetrol => "АИ-95";

        public void PrintCostPerLiter()
        {
            Console.WriteLine($"Данный бензин стоит {Price} руб/литр");
        }

        public void PrintNamePetrol()
        {
            Console.WriteLine($"Бензин {TypePetrol}");
        }
    }
}
