namespace Homework_Template
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http.Headers;

    class Program
    {
        static void Main(string[] args)
        {
            string result;

            do
            {
                result = DisplayMenu();
                Run(result);
            }
            while (result.ToUpper() != "E");

            Console.WriteLine(" Good Bye...");

        }

        public static string DisplayMenu()
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Homework 4");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1 (Are you casing today?).");
            Console.WriteLine("Hit [2] to run Exercise 2 (Wheel of Fortune - buying a vowel?).");
            Console.WriteLine("Hit [3] to run Exercise 3 (Sum of numbers).");
            Console.WriteLine("Hit [4] to run Exercise 4 (Debugging).");
            Console.WriteLine("Hit [5] to run Exercise 5 (Debugging).");

            Console.WriteLine();
            Console.WriteLine("Hit [E]: Exit;");
            Console.WriteLine();
            Console.WriteLine();

            var result = Console.ReadLine();
            return result;


        }

        private static bool Run(string exeArg)
        {
            switch (exeArg.ToLower())
            {

                case "1":
                    DoExe1();
                    return true;

                case "2":
                    DoExe2();
                    return true;

                case "3":
                    DoExe3();
                    return true;

                case "4":
                    DoExe4();
                    return true;

                case "5":
                    DoExe5();
                    return true;

                default:
                    Console.WriteLine("Exiting the Program!");
                    return true;
            }
        }

        /// <summary>
        /// Prompt the user to input until an uppercase letter is entered or ! to escape.
        /// </summary>
        private static void DoExe1()
        {
            Console.WriteLine("Exercise 1");
            
            char letter;

            do
            {
                Console.Write("Enter an uppercase letter >> ");
                letter = char.Parse(Console.ReadLine());

                if (letter != '!')
                {
                    if (Char.IsUpper(letter))
                    {
                        Console.WriteLine("OK");
                    }
                    else
                    {
                        Console.WriteLine($"Sorry - {letter} is not an uppercase letter.");
                    }

                    Console.WriteLine();
                    Console.WriteLine("Enter an uppercase letter or ! to quit");
                }
            } while (letter != '!');

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Prompt the user for a phrase and count the vowels (a,e,i,o,u) excluding y.
        /// </summary>
        private static void DoExe2()
        {
            Console.WriteLine("Exercise 2");

            var vowels = new List<char> {'A', 'E', 'I', 'O', 'U'};
            int vowelCount = 0;
            string sentence, sentenceToUpper;

            Console.Write("Enter a phrase >> ");
            sentence = Console.ReadLine().Trim();

            // Trim user input and convert to uppercase for easier comparison.
            sentenceToUpper = sentence.ToUpper();

            for (int i = 0; i < sentenceToUpper.Length; i++)
            {
                char character = sentenceToUpper[i];
                
                // Ignore any white space and punctuation.
                if (!Char.IsPunctuation(character) && !Char.IsWhiteSpace(character))
                {
                    if (vowels.Contains(sentenceToUpper[i]))
                    {
                        vowelCount++;
                    }
                }
            }

            Console.WriteLine($"There are {vowelCount} vowel(s) in: {sentence}");

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Loop from 1 to 200 and display the sum halfway and at the end.
        /// </summary>
        private static void DoExe3()
        {
            Console.WriteLine("Exercise 3");

            int sum = 0;

            for (int i = 1; i <= 200; i++)
            {
                if (i == 100)
                {
                    Console.WriteLine("Halfway through...");
                    Console.WriteLine($"\t after {i} numbers, sum is {sum}");
                }

                sum += i;
            }

            Console.WriteLine($"The sum of integers 1 through 200 is {sum}");

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Selecting an item from inventory then display the price of the selected item.
        /// </summary>
        private static void DoExe4()
        {
            Console.WriteLine("Exercise 4");

            const string ITEM209 = "209";
            const string ITEM312 = "312";
            const string ITEM414 = "414";
            const double PRICE209 = 12.99, PRICE312 = 16.77, PRICE414 = 109.07;
            double price;
            string stockNum;

            Console.Write("Please enter the stock number of the item you want ");
            stockNum = Console.ReadLine();
            while (stockNum != ITEM209 && stockNum != ITEM312 && stockNum != ITEM414)
            {
                Console.WriteLine("Invalid stock number. Please enter again. ");
                stockNum = Console.ReadLine();
            }
            if (stockNum == ITEM209)
                price = PRICE209;
            else
               if (stockNum == ITEM312)
                price = PRICE312;
            else
                price = PRICE414;
            Console.WriteLine("The price for item # {0} is {1}", stockNum, price.ToString("C"));

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Ask the user how many days it will take to reach 1000000.00
        /// while doubling .01 every day.
        /// </summary>
        private static void DoExe5()
        {
            Console.WriteLine("Exercise 5");

            const double LIMIT = 1000000.00;
            const double START = 0.01;
            string inputString;
            double total;
            int howMany;
            int count;
            Console.Write("How many days do you think ");
            Console.WriteLine("it will take you to reach");
            Console.Write("{0} starting with {1}",
                LIMIT.ToString("C"), START.ToString("C"));
            Console.WriteLine(" and doubling it every day?");
            inputString = Console.ReadLine();
            howMany = Convert.ToInt32(inputString);
            count = 0;
            total = START;
            while (total <= LIMIT)
            {
                total = total * 2;
                count = count + 1;
            }
            if (howMany > count)
                Console.WriteLine("Your guess was too high.");
            else
              if (howMany < count)
                Console.WriteLine("Your guess was too low.");
            else
                Console.WriteLine("Your guess was correct.");
            Console.WriteLine("It takes {0} days to reach {1}",
               count, LIMIT.ToString("C"));
            Console.WriteLine("when you double {0} every day",
               START.ToString("C"));

            // Pause until the user hits enter.
            Console.ReadKey();
        }
    }
}
