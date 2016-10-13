using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class PrivateContact: Person
    {
        private int numeroTel;
        private String adresseMail;
        private DateTime dateNaiss;

        public int NumeroTel
        {
            get
            {
                return numeroTel;
            }

            set
            {
                numeroTel = value;
            }
        }

        public string AdresseMail
        {
            get
            {
                return adresseMail;
            }

            set
            {
                adresseMail = value;
            }
        }

        public DateTime DateNaiss
        {
            get
            {
                return dateNaiss;
            }

            set
            {
                dateNaiss = value;
            }
        }

        public PrivateContact(String name, String lastName, int nT, String aM, DateTime dN) : base(name, lastName)
        {
            NumeroTel = nT;
            AdresseMail = aM;
            DateNaiss = dN;
        }

        public PrivateContact(String name, String lastName, int nT, String aM) : base(name, lastName)
        {
            NumeroTel = nT;
            AdresseMail = aM;
        }

        public override bool HasHisBirthday()
        {
            return (DateTime.Today.Month == DateNaiss.Month && DateTime.Today.Day == DateNaiss.Day);
        }

        public string Print()
        {
            return base.ToString() + " est un contact privé";
        }

        public override string ToString()
        {
            return base.ToString() +" ("+ NumeroTel+") "+AdresseMail;
        }
    }
}
