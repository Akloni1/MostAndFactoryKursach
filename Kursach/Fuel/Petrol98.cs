using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.Fuel
{
    internal class Petrol98: IPetrol
    {
        public decimal Price => 61.98M;
        public string TypePetrol => "АИ-98";

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
