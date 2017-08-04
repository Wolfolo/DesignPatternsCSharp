/// <summary>
/// The factory which produces cars
/// </summary>
namespace DesignPatternsExercise.CreationalPatterns.AbstractFactory.Mocks
{
    class CarFactory : IAbstractFactory
    {
        public IProduct CreateProduct()
        {
            return new Car();
        }
    }
}
