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
            PTSalesPerson TestPTSP = new PTSalesPerson("Alex", 24, 93, 500000, "1337-1337", 4000, 4);
            Console.WriteLine("SalesPerson {0} works {1} hours / day", TestPTSP.Name, TestPTSP.WorkHours);


        }
    }
}
