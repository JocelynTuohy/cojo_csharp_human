using System;

namespace human
{
  public class Wizard : Human
  {
    public Wizard(string thisName) : base(thisName)
    {
      intelligence = 25;
      health = 50;
    }
    public void Heal()
    {
      this.health += 10 * this.intelligence;
    }
    public void Fireball(Object subject)
    {
      if (subject is Human)
      {
        Human victim = subject as Human;
        Random rand = new Random();
        victim.health -= rand.Next(20,51);
      }
    }
  }
}