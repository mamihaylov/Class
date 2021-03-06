﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneableExample
{
    public abstract class CloneableTyoe
    {

        // Только производные типы могут поддерживать этот "Полиморфный интерфейс"
        // Классы в других иерархиях не имеют доступа к этому абстрактному члену.
        public abstract object Clone();
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // Все эти классы поддерживают интерфейс IConeable
            string myStr = "Hello";
            OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());
            System.Data.SqlClient.SqlConnection sqlCnn =
                new System.Data.SqlClient.SqlConnection();
            CloneMe(myStr);
            CloneMe(unixOS);
            CloneMe(sqlCnn);
            Console.ReadLine();

        }
        private static void CloneMe(ICloneable c)
        {
            object theClone = c.Clone();
            Console.WriteLine("Your clone is a: {0}", theClone.GetType().Name);
        }
    }
}
