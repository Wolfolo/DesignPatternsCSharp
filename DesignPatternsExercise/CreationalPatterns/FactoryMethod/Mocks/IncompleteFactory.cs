using System;

/// <summary>
/// Build different products based on input.
/// </summary>
namespace DesignPatternsExercise.CreationalPatterns.FactoryMethod.Mocks
{
    class IncompleteFactory : IFactoryMethod
    {
        public IProduct Build(ProductType type)
        {
            switch (type)
            {
                case ProductType.Foo:
                    return new FooProduct();
                case ProductType.Bar:
                    return new BarProduct();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
