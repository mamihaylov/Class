using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{// менеджерам нужно знать кол-во их опционов на акции.
    class Manager : Employee
    {
		public int StockOptions{ get; set; }
        // Конструкторы.
        public Manager(string fullName, int age, int empID,
                        float currPay, string ssn, int numbOfOpts)
            : base(fullName, age, empID, currPay, ssn)
        {
            StockOptions = numbOfOpts;
            //Просвоить входные параметры используя унаследованные свойства.
        }
        public Manager () { }
        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500);
        }
        public override void DisplayStats()

        {
            base.DisplayStats();
            Console.WriteLine(" Number of Stock Options: {0}", StockOptions);
            

        }
    }
        
}
