namespace Homework_Template
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http.Headers;
    using System.Runtime.CompilerServices;

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
            Console.WriteLine("Homework 5");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1 (What is the average of eight test scores?).");
            Console.WriteLine("Hit [2] to run Exercise 2 (Are you getting warming or colder?).");
            Console.WriteLine("Hit [3] to run Exercise 3 (Are you staying for the week?).");
            Console.WriteLine("Hit [4] to run Exercise 4 (Debugging with arrays).");
            Console.WriteLine("Hit [5] to run Exercise 5 (Debugging with lists).");

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
        /// Accepts eight int values representing student test scores.
        /// Display each of the values along with a message that,
        /// indicates how far it is from the average.
        /// </summary>
        private static void DoExe1()
        {
            Console.WriteLine("Exercise 1");

            int[] studentTestScores = new int[8];

            for (int i = 0; i < studentTestScores.Length; i++)
            {
                // Add 1 to i when prompting user for test # 1 through 8.
                Console.Write($"Please enter score for test number {i + 1} >> ");
                studentTestScores[i] = int.Parse(Console.ReadLine());
            }

            double averageTestScore = studentTestScores.Average();
            int totaledScore = studentTestScores.Sum();

            Console.WriteLine();
            Console.WriteLine("Scores for the tests are:");
            Console.WriteLine();

            for (int i = 0; i < studentTestScores.Length; i++)
            {
                var testScore = studentTestScores[i];
                var differenceFromAverage = testScore - averageTestScore;

                // Format to 6 fixed spaces for consistency.
                Console.WriteLine($"Test # {i}: {testScore,6} " +
                    $"From average: {differenceFromAverage}");
            }

            // Add a space.
            Console.WriteLine();
            Console.WriteLine($"  Total is {totaledScore}");
            Console.WriteLine($"Average is {averageTestScore}");

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Prompt the user to enter five daily Fahrenheit temperatures.
        /// Temperatures must be within the range from −30 to 130.
        /// If a temperature is out of range, require the user to reenter it.
        /// If no temperature is lower than any previous one, display a message Getting warmer.
        /// If every temperature is lower than the previous one, display a message Getting cooler.
        /// If the temperatures are not entered in either ascending or descending order, display a message It’s a mixed bag.
        /// Finally, display the temperatures in the order they were entered, and then display the average of the temperatures.
        /// </summary>
        private static void DoExe2()
        {
            Console.WriteLine("Exercise 2");

            int[] temperatures = new int[5];
            int currentTemperature;
            string message;

            for (int i = 0; i < temperatures.Length; i++)
            {
                // Add 1 to i when prompting user for temperature 1 through 5.
                Console.Write($"Enter temperature {i + 1} >> ");
                currentTemperature = int.Parse(Console.ReadLine());

                if (currentTemperature >= -30 && currentTemperature <= 130)
                {
                    temperatures[i] = currentTemperature;
                }
                else
                {
                    Console.WriteLine($"Temperature entered {currentTemperature} " +
                        $"is invalid. Temperature must be in the range of -30 to 130.");

                    // Keep them in the loop.
                    i--;
                }
            }

            // Add a space.
            Console.WriteLine();

            // Determine if the array is sorted in the order it was entered.
            if (IsSortedAscending(temperatures))
            {
                message = "Getting warmer: ";
            }
            else if (IsSortedDescending(temperatures))
            {
                message = "Getting cooler: ";
            }
            else
            {
                message = "It's a mixed bag: ";
            }

            // Join the array on a space and print inline.
            Console.WriteLine(message + string.Join(" ", temperatures));

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Prompt the user and determine the price for the number of nights
        /// they will be staying at the resort.
        /// </summary>
        private static void DoExe3()
        {
            Console.WriteLine("Exercise 3");

            const int RATE_ONE_TWO_NIGHTS = 200;
            const int RATE_THREE_FOUR_NIGHTS = 180;
            const int RATE_FIVE_SIX_SEVEN_NIGHTS = 160;
            const int RATE_EIGHT_OR_MORE_NIGHTS = 145;
            int nightlyRate;

            Console.Write("How many nights is your stay? ");
            int numberOfNights = int.Parse(Console.ReadLine());

            if (numberOfNights >= 1 && numberOfNights <= 2)
            {
                nightlyRate = RATE_ONE_TWO_NIGHTS;
            }
            else if (numberOfNights >= 3 && numberOfNights <= 4)
            {
                nightlyRate = RATE_THREE_FOUR_NIGHTS;
            }
            else if (numberOfNights >= 5 && numberOfNights <= 7)
            {
                nightlyRate = RATE_FIVE_SIX_SEVEN_NIGHTS;
            }
            else
            {
                nightlyRate = RATE_EIGHT_OR_MORE_NIGHTS;
            }

            Console.WriteLine($"Price per night is {nightlyRate:C}");
            decimal totalPrice = nightlyRate * numberOfNights;

            if (numberOfNights == 1)
            {
                Console.WriteLine($"Total for {numberOfNights} " +
                    $"night is {totalPrice:C}");
            }
            else
            {
                Console.WriteLine($"Total for {numberOfNights} " +
                    $"nights is {totalPrice:C}");
            }

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Debug the following and output the average from a list.
        /// </summary>
        private static void DoExe4()
        {
            Console.WriteLine("Exercise 4");

            int[] numbers = { 12, 15, 22, 88 };
            int x;
            double average;
            double total = 0;

            Console.Write("\nThe numbers are...");
            for (x = 0; x < numbers.Length; ++x)
                Console.Write("\t{0}", numbers[x]);
            Console.WriteLine();
            for (x = 0; x < numbers.Length; ++x)
            {
                total += numbers[x];
            }

            average = total / numbers.Length;
            Console.WriteLine($"The average is {average}");

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Debug the following and output the average from an array.
        /// </summary>
        private static void DoExe5()
        {
            Console.WriteLine("Exercise 5");

            const int QUIT = 999;

            // int[] numbers = new int[];
            // Convert array to list since we won't know the true size.
            var numbers = new List<int>();
            // int x = 0;
            int num;
            double average;
            // double total = 0;
            string inString;
            Console.Write("Please enter a number or "+
                QUIT + " to quit...");
            inString = Console.ReadLine();
            num = Convert.ToInt32(inString);

            // while((x < numbers.Length) && num == QUIT)
            // Do until the user enters 999.
            while (num != QUIT)
            {
                // numbers[x] = num;
                // Add the number to the list.
                numbers.Add(num);
                // total += num;
                // total += numbers[x];
                // ++x;
                Console.Write("Please enter a number or " +
                    QUIT + " to quit...");
                inString = Console.ReadLine();
                num = Convert.ToInt32(inString);
            }

            Console.WriteLine("The numbers are:");

            // Convert the for loop to a foreach loop.
            // for (int y = 0; y < x; ++y)
            //    Console.Write("\t{0}", numbers[y]);
            foreach (var number in numbers)
            {
                Console.Write($"\t{number}");
            }

            // average = total / z;
            // Get the average if the list contains at least one number (user could only enter 999).
            average = (numbers.Count > 0) ? numbers.Average() : 0;

            Console.WriteLine();
            Console.WriteLine("The average is {0}", average);

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Determines if int array is sorted from 0 -> Max.
        /// https://www.dotnetperls.com/issorted
        /// </summary>
        /// <param name="array">The int array.</param>
        /// <returns>Boolean if sorted in ascending order.</returns>
        private static bool IsSortedAscending(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Determines if int array is sorted from Max -> 0.
        /// https://www.dotnetperls.com/issorted
        /// </summary>
        /// <param name="array">The int array.</param>
        /// <returns>Boolean if sorted in descending order.</returns>
        private static bool IsSortedDescending(int[] array)
        {
            for (int i = array.Length - 2; i >= 0; i--)
            {
                if (array[i] < array[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
