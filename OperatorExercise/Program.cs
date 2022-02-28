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

            int additionAnswer = a + b;
            int subtractionAnswer = a - b;
            int multiplicationAnswer = a * b;

            Console.WriteLine($"The addition result is {additionAnswer}");
            Console.WriteLine($"The subtraction result is {subtractionAnswer}");
            Console.WriteLine($"The multiplication result is {multiplicationAnswer}");
            Console.WriteLine($"The division result is shown below:");
            if (a==17 && b == 4) //division result
            {
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            }
        }
    }
}
