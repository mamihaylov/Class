﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun whth Static Data ****\n");
            SavingAccount s1 = new SavingAccount(50);
            SavingAccount s2 = new SavingAccount(100);
            SavingAccount s3 = new SavingAccount(10000.75);
            Console.ReadLine();
        }
    }
}
