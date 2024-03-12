using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    // Абстрактный класс - Автомобиль
    abstract class Car
    {
        public string Name { get; protected set; }
        public double Speed { get; protected set; }
        public double Distance { get; set; }

        /// <summary>
        /// Изменение скорости автомобиля
        /// </summary>
        /// <param name="distance"></param>
        public abstract void Accelerate(double distance);
        /// <summary>
        /// Вывод информации о скорости и дистанциии
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} - Скорость: {Speed} км/ч, Дистанция: {Distance} км");
        }
        /// <summary>
        /// Вывод информации о фишине
        /// </summary>
        public void FinishRace()
        {
            Console.WriteLine($"{Name} финишировал!");
        }
    }
}
