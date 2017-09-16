/// <summary>
/// A shape class with its own area and perimeter
/// </summary>
namespace DesignPatternsExercise.StructuralPatterns.Bridge.Mocks
{
    class Circle : IShape
    {
        public string Area()
        {
            return "Circle.Area";
        }

        public string Perimeter()
        {
            return "Circle.Perimeter";
        }
    }
}
