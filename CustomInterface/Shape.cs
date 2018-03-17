using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    abstract class Shape
    {   // Вынудить все дочерние классы определить свою визуализацию.
        public abstract void Draw();
        public Shape(string name = "Noname")
        { PetName = name; }
        public string PetName { get; set; }
        
        
        
    }
; }
