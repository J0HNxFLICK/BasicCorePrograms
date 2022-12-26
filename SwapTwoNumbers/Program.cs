namespace SwapTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number swapper.");
            int tempNumHolder = 0;

            Console.WriteLine("Enter first number : ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            tempNumHolder = firstNum;
            firstNum= secondNum;
            secondNum= tempNumHolder;

            Console.WriteLine("Now first number is : " + firstNum);
            Console.WriteLine("And second number is : " + secondNum);
        }
    }
}