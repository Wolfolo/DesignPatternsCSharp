/// <summary>
/// The Bridge pattern differs from the Adapter pattern in the ability to use the same Bridge for multiple classes sharing the same interface,
/// while the Adapter is usually tightly coupled to a specific class.
/// The Bridge implements its own interface and this allows to chain multiple bridges and change them indipendently.
/// </summary>
namespace DesignPatternsExercise.StructuralPatterns.Bridge.Mocks
{
    class AbstractShape : IBridge
    {
        IShape shape;

        public AbstractShape(IShape shape)
        {
            this.shape = shape;
        }

        public string GetShapeArea()
        {
            return this.shape.Area();
        }

        public string GetShapePerimeter()
        {
            return this.shape.Perimeter();
        }
    }
}
