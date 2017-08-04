using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternsExercise.CreationalPatterns.AbstractFactory;
using DesignPatternsExercise.CreationalPatterns.AbstractFactory.Mocks;
using System.Collections.Generic;

namespace DesignPatternsExercise
{
    [TestClass]
    public class AbstractFactoryTest
    {
        [TestMethod]
        public void TestProduction()
        {
            var factories = new Dictionary<Type, IAbstractFactory>();

            factories.Add(typeof(Book), new BookFactory());
            factories.Add(typeof(Car), new CarFactory());

            foreach (KeyValuePair<Type, IAbstractFactory> factory in factories)
            {
                /* The code is the same for every product, since the product are based on an interface and their creation is hidden */
                IProduct product = factory.Value.CreateProduct();

                Assert.IsInstanceOfType(product, factory.Key);
                Assert.AreEqual<string>("This product is a " + factory.Key, product.GetDescription());
            }
        }
    }
}
