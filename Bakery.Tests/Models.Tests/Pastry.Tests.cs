using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void CalculationPastry_OnePastryEqualsTwo()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(2, newPastry.CalculationPastryPrice());
    }
    [TestMethod]
    public void CalculationPastry_FourPastryEqualsSeven()
    {
      Pastry newPastry = new Pastry(4);
      Assert.AreEqual(7, newPastry.CalculationPastryPrice());
    }  
    [TestMethod]
    public void CalculationPastry_FivePastryEqualsNine()
    {
      Pastry newPastry = new Pastry(5);
      Assert.AreEqual(9, newPastry.CalculationPastryPrice());
    } 
  }
}