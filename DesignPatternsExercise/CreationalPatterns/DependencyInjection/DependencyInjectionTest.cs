using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatternsExercise.CreationalPatterns.DependencyInjection.Mocks;

namespace DesignPatternsExercise.CreationalPatterns.DependencyInjection
{
    [TestClass]
    public class DependencyInjectionTest
    {
        [TestMethod]
        public void TestConstructorDependencyOutput()
        {
            IExample obj = new ConstructorExample(new Dependency1());

            Assert.AreEqual("Elaborated by " + typeof(Dependency1), obj.DoSomething());
        }

        [TestMethod]
        public void TestSetterDependencyThrowsExceptionWithoutDependency()
        {
            IExample obj = new SetterExample();

            try
            {
                obj.DoSomething();

                Assert.Fail();
            }
            catch(InvalidOperationException)
            {
            }
        }

        [TestMethod]
        public void TestSetterDependencyChangeDependencyOutput()
        {
            IExample obj = new SetterExample();

            ((SetterExample)obj).MyDependency = new Dependency1();

            Assert.AreEqual("Elaborated by " + typeof(Dependency1), obj.DoSomething());

            ((SetterExample)obj).MyDependency = new Dependency2();

            Assert.AreEqual("Elaborated by " + typeof(Dependency2), obj.DoSomething());
        }

        [TestMethod]
        public void TestInjector()
        {
            var injector = new Injector();

            Assert.AreEqual("Elaborated by " + typeof(Dependency1), injector.GetExample(Examples.ConstructorWithDependency1).DoSomething());
            Assert.AreEqual("Elaborated by " + typeof(Dependency2), injector.GetExample(Examples.ConstructorWithDependency2).DoSomething());
            Assert.AreEqual("Elaborated by " + typeof(Dependency1), injector.GetExample(Examples.SetterWithDependency1).DoSomething());
            Assert.AreEqual("Elaborated by " + typeof(Dependency2), injector.GetExample(Examples.SetterWithDependency2).DoSomething());
        }
    }
}
