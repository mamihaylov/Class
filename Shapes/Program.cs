using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Fun with Polymorphism ***\n");
            // Создать массив совместимых с Shape объектов.
            Shape[] myShape = { new Hexagon(), new Circle(),new Hexagon("Mick"),
                                new Circle("Beth"), new Hexagon("Linda")};
            // пройти в цикле по всем эелементам и взаимодействовать 
            // С полиморфным интерфесом.
            foreach(Shape s in myShape)
            {
                s.Draw();
                
            }
            Console.ReadLine();

            
        }
    }
}
