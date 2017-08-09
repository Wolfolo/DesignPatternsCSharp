namespace DesignPatternsExercise.CreationalPatterns.DependencyInjection.Mocks
{
    class Dependency2 : IDependency
    {
        public string Elaborate()
        {
            return this.GetType().ToString();
        }
    }
}
