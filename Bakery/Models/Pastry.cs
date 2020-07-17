using System;

namespace Bakery
{
  public class Pastry
  {
    public int PastryQuantity { get; }

    public Pastry(int pastryQuantity)
    {
      PastryQuantity = pastryQuantity;
    }
    public int AddPastryCost()
    {
      int pastryCost = 2 * PastryQuantity;
      return pastryCost;
    }
    public int SubtractPastryDiscount(int pastryCost)
    {
      int freePastryQuantity = (int)Math.Floor((decimal)PastryQuantity / 3);
      int freePastryCost = freePastryQuantity;
      int discountedPastryCost = pastryCost - freePastryCost;
      return discountedPastryCost;
    }
  }
}