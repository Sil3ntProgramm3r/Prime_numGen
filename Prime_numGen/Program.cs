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
            {
                break;
            }

            if (int.TryParse(input, out int number))
            {
                if (number <= 1)
                {
                    Console.WriteLine("Enter a number greater than 1.");
                    continue;
                }

                Console.WriteLine("Prime numbers:");

                for (int i = 2; i <= number; i++)
                {
                    if (IsPrime(i))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        if (number == 2 || number == 3)
        {
            return true;
        }

        if (number % 2 == 0)
        {
            return false;
        }

        int sqrt = (int)Math.Sqrt(number);

        for (int i = 3; i <= sqrt; i += 2)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
