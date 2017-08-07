using System;

namespace human
{
    public class Human
    {
        public string name;
        public int strength;
        public int intelligence;
        public int dexterity;
        public int health;
        public Human(string thisName){
            name = thisName;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }
        public Human(string thisName, int setStrength, int setIntelligence, int setDexterity, int setHealth)
        {
          name = thisName;
          strength = setStrength;
          intelligence = setIntelligence;
          dexterity = setDexterity;
          health = setHealth;
        }
        public void Attack(Object subject)
        {
          if (subject is Human)
          {
            Human victim = subject as Human;
            victim.health -= strength * 5;
          }
        }
        public void DisplayInfo()
        {
          Console.WriteLine($"Name: {this.name}");
          Console.WriteLine($"Strength: {this.strength}");
          Console.WriteLine($"Intelligence: {this.intelligence}");
          Console.WriteLine($"Dexterity: {this.dexterity}");
          Console.WriteLine($"Health: {this.health}");
        }
    }
}
