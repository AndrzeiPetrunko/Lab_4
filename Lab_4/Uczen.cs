using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Uczen : Osoba
    {
        protected string Szkola;
        protected bool MozeSamWracacDoDomu;
        public void SetSchool(string School)
        {
            this.Szkola = School;
        }
        public void ChangeSchool(string School)
        {
            this.Szkola = School;
        }
        public void SetCanGoHomeAlone(bool set)
        {
            this.MozeSamWracacDoDomu = set;
        }
        public override void SetFirstName(string Imie)
        {
            this.Imie = Imie;
        }

        public override void SetLastName(string Nazwisko)
        {
            this.Nazwisko = Nazwisko;
        }
        public override void SetPesel(string Pesel)
        {
            this.Pesel = Pesel;
        }

        public override int GetAge()
        {

            if (this.Pesel != null && this.Pesel.Length == 11)
            {
                int y;
                int m;
                int d;
                int result;
                if (this.Pesel[2] < '2')
                {
                    y = Convert.ToInt32($"19{this.Pesel[0]}{this.Pesel[1]}");
                    m = Convert.ToInt32($"{this.Pesel[2]}{this.Pesel[3]}");
                    d = Convert.ToInt32($"{this.Pesel[4]}{this.Pesel[5]}");
                }
                else
                {
                    y = Convert.ToInt32($"20{this.Pesel[0]}{this.Pesel[1]}");
                    m = Convert.ToInt32($"{this.Pesel[2]}{this.Pesel[3]}") - 20;
                    d = Convert.ToInt32($"{this.Pesel[4]}{this.Pesel[5]}");
                }
                if (DateTime.Now.Month >= m && DateTime.Now.Day >= d)
                {
                    result = DateTime.Now.Year - y;
                }
                else
                {
                    result = DateTime.Now.Year - y - 1;
                }
                return result;
            }
            else
            {
                Console.WriteLine("Nie podałeś(-łaś) numeru PESEL lub on jest błędny.");
                return -1;
            }

        }
        public override void GetGender()
        {
            if (this.Pesel != null)
            {
                if (this.Pesel[9] % 2 == 0)
                {
                    Console.WriteLine("Kobieta");
                }
                else
                {
                    Console.WriteLine("Mężczyzna");
                }
            }
            else
            {
                Console.WriteLine("Podaj numer PESEL !!!");
            }
        }
        public override void GetEducationInfo()
        {

        }
        public override void GetFullName()
        {
            if (this.Imie != null && this.Nazwisko != null)
            Console.WriteLine($"Pełne imię ucznia: {this.Imie} {this.Nazwisko}");
        }

        public override void CanGoAloneToHome()
        {
            
        }
    }
}
