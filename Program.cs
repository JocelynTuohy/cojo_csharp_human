using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human amanda = new Human("Amanda");
            Human freya = new Human("Freya", 4, 5, 3, 80);
            amanda.Attack(freya);
            freya.Attack(amanda);
            amanda.Attack("string");
            Console.WriteLine("Amanda's health is currently {0} and Freya's health is currently {1}", amanda.health, freya.health);
        }
    }
}
