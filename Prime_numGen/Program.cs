using System;

class PrimeNumberGenerator
{
    static void Main()
    {
        Console.WriteLine("Prime Number Generator");

        while (true)
        {
            Console.Write("Enter a number (press Enter to exit): ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                break;

            if (int.TryParse(input, out int number) && number > 1)
            {
                Console.WriteLine("Prime numbers:");
                PrintPrimeNumbers(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number greater than 1.");
            }
        }
    }

    static void PrintPrimeNumbers(int number)
    {
        for (int i = 2; i <= number; i++)
        {
            if (IsPrime(i))
                Console.WriteLine(i);
        }
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}
