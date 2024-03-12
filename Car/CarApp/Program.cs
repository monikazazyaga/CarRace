using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CarLibrary;


namespace CarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Race race = new Race();

            Console.Write("Введите тип 1 автомобиля (Спортивный/Грузовик): ");
            string carType1 = Console.ReadLine();
            Console.Write("Введите тип 2 автомобиля (Спортивный/Грузовик): ");
            string carType2 = Console.ReadLine();

            Console.Write("Введите дистанцию гонки (км) : ");
            int distance = Convert.ToInt32(Console.ReadLine());


            Thread sportsCarThread = new Thread(() => race.StartRace(carType1, distance));
            Thread truckThread = new Thread(() => race.StartRace(carType2, distance));

            sportsCarThread.Start();
            truckThread.Start();

            sportsCarThread.Join();
            truckThread.Join();

            Console.WriteLine("Гонка окончена для всех автомобилей.");

            Console.ReadLine();
        }
    }
}
