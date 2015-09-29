using ConsoleApplicationLabo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Pupil : Person
    {
        private int grade;
        private List<Activity> lstActivity;
        private char[] tabVal;

        public char[] TabVal
        {
            get { return tabVal; }
            set { tabVal = value; }
        }

        public List<Activity> LstActivity
        {
            get { return lstActivity; }
            set { lstActivity = value; }
        }

        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public Pupil(String name, int age,int grade): base(name, age)
        {
            Grade = grade;
            LstActivity = new List<Activity>() ;
            TabVal = new char [10] ;
        }

        public Pupil(String name, int age) : this(name, age, 1) { }

        public void addActivity(Activity act)
        {
            if(LstActivity.Count() < Parameter.DIX)
                LstActivity.Add(act);
            else
                System.Console.Write("Le nombre maximum d'activités est déjà atteint");
        }

        public override string ToString()
        {
            string ch = base.ToString() + ((LstActivity.Count()!=0 )? " a choisi les activités suivantes:" : "n'a pas encore choisi d'activité");

            int i;
            for(i=0; i<LstActivity.Count(); i++)
            {
                ch += "\n"+LstActivity[i];
            }

            return ch;
        }

        public void AddEvaluation ( String title = null, char evaluation=(char)Parameter.evaluation.Satisfaisant /*char evaluation = 'S'*/) 
        {
            int i=0 ;
            if(title !=null)
            {
                foreach(Activity activity in lstActivity)
                { 
                    if(activity.Title.Equals(title)) break ;
                    i++ ;
                }
                TabVal[i] = evaluation;
            }
        }

        public Char GetEvaluationFor(String title)
        {
            int i = 0;
            if (title != null)
            {
                foreach (var activity in lstActivity)
                {
                    if (activity.Title.Equals(title))
                        return TabVal[i];
                    i++;
                }
                
            }
            throw new KeyNotFoundException();
            
        }
        
    }
}
