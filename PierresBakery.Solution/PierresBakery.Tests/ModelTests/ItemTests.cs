using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresBakery.Models;
using System;

namespace PierresBakery.TestTools
{
  [TestClass]
  public class BreadTests 
  {
    [TestMethod]

    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread bread = new Bread(1);
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }
    [TestMethod]
    public void CheckBreadPrice_ReturnsPriceForQuantityOfBread_Int()
    {
      Bread bread = new Bread(1);
      Assert.AreEqual(5, Bread.CheckBreadPrice(bread));
    }

    [TestMethod]
    public void CheckBreadPrice_ReturnsPriceForQuantityOfBreadWithDiscount_Int()
    {
      Bread bread = new Bread(6);
      Assert.AreEqual(20, Bread.CheckBreadPrice(bread));
    }

  }

  [TestClass]
  public class PastryTests 
  {

    [TestMethod]
    public void CheckPastryPrice_ReturnsPriceForQuantityOfPrice_Int()
    {
      Pastry pastry = new Pastry(1);
      Assert.AreEqual(2, Pastry.CheckPastryPrice(pastry));
    }

    [TestMethod]
    public void CheckPastryPrice_ReturnsPriceForQuantityOfPriceWithDiscount_Int()
    {
      Pastry pastry = new Pastry(7);
      Assert.AreEqual(12, Pastry.CheckPastryPrice(pastry));
    }

    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry pastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), pastry.GetType());
    }
  }

}