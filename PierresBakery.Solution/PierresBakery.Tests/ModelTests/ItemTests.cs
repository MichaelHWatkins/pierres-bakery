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
    public void CheckBreadPrice_ReturnsPriceForQuantityOfBread_Int()
    {
      Assert.AreEqual(5, Bread.CheckBreadPrice(1));
      Assert.AreEqual(20, Bread.CheckBreadPrice(6));
    }
  }
}