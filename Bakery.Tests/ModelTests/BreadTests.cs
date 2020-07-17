using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBreadClass_Bread()
    {
      Bread breadOrder = new Bread(3);
      Assert.AreEqual(typeof(Bread), breadOrder.GetType());
    }
    [TestMethod]
    public void GetBreadQuantity_ReturnsBreadQuantity_Int()
    {
      int breadQuantity = 3;
      Bread breadOrder = new Bread(3);
      int result = breadOrder.BreadQuantity;
      Assert.AreEqual(breadQuantity, result);
    }
    [TestMethod]
    public void AddBreadCost_ReturnBreadCost_Int()
    {
      Bread breadOrder = new Bread(3);
      Assert.AreEqual(15, breadOrder.AddBreadCost());
    }
    [TestMethod]
    public void SubtractBreadDiscount_ReturnBreadDiscount_Int()
    {
      Bread breadOrder = new Bread(3);
      Assert.AreEqual(5, breadOrder.SubtractBreadDiscount(15));
    }
  }
}