/// <summary>
/// Configurable base Builder which creates a product
/// </summary>
namespace DesignPatternsExercise.CreationalPatterns.Builder
{
    class Builder
    {
        string Name;
        int Value;
        bool Flag;

        public Product Build()
        {
            return new Product(Name, Value, Flag);
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetValue(int value)
        {
            Value = value;
        }

        public void SetFlag(bool flag)
        {
            Flag = flag;
        }
    }
}
