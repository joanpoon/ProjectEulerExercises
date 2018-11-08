using System;

namespace RatInTheMaze
{
    class Program
    {
        static void Main(string[] args)
        {
            //size of maze
            int N = 5;

            //maze to be solved
            int[,] maze = {
                { 1, 1, 1, 1, 0 },
                { 1, 1, 0, 0, 1 },
                { 1, 0, 1, 1, 1 },
                { 1, 0, 1, 0, 1 },
                { 1, 1, 1, 0, 1 } };

            //solution for the maze
            int[,] solution = {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 } };

            //call solveMaze function to solve the N * N maze
            solveMaze(maze, N, solution);
        }

        static void solveMaze(int[,] maze, int N, int[,] solution)
        {
            if (nextMove(maze, 0, 0, N, "down", solution))
            {
                //output the maze when it is solved
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                        Console.Write(" " + solution[i, j]);
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("No possible path...");
        }

        static bool nextMove(int[,] maze, int x, int y, int N, String direction, int[,] solution)
        {
            if (x == N - 1 && y == N - 1)
            {
                solution[x, y] = 1;
                return true;
            }
            else if (isValid(maze, x, y, N))
            {
                solution[x, y] = 1;

                if (direction != "up" && nextMove(maze, x + 1, y, N, "down", solution))
                    return true;
                else if (direction != "left" && nextMove(maze, x, y + 1, N, "right", solution))
                    return true;
                else if (direction != "down" && nextMove(maze, x - 1, y, N, "up", solution))
                    return true;
                else if (direction != "right" && nextMove(maze, x, y - 1, N, "left", solution))
                    return true;

                solution[x, y] = 0;
                return false;
            }
            return false;
        }

        //this function check if the step is safe to go
        static bool isValid(int[,] maze, int x, int y, int N)
        {
            if (x >= 0 && y >= 0 && x < N && y < N && maze[x, y] != 0)
                return true;
            else
                return false;
        }
    }
}
