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
        public string driverName; // Имя водителя.
        public void PopAWheely()
        {
            for(int i=0; i<= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeee Haaaaaeeww!");

            }
        }
        // связывание конструкторов в цепочку
        public Motocrycle() { }
        public Motocrycle(int intensity)
            : this(intensity ,"") { }
       public Motocrycle (string name)
            : this(0,name) { }
        // Главный конструктор
        public Motocrycle (int intensity,string name)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }
       

    }
}
