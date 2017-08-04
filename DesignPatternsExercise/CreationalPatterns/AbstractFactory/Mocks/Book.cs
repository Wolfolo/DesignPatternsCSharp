/// <summary>
/// A product of type "Book"
/// </summary>
namespace DesignPatternsExercise.CreationalPatterns.AbstractFactory.Mocks
{
    class Book : IProduct
    {
        public string GetDescription()
        {
            return "This product is a " + GetType();
        }
    }
}
