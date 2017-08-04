/// <summary>
/// A custom product
/// </summary>
namespace DesignPatternsExercise.CreationalPatterns.Builder
{
    class Product
    {
        public string Name { get; private set; }
        public int Value { get; private set; }
        public bool Flag { get; private set; }

        public Product(string name, int value, bool flag)
        {
            Name = name;
            Value = value;
            Flag = flag;
        }
    }
}
