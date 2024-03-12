using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    // Класс Гонка
    public class Race
    {
        public void StartRace(string carType, double distance)
        {
            CarFactory factory = new CarFactory();
            Car car = factory.CreateCar(carType);

            Console.WriteLine($"Гонка началась для {car.Name}!");

            while (car.Distance < distance)
            {
                car.Accelerate(distance);
            }

            car.FinishRace();
        }
    }
}
