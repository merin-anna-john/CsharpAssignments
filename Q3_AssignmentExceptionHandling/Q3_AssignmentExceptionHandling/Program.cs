
namespace Q3_AssignmentExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            try
            {
                int[] numbers = new int[10];
                for ( i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = i + 1; // Initializing array with values 1 to 10
                }

                // Trying to access the 11th element (index 10)
                Console.WriteLine("The element at the 11th position is: ");
                Console.ReadLine(numbers[i]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Error: Attempted to access an element outside the array bounds.");
                Console.WriteLine($"Exception message: {ex.Message}");
            }
        }
    }
}

