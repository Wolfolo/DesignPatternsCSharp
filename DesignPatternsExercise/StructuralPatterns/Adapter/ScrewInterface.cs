/// <summary>
/// The current Screw interface we want to use in the application
/// </summary>
namespace DesignPatternsExercise.StructuralPatterns.Adapter
{
    public enum Direction
    {
        CounterClockwise = -1,
        Clockwise = 1,
    }

    interface IScrew
    {
        bool Twist(Direction direction);
    }
}
