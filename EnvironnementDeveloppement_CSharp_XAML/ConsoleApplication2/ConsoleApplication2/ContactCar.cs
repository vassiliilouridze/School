using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ContactCar
    {
        private Person person;
        private Car car;

        public Person Person
        {
            get
            {
                return person;
            }

            set
            {
                person = value;
            }
        }

        internal Car Car
        {
            get
            {
                return car;
            }

            set
            {
                car = value;
            }
        }

        public ContactCar(Person p, Car c)
        {
            Person = p;
            Car = c;
        }

        public void DynamicPrint(dynamic objet)
        {
            System.Console.WriteLine(objet.Print() + " voiture : " + Car.ToString());
        }
    }
}
