using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_GenericsProgram
{
    internal class FindMaxNum
    {
        //UC1
        public static void MaxValue(int first, int second, int third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("{0} is Maximum", first);
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("{0} is  Maximum", second);
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                Console.WriteLine("{0} is Maximum", third);
            }
            else
                Console.WriteLine("All The Numbers Are Equal");
        }
        //UC2
        public static void MaxValue(float first, float second, float third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("{0} is Maximum", first);
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("{0} is  Maximum", second);
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                Console.WriteLine("{0} is Maximum", third);
            }
            else
                Console.WriteLine("All The Numbers Are Equal");
        }
        //UC3
        public static void MaxValue(string first, string second, string third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine($"{first} is greater");
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine($"{second} is greater");
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                Console.WriteLine($"{third} is greater");
            }
            else
                Console.WriteLine("All The Numbers are Equal");
        }
    }
}

