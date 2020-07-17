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
  }
}