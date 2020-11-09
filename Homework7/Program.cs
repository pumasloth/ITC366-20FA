namespace Homework_Template
{
    using System;
    using Homework7;

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
            Console.WriteLine("Homework 7");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1 (How many commission are you making today?).");
            Console.WriteLine("Hit [2] to run Exercise 2 (How much paint will you need today?).");
            Console.WriteLine("Hit [3] to run Exercise 3 (How much tax are you paying today?).");
            Console.WriteLine("Hit [4] to run Exercise 4 (Little Red Corvette).");
            Console.WriteLine("Hit [5] to run Exercise 5 (Gone Fishin').");

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
        /// Display a <see cref="SalesTransaction"/> when called with different values.
        /// </summary>
        private static void DoExe1()
        {
            Console.WriteLine("Exercise 1");

            SalesTransaction st1 = new SalesTransaction("Todd", 2000, 0.15);
            SalesTransaction st2 = new SalesTransaction("Larry", 5000);
            SalesTransaction st3 = new SalesTransaction("Ashley");
            SalesTransaction total = st1 + st2 + st3;

            Display(st1);
            Display(st2);
            Display(st3);
            DisplayTotal(total);

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Determine the amount of paint (in gallons) required to paint a room.
        /// </summary>
        private static void DoExe2()
        {
            Console.WriteLine("Exercise 2");

            Room[] rooms = new Room[8];
            int length = 8;
            int width = 8;
            int height = 8;

            for (int i = 0; i < rooms.Length; i++)
            {
                rooms[i] = new Room(length, width, height);
                length += 3;
                width += 2;
                if (i % 2 == 1)
                {
                    height += 1;
                }
            }

            // Get all the rooms and output the dimensions and paint needed.
            foreach (var room in rooms)
            {
                Console.WriteLine($"For a {room.length} X {room.width} X {room.height} foot room");
                Console.WriteLine($"\tTwo walls are {room.length} long and {room.height} high");
                Console.WriteLine($"\t\tand the other two walls are {room.width} long and {room.height} high");
                Console.WriteLine($"\tTotal wall area is {room.surfaceArea}, so you need {room.gallons} gallon(s) of paint.");

                // New line.
                Console.WriteLine();
            }

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Inventory 10 items and calculate the sales tax for each sale.
        /// </summary>
        private static void DoExe3()
        {
            Console.WriteLine("Exercise 3");

            Sale[] sales = new Sale[10];

            for (int i = 0; i < sales.Length; i++)
            {
                // Add 1 to i when prompting user for so it is 1 through 10.
                Console.Write($"Enter inventory number #{i + 1} >> ");
                int inventoryId = int.Parse(Console.ReadLine());
                Console.Write("Enter amount of sale >> ");
                double saleAmount = double.Parse(Console.ReadLine());
                sales[i] = new Sale(inventoryId, saleAmount);
            }

            for (int i = 0; i < sales.Length; i++)
            {
                var sale = sales[i];
                // Add 1 to i when prompting user for so it is 1 through 10.
                Console.WriteLine($"Sale # {i + 1} Amount: {i + 1} Sale {sale.SaleAmount:C}");
                Console.WriteLine($"\t Tax is {sale.TaxOwed:C}");
            }

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Display the color of <see cref="Car"/>s and their cost.
        /// </summary>
        private static void DoExe4()
        {
            Console.WriteLine("Exercise 4");

            Car myCar = new Car(32000, "red");
            Car yourCar = new Car(14000);
            Car theirCar = new Car();
            Console.WriteLine("My {0} car cost {1}", myCar.Color, myCar.Price.ToString("c2"));
            Console.WriteLine("Your {0} car cost {1}", yourCar.Color, yourCar.Price.ToString("c2"));
            Console.WriteLine("Their {0} car cost {1}", theirCar.Color, theirCar.Price.ToString("c2"));

        // Pause until the user hits enter.
        Console.ReadKey();
        }

        /// <summary>
        /// Determine the price of a boat license based on the motor's horse power.
        /// </summary>
        private static void DoExe5()
        {
            Console.WriteLine("Exercise 5");

            const int STARTING_NUM = 201601;
            BoatLicense[] license = new BoatLicense[3];
            int x;
            for (x = 0; x < license.Length; ++x)
            {
                license[x] = new BoatLicense();
                license[x].LicenseNum = (x + "" + STARTING_NUM);
            }
            license[0].State = "WI";
            license[1].State = "MI";
            license[2].State = "MN";
            license[0].MotorSizeInHP = 30;
            license[1].MotorSizeInHP = 50;
            license[2].MotorSizeInHP = 100;
            for (x = 0; x < license.Length; ++x)
                Display(license[x]);

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Output a <see cref="SalesTransaction"/>.
        /// </summary>
        /// <param name="st">The <see cref="SalesTransaction"/> sales transaction.</param>
        private static void Display(SalesTransaction st)
        {
            Console.WriteLine($"{st.salesPersonName} had sales totaling {st.salesAmount}." +
                $" Commission rate is {st.commissionRate};" +
                $" commission value is {st.commission}");
        }

        /// <summary>
        /// Output the total amount of sales.
        /// </summary>
        /// <param name="st">The <see cref="SalesTransaction"/> sales transaction.</param>
        private static void DisplayTotal(SalesTransaction st)
        {
            Console.WriteLine($"Total sales: {st.salesAmount:C}");
        }

        /// <summary>
        /// Display a boat license.
        /// </summary>
        /// <param name="bl">The <see cref="BoatLicense"/> boat license.</param>
        private static void Display(BoatLicense bl)
        {
            Console.WriteLine($"Boat #{bl.LicenseNum} from {bl.State} has a {bl.MotorSizeInHP} HP motor.");
            Console.WriteLine($"\t The price for the license is {bl.Price:C}");
        }
    }
}