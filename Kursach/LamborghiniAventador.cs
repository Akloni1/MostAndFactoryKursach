using Kursach.Fuel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    internal class LamborghiniAventador: Car
    {
        public LamborghiniAventador(IPetrol petrol) : base(petrol)
        {
        }

        public override void FeelingsCar()
        {
            if (petrol.TypePetrol == "АИ-98")
            {
                Console.WriteLine("По моим ощущениям данный бензин подходит для меня");
            }
            else
            {
                Console.WriteLine("Ой! Что-то мне не хорошо, так много или мало октановых единиц. Поменяйте мне бензин на АИ-98");
            }
        }

        public override void NameCar()
        {
            Console.WriteLine("Привет, я Lamborghini Aventador");
        }
    }
}
