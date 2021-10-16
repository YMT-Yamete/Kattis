using System;
using System.Collections.Generic;
namespace ACM_Contest_Scoring
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> time = new List<int>();
            List<string> problemNum = new List<string>();
            List<string> result = new List<string>();
            int inputCount = 0;
            int right = 0;
            int totalTime = 0;
            string userInput = Console.ReadLine();

            while (userInput != "-1")
            {
                inputCount++;
                string[] userInputSplit = userInput.Split(" ");
                time.Add(int.Parse(userInputSplit[0]));
                problemNum.Add(userInputSplit[1]);
                result.Add(userInputSplit[2]);
                userInput = Console.ReadLine();

                if (userInputSplit[2] == "right")
                {
                    right++;
                    totalTime = totalTime + int.Parse(userInputSplit[0]);

                    for (int i = 0; i < inputCount - 1; i++)
                    {
                        if (userInputSplit[1] == problemNum[i])
                        {
                            totalTime = totalTime + 20;
                        }
                    }
                }
            }
            Console.WriteLine(right + " " + totalTime);
        }
    }
}
