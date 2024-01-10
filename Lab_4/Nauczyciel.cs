using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Nauczyciel : Uczen
    {
        protected string TytulNaukowy;
        protected List<Uczen> PodwladniUczniowie;
        public void AssignStudent(Uczen stud)
        {
            this.PodwladniUczniowie.Add(stud);
        }

        public void WhichStudentCanGoHomeAlone()
        {
            foreach(Uczen u in PodwladniUczniowie)
            {
                if (u.CanGoAloneToHome())
                {
                    Console.WriteLine($"Uczeń {u.GetFullName} może sam pójść do domu.");
                }
                else
                {
                    continue;
                }
                
            }
        }
        
    }
}
