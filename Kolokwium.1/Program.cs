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
        public string[] Tagi;
        public DateTime Czas;
        
        public Post(string tytul, string autor,string tresc, string[] tagi, DateTime czas)
        {
            DateTime time = new DateTime(2000, 1, 1);
            
            if (string.IsNullOrEmpty(tytul) || string.IsNullOrEmpty(autor) || string.IsNullOrEmpty(tresc))
            {
                Console.WriteLine("Czegoś Brakuje!!");
            }
            else if (time.Year - czas.Year >= 0)
            {
                Console.WriteLine("Za stara data utworzenia!!");
            }
            else if (tagi.Length == 0 || tagi == null)
            {
                Console.WriteLine("Tablica jest pusta!");
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
             Console.WriteLine("Tytul: {0} \n Autor: {1} \n Tresc: {2} \n tagi: {3} {4} \n Data: {5}"
                 , Tytul, Autor, Tresc, Tagi[0],Tagi[1], Czas);
             
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
                    Console.WriteLine("Brak typu konta");
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
            // //zadanie1 - test
            // Console.WriteLine("Zadanie1");
            // wczytaj();
            //
            // //zadanie2 - test
            //
            //  Console.WriteLine("Zadanie2");
            //  Console.WriteLine("Parzyste");
            //  DowolnaParam("1","2","3","5","6","7");
            //  Console.WriteLine("Nieparzyste");
            //  DowolnaParam("1","2","3","5","6","7","8");
            
             //zadanie3 - test
            
             Console.WriteLine("Zadanie3");
             DateTime time = new DateTime(2002, 1, 1);
             DateTime time2 = new DateTime(2002, 1, 1);
             DateTime time3 = new DateTime(2013, 1, 1);

             string[] tab = new string[2] {"dom", "dom2"};
             string[] tab2 = new string[2] {" "," "};
            
             Post post = new Post("DDDD", "Katana", "ddd", tab , time);
             post.wypisz();
             Post post2 = new Post("ddd", "Katana", "ddd", tab2 , time2);
             post2.wypisz();
             Post post3 = new Post("ddd", "Katana", "ddd", tab , time3);
             post3.wypisz();
        }
    }
}
