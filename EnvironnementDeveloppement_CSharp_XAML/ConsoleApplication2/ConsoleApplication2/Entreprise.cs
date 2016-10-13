using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Entreprise
    {
        private String nom;
        private String localite;

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Localite
        {
            get
            {
                return localite;
            }

            set
            {
                localite = value;
            }
        }

        public Entreprise(String n, String l)
        {
            Nom = n;
            Localite = l;
        }

        public override string ToString()
        {
            return Nom + " " + Localite;
        }
    }
}
