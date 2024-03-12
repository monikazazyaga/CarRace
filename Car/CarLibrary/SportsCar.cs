using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    // Класс - Спортивный автомобиль
    class SportsCar : Car
    {
        public SportsCar()
        {
            Name = "Спортивный автомобиль";
            Speed = 0;
            Distance = 0;
        }

        public override void Accelerate(double distance)
        {
            DisplayInfo();
            while (Speed < 100 && Distance < distance)
            {
                Speed += 10;
                double time = 1.5; 
                Distance += Speed * time;
                if (Distance > distance) break;
                DisplayInfo();
            }
            while (Speed > 0 && Distance < distance)
            {
                Speed -= 5;
                double time = 1;
                Distance += Speed * time;
                if (Distance > distance) break;
                DisplayInfo();
            }
        }
    }
}
