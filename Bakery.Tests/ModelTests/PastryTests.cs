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
      Pastry pastryOrder = new Pastry();
      Assert.AreEqual(typeof(Pastry), pastryOrder.GetType());
    }
    [TestMethod]
    public void GetPastryQuantity_ReturnsPastryQuantity_Int()
    {
      int pastryQuantity = 1;
      Pastry pastryOrder = new Pastry();
      int result = pastryOrder.PastryQuantity;
      Assert.AreEqual(pastryQuantity, result);
    }
  }
}