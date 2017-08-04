using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsExercise.CreationalPatterns.Builder
{
    [TestClass]
    public class BuilderTest
    {
        [TestMethod]
        public void TestProduction()
        {
            var builder = new ConcreteBuilder();

            var foo = builder.BuildFoo();

            Assert.IsInstanceOfType(foo, typeof(Product));
            Assert.AreEqual<string>("Foo", foo.Name);
            Assert.AreEqual<int>(4, foo.Value);
            Assert.AreEqual<bool>(true, foo.Flag);
        }
    }
}
