using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Person
    {
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
            public Person(string fname,string lName,int personAge)
        {
            FirsName = fname;
            LastName = lName;
            Age = personAge;

        }


    }
}
