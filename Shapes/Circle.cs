using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    // Circle не переопределяет Draw()
    class Circle : Shape
    {
        public Circle() { }
        public Circle(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Circle", PetName);
        }
    }
    // Hexagon переопределяет Draw()
    class Hexagon : Shape
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }
    }
}
