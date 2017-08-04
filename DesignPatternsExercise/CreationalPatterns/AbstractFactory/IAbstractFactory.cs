/// <summary>
/// Provides a common interface for the different factories
/// </summary>
namespace DesignPatternsExercise.CreationalPatterns.AbstractFactory
{
    interface IAbstractFactory
    {
        IProduct CreateProduct();
    }
}
