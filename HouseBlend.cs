using System;

namespace Starbuzz
{
  public class HouseBlend : Beverage
  {
    public HouseBlend()
    {
      description = "House Blend";
    }
    public override double cost()
    {
      return .89;
    }
  }
}