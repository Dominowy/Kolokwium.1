using System;
using System.Threading;

namespace Kolokwium._1
{
    class Post
    {
        public string Autor;
        public string Tytul;
        public string Tresc;
        public string Tagi;
        
        public Post(string tytul, string autor,string tresc, string tagi)
        {
            Tytul = tytul;
            Autor = autor;
            Tresc = tresc;
            Tagi = tagi;

        }
    }
    
    class Program
    {
        static void wczytaj(string imie, string nazwisko, int wiek)
        {
            Console.WriteLine("Imie: {0} \n Nazwisko: {1} \n Wiek: {2}"
                , imie, nazwisko, wiek);
        }
        
        static void Main(string[] args)
        {
            wczytaj("Dominik", "Katana", 20);
        }
    }
}
