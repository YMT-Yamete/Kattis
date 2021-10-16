using System;

namespace Kattis
{
    class AddTwoNumbers
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(' ');
            int num1 = int.Parse(tokens[0]);
            int num2 = int.Parse(tokens[1]);
            Console.WriteLine(num1 + num2);
        }
    }
}
