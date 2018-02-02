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
            // константа А
            Console.WriteLine("The value of A is {0}", Constants.A);
            Console.WriteLine("The value of B is {0}", Constants.B);
            Console.ReadLine();

        }
    }
}
