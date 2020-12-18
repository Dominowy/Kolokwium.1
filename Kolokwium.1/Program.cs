using System;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Kolokwium._1
{
    //zadanie1
    public enum typKonta
    {
        Oszczednosciowe,
        Rozliczeniowe 
    }
    
    
    
    //zadanie3
    class Post
    {
        public string Autor;
        public string Tytul;
        public string Tresc;
        public string Tagi;
        public DateTime Czas;
        
        public Post(string tytul, string autor,string tresc, string tagi, DateTime czas)
        {
            DateTime time = new DateTime(2000, 1, 1);
            
            if (string.IsNullOrEmpty(tytul) || string.IsNullOrEmpty(autor) || string.IsNullOrEmpty(tresc) || string.IsNullOrEmpty(tagi))
            {
                Console.WriteLine("Czegoś Brakuje!!");
            }
            else if (time.Year - czas.Year >= 0)
            {
                Console.WriteLine("Za stara data utworzenia!!");
            }
            else
            {
                Tytul = tytul;
                Autor = autor;
                Tresc = tresc;
                Tagi = tagi;
                Czas = czas;
            }
        }
        public void wypisz()
        {
            Console.WriteLine("Tytul: {0} \n Autor: {1} \n Tresc: {2} \n tagi: {3} \n Data: {4}"
                , Tytul, Autor, Tresc, Tagi, Czas);
        }
    }
    
    class Program
    {
        //zadanie1
        static void wczytaj()
        {
            Console.WriteLine("Podaj Imie:");
            string imie = Console.ReadLine();
            Console.WriteLine("Podaj Nazwisko:");
            string nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj Wiek:");
            string wiek = Console.ReadLine();
            Console.WriteLine("Podaj Typ Konta:");
            string typkonta = Console.ReadLine();

            Console.WriteLine("Imie: {0} \n Nazwisko: {1} \n Wiek: {2} \n Typ Konta: {3}"
                , imie, nazwisko, wiek, typkonta);
        }
        
        //zadanie2
        static void DowolnaParam(params string[] parametr)
        {
            string napis = "";
            
                 napis = String.Join("\n",parametr);
            
            Console.WriteLine(napis);
        }

        static void Main(string[] args)
        {
            //zadanie1 - test
            wczytaj();
            
            //zadanie2 - test
            
            DowolnaParam("1","2","3","5","6","7");
            
            //zadanie3 - test

            DateTime time = new DateTime(2002, 1, 1);

            Post post = new Post("ddd", "Katana", "ddd", "Tag" , time);
            
            
        }
    }
}
