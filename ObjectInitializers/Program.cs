using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Object Init Syntax****\n");
            // Создать обьект Point с установкой кажого свойства вручную.
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();
            // Создаем обьект с исп.спец конструктора.
            Point anotherPoint = new Point(20, 20);
            anotherPoint.DisplayStats();

            // Создать обьект с использованием синтаксиса инициализатора обьекта.
            Point finalPoint = new Point { X = 30, Y = 30 };
            finalPoint.DisplayStats();
            Console.ReadLine();

        }
    }
}
