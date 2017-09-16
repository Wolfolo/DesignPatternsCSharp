/// <summary>
/// The bridge interface helps in providing a fully decoupled architecture
/// </summary>
namespace DesignPatternsExercise.StructuralPatterns.Bridge
{
    interface IShape
    {
        string Area();
        string Perimeter();
    }
}
