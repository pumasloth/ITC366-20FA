namespace Homework_Template
{
    using System;
    using System.Linq;

    using Homework8;

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
            Console.WriteLine("Homework 8");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1 (Have you been working lately?).");
            Console.WriteLine("Hit [2] to run Exercise 2 (How much to replace your roof?).");
            Console.WriteLine("Hit [3] to run Exercise 3 (Rushin').");
            Console.WriteLine("Hit [4] to run Exercise 4 (Repeat customer).");
            Console.WriteLine("Hit [5] to run Exercise 5.");

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
        /// The do exe 1.
        /// </summary>
        private static void DoExe1()
        {
            Console.WriteLine("Exercise 1");

            Job job1 = new Job(213, "Layla", "Tree trimming", 5);
            Job job2 = new Job(112, "Smith", "Road resurfacing", 20);
            Job job3 = new Job(213, "Stacy", "Moving", 15);

            Console.WriteLine(job1.ToString());
            Console.WriteLine(job2.ToString());
            Console.WriteLine(job3.ToString());

            if (Job.Equals(job1, job2))
            {
                Console.WriteLine($"{job1.GetHashCode()} for {job1.CustomerName}" +
                    $" has the same job number as {job2.GetHashCode()} for {job2.CustomerName}");
            }

            if (Job.Equals(job1, job3))
            {
                Console.WriteLine($"{job1.GetHashCode()} for {job1.CustomerName}" +
                    $" has the same job number as {job3.GetHashCode()} for {job3.CustomerName}");
            }

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// The do exe 2.
        /// </summary>
        private static void DoExe2()
        {
            Console.WriteLine("Exercise 2");

            Job[] jobs = new Job[5];
            for (int i = 0; i < jobs.Length; i++)
            {
                Console.Write("Enter job number >> ");
                if (int.TryParse(Console.ReadLine(), out int jobNumber))
                {
                    if (jobs.Any(j => j?.Id == jobNumber))
                    {
                        // Duplicate job number entered. Keep them in the loop.
                        Console.WriteLine($"Sorry, the job number {jobNumber} is a duplicate.");
                        i--;
                        continue;
                    }

                    Console.Write("Enter customer name >> ");
                    var customerName = Console.ReadLine();
                    Console.Write("Enter job description >> ");
                    var jobDescription = Console.ReadLine();
                    Console.Write("Enter estimated hours for job >> ");
                    int.TryParse(Console.ReadLine(), out int hours);
                    jobs[i] = new Job(jobNumber, customerName, jobDescription, hours);
                }
                else
                {
                    // Invalid data entered. Keep them in the loop.
                    i--;
                }
            }

            Console.WriteLine("\nSummary\n");

            double totalPrice = 0;
            foreach (var job in jobs)
            {
                Console.WriteLine(job.ToString());
                totalPrice += job.Hours * job.Price;
            }

            Console.WriteLine();
            Console.WriteLine($"Total for all jobs is {totalPrice:C}");

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// The do exe 3.
        /// </summary>
        private static void DoExe3()
        {
            Console.WriteLine("Exercise 3");

            RushJob[] rushJobs = new RushJob[5];
            for (int i = 0; i < rushJobs.Length; i++)
            {
                Console.Write("Enter job number >> ");
                if (int.TryParse(Console.ReadLine(), out int jobNumber))
                {
                    if (rushJobs.Any(j => j?.Id == jobNumber))
                    {
                        // Duplicate job number entered. Keep them in the loop.
                        Console.WriteLine($"Sorry, the job number {jobNumber} is a duplicate.");
                        i--;
                        continue;
                    }

                    Console.Write("Enter customer name >> ");
                    var customerName = Console.ReadLine();
                    Console.Write("Enter job description >> ");
                    var jobDescription = Console.ReadLine();
                    Console.Write("Enter estimated hours for job >> ");
                    int.TryParse(Console.ReadLine(), out int hours);
                    rushJobs[i] = new RushJob(jobNumber, customerName, jobDescription, hours);
                }
                else
                {
                    // Invalid data entered. Keep them in the loop.
                    i--;
                }
            }

            Console.WriteLine("\nSummary\n");

            double totalPrice = 0;
            foreach (var rushJob in rushJobs)
            {
                Console.WriteLine(rushJob.ToString());
                totalPrice += (rushJob.Hours * rushJob.Price) + RushJob.PREMIUM;
            }

            Console.WriteLine();
            Console.WriteLine($"Total for all jobs is {totalPrice:C}");

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// The do exe 4.
        /// </summary>
        private static void DoExe4()
        {
            Console.WriteLine("Exercise 4");

            Customer aRegularCustomer = new Customer();
            FrequentCustomer aFrequentCustomer = new FrequentCustomer();
            aRegularCustomer.CustNum = 2514;
            aRegularCustomer.CustBal = 765.00;
            aFrequentCustomer.CustNum = 5719;
            aFrequentCustomer.CustBal = 2_500.00;
            aFrequentCustomer.DiscountRate = 0.15;
            Console.WriteLine(
                "\naRegularCustomer #{0} owes {1}",
                aRegularCustomer.CustNum,
                aRegularCustomer.CustBal.ToString("C2"));
            Console.WriteLine(
                "\naFrequentCustomer #{0} would owe {1} without the discount",
                aFrequentCustomer.CustNum,
                aFrequentCustomer.CustBal.ToString("C2"));
            double newBal = (1 - aFrequentCustomer.DiscountRate) *
                            aFrequentCustomer.CustBal;
            Console.WriteLine(
                "...with {0} discount, customer owes {1}",
                aFrequentCustomer.DiscountRate.ToString("P"),
                newBal.ToString("C"));

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// The do exe 5.
        /// </summary>
        private static void DoExe5()
        {
            Console.WriteLine("This is not the method you are looking for...");
        }
    }
}