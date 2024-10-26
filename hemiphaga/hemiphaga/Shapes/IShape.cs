namespace hemiphaga
{
    public interface IShape
    {
        public double Area { get; }
    }

    //ISP-drived overengineering
    public interface ICreatable<T>
    {
        public static abstract T Create(params double[] input);
    }
}
