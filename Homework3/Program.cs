namespace Homework_Template
{
    using System;
    using System.Linq;
    using System.Net.Http.Headers;

    class Program
    {
        /// <summary>
        /// Enum for Rock, Paper, Scissors.
        /// </summary>
        private enum RpsGameChoices
        {
            Rock = 1,
            Paper,
            Scissors
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
            Console.WriteLine("Homework 3");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1 (Are you social networking today?).");
            Console.WriteLine("Hit [2] to run Exercise 2 (Admission for a college’s admissions office).");
            Console.WriteLine("Hit [3] to run Exercise 3 (Rock Paper Scissors).");
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
        /// Determine if a message for a social media platform
        /// is within the 140 character limit.
        /// </summary>
        private static void DoExe1()
        {
            Console.WriteLine("Exercise 1");

            const int CHARACTER_LIMIT = 140;
            string userMessage, result;

            Console.Write("Enter your short message >> ");
            userMessage = Console.ReadLine();

            result = (userMessage.Length <= CHARACTER_LIMIT) ? "okay" : "too long";
            Console.WriteLine($"The message is {result}");

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Determine if a student should be accepted into the college
        /// based on their GPA and test score.
        /// </summary>
        private static void DoExe2()
        {
            Console.WriteLine("Exercise 2");

            const double MINIMUM_GPA = 3.0;
            const int MINIMUM_TEST_SCORE1 = 60;
            const int MINIMUM_TEST_SCORE2 = 80;
            double studentGpa, studentTestScore;
            string admitStatus = "Reject";

            Console.WriteLine("Enter grade point average");
            studentGpa = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter test score");
            studentTestScore = double.Parse(Console.ReadLine());

            if(studentGpa >= MINIMUM_GPA && studentTestScore >= MINIMUM_TEST_SCORE1)
            {
                admitStatus = "Accept";
            }
            else if (studentGpa < MINIMUM_GPA && studentTestScore >= MINIMUM_TEST_SCORE2)
            {
                admitStatus = "Accept";
            }

            Console.WriteLine($"\n{admitStatus}");

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Play the game Rock Paper Scissors against the computer.
        /// </summary>
        private static void DoExe3()
        {
            Console.WriteLine("Exercise 3");

            char userSelection;
            Console.Write("Enter r, p, or s for rock, paper or scissors >> ");
            userSelection = char.Parse(Console.ReadLine().ToUpper());

            RpsGameChoices computerSelection = (RpsGameChoices)(new Random()).Next(1, 4);
            Console.WriteLine($"Computer picked {computerSelection}");

            string gameResult = computerSelection switch
            {
                RpsGameChoices.Rock => userSelection switch
                {
                    'R' => "Tied",
                    'P' => "Win",
                    'S' => "Lose",
                    _ => $"Unknown user selection {userSelection}",
                },
                RpsGameChoices.Paper => userSelection switch
                {
                    'R' => "Lose",
                    'P' => "Tied",
                    'S' => "Win",
                    _ => $"Unknown user selection {userSelection}",
                },
                RpsGameChoices.Scissors => userSelection switch
                {
                    'R' => "Win",
                    'P' => "Lose",
                    'S' => "Tied",
                    _ => $"Unknown user selection {userSelection}",
                },
                _ => $"Unknown computer selection {computerSelection}",
            };

            Console.WriteLine($"You {gameResult}");

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Program decides tuition based on several criteria:
        /// 1 - 12 credit hours @ $150 per credit hour
        /// 13 - 18 credit hours, flat fee $1900
        /// over 18 hours, $1900 plus $100 per credit hour over 18
        /// If year in school is 4, there is a 15% discount
        /// </summary>
        private static void DoExe4()
        {
            Console.WriteLine("Exercise 4");

            int credits, year;
            string inputString;
            double tuition;
            const int LOWCREDITS = 12;
            const int HIGHCREDITS = 18;
            const double HOURFEE = 150.00;
            const double DISCOUNT = 0.15;
            const double FLAT = 1900.00;
            const double RATE = 100.00;
            const int SENIORYEAR = 4;

            Console.WriteLine("How many credits? ");
            inputString = Console.ReadLine();
            credits = Convert.ToInt32(inputString);

            Console.WriteLine("Year in school? ");
            inputString = Console.ReadLine();
            year = Convert.ToInt32(inputString);

            if (credits <= LOWCREDITS)
                tuition = HOURFEE * credits;
            else if (credits <= HIGHCREDITS)
                tuition = FLAT;
            else
                tuition = FLAT + (credits - HIGHCREDITS) * RATE;
            if (year == SENIORYEAR)
                tuition = tuition - (tuition * DISCOUNT);
            Console.WriteLine("For year {0}, with {1} credits", year, credits);
            Console.WriteLine("Tuition is {0}", tuition.ToString("C"));

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Program takes a hot dog order and determines the price.
        /// </summary>
        private static void DoExe5()
        {
            Console.WriteLine("Exercise 5");

            const double BASIC_DOG_PRICE = 2.00;
            const double CHILI_PRICE = 0.69;
            const double CHEESE_PRICE = 0.49;
            string wantChili, wantCheese;
            double price;

            Console.Write("Do you want chili on your dog? ");
            wantChili = Console.ReadLine().ToUpper();
            Console.Write("Do you want cheese on your dog? ");
            wantCheese = Console.ReadLine().ToUpper();
            if (wantChili == "Y")
                if (wantCheese == "Y")
                    price = BASIC_DOG_PRICE + CHILI_PRICE + CHEESE_PRICE;
                else
                    price = BASIC_DOG_PRICE + CHILI_PRICE;
            else
               if (wantCheese == "Y")
                price = BASIC_DOG_PRICE;
            else
                price = BASIC_DOG_PRICE;
            Console.WriteLine("Your total is {0}", price.ToString("C"));

            // Pause until the user hits enter.
            Console.ReadKey();
        }
    }
}
