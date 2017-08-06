/// <summary>
/// The abstract prototype defines the base properties
/// The clone uses the base properties?
/// </summary>
namespace DesignPatternsExercise.CreationalPatterns.Prototype
{
    abstract class Prototype
    {
        public string String { get; set; } = "Prototype";
        public int Number { get; set; }
        public bool Flag { get; set; }

        public object Clone()
        {
            Prototype clone = (Prototype)this.MemberwiseClone();

            HandleClone(clone);

            return clone;
        }

        protected virtual void HandleClone(Prototype clone)
        {
        }
    }

    class Concrete : Prototype
    {
        protected override void HandleClone(Prototype clone)
        {
            base.HandleClone(clone);

            clone.String += "Clone";
        }
    }
}
