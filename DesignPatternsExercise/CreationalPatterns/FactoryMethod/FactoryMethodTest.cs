using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternsExercise.CreationalPatterns.FactoryMethod.Mocks;

namespace DesignPatternsExercise.CreationalPatterns.FactoryMethod
{
    [TestClass]
    public class FactoryMethodTest
    {
        [TestMethod]
        public void TestProduction()
        {
            IFactoryMethod factory = new IncompleteFactory();

            Assert.IsInstanceOfType(factory.Build(ProductType.Foo), typeof(IProduct));
            Assert.IsInstanceOfType(factory.Build(ProductType.Bar), typeof(IProduct));
            Assert.IsInstanceOfType(factory.Build(ProductType.Foo), typeof(FooProduct));
            Assert.IsInstanceOfType(factory.Build(ProductType.Bar), typeof(BarProduct));

            try
            {
                factory.Build(ProductType.Baz);
            }
            catch(Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(NotImplementedException));
            }

            // Try again with a complete factory
            factory = new CompleteFactory();

            Assert.IsInstanceOfType(factory.Build(ProductType.Foo), typeof(IProduct));
            Assert.IsInstanceOfType(factory.Build(ProductType.Bar), typeof(IProduct));
            Assert.IsInstanceOfType(factory.Build(ProductType.Baz), typeof(IProduct));
            Assert.IsInstanceOfType(factory.Build(ProductType.Foo), typeof(FooProduct));
            Assert.IsInstanceOfType(factory.Build(ProductType.Bar), typeof(BarProduct));
            Assert.IsInstanceOfType(factory.Build(ProductType.Baz), typeof(BazProduct));
        }
    }
}
