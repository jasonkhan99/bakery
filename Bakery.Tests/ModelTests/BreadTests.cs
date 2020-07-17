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
      Bread breadOrder = new Bread();
      Assert.AreEqual(typeof(Bread), breadOrder.GetType());
    }
    [TestMethod]
    public void GetBreadQuantity_ReturnsBreadQuantity_Int()
    {
      int breadQuantity = 1;
      Bread breadOrder = new Bread(breadQuantity);
      int result = breadOrder.breadQuantity;
      Assert.AreEqual(breadQuantity, result);
    }
  }
}