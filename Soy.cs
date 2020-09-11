using System;

namespace Starbuzz
{
  public class Soy : CondimentDecorator
  {
    Beverage beverage;
    public Soy(Beverage beverage)
    {
      this.beverage = beverage;
    }
    public override string getDescription()
    {
      return beverage.getDescription() + ", Soy";
    }
    public override double cost()
    {
      return beverage.cost() + .15;
    }
  }
}