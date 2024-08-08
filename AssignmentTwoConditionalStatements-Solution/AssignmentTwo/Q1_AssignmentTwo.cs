namespace AssignmentTwo
{
    internal class Q1_AssignmentTwo
    {
        static void Main(string[] args)
        {
            int age;

            //entering age
            Console.WriteLine("Enter the age of candidate:");
            age = int.Parse(Console.ReadLine());
            //checking condition
            if (age >= 18)
            {
                Console.WriteLine("Eligible for casting his/her own vote");
            }
            else
            {
                Console.WriteLine("Not eligible for casting his/her own vote");
            }
            Console.ReadKey();
        }
    }
}
