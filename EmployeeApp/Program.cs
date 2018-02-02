using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Код с ошибкой, невозможно на прямую обращаться к закрытыми полям обьекта.
            Employee emp = new Employee();
            emp.empName = "Marv";

        }
    }
}
