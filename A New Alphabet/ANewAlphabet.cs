using System;

namespace A_New_Alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.ToLower();
            input = input.Replace("a", "@");
            input = input.Replace("b", "8");
            input = input.Replace("c", "(");
            input = input.Replace("d", "|)");
            input = input.Replace("e", "3");
            input = input.Replace("f", "#");
            input = input.Replace("g", "6");
            input = input.Replace("h", "[-]");
            input = input.Replace("i", "|");
            input = input.Replace("j", "_|");
            input = input.Replace("k", "|<");
            input = input.Replace("l", "1");
            input = input.Replace("m", "[]\\/[]");
            input = input.Replace("n", "[]\\[]");
            input = input.Replace("o", "0");
            input = input.Replace("p", "|D");
            input = input.Replace("q", "(,)");
            input = input.Replace("r", "|Z");
            input = input.Replace("s", "$");
            input = input.Replace("t", "']['");
            input = input.Replace("u", "|_|");
            input = input.Replace("v", "\\/");
            input = input.Replace("w", "\\/\\/");
            input = input.Replace("x", "}{");
            input = input.Replace("y", "`/");
            input = input.Replace("z", "2");
            Console.WriteLine(input);
        }
    }
}
