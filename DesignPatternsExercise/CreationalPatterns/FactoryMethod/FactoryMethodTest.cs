using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternsExercise.CreationalPatterns.FactoryMethod.Mocks;
using System.Collections.Generic;

namespace DesignPatternsExercise.CreationalPatterns.FactoryMethod
{
    [TestClass]
    public class FactoryMethodTest
    {
        private Dictionary<ProductType, Type> ProductionProvider()
        {
            var products = new Dictionary<ProductType, Type>();

            products.Add(ProductType.Foo, typeof(FooProduct));
            products.Add(ProductType.Bar, typeof(BarProduct));
            products.Add(ProductType.Baz, typeof(BazProduct));

            return products;
        }

        [TestMethod]
        public void TestFactoryProducesProducts()
        {
            var factory = new CompleteFactory();

            foreach (var product in ProductionProvider())
            {
                Assert.IsInstanceOfType(factory.Build(product.Key), typeof(IProduct));
                Assert.IsInstanceOfType(factory.Build(product.Key), product.Value);
            }
        }

        [TestMethod]
        public void TestIncompleteFactoryThrowsException()
        {
            IFactoryMethod factory = new IncompleteFactory();

            try
            {
                foreach (var product in ProductionProvider())
                {
                    Assert.IsInstanceOfType(factory.Build(product.Key), typeof(IProduct));
                    Assert.IsInstanceOfType(factory.Build(product.Key), product.Value);
                }

                // Must not get here
                Assert.Fail();
            }
            catch(Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(NotImplementedException));
            }
        }
    }
}
