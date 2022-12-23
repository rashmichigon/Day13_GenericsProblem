using System.IO;
using System;
namespace Day13_GenericsProgram
 {
        internal class Program
        {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics Problem");
            //UC1
            FindMaxNum.MaxValue(20, 50, 30);
            //UC2
            FindMaxNum.MaxValue(90.22f, 20.111f, 10.2f);
            //UC3
            FindMaxNum.MaxValue("Apple", "Peach", "Banana");
            //UC4
            GenericsFindMax<int> genericsFindMax = new GenericsFindMax<int>();
            int[] array = { 4, 3, 2, 1 };
            genericsFindMax.MaxVal(array);
            //UC5
            GenericsFindMax<int>.FindMaxValue(1, 2, 3);
        }
    }
}