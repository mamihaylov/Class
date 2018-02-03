using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Basic Inheritance ****\n");
            // Создаем экземпляр типа Car и устанавливаем max. Скорость
            Car myCar = new Car(80);
            //Установить текущую скорость и вывести е ена консоль.
            myCar.Speed = 50;
            Console.WriteLine("My car is going {0} MPH", myCar.Speed);
            Console.ReadLine();

        }
    }
}
