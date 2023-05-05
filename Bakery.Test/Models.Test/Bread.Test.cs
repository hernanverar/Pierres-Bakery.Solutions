using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Test
{
  [TestClass]
  public class BreadTest
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
    [TestMethod]
    public void CalculationBread_FourBreadEqualsFifteen()
    {
      Bread newBread = new Bread(4);
      Assert.AreEqual(15, newBread.CalculationBreadPrice());
    }
  }
}