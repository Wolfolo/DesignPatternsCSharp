using System;

/// <summary>
/// Build different products based on input.
/// </summary>
namespace DesignPatternsExercise.CreationalPatterns.FactoryMethod.Mocks
{
    class CompleteFactory : IFactoryMethod
    {
        public IProduct Build(ProductType type)
        {
            switch (type)
            {
                case ProductType.Foo:
                    return new FooProduct();
                case ProductType.Bar:
                    return new BarProduct();
                case ProductType.Baz:
                    return new BazProduct();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
