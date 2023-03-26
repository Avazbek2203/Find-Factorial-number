using System;

class Program
{
    static void Main()
    {
        int number = 0;
        bool validInput = false;

        while (!validInput)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out number))
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
            }
        }

        int factorial = 1;

        for (int i = 2; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("Factorial of {0} is: {1}.", number, factorial);
    }
}
