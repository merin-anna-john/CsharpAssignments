using Q1_AssignmentInterface.Model;

namespace Q1_AssignmentInterface
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyAnimals myAnimal = new MyAnimals();
            int temp = myAnimal.GetBodyTemp("Normal");
            Console.WriteLine("Body Temperature: " + temp); 
            myAnimal.SaySomething();
        }
    }
}
