using System;
using System.ComponentModel;

namespace Poprawa_2
{
    class Program
    {
        
        
        //zadanie1
        
        public enum info
        {
            firma,
            prywatny,
        }
        static void oblicz(double masa, info info)
        {
            double tony = masa / 1000;

            double suma = tony * 850;
            double suma_masy;

            if (info == info.firma)
            {
                suma = suma + (Math.Floor(tony) * 35);

            }

            if (masa < 3500)
            {
               Console.WriteLine(suma + 35); 
            }
            else
            {
                suma_masy = Math.Ceiling( masa / 3500);
                Console.WriteLine(suma + (suma_masy*35));
            }
            
            
            
        }
        
        //Zadanie 2

        static void wylicz()
        {
            
        }
        
        //zadanie 3
        
        public class Ogloszenie
        {
            public string Tytul { get; set; }
            public string Tresc { get; set; }
            public double Cena { get; set; }
            public DateTime Czas { get; set; }
            public string NrTel { get; set; }
            public int Wyswietlenia { get; set; }
            public int WyswietleniaTel { get; set; }


            public Ogloszenie(string tytul, string tresc, double cena, DateTime czas, string nrTel)
            {
                if (string.IsNullOrEmpty(tytul) || string.IsNullOrEmpty(tresc))
                {
                    Console.WriteLine("Error");
                }
                else if(nrTel.Length != 9 || cena < 0)
                {
                    Console.WriteLine("Numer telefonu nie prawidłowy");
                }
                else
                {
                    Tytul = tytul ;
                    Tresc = tresc;
                    Cena = cena ;
                    Czas = czas;
                    NrTel = nrTel; 
                }
            }

            public void wyswietl()
            {
                Wyswietlenia++;
                
                Console.WriteLine("Tytuł: {0} \n Tresc: {1} \n Cena: {2}", 
                    Tytul, Tresc, Cena);
                
                Console.WriteLine(Wyswietlenia);
            }
            
            public void wyswietlTel()
            {
                WyswietleniaTel++;
                
                Console.WriteLine("Numer Telefonu: {0} \n Telefon Wyswietlenia: {1}", 
                    NrTel, WyswietleniaTel);
            }
        }
        
        static void Main(string[] args)
        {
            //Zadanie1
            oblicz(1500, info.firma);
            
            //Zadanie2
            
            
            //Zadanie3
            
            Ogloszenie ogloszenie = new Ogloszenie("ddd", "rrr", 20, DateTime.Now, "999999999");


            ogloszenie.Wyswietlenia = 6;
            ogloszenie.WyswietleniaTel = 6;
            
            ogloszenie.wyswietl();
            
            ogloszenie.wyswietlTel();
        }
    }
}