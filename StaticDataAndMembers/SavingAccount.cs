using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    // Класс депозитного счета.
    class SavingAccount
    {   
        // Данные уровня экземпляра.
        public double currBalance;
        //Статический элемент данных.
        public static double currInterestRate = 0.04;
        public SavingAccount(double balance)
        {
            currBalance = balance;
        }
        
    }
}
