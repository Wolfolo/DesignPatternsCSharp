using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Timers;

namespace DesignPatternsExercise.CreationalPatterns.ObjectPool
{
    [TestClass]
    public class ObjectPoolTest
    {
        [TestMethod]
        public void TestObjectCreated()
        {
            var pool = new ObjectPool();
            var obj1 = pool.GetObject();
            var obj2 = pool.GetObject();

            Assert.AreNotSame(obj1, obj2);
        }

        [TestMethod]
        public void TestObjectPooled()
        {
            var pool = new ObjectPool();
            var obj = pool.GetObject();

            pool.Release(obj);

            Assert.AreSame(obj, pool.GetObject());
        }

        [TestMethod]
        public void TestObjectRetrieved()
        {
            var pool = new ObjectPool();
            var obj = pool.GetObject();

            Assert.IsNull(obj.Property);

            obj.Property = "Some value";

            Assert.AreEqual("Some value", obj.Property);

            pool.Release(obj);

            obj = pool.GetObject();
            
            Assert.IsNull(obj.Property);
        }
    }
}
