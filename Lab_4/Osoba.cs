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
        private string Imie;
        private string Nazwisko;
        private string Pesel;
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
        public void SetFirstName(string Imie)
        {
            this.Imie = Imie;
        }
        public void SetLastName(string Nazwisko)
        {
            this.Nazwisko = Nazwisko;
        }
        public void SetPesel(string Pesel)
        {
            this.Pesel = Pesel;
        }
        public void GetAge()

        {
            if (this.Pesel != null && this.Imie != null)
            {
                int y;
                int result;
                if (this.Pesel[2] < 2)
                {
                    y = Convert.ToInt32($"19{this.Pesel[0]}{this.Pesel[1]}");
                }
                else
                {
                    y = Convert.ToInt32($"20{this.Pesel[0]}{this.Pesel[1]}");
                }
                result = DateTime.Now.Year - y;
                Console.WriteLine($"{this.Imie} ma {result} rok/lat/lata");
            }
            else
            {
                Console.WriteLine("Podaj numer PESEL i/lub imię !!!");
            }
        }
        public void GetGender()
        {
            if (this.Pesel != null) { 
                if (this.Pesel[this.Pesel.Length - 1] % 2 == 0)
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



    }
}
