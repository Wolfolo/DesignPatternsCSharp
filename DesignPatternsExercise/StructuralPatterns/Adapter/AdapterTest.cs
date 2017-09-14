using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsExercise.StructuralPatterns.Adapter
{
    [TestClass]
    public class AdapterTest
    {
        [TestMethod]
        public void TestScrewTwist()
        {
            IScrew adaptedScrew = new OneWayScrewAdapter(new ThirdParty.OneWayScrew());

            Assert.IsFalse(adaptedScrew.Twist(Direction.Clockwise));
            Assert.IsTrue(adaptedScrew.Twist(Direction.CounterClockwise));
        }
    }
}
