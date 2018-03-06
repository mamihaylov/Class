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
            // Свойство TargetSite в действительности возвращает обьект MethodBase.
            catch(Exception e)
            {
                Console.WriteLine("\n *** Error! ***"); // Ошибка
                Console.WriteLine("Member name: {0}", e.TargetSite); // Имя члена
                Console.WriteLine("Class defining member: {0}", 
                    e.TargetSite.DeclaringType); // Класс, определяющий член
                Console.WriteLine("Member Type : {0}", e.TargetSite.MemberType); //Тип члена

                Console.WriteLine("Message : {0}", e.Message); // сообщение
                Console.WriteLine("Source : {0}", e.Source); // источник
                Console.WriteLine("Stack: {0}", e.StackTrace); // Стек
                Console.WriteLine("HelpLink: {0}", e.HelpLink);
            }
            /* Ошибка была обработанна, продолжается выполнение
             * следующего оператора.*/
            Console.WriteLine("\n**** out of exception logic ****");
            Console.ReadLine();

        }
    }
}
