using System;

namespace Factorial
{
    public class FactorialCalculator
    {
        public static void main(String[] args)
        {
            Console.WriteLine(Factorial(0));
            Console.WriteLine(Factorial(1));
            Console.WriteLine(Factorial(5));
            Console.WriteLine(Factorial(8));
            Console.WriteLine(Factorial(10));
            Console.WriteLine(Factorial(12));
            Console.WriteLine(Factorial(13));
        }
        public static int Factorial(int n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException();
            if (n > 12) throw new ArgumentOutOfRangeException();
            if (n == 0) return 1;
            else return n * Factorial(n - 1);
        }
    }
}
