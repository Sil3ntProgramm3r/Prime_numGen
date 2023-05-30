using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class PrimeNumberGenerator
{
    static void Main()
    {
        Console.WriteLine("Prime Number Generator");

        while (true)
        {
            Console.Write("Enter a number (press Enter to exit): ");
            string? input = Console.ReadLine();// if the return could be null then our type is a nullable type.
                                               // The code will work either way but this is clearer to the user
                                               // of the string that it could be null.

            if (string.IsNullOrWhiteSpace(input))
            {// it is possible to remove the dependance on the break statement by refactoring further see Main2 
                break;
            }
            else if (!int.TryParse(input, out int number))// if the relationship can be conveyed using
                                                          // an else, then it is (in my opinion) cleare to do so.
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            else if(number <= 1)
            {
                Console.WriteLine("Enter a number greater than 1.");
                //continue; since all our relations are clearly defined as an if else tree
                //we don't need the continue statement.
            }
            else
            {
                Console.WriteLine("Prime numbers:");
                foreach (var prime in PrimeNumbersUpTo(number))
                {// Separation of concerns is very important. We have isolated the prime number generation
                 // from printing to screen. This way we can use the PrimeNumbersUpTo function in other
                 // places which doesn't use printing to screen of maybe it can print to file.
                    Console.WriteLine(prime);
                }
            }
        }
    }
    /// <summary>
    /// This function returns the list of prime numbers between 0 and the number provided.
    /// We got this function out and made it public so we can benchmark it.
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public static List<int> PrimeNumbersUpTo(int number)
    {
        var listOfPrimes = new List<int>();
        for (int i = 2; i <= number; i++)
        {
            if (IsPrime(i))
            {
                listOfPrimes.Add(i);
            }
        }
        return listOfPrimes;
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }


    static void Main2()
    {
        Console.WriteLine("Prime Number Generator");

        while (TryGetInput(out var input))
        {
            if (!int.TryParse(input, out int number))// if the relationship can be conveyed using
                                                          // an else, then it is (in my opinion) cleare to do so.
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            else if (number <= 1)
            {
                Console.WriteLine("Enter a number greater than 1.");
                //continue; since all our relations are clearly defined as an if else tree
                //we don't need the continue statement.
            }
            else
            {
                Console.WriteLine("Prime numbers:");
                foreach (var prime in PrimeNumbersUpTo(number))
                {
                    Console.WriteLine(prime);
                }
            }
        }
    }

    private static bool TryGetInput(out string input)
    {
        Console.Write("Enter a number (press Enter to exit): ");
        input = Console.ReadLine()??"";// the "??" is used often to test if something is null.
                                       // If it is null then it gets subsituted with the value
                                       // provided after "??" which is an empty string in this case.
        return string.IsNullOrWhiteSpace(input);
    }
}
