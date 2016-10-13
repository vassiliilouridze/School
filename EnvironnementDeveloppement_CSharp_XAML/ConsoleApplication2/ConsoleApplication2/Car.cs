using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Car
    {
        private String numeroPlaque;

        public string NumeroPlaque
        {
            get
            {
                return numeroPlaque;
            }

            set
            {
                numeroPlaque = value;
            }
        }

        public Car(String nP)
        {
            NumeroPlaque = nP;
        }

        public override string ToString()
        {
            return NumeroPlaque;
        }
    }
}
