using System;

namespace AlphabetSpam
{
    class AplhabetSpam
    {
        static void Main(string[] args)
        {
            float whitespace = 0.0f;
            float lower = 0.0f;
            float upper = 0.0f;
            float symbol = 0.0f;

            string inputString = Console.ReadLine();
            char[] inputChar = inputString.ToCharArray();

            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputChar[i] == '_')
                {
                    whitespace++;
                }
                else if (Char.IsLower(inputChar[i]))
                {
                    lower++;
                }
                else if (Char.IsUpper(inputChar[i]))
                {
                    upper++;
                }
                else
                {
                    symbol++;
                }
            }
            Console.WriteLine(whitespace / inputString.Length);
            Console.WriteLine(lower / inputString.Length);
            Console.WriteLine(upper / inputString.Length);
            Console.WriteLine(symbol / inputString.Length);
        }
    }
}
