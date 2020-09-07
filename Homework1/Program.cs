namespace Homework_Template
{
    using System;

    class Program
    {
        /// <summary>
        /// Create an enumeration for the plants in our solar system
        /// and assign Mercury as the first value.
        /// </summary>
        private enum Planet
        {
            MERCURY = 1,
            VENUS,
            EARTH,
            MARS,
            JUPITER,
            SATURN,
            URANUS,
            NEPTUNE
        }

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
            Console.WriteLine("Homework 1");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1 (InchesToCentimeters).");
            Console.WriteLine("Hit [2] to run Exercise 2 (InchesToCentimetersInteractive).");
            Console.WriteLine("Hit [3] to run Exercise 3 (FahrenheitToCelsius).");
            Console.WriteLine("Hit [4] to run Exercise 4 (Enumerating Planets).");
            Console.WriteLine("Hit [5] to run Exercise 5 (Fixin' the Squigglies).");

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

        private static void DoExe1()
        {
            Console.WriteLine("Exercise 1");

            const double CentimetersInAnInch = 2.54;
            int measurementInInches = 4;

            Console.WriteLine($"{measurementInInches} inches is " +
                $"{measurementInInches * CentimetersInAnInch} centimeters");
        }

        private static void DoExe2()
        {
            Console.WriteLine("Exercise 2");

            const double CentimetersInAnInch = 2.54;
            Console.Write($"Enter a value in inches >> ");
            double measurementInInches = double.Parse(Console.ReadLine());

            Console.WriteLine($"{measurementInInches} inches is " +
                $"{measurementInInches * CentimetersInAnInch} centimeters");
        }

        private static void DoExe3()
        {
            Console.WriteLine("Exercise 3");

            Console.Write($"Enter Fahrenheit degrees >> ");
            double temperatureInFahrenheit = double.Parse(Console.ReadLine());
            double temperatureInCelsius = (temperatureInFahrenheit - 32) * 5 / 9;

            Console.WriteLine($"{temperatureInFahrenheit:F1} F is {temperatureInCelsius:F1} C");
        }

        private static void DoExe4()
        {
            Console.WriteLine("Exercise 4");

            Console.Write("Enter a number to see the planet at that position >> ");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine($"You entered {position}");
            var selection = (Planet)position;
            Console.WriteLine($"{selection} is {position} planet(s) away from the sun");
        }

        private static void DoExe5()
        {
            string name;
            string firstString, secondString;
            int first, second, product;
            Console.Write("Enter your name >> ");
      
            name = Console.ReadLine();
            Console.Write("Hello, {0}! Enter an integer >> ", name);
            firstString = Console.ReadLine();
            first = Convert.ToInt32(firstString);
            Console.Write("Enter another integer >> ");
            secondString = Console.ReadLine();
            second = Convert.ToInt32(secondString);
            product = first * second;
            Console.WriteLine("Thank you, {0}. The product of {1} and {2} is {3}",
                name, first, second, product);
        }
    }
}
