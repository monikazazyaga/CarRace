using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    class CarFactory
    {
        public Car CreateCar(string type)
        {
            switch (type)
            {
                case "Спортивный":
                    return new SportsCar();
                case "Грузовик":
                    return new Truck();
                default:
                    throw new ArgumentException("Неверный тип автомобиля");
            }
        }
    }
}
