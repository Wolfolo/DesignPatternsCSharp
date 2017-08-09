namespace DesignPatternsExercise.CreationalPatterns.DependencyInjection.Mocks
{
    class Dependency1 : IDependency
    {
        public string Elaborate()
        {
            return this.GetType().ToString();
        }
    }
}
