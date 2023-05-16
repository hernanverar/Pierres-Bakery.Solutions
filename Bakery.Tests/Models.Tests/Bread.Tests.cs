using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void CalculationBread_OneBreadEqualsFive()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(5, newBread.CalculationBreadPrice());
    }
    [TestMethod]
    public void CalculationBread_ThreeBreadEqualsTen()
    {
      Bread newBread = new Bread(3);
      Assert.AreEqual(10, newBread.CalculationBreadPrice());
    }
  }
}