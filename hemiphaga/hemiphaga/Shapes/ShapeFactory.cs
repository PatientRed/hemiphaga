using System.Reflection;

namespace hemiphaga
{
    public static class SimpleShapeFactory
    {
        private static readonly Dictionary<string, Func<double[], IShape>> _shapes;

        public static IShape Create(string type, double[] values) => _shapes[type](values);

        static SimpleShapeFactory()
        {
            _shapes = AppDomain.CurrentDomain.GetAssemblies().SelectMany(assembly => assembly.GetTypes())
                                                                                             .Where(type => type.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(ICreatableShape<>)))
                                                                                             .Select(type => new KeyValuePair<string, Func<double[], IShape>>(type.Name,
                                                                                                (double[] input) => (IShape)type.GetMethod(nameof(ICreatableShape<Circle>.Create), BindingFlags.Static | BindingFlags.Public)! //not null since type is ICreatableShape<>
                                                                                                                                .Invoke(null, [input])!)) //not null since .Create() anyway returns IShape
                                                                                             .ToDictionary(StringComparer.OrdinalIgnoreCase);
        }
    }
}
