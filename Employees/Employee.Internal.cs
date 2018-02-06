using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    partial class Employee
    {
        
        public void DisplayStats() // Обнавленный.
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empID);
            Console.WriteLine("Age: {0}", empAge); // Учитываем возраст.
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
