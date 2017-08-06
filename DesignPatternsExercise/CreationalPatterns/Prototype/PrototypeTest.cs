using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsExercise.CreationalPatterns.Prototype
{
    [TestClass]
    public class PrototypeTest
    {
        [TestMethod]
        public void TestCreationFromPrototype()
        {
            // Configure the prototype
            var prototype = new Concrete();
            prototype.Number = 4;
            prototype.Flag = true;

            // Clone it
            var clone = (Concrete)prototype.Clone();

            Assert.AreEqual("Prototype", prototype.String);
            Assert.AreEqual("PrototypeClone", clone.String);
            Assert.AreEqual(prototype.Number, clone.Number);
            Assert.AreEqual(prototype.Flag, clone.Flag);
        }
    }
}
