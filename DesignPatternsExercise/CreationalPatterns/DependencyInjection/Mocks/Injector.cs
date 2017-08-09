using System;

/// <summary>
/// The injector hides the construction of the objects and their dependencies to the client class
/// </summary>
namespace DesignPatternsExercise.CreationalPatterns.DependencyInjection.Mocks
{
    enum Examples
    {
        ConstructorWithDependency1,
        ConstructorWithDependency2,
        SetterWithDependency1,
        SetterWithDependency2,
    }

    class Injector
    {
        public IExample GetExample(Examples example)
        {
            switch (example)
            {
                case Examples.ConstructorWithDependency1:
                    return new ConstructorExample(new Dependency1());

                case Examples.ConstructorWithDependency2:
                    return new ConstructorExample(new Dependency2());

                case Examples.SetterWithDependency1:
                    return new SetterExample()
                    {
                        MyDependency = new Dependency1()
                    };

                case Examples.SetterWithDependency2:
                    return new SetterExample()
                    {
                        MyDependency = new Dependency2()
                    };

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
