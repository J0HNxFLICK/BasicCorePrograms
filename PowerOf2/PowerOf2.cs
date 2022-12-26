namespace PowerOf2
{
    internal class PowerOf2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Power Of 2 calculator.");

            double powerOf2 = 0;
            Console.WriteLine("Enter power value : ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            for (int counter = 1 ; counter <= userInput; counter++)
            {
                powerOf2 = Math.Pow(2, counter);
                Console.WriteLine("2 ^ {0} : {1}", counter , powerOf2);
            }
        }
    }
}