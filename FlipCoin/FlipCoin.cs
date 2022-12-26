namespace FlipCoin
{
    internal class FlipCoin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO COIN FLIP !");
            int tails = 0;
            int heads = 0;

            Console.WriteLine("Enter how many times you want to flip the coin :");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Random random= new Random();

            for (int count = 1; count <= userInput; count++) 
            {
                double coin = random.NextDouble();

                if (coin < 0.5)
                {
                    tails++;
                }
                else
                {
                    heads++;
                }

            }

            Console.WriteLine("Tails : {0}\nHeads : {1}" ,tails, heads);
            int tailPercentage = (tails * 100) / userInput;
            int headPercentage = (heads * 100) / userInput;
            Console.WriteLine("Percentage of tails is {0}% and heads is {1}%" , tailPercentage, headPercentage);
        }
    }
}