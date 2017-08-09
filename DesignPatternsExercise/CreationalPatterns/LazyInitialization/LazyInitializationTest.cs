using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsExercise.CreationalPatterns.LazyInitialization
{
    [TestClass]
    public class LazyInitializationTest
    {
        [TestCleanup]
        public void Cleanup()
        {
            /* Cleanup the static object which will preserve his state globally between tests */
            Product._Cleanup();
        }

        [TestMethod]
        public void TestNoProductsAtStart()
        {
            Assert.AreEqual(0, Product.GetProducts().Count);
        }

        [TestMethod]
        public void TestProductCreation()
        {
            Assert.AreEqual("foo", Product.GetProduct("foo").Name);
            Assert.AreEqual("bar", Product.GetProduct("bar").Name);
            Assert.AreEqual(2, Product.GetProducts().Count);
        }

        [TestMethod]
        public void TestRequestingSameProduct()
        {
            var first = Product.GetProduct("foo");
            var second = Product.GetProduct("foo");

            Assert.AreSame(first, second);
            Assert.AreEqual(1, Product.GetProducts().Count);
        }
    }
}
