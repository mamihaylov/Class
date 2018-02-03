using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInheritance
{
    // Простой базовый класс.
    class Car
    {
        public readonly int maxSpeed; // поле для только чтения.
        private int currSpeed; // закрытое поле.

        //конструкторы
        public Car(int max)
        {
            maxSpeed = max;

        }

        public Car()
        {
            maxSpeed = 55;
        }
        public int Speed // Открытое свойство.
        {
            get { return currSpeed; }
            set
            {
                currSpeed = value;

                if (currSpeed > maxSpeed )
                {
                    currSpeed = maxSpeed;
                }

            }
        }
    }
}
