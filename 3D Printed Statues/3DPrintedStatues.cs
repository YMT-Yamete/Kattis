using System;

namespace _3D_Printed_Statues
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = 0;
            int printer = 1;
            int statues = Convert.ToInt32(Console.ReadLine());
            if (statues == 1)
            {
                Console.WriteLine(1);
            }
            else if (statues == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                while (printer < statues)
                {
                    printer = printer * 2;
                    day++;
                }
                Console.WriteLine(day + 1);
            }
        }
    }
}
