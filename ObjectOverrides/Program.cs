using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with system.object ****\n");
            Person p1 = new Person();
            // Использовать унаследованные члены System.Object.
            Console.WriteLine("ToString: {0}", p1.ToString());
            Console.WriteLine("Hash code: {0}", p1.GetHashCode());
            Console.WriteLine("Type: {0}", p1.GetType());

            // Создать другую ссылку на p1
            Person p2 = p1;
            object o = p2;
            // Указывают ли ссылки на олин и тот же обьект в памяти?
            if (o.Equals(p1) && p2.Equals(o))
            {
                Console.WriteLine("Same instance!"); // Один и тот же экземпляр

            }
            Console.ReadLine();

        }
    }
}
