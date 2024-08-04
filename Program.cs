using System;

namespace Q4_AssignmentsExceptionalHandling
{
    internal class PrimeNumberException : Exception
    {
        public PrimeNumberException(string message) : base(message)
        {
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int randomNumber = GenerateRandomNumber();
                Console.WriteLine("Generated random number: " + randomNumber+" is not a prime number");
            }
            catch (PrimeNumberException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        public static int GenerateRandomNumber()
        {
            Random random = new Random();
            int number = random.Next(1, 101); // Generates a random number between 1 and 100
            if (IsPrime(number))
            {
                throw new PrimeNumberException($"Generated number {number} is a prime number.");
            }
            return number;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2)
                return true;
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            return count == 2;
        }
    }
}
