using System;

namespace human
{
  public class Samurai : Human
  {
    public static int population = 0;
    public Samurai(string thisName) : base(thisName)
    {
      health = 200;
      population++;
    }
    public void DeathBlow(object subject)
    {
      if (subject is Human)
      {
        Human victim = subject as Human;
        if (victim.health < 50)
        {
          victim.health = 0;
        } else
        {
          this.Attack(victim);
        }
      }
    }
    public void Meditate()
    {
      this.health = 200;
    }
    public static int HowMany()
    {
      return population;
    }
  }
}