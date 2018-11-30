using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieTheatre;

namespace Uppgift_2
{

    class Program
    {

        public static int[] RetrieveCustomerAges(int customersCount)
        {
            int[] ages = new int[customersCount];
            int index = 0;
            while (index < customersCount)
            {
                try
                {
                    Console.Write("Add age for person number {0}: ", index + 1);
                    string userInput = Console.ReadLine();
                    int age = int.Parse(userInput);
                    ages[index] = age;
                    index++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Age must be an integer!!!");
                }
            }
            return ages;
        }

        public static void BuyMovieTickets()
        {

            bool wrongInput = true;
            int[] ages;
            int total = 0;
            LocalMovieTheatre theatre = new LocalMovieTheatre();

            while (wrongInput)
            {
                try
                {
                    Console.Write("Number of customers: ");
                    string userInput = Console.ReadLine();
                    int customersCount = int.Parse(userInput);
                    ages = RetrieveCustomerAges(customersCount);

                    total = theatre.BuyTickets(null, ages);

                    wrongInput = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Number of customers must be an integer!!!");
                }
            }

            Console.WriteLine($"Movie tickets total: {total}", total);

        }

        private static void IterateInputTenTimes()
        {
            Console.Write("Write the text that you want to iterate 10 times: ");
            string userInput = Console.ReadLine();

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
                
                Console.WriteLine("0. Quit\n1: Buy movie tickets\n2. Iterate input ten times\n3. The third word");
                string menuOption = Console.ReadLine();

                switch (menuOption)
                {
                    case "0":
                        keepGoing = false;
                        break;
                    case "1":
                        BuyMovieTickets();
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
