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
            Console.WriteLine("Homework 6");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1 (How many kilometers?).");
            Console.WriteLine("Hit [2] to run Exercise 2 (Did you forget to return your books?).");
            Console.WriteLine("Hit [3] to run Exercise 3 (Are you a decent tipper?).");
            Console.WriteLine("Hit [4] to run Exercise 4 (Reversing the overloads).");
            Console.WriteLine("Hit [5] to run Exercise 5 (Overloading the debugger).");

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
        /// Prompt the user to enter miles to convert to kilometers.
        /// </summary>
        private static void DoExe1()
        {
            Console.WriteLine("Exercise 1");

            Console.Write($"Enter miles >> ");
            double miles = double.Parse(Console.ReadLine());
            var kilometers = ConvertMilesToKilometers(miles);

            Console.WriteLine($"{miles} miles is {kilometers} kilometers");

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Calculate the overdue amount for library books.
        /// </summary>
        private static void DoExe2()
        {
            Console.WriteLine("Exercise 2");

            Console.Write("Enter the number of books that are overdue >> ");
            int numberOfBooks = int.Parse(Console.ReadLine());

            Console.Write($"Enter the number of days the {numberOfBooks} book(s) are overdue >> ");
            int numberOfDays = int.Parse(Console.ReadLine());

            var amountDue = CalculateOverdueAmount(numberOfBooks, numberOfDays);

            Console.WriteLine($"The fine for {numberOfBooks} book(s) for {numberOfDays} day(s) is {amountDue:C}");

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Determine the total bill with tip using two overloaded methods.
        /// </summary>
        private static void DoExe3()
        {
            Console.WriteLine("Exercise 3");

            double mealPrice = 25.00;
            double tipAsDouble = 0.20;
            int tipAsInt = 4;

            CalculateTipAmount(mealPrice, tipAsDouble);

            // New line.
            Console.WriteLine();

            CalculateTipAmount(mealPrice, tipAsInt);

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Declares three integers named firstInt, middleInt, and lastInt.
        /// Assign values to the variables, display them, and then pass them to a method that accepts
        /// them as reference variables, places the first value in the lastInt variable,
        /// and places the last value in the firstInt variable.
        /// In the calling method, display the three variables again,
        /// demonstrating that their positions have been reversed.
        /// </summary>
        private static void DoExe4()
        {
            Console.WriteLine("Exercise 4");

            int firstInt = 15;
            int middleInt = 49;
            int lastInt = 32;

            Console.WriteLine($"The numbers are {firstInt}, {middleInt}, {lastInt}");
            ReverseNumbers(ref firstInt, ref middleInt, ref lastInt);

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Print parameters based on overloading method FancyDisplay().
        /// </summary>
        private static void DoExe5()
        {
            Console.WriteLine("Exercise 5");

            FancyDisplay(33);
            FancyDisplay(44, '@');
            FancyDisplay(55.55);
            FancyDisplay(77.77, '*');
            FancyDisplay("hello");
            FancyDisplay("goodbye", '#');

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Convert miles to kilometers.
        /// 1 mile is 1.60934 kilometers.
        /// </summary>
        /// <param name="miles">Total miles to convert.</param>
        /// <returns>The miles converted to kilometers.</returns>
        private static double ConvertMilesToKilometers(double miles)
        {
            const double KILOMETER = 1.60934;

            return miles * KILOMETER;
        }

        /// <summary>
        /// The fine for an overdue book is as follows.
        /// 10 cents per book per day for the first seven days a book is overdue,
        /// then 20 cents per book per day for each additional day.
        /// </summary>
        /// <param name="numOfBooks">The number of books overdue.</param>
        /// <param name="numOfDays">The number of days the book is overdue.</param>
        /// <returns>The amount due.</returns>
        private static decimal CalculateOverdueAmount(int numOfBooks, int numOfDays)
        {
            const decimal RATE_ONE_SEVEN_DAYS = 0.10m;
            const decimal RATE_AFTER_SEVEN_DAYS = 0.20m;
            decimal overdueAmount, total;

            if (numOfDays >= 1 && numOfDays <= 7)
            {
                overdueAmount = numOfDays * RATE_ONE_SEVEN_DAYS;
            }
            else
            {
                overdueAmount = numOfDays * RATE_AFTER_SEVEN_DAYS;
            }

            total = numOfBooks * overdueAmount;

            return total;
        }

        /// <summary>
        /// Calculate the total amount for a bill.
        /// Displays the meal price, the tip as a percentage of the meal price,
        /// the tip in dollars, and the total of the meal plus the tip.
        /// </summary>
        /// <param name="mealPrice">The price of the meal.</param>
        /// <param name="tipAmount">The amount of the tip as a percent.</param>
        private static void CalculateTipAmount(double mealPrice, double tipAmount)
        {
            double total = mealPrice;
            double tipInDollars = mealPrice * tipAmount;
            total += tipInDollars;

            // Display price as currency and tips as (decimal) percent to two places.
            Console.WriteLine($"Meal price: {mealPrice:C}. Tip percent: {tipAmount:F2}");
            Console.WriteLine($"Tip in dollars: {tipInDollars:C}. Total bill {total:C}");
        }

        /// <summary>
        /// Calculate the total amount for a bill.
        /// Displays the meal price, the tip as a percentage of the meal price,
        /// the tip in dollars, and the total of the meal plus the tip.
        /// </summary>
        /// <param name="mealPrice">The price of the meal.</param>
        /// <param name="tipAmount">The amount of the tip as the dollar amount.</param>
        private static void CalculateTipAmount(double mealPrice, int tipAmount)
        {
            double total = mealPrice + tipAmount;
            // Display the tip as percent.
            double tipAsDouble = tipAmount / mealPrice;

            // Display price as currency and tips as (decimal) percent to two places.
            Console.WriteLine($"Meal price: {mealPrice:C}. Tip percent: {tipAsDouble:F2}");
            Console.WriteLine($"Tip in dollars: {tipAmount:C}. Total bill {total:C}");
        }

        /// <summary>
        /// Reverse the order of the numbers passed in.
        /// </summary>
        /// <param name="firstInt">The first integer.</param>
        /// <param name="middleInt">The second integer.</param>
        /// <param name="lastInt">The last integer.</param>
        private static void ReverseNumbers(ref int firstInt, ref int middleInt, ref int lastInt)
        {
            int originalFirstInt = firstInt;
            int originalLastInt = lastInt;
            lastInt = originalFirstInt;
            firstInt = originalLastInt;
            Console.WriteLine($"The numbers are {firstInt}, {middleInt}, {lastInt}");
        }

        private static void FancyDisplay(int num, char decoration = 'X')
        {
            Console.WriteLine("{0}{0}{0}  {1}  {0}{0}{0}\n", decoration, num);
        }
        private static void FancyDisplay(double num, char decoration = 'X')
        {
            Console.WriteLine("{0}{0}{0}  {1}  {0}{0}{0}\n", decoration, num.ToString("C"));
        }
        private static void FancyDisplay(string word, char decoration = 'X')
        {
            Console.WriteLine("{0}{0}{0}  {1}  {0}{0}{0}\n", decoration, word);
        }
    }
}