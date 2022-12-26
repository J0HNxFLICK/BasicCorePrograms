namespace LeapYear
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leap year checker.");

            Console.WriteLine("Enter a year to check if its a leap year : ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput % 4 == 0 || userInput % 100 == 0 || userInput % 400 == 10)
            {
                Console.WriteLine(userInput + " is a leap year.");
            }
            else
            {
                Console.WriteLine(userInput + " is not a leap year");
            }
        }
    }
}