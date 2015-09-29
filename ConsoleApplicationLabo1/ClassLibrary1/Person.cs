using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    public class Person
    {
        //private String name;
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public String Name{get;set;}

        public Person(String name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return Name + " age(e) de " + Age + " ans ";
        }
    }
}
