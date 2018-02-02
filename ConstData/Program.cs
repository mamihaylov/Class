using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Const***\n");
            Console.WriteLine("The value of PI is {0}", MyMathClass.PI);
            // ошибка ! нельзя именять константу.
            MyMathClass.PI = 3.14444;
            Console.ReadLine();
        }
    }
}
