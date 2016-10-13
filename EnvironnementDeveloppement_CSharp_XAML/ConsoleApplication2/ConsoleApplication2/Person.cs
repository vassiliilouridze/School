using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public abstract class Person
    {
        private String name;
        private String lastName;

        public string Name
        {
            get;set;
        }

        public string LastName
        {
            get; set;
        }

        public Person(String n, String lN)
        {
            Name = n;
            LastName = lN;
        }

        public override string ToString()
        {
            return Name + " " + LastName;
        }

        public abstract bool HasHisBirthday();
    }
}
