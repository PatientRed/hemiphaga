namespace hemiphaga.Tests
{
    internal static class Helper
    {
        internal static IShape Construct(string figure, double[] dimensions) => SimpleShapeFactory.Create(figure, dimensions);

        //TODO: use some algo (Heap's?) & generalize
        internal static IEnumerable<double[]> PermutationsThree(double[] dimensions)
        {
            yield return dimensions;
            yield return [dimensions[0], dimensions[2], dimensions[1]];
            yield return [dimensions[1], dimensions[0], dimensions[2]];
            yield return [dimensions[1], dimensions[2], dimensions[0]];
            yield return [dimensions[2], dimensions[1], dimensions[0]];
            yield return [dimensions[2], dimensions[0], dimensions[1]];
        }
    }
}
