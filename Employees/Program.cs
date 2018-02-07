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
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            Manager fran = new Manager("Fran", 42, 93, 100000, "999-23-3232", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();
            Console.ReadLine();
            


        }
    }
}
