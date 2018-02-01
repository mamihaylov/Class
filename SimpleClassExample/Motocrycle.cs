using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motocrycle
    {
        public int driverIntensity;
        public string name; // Имя водителя.
        public void PopAWheely()
        {
            for(int i=0; i<= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeee Haaaaaeeww!");

            }
        }
        // Вернуть стандартный конструктор, который будет устанавливать
        // Для всех членов данных стандартных значенией.
        public Motocrycle(int intensity)
        {
            driverIntensity = intensity;
        }
        public void SetDriverName(string name)
        { this.name = name; }
    }
}
