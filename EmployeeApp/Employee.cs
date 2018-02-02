using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        //поля данных
        private string empName;
        private int empID;
        private float currPay;
        
        // Конструкторы.
        public Employee () { }
        public Employee (string name, int id, float pay)
        {
            empName = name;
            empID = id;
            currPay = pay;
        }
        //Методы.
        public void GiveBonus (float amount)
        {
            currPay += amount;
        }
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Pay: {0}", currPay);
        
        }
        // Метод доступа ( Get )
        public string GetName()
        {
            return empName;
        }
        // метод изменения ( Set )
        public void SetName(string name)
        {
            if (name.Length > 15)
                //Ошибка, имя должно иметь меньше 16 символов.
                Console.WriteLine("Error! Name must be less than 16 characters!");
            else
                empName = name;
        }
        
    }
}
