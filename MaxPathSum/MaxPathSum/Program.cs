using System;
using System.IO;

namespace MaxPathSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("triangletext.txt");
            int N = lines.Length;
            int[,] numbers = new int[N, N];

            //split the numbers in string[] lines, and parse them to int array
            for (int i = 0; i < N; i++)
            {
                string[] snumbers = lines[i].Split(' ');
                for (int j = 0; j <= i; j++)
                    numbers[i, j] = int.Parse(snumbers[j]);
            }


            for (int i = N - 2; i >= 0; i--)
                for (int j = 0; j <= i; j++)
                    //pick the larger number and add it to the current number
                    numbers[i, j] += Math.Max(numbers[i + 1, j], numbers[i + 1, j + 1]);

            //the current max sum would be the number at numbers[0,0]
            Console.WriteLine(numbers[0, 0]);
        }
    }
}
