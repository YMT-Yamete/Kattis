using System;

namespace Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(' ');
            int num1 = int.Parse(a[0]);
            int num2 = int.Parse(a[1]);
            Console.WriteLine(num1 + num2);
        }
    }
}
