/// <summary>
/// A third party class with an obscure implementation which we need to use in our application
/// </summary>
namespace DesignPatternsExercise.StructuralPatterns.Adapter.ThirdParty
{
    class OneWayScrew
    {
        public int Direction { get; set; }

        public bool Twist()
        {
            return Direction < 0;
        }
    }
}
