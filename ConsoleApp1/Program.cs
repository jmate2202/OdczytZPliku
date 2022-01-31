using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            A obiekt = new A("a");
            obiekt.Witaj("b");

        }
    }
    public class A
    {
        public A()
        {
            Console.WriteLine("witaj");
        }
        public A(string imie)
        {
            Console.WriteLine("witaj 2");
        }
        public void Witaj(string imie)
        {
            Console.WriteLine("witaj 3");
        }
    }
}
