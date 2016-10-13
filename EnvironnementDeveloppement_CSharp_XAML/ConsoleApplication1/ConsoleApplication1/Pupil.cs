using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Pupil : Person
    {
        private int grade;
        private List<Activity> listActivities;
        private char[] tabEval;
        public delegate string DelegatePrintActivityCompulsory(Activity activity);

        public Pupil(string name, int age, int grade) : base(name, age)
        {
            Grade = grade;
            ListActivities = new List<Activity>();
            TabEval = new char[10];
        }

        public Pupil(string name, int age) : this(name, age, 1) { }

        public int Grade
        {
            get;set;
        }

        public char[] TabEval
        {
            get;set;
        }

        public List<Activity> ListActivities
        {
            get;set;
        }


        public void AddActivity(Activity activity)
        {
            ListActivities.Add(activity);
        }

        public void AddEvaluation(String title = null, char evaluation = 'S')
        {
            int i = 0;
            while(i<ListActivities.Count && ListActivities.ElementAt(i).Title != title){ i++; }
            if( i < ListActivities.Count && i < 10)
            {
                TabEval[i] = evaluation;
            }
        }

        private string PrintActivitiesPupil(string ch)
        {
            for (int i = 0; i < ListActivities.Count; i++)
            {
                ch += "\n" + ListActivities.ElementAt(i).ToString() + " : " + ListActivities.ElementAt(i);
            }

            return ch;
        }
        private String HeaderPupil()
        {
            string ch = base.ToString();
            return ch;
        }

        public string PrintPupilActivityCompulsory(DelegatePrintActivityCompulsory MyPrintActivity)
        {
            int numAct = 0;
            string ch = base.ToString() + " a choisi les activités obligatoires: \n";
            foreach(Activity activity in ListActivities)
            {
                if (activity.Compulsory)
                {
                    ch += (++numAct) + " " + MyPrintActivity(activity);
                }
            }
            return ch;
        }

        public override string ToString()
        {
            /*string ch = base.ToString();
            int cptActivities = ListActivities.Count();
            if(cptActivities == 0)
            {
                ch += " n'a pas encore choisi d'activité";
            }
            else
            {
                ch += " a choissi les activités suivantes : ";
                foreach(Activity activity in ListActivities)
                {
                    ch += " " + activity.ToString() + " avec " + TabEval[ListActivities.IndexOf(activity)] + " , ";
                }
                ch = ch.Remove(ch.Length - 3);
            }

            return ch;*/
            string ch = HeaderPupil();
            ch = PrintActivitiesPupil(ch);

            return ch;
        }
    }
}
