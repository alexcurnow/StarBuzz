using System;

namespace Starbuzz
{
  public abstract class CondimentDecorator : Beverage
  {
    public new abstract string getDescription();
  }
}