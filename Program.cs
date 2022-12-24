namespace Day13_GenericsProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics Problem");
            FindMaxNum.MaxValue(20, 50, 30);
            FindMaxNum.MaxValue(90.22f, 20.111f, 10.2f);
            FindMaxNum.MaxValue("Apple", "Peach", "Banana");
            Console.ReadLine();
        }
    }
}