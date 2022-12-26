namespace NthHarmonicNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nth harmonic number sum.");
            double storage = 1;

            Console.WriteLine("Enter N value : ");
            int n =Convert.ToInt32(Console.ReadLine()); 

            if (n == 0)
            {
                Console.WriteLine("Cannot be 0.");
            }

            else
            {
                for (int counter = 1; counter <= n; counter++)
                {
                    Console.Write("1/{0} + ", counter);
                    storage += (float)1 / counter;
                }
            }

            Console.WriteLine("\nSum of {0} harmonic number is {1}." , n, storage);
        }
    }
}