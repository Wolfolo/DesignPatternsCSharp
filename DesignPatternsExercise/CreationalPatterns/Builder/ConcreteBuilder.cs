/// <summary>
/// Uses the builder to build a Product with pre-defined properties
/// </summary>
namespace DesignPatternsExercise.CreationalPatterns.Builder
{
    class ConcreteBuilder
    {
        public Product BuildFoo()
        {
            Builder builder = new Builder();

            builder.SetName("Foo");
            builder.SetValue(4);
            builder.SetFlag(true);

            return builder.Build();
        }
    }
}
