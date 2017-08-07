using System;

namespace human
{
  public class Ninja : Human
  {
    public Ninja(string thisName) : base(thisName)
    {
      dexterity = 175;
    }
    public void Steal(object thing)
    {
      this.Attack(thing);
      this.health += 10;
    }
    public void GetAway()
    {
      this.health -= 15;
    }
  }
}