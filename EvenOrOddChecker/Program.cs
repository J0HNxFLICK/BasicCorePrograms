namespace EvenOrOddChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even or odd checker.");

            Console.WriteLine("Enter a number to check if a number is even or odd : ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput % 2 == 0)
            {
                Console.WriteLine(userInput + " is an even number.");
            }
            else
            {
                Console.WriteLine(userInput + " is an odd number.");
            }
        }
    }
}