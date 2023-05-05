using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Test
{
  [TestClass]
  public class PastryTest
  {
    [TestMethod]
    public void CalculationPastry_OnePastryEqualsTwo()
    {
      Pastry pastry = new Pastry(1);
      Assert.AreEqual(2, pastry.CalculationPastryPrice());
    }
  }
}