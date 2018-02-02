using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    partial class Employee
    {
        //поля данных
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        //Свойство
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }
        
       

        //Методы.
        public void GiveBonus (float amount)
        {
            currPay += amount;
        }
       
        
        }
       
        
    }
}
