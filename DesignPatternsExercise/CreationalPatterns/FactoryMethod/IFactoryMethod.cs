/// <summary>
/// Provides a common interface for different factories and defines which products can be built.
/// Some products may not be available in all the factories.
/// </summary>
namespace DesignPatternsExercise.CreationalPatterns.FactoryMethod
{
    enum ProductType
    {
        Foo,
        Bar,
        Baz,
    }

    interface IFactoryMethod
    {
        IProduct Build(ProductType type);
    }
}
