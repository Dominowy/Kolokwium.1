using System;
using System.ComponentModel;
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
            int wiek = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj Typ Konta(Rozliczeniowe lub Oszczędnościowe):");
            Enum.TryParse(Console.ReadLine(), out typKonta typkonta);

            switch (typkonta)
            {
                case typKonta.Oszczednosciowe:
                    break;
                case typKonta.Rozliczeniowe:
                    break;
                default:
                    break;
            }
            
            Console.WriteLine("Imie: {0} \n Nazwisko: {1} \n Wiek: {2} \n"
                ,imie, nazwisko, wiek);
            
            switch (typkonta)
            {
                case typKonta.Oszczednosciowe:
                    Console.WriteLine("Typ Konta: Oszczędnościowe\n");
                    break;
                case typKonta.Rozliczeniowe:
                    Console.WriteLine("Typ Konta: Rozliczeniowe\n");
                    break;
                default:
                    break;
            }
        }
        
        //zadanie2
        static void DowolnaParam(params string[] parametr)
        {
            if (parametr.Length % 2 == 1)
            {
                for (int i = 0; i < parametr.Length-1; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(parametr[i] + ":");
                    }
                    else if (i % 2 == 1)
                    {
                        Console.Write(parametr[i] + "\n");
                    }
                }
                Console.Write(parametr.Length + ".");
            }
            else if(parametr.Length % 2 == 0)
            {
                for (int i = 0; i < parametr.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(parametr[i] + ":");
                    }
                    else if (i % 2 == 1)
                    {
                        Console.Write(parametr[i] + "\n");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            //zadanie1 - test
            Console.WriteLine("Zadanie1");
            wczytaj();
            
            //zadanie2 - test
            
             Console.WriteLine("Zadanie2");
             Console.WriteLine("Parzyste");
             DowolnaParam("1","2","3","5","6","7");
             Console.WriteLine("Nieparzyste");
             DowolnaParam("1","2","3","5","6","7","8");
            
             //zadanie3 - test
            
             Console.WriteLine("Zadanie3");
             DateTime time = new DateTime(2002, 1, 1);
             DateTime time2 = new DateTime(1999, 1, 1);
             DateTime time3 = new DateTime(2013, 1, 1);
            
             Post post = new Post("", "Katana", "ddd", "Tag" , time);
             post.wypisz();
             Post post2 = new Post("ddd", "Katana", "ddd", "Tag" , time2);
             post2.wypisz();
             Post post3 = new Post("ddd", "Katana", "ddd", "Tag" , time3);
             post3.wypisz();
        }
    }
}
