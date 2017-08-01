using System;

namespace human
{
    class Human
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
    }
}
