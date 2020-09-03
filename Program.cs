using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[4] { 1, 2, 3, 4 };
            for (int i = 0; i < nums.Length; i++) {
                Console.WriteLine(nums[i]);
            }

            int[][] nums3 = new int[3][];
            nums3[0] = new int[2] { 1, 2 };
            nums3[1] = new int[3] { 1, 2, 3 };
            nums3[2] = new int[4] { 1, 2, 5, 6 };
            for (int j = 0; j < nums3.Length; j++)
            {
                for (int d = 0; d < nums3[j].Length; d++)
                {
                    Console.Write($"{nums3[j][d]} \t");
                }
                Console.WriteLine();
            }

            int[] zulen = {-1, -2, -3, -4, 5, -7, 6, -8, 9, -10, 11 };
            int result = 0;
            foreach (int number in zulen) 
            {
                if(number > 0)
                {
                    result++;
                }
            }
            Console.WriteLine($"Quantity of positive numbers in arrayZulen: {result}");

            //static method reducing 
            static void SayHello()
            {
                Console.WriteLine("Hello");
            };
            SayHello();

            //parameters
            static int Sum(int x, int y)
            {
                return x + y;
            }
            int TotalSum = Sum(5, 6);
            Console.WriteLine($"Total summ is {TotalSum}");

            int a = 45;
            int b = 35;
            int final = SumL(a, b);
            Console.WriteLine(final);

            int final2 = SumL(b, 45);
            Console.WriteLine(final2);

            int final3 = SumL(a + b + 18, 12);
            Console.WriteLine(final3);

            Console.ReadKey();

            

        }
        static int SumL(int x, int y)
        {
            return x + y;
        }
    }
}
