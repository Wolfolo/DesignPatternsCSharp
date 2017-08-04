/// <summary>
/// The factory which produces books
/// </summary>
namespace DesignPatternsExercise.CreationalPatterns.AbstractFactory.Mocks
{
    class BookFactory : IAbstractFactory
    {
        public IProduct CreateProduct()
        {
            return new Book();
        }
    }
}
