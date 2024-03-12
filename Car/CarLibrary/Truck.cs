using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLibrary
{
    // Класс - Грузовик
    class Truck : Car
    {
        public Truck()
        {
            Name = "Грузовик";
            Speed = 0;
            Distance = 0;
        }

        public override void Accelerate(double distance)
        {
            DisplayInfo();
            while (Speed < 80 && Distance < distance)
            {
                Speed += 5;                               
                double time = 0.8;
                Distance += Speed * time;
                if (Distance > distance) break;
                DisplayInfo();
            }
            while (Speed > 0 && Distance < distance)
            {
                Speed -= 3;
                double time = 0.5;
                Distance += Speed * time;
                if (Distance > distance) break;
                DisplayInfo();
            }
        }
    }
}
