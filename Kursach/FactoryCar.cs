using Kursach.Fuel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    internal static class FactoryCar
    {
        public static Car CreateCar(string type, IPetrol petrol)
        {
            if (type.Equals("Toyota Camry"))
            {
                return new ToyotaCamry(petrol);
            }
            else if (type.Equals("KIA RIO"))
            {
                return new KiaRio(petrol);
            }
            else if (type.Equals("Lamborghini Aventador"))
            {
                return new LamborghiniAventador(petrol);
            }
            else return null;
        }
    }
}
