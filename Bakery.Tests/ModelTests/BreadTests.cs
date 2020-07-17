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
      Bread breadOrder = new Bread(1);
      Assert.AreEqual(typeof(Bread), breadOrder.GetType());
    }
    [TestMethod]
    public void GetBreadQuantity_ReturnsBreadQuantity_Int()
    {
      int breadQuantity = 1;
      Bread breadOrder = new Bread(1);
      int result = breadOrder.BreadQuantity;
      Assert.AreEqual(breadQuantity, result);
    }
    [TestMethod]
    public void AddBreadCost_ReturnBreadCost_Int()
    {
      Bread breadOrder = new Bread(1);
      Assert.AreEqual(5, breadOrder.AddBreadCost());
    }
  }
}