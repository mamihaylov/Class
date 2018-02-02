using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public string Color { get; set; }
        public Point (int xVal, int YVal,string cl)
        {
            X = xVal;
            Y = YVal;
            Color = cl;
        }
        // Конструктор
        public Point () { }

        public void DisplayStats()
        {
            Console.WriteLine("[{0},{1},{3}]", X, Y,Color);
        }
    }
}
