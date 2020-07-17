using System;
using System.Collections.Generic;
using Bakery;

namespace Bakery {
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery");
      Console.WriteLine("Loaves of Bread are $5.00 each, buy two get one free!");
      Console.WriteLine("Pastries are $2.00 each, three for $5.00!");
      Console.WriteLine("How many Loaves of Bread would you like?");
      Bread inputBreadQuantity = new Bread(int.Parse(Console.ReadLine()));
      int outputBreadCost = inputBreadQuantity.SubtractBreadDiscount(inputBreadQuantity.AddBreadCost());
      Console.WriteLine("How many Pastries would you like?");
      Pastry inputPastryQuantity = new Pastry(int.Parse(Console.ReadLine()));
      int outputPastryCost = inputPastryQuantity.SubtractPastryDiscount(inputPastryQuantity.AddPastryCost());
      int outputTotalCost = outputPastryCost + outputBreadCost;
      Console.WriteLine(outputBreadCost);
      Console.WriteLine(outputPastryCost);
      Console.WriteLine(outputTotalCost);
    }
  }
}