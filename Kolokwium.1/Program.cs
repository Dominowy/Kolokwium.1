using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
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
    public class Post
    {
        public string Autor { get; set; }
        public string Tytul { get; set; }
        public string Tresc { get; set; }
        public string[] Tagi{ get; set; }
        public DateTime Czas { get; set; }
        

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
            else if (string.IsNullOrEmpty(tagi[0]))
            {
                Console.WriteLine("Tablica jest pusta!");
            }
            Tytul = tytul;
            Autor = autor;
            Tresc = tresc;
            Tagi = tagi;
            Czas = czas;
        }
        public void wypisz()
        {
             Console.WriteLine("Tytul: {0} \n Autor: {1} \n Tresc: {2}\n Tagi: {3}\n Data: {4}"
               , Tytul, Autor, Tresc, Tagi[0], Czas);
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
            for (int i = 0; i < parametr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (parametr.Length == i+1)
                    {
                        Console.Write(parametr[i] + "."); 
                    }
                    else
                    {
                        Console.Write(parametr[i] + ":");
                    }
                }
                else
                {
                    Console.Write(parametr[i] + ",");
                }
            }
        }
        static void Main(string[] args)
        {
            //zadanie1 - test
            //Console.WriteLine("Zadanie1");
            //wczytaj();
            
            //zadanie2 - test
            
             // Console.WriteLine("Zadanie2\n");
             // Console.WriteLine("Parzyste\n");
             // DowolnaParam("1","2","3","5","6","7");
             // Console.WriteLine("\n");
             // Console.WriteLine("Nieparzyste\n");
             // DowolnaParam("1","2","3","5","6","7","8");
            
             //zadanie3 - test
            
             Console.WriteLine("Zadanie3");
             DateTime time = new DateTime(1999, 1, 1);
             DateTime time2 = new DateTime(2002, 1, 1);
             DateTime time3 = new DateTime(2013, 1, 1);
             
             string[] tab = new string[1] {""};
             string[] tab2 = new string[1]{"ddd"};
             
             //Post post = new Post("DDDD", "Katana", "ddd", tab , time);
             Post post2 = new Post("ddd", "Katana", "ddd", tab2 ,time2);
             
             post2.wypisz();

             //Post post3 = new Post("ddd", "Katana", "ddd", tab , time3);
        }
    }
}
