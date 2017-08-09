/// <summary>
/// This class demands the elaboration to an another class
/// </summary>
namespace DesignPatternsExercise.CreationalPatterns.DependencyInjection.Mocks
{
    class ConstructorExample : IExample
    {
        private IDependency myDependency;

        public ConstructorExample(IDependency dep)
        {
            myDependency = dep;
        }

        public string DoSomething()
        {
            return "Elaborated by " + myDependency.Elaborate();
        }
    }
}
