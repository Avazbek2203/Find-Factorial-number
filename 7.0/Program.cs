using System;

class Program
{
    static void Main()
    {
        int num = 0;
        bool validInput = false;

        while (!validInput)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out num))
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
            }
        }

        int factorial = 1;

        for (int i = 2; i <= num; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("Factorial of {0} is: {1}.", num, factorial);
    }
}
