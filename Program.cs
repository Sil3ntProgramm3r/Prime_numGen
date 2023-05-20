using System;

class ConsoleApp2
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        int number;
        bool isValidNumber = int.TryParse(input, out number);

        if (isValidNumber)
        {
            if (number >= 2)
            {
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
                Console.WriteLine("Please enter a number greater than or equal to 2.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        Console.WriteLine("Program ended press enter to exit.");
        Console.ReadLine();
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}