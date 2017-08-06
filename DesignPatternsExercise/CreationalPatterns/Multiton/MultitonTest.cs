using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternsExercise.CreationalPatterns.Multiton
{
    [TestClass]
    public class MultitonTest
    {
        [TestMethod]
        public void TestGetSameNamedInstance()
        {
            var multiton = new Multiton();

            var first = multiton.GetInstanceOf(Multiton.Types.Class1);
            var second = multiton.GetInstanceOf(Multiton.Types.Class1);

            Assert.AreSame(first, second);
        }

        [TestMethod]
        public void TestDifferentInstance()
        {
            var multiton = new Multiton();

            var first = multiton.GetInstanceOf(Multiton.Types.Class1);
            var second = multiton.GetInstanceOf(Multiton.Types.Class2);

            Assert.AreNotSame(first, second);
        }

        [TestMethod]
        public void TestGetSameNamedInstanceFromDifferentMultiton()
        {
            var multiton1 = new Multiton();
            var multiton2 = new Multiton();

            var first = multiton1.GetInstanceOf(Multiton.Types.Class1);
            var second = multiton2.GetInstanceOf(Multiton.Types.Class1);

            Assert.AreNotSame(first, second);
        }
    }
}
