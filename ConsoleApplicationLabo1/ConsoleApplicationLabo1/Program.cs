using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplicationLabo1;
using ClassLibrary1;

namespace ConsoleApplicationLabo1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pupil> pupilList = new List<Pupil>()
            {
                new Pupil ("Ghislain", 20, 5),
                new Pupil ("Françoise", 26, 2),
                new Pupil ("Olivier", 20, 4),
                new Pupil ("Zipo", 5, 1),
                new Pupil ("Mimu", 7, 1),
                new Pupil ("Nono", 8, 1),
            };
            //var pupilGrade1Plus6 = from pupil in pupilList
            //                       where pupil.Grade == 1 && pupil.Age > 6
            //                       select pupil;
            var pupilGrade1Plus6 = pupilList.Where(pupil =>pupil.Grade ==1 && pupil.Age > 6); //Lambda expression 


            if(pupilGrade1Plus6 != null)
                foreach(var pupil in pupilGrade1Plus6)
                {
                    System.Console.Write(pupil);
                    System.Console.Write("\n");
                }

            //Covariance
            List <Pupil> listPupils = new List <Pupil>()
            {
                new Pupil("AAAA", 21, "IG");
            } ;

            Activity a = new Activity("Math",false);
            Activity a1 = new Activity("Français", true);
            Activity a2 = new Activity("Langage c", false);

            Pupil p1 = new Pupil("Ghislain", 20);

            p1.addActivity(a);
            p1.addActivity(a2);
            p1.AddEvaluation("Math");

            System.Console.Write(p1);
            System.Console.Read();
        }
    }
}
