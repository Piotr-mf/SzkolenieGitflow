using System;
using BibliotekaWspolna;

namespace AplikacjaKonsolowa
{
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();

            Console.WriteLine("Hello World!");
            test.TestBibliotekiWspolnej();
            test.TestNowejFunkcjonalnosciPiotr();
            test.TestNowejFunkcjonalnościTomek();
        }
    }
}
