using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach.Fuel
{
    internal interface IPetrol
    {
        decimal Price { get; }
        string TypePetrol { get; }
        void PrintCostPerLiter();
        void PrintNamePetrol();
    }
}
