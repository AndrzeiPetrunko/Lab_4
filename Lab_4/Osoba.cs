using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    abstract class Osoba
    {
        protected string Imie;
        protected string Nazwisko;
        protected string Pesel;
        /*public Osoba()
        {
            Imie = string.Empty;
            Nazwisko = string.Empty;
            Pesel = string.Empty;
        }
        public Osoba(string Imie, string Nazwisko, string Pesel)
        {
            this.Imie = Imie;
            this.Nazwisko = Nazwisko;
            this.Pesel = Pesel;
        }*/
        public abstract void SetFirstName(string Imie);
        public abstract void SetLastName(string Nazwisko);
        public abstract void SetPesel(string Pesel);
        public abstract int GetAge();
        public abstract void GetGender();
        public abstract void GetEducationInfo();
        public abstract string GetFullName();
        public abstract bool CanGoAloneToHome();






    }
}
