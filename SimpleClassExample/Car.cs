using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    { // 'Состояние ' обьекта car.
        public string petName;
        public int currSpeed;
        // специальный конструктор.
        public Car()
        {
            petName   = "Chuck";
            currSpeed = 10;
        }
        //Здесь currspeed получает стандартное значение для типа int (0).
        public Car(string pn)
        {
            petName = pn;
        }
        // Позволяет вызывающему коду установить полное состояние Car.
        public Car(string pn,int cs)
        {
            petName = pn;
            currSpeed = cs;

        }

        // Функциональность car
        public void PrintState()
        {
            Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);
        }
        public void SpeedUp(int delta)
        {
            currSpeed += delta;
        }
       
    }
    
    
}
