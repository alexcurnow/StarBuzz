using System;

namespace Starbuzz
{
  public class Whip : CondimentDecorator
  {
    Beverage beverage;
    public Whip(Beverage beverage)
    {
      this.beverage = beverage;
    }
    public override string getDescription()
    {
      return beverage.getDescription() + ", Whip";
    }
    public override double cost()
    {
      return beverage.cost() + .10;
    }
  }
}