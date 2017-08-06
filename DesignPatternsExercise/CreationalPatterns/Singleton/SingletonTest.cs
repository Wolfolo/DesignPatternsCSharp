using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;
using System.Threading;

namespace DesignPatternsExercise.CreationalPatterns.Singleton
{
    [TestClass]
    public class SingletonTest
    {
        [TestMethod]
        public void TestCannotInstanceWithNew()
        {
            ConstructorInfo[] constructors = typeof(Singleton).GetConstructors();

            Assert.IsTrue(constructors.Length == 0);
        }

        [TestMethod]
        public void TestIsSameInstance()
        {
            var instance = Singleton.Instance();
            var newInstance = Singleton.Instance();

            Assert.AreSame(instance, newInstance);
        }

        [TestMethod]
        public void TestChangeValue()
        {
            var instance = Singleton.Instance();
            var newInstance = Singleton.Instance();

            instance.Value = 4;

            Assert.AreEqual(instance.Value, newInstance.Value);
        }
    }
}
