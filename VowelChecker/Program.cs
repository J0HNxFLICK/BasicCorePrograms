using System.Runtime;
using System.Transactions;

namespace VowelChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vowel or Consonant checker");

            Console.WriteLine("Enter an alphabet to check wether its a vowel or consonant : ");
            char userInput = Convert.ToChar(Console.ReadLine());

            switch (userInput)
            {
                case 'a':
                    Console.WriteLine(userInput + " is a vowel.");
                    break;

                case 'e':
                    Console.WriteLine(userInput + " is a vowel.");
                    break;

                case 'i':
                    Console.WriteLine(userInput + " is a vowel.");
                    break;

                case 'o':
                    Console.WriteLine(userInput + " is a vowel.");
                    break;

                case 'u':
                    Console.WriteLine(userInput + " is a vowel.");
                    break;

                case 'A':
                    Console.WriteLine(userInput + " is a vowel.");
                    break;

                case 'E':
                    Console.WriteLine(userInput + " is a vowel.");
                    break;

                case 'I':
                    Console.WriteLine(userInput + " is a vowel.");
                    break;

                case 'O':
                    Console.WriteLine(userInput + " is a vowel.");
                    break;

                case 'U':
                    Console.WriteLine(userInput + " is a vowel.");
                    break;

                default:
                    Console.WriteLine(userInput + " is a consonant.");
                    break;
            }
        }
    }
}