using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using DesignPatternsExercise.StructuralPatterns.Facade.Mocks;

namespace DesignPatternsExercise.StructuralPatterns.Facade
{
    [TestClass]
    public class FacadeTests
    {
        [TestMethod]
        public void TestCakeA()
        {
            CakeFacade facade = new CakeFacade();

            List<string> log = facade.Make(false);

            List<string> expected = new List<string> {
                "Purchased the ingredients!",
                "Prepared the base!",
                "Put in the oven!",
                "Waiting...",
                "Decorated!",
                "Put in the fridge!",
                "Waiting...",
                "Packed for delivery!"
            };

            Assert.AreEqual(expected.Count, log.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], log[i]);
            }
        }

        [TestMethod]
        public void TestCakeB()
        {
            CakeFacade facade = new CakeFacade();

            List<string> log = facade.Make(true);

            List<string> expected = new List<string> {
                "Purchased the ingredients!",
                "Prepared the base!",
                "Decorated!",
                "Put in the oven!",
                "Waiting...",
                "Packed for delivery!"
            };

            Assert.AreEqual(expected.Count, log.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], log[i]);
            }
        }
    }
}
