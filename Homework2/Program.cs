namespace Homework_Template
{
    using System;
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
            Console.WriteLine("Homework 2");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1 (Stating the word).");
            Console.WriteLine("Hit [2] to run Exercise 2 (Hello your name).");
            Console.WriteLine("Hit [3] to run Exercise 3 (System 32).");
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
        /// Get the second word from the school's department.
        /// </summary>
        private static void DoExe1()
        {
            Console.WriteLine("Exercise 1");

            string schoolDepartmentName = "Missouri State University College of Business";
            int startPosition = schoolDepartmentName.IndexOf(" ") + 1;
            string secondWord = schoolDepartmentName.Substring(startPosition,
                schoolDepartmentName.IndexOf(" ", startPosition) - startPosition);
           
            Console.Write($"Second word: {secondWord}");

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Print greeting to the user with today's date/time formatted.
        /// </summary>
        private static void DoExe2()
        {
            Console.WriteLine("Exercise 2");

            string firstName = "Ethan";
            DateTime date = DateTime.Now;

            Console.WriteLine("Composite Formatting");
            Console.WriteLine("Hello, {0}! Today is {1}, it's {2:g} now.", firstName, date.DayOfWeek, date);
            Console.ReadKey();

            // New line.
            Console.WriteLine();

            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello, {firstName}! Today is {date.DayOfWeek}, it's {date:g} now.");

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Print a string two different ways.
        /// </summary>
        private static void DoExe3()
        {
            Console.WriteLine("Exercise 3");

            string text = "The path is C:";
            
            // Escape.
            Console.WriteLine($"{text}\\Windows\\System32");

            // Puase until the user hits enter.
            Console.ReadKey();

            // Verbaim.
            Console.WriteLine(@"{0}\Windows\System32", text);

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Fix syntax, logic, math and spelling errors.
        /// Print gross and net pay to the user.
        /// </summary>
        private static void DoExe4()
        {
            Console.WriteLine("Exercise 4");

            const double WITHHOLDING_RATE = 15;
            string hoursAsString, rateAsString;
            double hours, rate;
            double gross, withholding, net;

            Console.Write("Enter the number of hours you worked this week >> ");
            hoursAsString = Console.ReadLine();
            Console.Write("Enter your hourly rate >> ");
            rateAsString = Console.ReadLine();
            hours = Convert.ToDouble(hoursAsString);
            rate = Convert.ToDouble(rateAsString);
            gross = hours * rate;
            withholding = gross * WITHHOLDING_RATE / 100;
            net = gross - withholding;

            Console.WriteLine("You worked {0} hours at {1} per hour", hours, rate.ToString("C"));
            Console.WriteLine("Gross pay is {0}", gross.ToString("C"));
            Console.WriteLine("Withholding is {0}", withholding.ToString("C"));
            Console.WriteLine("Net pay is {0}", net.ToString("C"));

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Fix syntax, logic, math and spelling errors.
        /// Compare two strings and print out the result to the user.
        /// </summary>
        private static void DoExe5()
        {
            Console.WriteLine("Exercise 5");

            string name, bossName;
            bool areNamesTheSame;
            
            Console.Write("Enter your name >> ");
            name = Console.ReadLine();
            Console.Write("Hello {0}! Enter the name of your boss >> ", name);
            bossName = Console.ReadLine();
            areNamesTheSame = String.Equals(name, bossName);
            Console.WriteLine("It is {0} that you are your own boss", areNamesTheSame);

            // Pause until the user hits enter.
            Console.ReadKey();
        }
    }
}
