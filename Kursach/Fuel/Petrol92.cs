using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.Fuel
{
    internal class Petrol92 : IPetrol
    {

        public decimal Price => 46.89M;

        public string TypePetrol => "АИ-92";

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
