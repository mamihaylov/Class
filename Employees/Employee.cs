using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
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
        public string Name
        {
            get { return empName;}
            set { empName = value; }
        }
       

        //Методы.
        public void GiveBonus (float amount)
        {
            currPay += amount;
        }

        // Конструкторы .
        public Employee() { }
        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay) { } // ссылаемся на гл.конструктор.
        public Employee(string name, int age, int id, float pay)
        {
            empName = name;
            empID = id;
            empAge = age;
            currPay = pay;
        }
    }

       
        
    
}
