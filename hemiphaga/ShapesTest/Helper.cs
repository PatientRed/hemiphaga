using hemiphaga;

namespace ShapesTest
{
    internal static class Helper
    {
        internal static IShape Construct(string figure, double[] dimensions) => SimpleShapeFactory.Create(figure, dimensions);
    }
}
