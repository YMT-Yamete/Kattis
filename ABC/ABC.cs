using System;

namespace Kattis
{
    class ABC
    {
        static void Main(string[] args)
        {
            string[] inputStringNum = Console.ReadLine().Split(' ');
            int[] myInts = Array.ConvertAll(inputStringNum, s => int.Parse(s));

            string inputABC = Console.ReadLine();
            char[] charArray = inputABC.ToCharArray();

            int[] final = new int[3];

            Array.Sort(myInts);
            for (int i = 0; i < 3; i++)
            {
                if (charArray[i].Equals('A'))
                {
                    final[i] = myInts[0];
                }
                else if (charArray[i].Equals('B'))
                {
                    final[i] = myInts[1];
                }
                else
                {
                    final[i] = myInts[2];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (i != 2)
                {
                    Console.Write(final[i] + " ");
                }
                else
                {
                    Console.Write(final[i]);
                }
            }
        }
    }
}