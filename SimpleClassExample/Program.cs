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
           
            // Создать обьект  Car по именя Chuck со скоростью 10 миль в час.
            Car chuck = new Car();
            chuck.PrintState();
            // Создать обьект  Car по именя Mary со скоростью 0 миль в час.
            Car mary = new Car("Mary");
            mary.PrintState();
            // Создать обьект  Car по именя Daisy со скоростью 75 миль в час.
            Car daisy = new Car("Daisy", 75);
            daisy.PrintState();
            

            Books book1 = new Books("Programmig C++",12);
            book1.PrintState();
            Books book2 = new Books("Programmig Java Scripts", 8);
            book2.PrintState();
            Console.ReadLine();

        }
    }
}
