using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Fun with Class types****\n");
            // разместить в памяти и сконфигурировать обьект Car.
            Car myCar = new SimpleClassExample.Car();
            myCar = new Car();
            myCar.petName = "henry";
            myCar.currSpeed = 10;
            // Увеличить скорость автомобиля в несколько раз и вывести новое состояние.
            for (int i=0; i<= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }
            Console.ReadLine();
            Car chuck = new Car();
            //Выводит "Chuck is going 10 mph"
            chuck.PrintState();
        }
    }
}
