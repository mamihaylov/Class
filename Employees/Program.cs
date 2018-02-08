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

            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            Manager fran = new Manager("Fran", 42, 93, 100000, "999-23-3232", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();
          

            Console.ReadLine();
        }
            static void GivePromotion(Employee emp)
            {
                // Повысить запрлату..
                // Предоставить место на порковке компании...
                Console.WriteLine("{0} was promoted!", emp.Name);
            if (emp is Salesperson)
            {
                Console.WriteLine("{0} was promoted!", emp.Name,
                    ((Salesperson)emp).SalesNumber);
                    Console.WriteLine();
               }
            if (emp is Manager)
            {
                Console.WriteLine("{0} had {1} stock options...", emp.Name,
                    ((Manager)emp).StockOptions);
                Console.WriteLine();

            }

            }
        static void CastingExamples()
        {
            object frank = new Manager("Frank Zappa", 9, 3000, 40000, "111-11-1111", 5);
            GivePromotion((Manager)frank);
            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);
            GivePromotion(moonUnit);
            //PtSalesPerson "является" SalesPerson
            Salesperson jill = new PTSalesPerson("Jill", 834, 3002, 100000, "111 - 12 - 1119", 90);
            GivePromotion(jill);
            // Использование as для проверки соместимости.
            Salesperson hex2 = frank as Salesperson;
            if (hex2 == null)
                Console.WriteLine("Sorry, frank is not a Salesperson");
            
            
            

        }
            
        

    }
}
