using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ComplexClassExample.Model;
using System.Collections.Generic;

namespace ComplexClassExample.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateItemWeightTest()
        {
            // step 1: arrangement
            Fruit testFruit = new Fruit("Banana", 2.0, 8);
            // step 2: action
            double result = ProduceUtils.GetItemWeight(testFruit);
            // step 3: assertion
            Assert.AreEqual(16.0, result);

        }

        [TestMethod]
        public void NameTest()
        {
            Vegetable v = new Vegetable("Carrot", 1.6, 19);
            v.Name = "";
            Assert.AreEqual("", v.Name);
        }

        [TestMethod]
        public void CalculateTotalWeightTest()
        {
            Fruit f1 = new Fruit("Apple", 2.0, 3);
            Fruit f2 = new Fruit("Watermelon", 20.0, 2);
            Vegetable v1 = new Vegetable("Pepper", 5.0, 6);
            var produces = new List<Produce>();
            produces.Add(f1);
            produces.Add(f2);
            produces.Add(v1);

            double result = ProduceUtils.GetTotalWeight(produces);

            Assert.AreEqual(76.0, result);

        }
    }
}
