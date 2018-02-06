using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Salesperson : Employee
    {
        public int SalesNumber { get; set; }
        public Salesperson (string fullName, int age, int empID,
                       float currPay, string ssn, int numbOfSales)
            : base(fullName, age, empID, currPay, ssn)
        {
            SalesNumber = numbOfSales;
            //Просвоить входные параметры используя унаследованные свойства.


        }
        public Salesperson ()
        {

        }
    }
}
