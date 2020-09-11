using System;

namespace Starbuzz
{
  public class SteamedMilk : CondimentDecorator
  {
    Beverage beverage;
    public SteamedMilk(Beverage beverage)
    {
      this.beverage = beverage;
    }
    public override string getDescription()
    {
      return beverage.getDescription() + ", Steamed Milk";
    }
    public override double cost()
    {
      return beverage.cost() + .10;
    }
  }
}