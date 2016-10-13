using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class ProfessionalContact : Person
    {
        private String Profession;
        private int numTelPro;
        private String adresseMailPro;
        private List<Entreprise> entrepriseList =  new List<Entreprise>();

        public string Profession1
        {
            get
            {
                return Profession;
            }

            set
            {
                Profession = value;
            }
        }

        public int NumTelPro
        {
            get
            {
                return numTelPro;
            }

            set
            {
                numTelPro = value;
            }
        }

        public string AdresseMailPro
        {
            get
            {
                return adresseMailPro;
            }

            set
            {
                adresseMailPro = value;
            }
        }

        public List<Entreprise> EntrepriseList
        {
            get
            {
                return entrepriseList;
            }

            set
            {
                entrepriseList = value;
            }
        }

        public ProfessionalContact(String name, String lastName, String p, int nTP, String aLP) : base(name, lastName)
        {
            Profession = p;
            numTelPro = nTP;
            adresseMailPro = aLP;
        }

        public override string ToString()
        {
            return base.ToString() + " (" + NumTelPro + ") " + AdresseMailPro;
        }

        public override bool HasHisBirthday()
        {
            return false;
        }

        public void EntrepriseAdd(Entreprise e)
        {
            EntrepriseList.Add(e);
        }

        public string Print()
        {
            return base.ToString() + " est un contact professionnel";
        }
    }
}
