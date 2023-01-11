using Kursach.Fuel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    internal class ToyotaCamry: Car
    {
        public ToyotaCamry(IPetrol petrol) : base(petrol)
        {
        }

        public override void FeelingsCar()
        {
            if (petrol.TypePetrol == "АИ-95")
            {
                Console.WriteLine("По моим ощущениям данный бензин подходит для меня");
            }
            else
            {
                Console.WriteLine("Ой! Что-то мне не хорошо, так много или мало октановых единиц. Поменяйте мне бензин на АИ-95");
            }
        }

        public override void NameCar()
        {
            Console.WriteLine("Привет, я Toyota Camry");
        }
    }
}
