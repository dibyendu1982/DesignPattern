﻿using System;
using LazyInitializationLazyLoadPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LazyLoadPatternUnitTest
{
    [TestClass]
    public class LazyInitOrderShould
    {
        [TestMethod]
        public void PrintLabelWithBadOrder()
        {
            var order = new OrderBad();

            var result = order.PrintLabel();

            Assert.Fail("Null reference exception");
        }

        [TestMethod]
        public void PrintLabelWithGoodOrder()
        {
            var order = new OrderGood();

            var result = order.PrintLabel();

            Assert.AreEqual("Company Name\nDefault Address", result);
        }
    }
}
