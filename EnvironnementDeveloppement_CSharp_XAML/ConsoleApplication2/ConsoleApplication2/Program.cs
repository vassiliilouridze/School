using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrivateContact contact1 = new PrivateContact("Vassili", "Ilouridzé", 0492697349, "vassili-ilouridze@hotmail.com");
            PrivateContact contact2 = new PrivateContact("Lucas", "Lapaglia", 0474138478, "luckylucke@hotmail.com", new DateTime(2016,09,26));

            ProfessionalContact proContact1 = new ProfessionalContact("May", "Beaufay", "consultant", 0499698787, "may@bobo.com");
            ProfessionalContact proContact2 = new ProfessionalContact("Kirikou", "Macoumba", "consultant", 0499698787, "kikou@bobo.com");
            ProfessionalContact proContact3 = new ProfessionalContact("Anais", "Koppens", "indépendant", 0499698787, "Anouchka@vk.ru");

            Entreprise entreprise1 = new Entreprise("CGG", "Namur");
            Entreprise entreprise2 = new Entreprise("NRB", "Tombouktou");

            Car car1 = new Car("PMZ229");
            Car car2 = new Car("ADB337");

            ContactCar contactCar1 = new ContactCar(contact1, car1);
            ContactCar contactCar2 = new ContactCar(proContact2, car2);

            //System.Console.Write(contact1);
            //System.Console.Write(contact2);
            if(contact2.HasHisBirthday() == true)
            {
                //System.Console.Write("Bon anniversaire!");
            }

            proContact1.EntrepriseAdd(entreprise1);
            proContact1.EntrepriseAdd(entreprise2);
            proContact2.EntrepriseAdd(entreprise2);
            proContact3.EntrepriseAdd(entreprise1);

            List<ProfessionalContact> listProContacts = new List<ProfessionalContact>();
            listProContacts.Add(proContact1);
            listProContacts.Add(proContact2);
            listProContacts.Add(proContact3);

            var proInde = from contacts in listProContacts
                          where contacts.EntrepriseList.Count == 1
                          select contacts;

            var proConsu = listProContacts.Where(contact => contact.EntrepriseList.Any(n => n.Nom == "NRB"));
            foreach(var contact in proConsu)
            {
                //System.Console.Write(contact.ToString());
            }

            //System.Console.Write("nombre d'indépendants : " + proInde.Count());

            contactCar1.DynamicPrint(contact1);
            contactCar2.DynamicPrint(proContact2);

            System.Console.Read();
        }
    }
}
