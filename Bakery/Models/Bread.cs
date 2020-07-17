using System;

namespace Bakery
{
  public class Bread
  {
    public int BreadQuantity { get; }

    public Bread(int breadQuantity)
    {
      BreadQuantity = breadQuantity;
    }

    public int AddBreadCost()
    {
      int breadCost = 5 * BreadQuantity;
      return breadCost;
    }
    public int SubtractBreadDiscount(int breadCost)
    {
      int freeBreadQuantity = (int)Math.Floor((decimal)BreadQuantity / 3);
      int freeBreadCost = freeBreadQuantity * 5;
      int discountedBreadCost = breadCost - freeBreadCost;
      return discountedBreadCost;
    }
  }
}