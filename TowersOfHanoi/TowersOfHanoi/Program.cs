using System;

namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDisk = 5;
            char fromRod = 'A';
            char toRod = 'C';
            char tempRod = 'B';

            solveHanoi(numOfDisk, fromRod, toRod, tempRod);
        }

        //recursive method to solve Towers of Hanoi with {n} disk
        static void solveHanoi(int n, char from, char to, char temporary)
        {
            if (n > 0)
            {
                solveHanoi(n - 1, from, temporary, to);
                Console.WriteLine($"Moving disk #{n} from {from} to {to} ...");
                solveHanoi(n - 1, temporary, to, from);
            }
        }
    }
}
