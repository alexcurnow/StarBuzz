using System;

namespace Starbuzz
{
  public abstract class Beverage
  {
    public string description = "unknown beverage";
    public string getDescription()
    {
      return description;
    }

    public abstract double cost();
  }
}