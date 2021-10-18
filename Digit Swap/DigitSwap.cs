using System;
using System.Collections.Generic;
namespace Digit_Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> numbers = new List<char>();
            string input = Console.ReadLine();
            numbers.Add(input.ToCharArray()[0]);
            numbers.Add(input.ToCharArray()[1]);
            Console.Write(numbers[1]);
            Console.Write(numbers[0]);
        }
    }
}
