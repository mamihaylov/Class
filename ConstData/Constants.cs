using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstData
{
    class Constants
    {
        // Использование константного поля.
        public const int A = 10;
        // Использование поля только для чтения.
        public static readonly int B;
        //конструктор B
        static Constants ()
        {
            B = 15;
        }
    }
}
