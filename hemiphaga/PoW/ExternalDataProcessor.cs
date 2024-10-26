using hemiphaga;
using System.Globalization;

namespace PoW
{
    internal static class ExternalDataProcessor
    {
        public static IEnumerable<string> Receive() => File.ReadLines("TestData.csv");


        public static IEnumerable<IShape> Process(IEnumerable<string> input) =>
            input.Select(line => line.Split(','))
                 .Select(args => new KeyValuePair<string, double[]>(args[0],
                                                                   new ArraySegment<string>(args, 1, args.Length - 1)
                                                                        .Select(arg => double.Parse(arg, CultureInfo.InvariantCulture))
                                                                        .ToArray()))
                 .Select(shape => SimpleShapeFactory.Create(shape.Key, shape.Value));
    }
}
