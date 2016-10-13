using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil pupil1 = new Pupil("Vassili", 11, 1);
            Pupil pupil2 = new Pupil("Vass", 5, 1);
            Pupil pupil3 = new Pupil("ili", 6, 1);
            Pupil pupil4 = new Pupil("ssili", 13, 14);
            Pupil pupil5 = new Pupil("Vali", 7);

            Activity activite1 = new Activity("math", true);
            Activity activite2 = new Activity("Francais", false);
            Activity activite3 = new Activity("Coloriage", true);
            Activity activite4 = new Activity("religion", true);
            Activity activite5 = new Activity("allemand", false);

            List<Pupil> pupils = new List<Pupil>();
            pupils.Add(pupil1);
            pupils.Add(pupil2);
            pupils.Add(pupil3);
            pupils.Add(pupil4);
            pupils.Add(pupil5);

            pupil1.AddActivity(activite1);
            pupil1.AddActivity(activite2);
            pupil1.AddActivity(activite3);
            pupil1.AddActivity(activite4);
            pupil1.AddActivity(activite5);

            pupil2.AddActivity(activite1);
            pupil2.AddActivity(activite2);
            pupil2.AddActivity(activite3);
            pupil2.AddActivity(activite4);
            pupil2.AddActivity(activite5);

            pupil3.AddActivity(activite1);
            pupil3.AddActivity(activite2);
            pupil3.AddActivity(activite3);
            pupil3.AddActivity(activite4);
            pupil3.AddActivity(activite5);

            pupil4.AddActivity(activite1);
            pupil4.AddActivity(activite2);
            pupil4.AddActivity(activite3);
            pupil4.AddActivity(activite4);
            pupil4.AddActivity(activite5);

            pupil5.AddActivity(activite1);
            pupil5.AddActivity(activite2);
            pupil5.AddActivity(activite3);
            pupil5.AddActivity(activite4);
            pupil5.AddActivity(activite5);

            pupil1.AddEvaluation("Coloriage");
            pupil1.AddEvaluation(evaluation: 'T', title: "math");

            List<Pupil> listPupils = new List<Pupil>()
            {
                new Pupil("Lucas",12,5),
                new Pupil("Georges",10,6),
            };

            List<Person> listPersons = new List<Person>()
            {
                new Person("Hyohan", 19),
                new Person("Benjamin", 18),
                new Person("Julie", 13)
            };

            var listFusion = listPersons.Union(pupils);
            foreach (Person person in listFusion)
            {
                //System.Console.WriteLine(person);
            }

          //  System.Console.Read();

            /*IEnumerable<Pupil> listPupilsNoDuplicated = pupils.Distinct<Pupil>(new PersonComparer());
            foreach (Pupil pupil in listPupilsNoDuplicated)
            {
                System.Console.WriteLine(pupil);
            }

            System.Console.Read();*/

            //System.Console.Write(pupil1);
            //System.Console.Read();

            var pupilGrade1Plus6 = pupils.Where(pupil => pupil.Age > 6 && pupil.Grade == 1);
            foreach (Pupil pupil in pupilGrade1Plus6)
            {
                //System.Console.Write(pupil);
            }

            //System.Console.Write(pupil1.PrintPupilActivityCompulsory(delegate(Activity activity) { return activity.Title + "\n"; }));

            //System.Console.Write(pupil1.PrintPupilActivityCompulsory(StaticPrintActivity));

            PrintActivityDelegate p = new PrintActivityDelegate();
            //System.Console.Write(pupil1.PrintPupilActivityCompulsory(p.PrintActivity));

            System.Console.WriteLine(pupil1.PrintPupilActivityCompulsory(activity => activity.Title+ Environment.NewLine));

            System.Console.Read();
        }
        private static string StaticPrintActivity(Activity activity)
        {
            return activity.Title + "\n";
        }

        public class PrintActivityDelegate
        {
            public string PrintActivity(Activity activity)
            {
                return activity.Title + "\n";
            }
        }
    }
}
