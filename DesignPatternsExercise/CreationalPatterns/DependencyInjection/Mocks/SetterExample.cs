using System;

/// <summary>
/// Like the ConstructorExample class, this class demands the elaboration to an another class
/// Unlike the other class, this one allows the dependency to be changed after the creation, but adds an invalid object state as a downside
/// </summary>
namespace DesignPatternsExercise.CreationalPatterns.DependencyInjection.Mocks
{
    class SetterExample : IExample
    {
        public IDependency MyDependency { private get; set; }

        public string DoSomething()
        {
            if (MyDependency == null)
            {
                throw new InvalidOperationException("The dependency is missing");
            }

            return "Elaborated by " + MyDependency.Elaborate();
        }
    }
}
