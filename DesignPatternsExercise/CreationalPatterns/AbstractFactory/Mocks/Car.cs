/// <summary>
/// A product of type "Car"
/// </summary>
namespace DesignPatternsExercise.CreationalPatterns.AbstractFactory.Mocks
{
    class Car : IProduct
    {
        public string GetDescription()
        {
            return "This product is a " + GetType();
        }
    }
}
