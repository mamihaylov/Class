using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {       // Создание обьекта подкласса и доступ к функциональности базового класса.
        static void Main(string[] args)
        {
            Console.WriteLine("**** The Employee Class Hierarchy***\n");
            
            Manager chucky = new Manager("Chucky",50, 92 , 100000 , "333-23-2322", 9000);
            Console.ReadLine();



        }
    }
}
