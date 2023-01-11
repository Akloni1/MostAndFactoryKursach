// See https://aka.ms/new-console-template for more information
using Kursach;
using Kursach.Fuel;

var petrol = FactoryFuel.CreatePetrol("АИ-98");
var car = FactoryCar.CreateCar("Lamborghini Aventador", petrol);
car.GetDataPetrol();
car.NameCar();
car.FeelingsCar();
Console.WriteLine("--------------------------");
var petrol1 = FactoryFuel.CreatePetrol("АИ-95");
var car1 = FactoryCar.CreateCar("KIA RIO", petrol1);
car1.GetDataPetrol();
car1.NameCar();
car1.FeelingsCar();


