using hemiphaga;

namespace PoW
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            foreach (var shape in ExternalDataProcessor.Process(ExternalDataProcessor.Receive()))
            {
                Console.WriteLine($"Figure: {shape.GetType().Name}");
                Console.WriteLine($"Area: {shape.CalculateArea()}");
                if (shape is Triangle)
                    Console.WriteLine($"Triangle is right: {(shape as Triangle).IsRight}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}