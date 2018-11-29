using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_2
{

    class Program
    {
        public const int INFANT_AGE = 5;
        public const int KID_AGE = 20;
        public const int OLD_MAN_AGE = 64;
        public const int VERY_OLD_AGE = 100;
        public const int KID_PRICE = 80;
        public const int STANDARD_PRICE = 120;
        public const int OLD_MAN_PRICE = 90;

        public static void YoungOrOld()
        {
            bool wrongInput = true;
            int? age = null;

            do
            {
                try
                {
                    Console.Write("Age input: ");
                    string userInput = Console.ReadLine();
                    age = int.Parse(userInput);
                    wrongInput = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The value of age must be an integer");
                }
            } while (wrongInput);

            if(age < INFANT_AGE || age > VERY_OLD_AGE)
            {
                Console.WriteLine("Price: Free!!!");
            }
            else if(age >= INFANT_AGE && age <= KID_AGE)
            {
                Console.WriteLine("Kid price: {0}", KID_PRICE.ToString("c"));
            }
            else if(age >= KID_AGE && age <= OLD_MAN_AGE)
            {
                Console.WriteLine("Standard price: {0}", STANDARD_PRICE.ToString("c"));
            }
            else if(age > OLD_MAN_AGE && age <= VERY_OLD_AGE)
            {
                Console.WriteLine("Senior price {0}", OLD_MAN_PRICE.ToString("c"));
            }
        }

        private static void IterateInputTenTimes()
        {
            Console.Write("Write the text that you want to iterate 10 times: ");
            string userInput = Console.ReadLine();

            //TODO: Add check for whitespace only input.
            Console.WriteLine("Here is your input iterated 10 times in the same row:");
            for(int i = 0; i < 10; i++)
            {
                Console.Write(userInput);
            }
            Console.WriteLine();
        }

        private static void TheThirdWord()
        {
            bool wrongInput = true;

            do
            {

                Console.Write("Write at least 3 words separated by spaces: ");
                string userInput = Console.ReadLine();
                string[] splittedWords = userInput.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                if(!string.IsNullOrWhiteSpace(userInput) && splittedWords.Length >= 3)
                {
                    Console.WriteLine("The third word of your input is: {0}", splittedWords[2]);
                    wrongInput = false;
                }
                else
                {
                    Console.WriteLine("Wrong input!!!");
                }
            } while (wrongInput);
        }

        static void Main(string[] args)
        {
            bool keepGoing = true;

            Console.WriteLine("Welcome to the program Menu");

            while (keepGoing)
            {
                
                Console.WriteLine("0. Quit\n1: Young or Old\n2. Iterate input ten times\n3. The third word");
                string menuOption = Console.ReadLine();

                switch (menuOption)
                {
                    case "0":
                        keepGoing = false;
                        break;
                    case "1":
                        YoungOrOld();
                        Console.WriteLine("Press key to continue...");
                        Console.ReadKey(intercept: true);
                        break;
                    case "2":
                        IterateInputTenTimes();
                        Console.WriteLine("Press key to continue...");
                        Console.ReadKey(intercept: true);
                        break;
                    case "3":
                        TheThirdWord();
                        Console.WriteLine("Press key to continue...");
                        Console.ReadKey(intercept: true);
                        break;
                    default:
                        Console.WriteLine("Option number {0} is not an option", menuOption);
                        break;
                }

            }

            Console.WriteLine("Program end");
            Console.ReadKey(intercept: true);
        }

        
    }
}
