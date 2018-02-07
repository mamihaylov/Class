using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Employees

{

    abstract partial class Employee

    {

    public class BenefitPackage

        {
            public double ComputePayDeduction()

            {

                return 125.0;

            }

        }



        //Перем.

        protected string empName;
        protected int empID;
        protected float currPay;
        protected int empAge;
        protected string empSSN;
        protected BenefitPackage empBenefits = new BenefitPackage();



        public double GetBenefitCost()

        { return empBenefits.ComputePayDeduction(); }

        public BenefitPackage Benefits

        {

            get { return empBenefits; }
            set { empBenefits = value; }

        }

         //Методы.

        public virtual void GiveBonus(float amount) // Виртуальный метод ( Может быть переопределен производным классом.

        {
        Pay += amount;
        }
        public virtual void DisplayStats()

        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID:{0}", ID);
            Console.WriteLine("Age:{0}", Age);
            Console.WriteLine("Pay: {0}", Pay);

        }





    }

}