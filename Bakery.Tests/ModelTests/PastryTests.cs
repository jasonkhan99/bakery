using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastryClass_Pastry()
    {
      Pastry pastryOrder = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), pastryOrder.GetType());
    }
    [TestMethod]
    public void GetPastryQuantity_ReturnsPastryQuantity_Int()
    {
      int pastryQuantity = 1;
      Pastry pastryOrder = new Pastry(1);
      int result = pastryOrder.PastryQuantity;
      Assert.AreEqual(pastryQuantity, result);
    }
  }
}