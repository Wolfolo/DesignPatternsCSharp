/// <summary>
/// A shape class with its own area and perimeter
/// </summary>
namespace DesignPatternsExercise.StructuralPatterns.Bridge.Mocks
{
    class Square : IShape
    {
        public string Area()
        {
            return "Square.Area";
        }

        public string Perimeter()
        {
            return "Square.Perimeter";
        }
    }
}
