﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
            public Person(string fname,string lName,int personAge)
        {
            FirstName = fname;
            LastName = lName;
            Age = personAge;

        }
        public Person() { }



        public override string ToString()

        {
            string myState;
            myState = string.Format("[First Name: {0}; Last Name: {1}; Age: {2}]", FirstName, LastName, Age);
            return myState;

        }
        public override bool Equals(object obj)

        {
        return obj.ToString() == this.ToString();
        }
         public override int GetHashCode()

        {
            return this.ToString().GetHashCode();

        }



    }

}
}
