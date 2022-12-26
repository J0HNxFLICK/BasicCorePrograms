namespace QuotientAndRemainder
{
    internal class QuotientAndRemainder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quotiant and remainder.");

            Console.WriteLine("Enter dividend : ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter divisor : ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend/ divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Quotient is : " + quotient);
            Console.WriteLine("Remainder is : " + remainder);
        }
    }
}