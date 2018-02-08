using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Program
    {   // Обработка сгенерированного исключения.
        static void Main(string[] args)
        {
            Console.WriteLine("**** simple Exception Example ****\n");
            Console.WriteLine("=> Creating a car and stepping on it");
            Car myCar = new Car("Zippy", 20);
            myCar.CrankTunes(true);

            /* Разогнать до скорости, превышающей максимальны
               предел автомобиля выдачи исключения. */
            try
            {
                for (int i = 0; i < 10; i++)
                    myCar.Accelerate(10);
            }
            catch(Exception e)
            {
                Console.WriteLine("\n *** Error! ***"); // Ошибка
                Console.WriteLine("Method : {0}", e.TargetSite); // Метод
                Console.WriteLine("Message : {0}", e.Message); // сообщение
                Console.WriteLine("Source : {0}", e.Source); // источник
            }
            /* Ошибка была обработанна, продолжается выполнение
             * следующего оператора.*/
            Console.WriteLine("\n**** out of exception logic ****");
            Console.ReadLine();

        }
    }
}
