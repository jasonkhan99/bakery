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
  }
}