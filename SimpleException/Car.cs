﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Car
    {
        // Константа для предстовление максимальной скорости
        public const int MaxSpeed = 100;

        //Свойства автомобиля.
        public int CurrentSpeed { get; set; }
        public string PetName { get; set; }

        //не вышел ли автомобил из строя?
        private bool carIsDead;

        // Автомобиль имеет радиоприемник
        private Radio theMusicBox = new Radio();

        // Конструкторы
        public Car () { } //1. констр.
        public Car (string name, int speed) // 2. констр.
        {
            CurrentSpeed = speed;
            PetName = name;
        }
        public void CrankTunes(bool state)
        {
            // делегировать запрос внутреннему объекту.
            theMusicBox.TurnOn(state);

        }
        // Проверить не перегрелся ли автомобиль.
        public void Accelerate(int delta)
        {
            if (carIsDead)
                Console.WriteLine("{0} is out of order. . .", PetName);
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    carIsDead = true;
                    CurrentSpeed = 0;
                   //Создать локальную переменную перед генерацией обьекта Exception.
                   //Что бы можно было обратиться к свойству HelpLink.
                   Exception ex =
                    new Exception(string.Format("{0} has overheated! :", PetName));
                    ex.HelpLink = "http://www.CarsRUs.com";
                    // Указать спец данные касающиеся ошибки.
                    ex.Data.Add("TimeStamp", string.Format("The car exploded at {0}", DateTime.Now)); // Метка времени.
                    ex.Data.Add("Cause","You have a lead foot."); // Причина.
                    throw ex;
                }
                else
                    Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);            }
        }
        

    }
}
