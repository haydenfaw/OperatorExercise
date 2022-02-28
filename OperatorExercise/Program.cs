using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = 1 % b;

            if (a==17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is remainder {remainder}");
            }
        }
    }
}
