using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Test
{
  [TestClass]
  public class Pastry.Test
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      PastrynewPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
  }
}