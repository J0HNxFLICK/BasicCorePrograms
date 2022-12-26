namespace Factors
{
    internal class Factors
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime Factorial finder.");
            int counter;

            Console.WriteLine("Enter Nth value of which you want prime factorization for : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (counter = 2; n > 1; counter ++)
            {
                if (n % counter == 0)
                {
                    int tracker = 0;
                    while (n % counter == 0)
                    {
                        n /= counter;
                        tracker++;
                    }

                    Console.WriteLine("{0} is a prime factor {1} times." , counter , tracker);
                }
            }


        }
    }
}