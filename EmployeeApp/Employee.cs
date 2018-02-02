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
        private int empAge;
        //Свойство
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }
        
        // Конструкторы .
        public Employee () { }
        public Employee (string name, int id, float pay)
            :this(name, 0, id, pay) { } // ссылаемся на гл.конструктор.
        public Employee (string name, int age,int id, float pay)
        {
            empName = name;
            empID = id;
            empAge = age; 
            currPay = pay;
        }
        //Методы.
        public void GiveBonus (float amount)
        {
            currPay += amount;
        }
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
