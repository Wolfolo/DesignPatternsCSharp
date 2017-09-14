using DesignPatternsExercise.StructuralPatterns.Adapter.ThirdParty;

/// <summary>
/// The adapter retrofits the implementation to work with the third party class
/// </summary>
namespace DesignPatternsExercise.StructuralPatterns.Adapter
{
    class OneWayScrewAdapter : IScrew
    {
        private OneWayScrew screw;

        public OneWayScrewAdapter(OneWayScrew screw)
        {
            this.screw = screw;
        }

        public bool Twist(Direction direction)
        {
            this.screw.Direction = (int)direction;

            return this.screw.Twist();
        }
    }
}
