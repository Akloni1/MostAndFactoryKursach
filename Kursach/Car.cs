using Kursach.Fuel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach
{
    internal abstract class Car
    {
        protected IPetrol petrol;
        public IPetrol Petrol
        {
            set { petrol = value; }
        }
        public Car(IPetrol petrol)
        {
            this.petrol = petrol;
        }
        public virtual void GetDataPetrol()
        {
            petrol.PrintNamePetrol();
            petrol.PrintCostPerLiter();
        }
        public abstract void FeelingsCar();
        public abstract void NameCar();

    }
}
