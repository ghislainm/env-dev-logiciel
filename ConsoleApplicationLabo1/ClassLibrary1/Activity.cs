using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    // snippet pour le constructeur : ctor suivit de "tab tab"
    // " auto-implememented : prop
    // "backing : propfull
    public class Activity
    {
        private String title;
        private bool isCompulsory;

        public bool IsCompulsory
        {
            get { return isCompulsory; }
            set { isCompulsory = value; }
        }

        public String Title
        {
            get { return title; }
            set { title = value; }
        }
        

        public Activity(String title, bool isCompulsory)
        {
            //pour obliger a rentrer une valeur dans le titre
            if (String.IsNullOrEmpty(title))
                throw new ArgumentNullException("Title");
            Title = title;
            IsCompulsory = isCompulsory;
        }

        public override string ToString()
        {
           /* if(isCompulsory == false)
                return Title;
            else
                return Title + "(Obligatoire)";*/
            return (isCompulsory) ? Title : Title + " (obligatoire)";
        }
        
    }
}
