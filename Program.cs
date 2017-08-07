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
            Console.WriteLine("Amanda's health is currently {0} and Freya's health is currently {1}", amanda.health, freya.health);

            Wizard conor = new Wizard("Conor");
            Ninja courtney = new Ninja("Courtney");
            Samurai erik = new Samurai("Erik");
            conor.DisplayInfo();
            Console.WriteLine("");
            courtney.DisplayInfo();
            Console.WriteLine("");
            erik.DisplayInfo();
            Console.WriteLine("");
            conor.Heal();
            conor.Fireball(courtney);
            courtney.Steal(erik);
            courtney.GetAway();
            erik.DeathBlow(conor);
            conor.DisplayInfo();
            courtney.DisplayInfo();
            erik.DisplayInfo();
            erik.Meditate();
            erik.DisplayInfo();
            Samurai jocelyn = new Samurai("Jocelyn");
            Console.WriteLine("There are " + Samurai.HowMany() + " samurai here.");
        }
    }
}
