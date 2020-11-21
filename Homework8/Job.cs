namespace Homework8
{
    using System;

    /// <summary>
    /// The job.
    /// </summary>
    public class Job
    {
        /// <summary>
        /// The fee.
        /// </summary>
        public const double FEE = 45.00;

        /// <summary>
        /// Initializes a new instance of the <see cref="Job"/> class.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="customerName">
        /// The customer name.
        /// </param>
        /// <param name="description">
        /// The description.
        /// </param>
        /// <param name="hours">
        /// The hours.
        /// </param>
        public Job(int id, string customerName, string description, int hours)
        {
            this.Id = id;
            this.CustomerName = customerName;
            this.Description = description;
            this.Hours = hours;
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the customer name.
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the hours.
        /// </summary>
        public int Hours
        {
            get => this.hours;

            set
            {
                this.hours = value;
                {
                    this.Price = FEE;
                }
            }
        }

        /// <summary>
        /// Gets the price.
        /// </summary>
        public double Price { get; private set; }

        /// <summary>
        /// Gets or sets the hours.
        /// </summary>
        private int hours{ get; set; }

        /// <summary>
        /// Get the job id.
        /// </summary>
        /// <returns>
        /// The <see cref="Job"/> id.
        /// </returns>
        public override int GetHashCode()
        {
            return this.Id;
        }

        /// <summary>
        /// The equals.
        /// </summary>
        /// <param name="job1">
        /// The job 1.
        /// </param>
        /// <param name="job2">
        /// The job 2.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// </exception>
        public static bool Equals(Job job1, Job job2)
        {
            if (job1 == null)
            {
                throw new ArgumentNullException(nameof(job1));
            }

            if (job2 == null)
            {
                throw new ArgumentNullException(nameof(job2));
            }

            return job1.Id == job2.Id;
        }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The entire <see cref="Job"/> to string.
        /// </returns>
        public override string ToString()
        {
            return $"Job {this.Id} {this.CustomerName} {this.Description} {this.Hours}" +
                $" hour(s) @{this.Price:C} per hour." +
                $" Total price is {this.Hours * this.Price:C}";
        }
    }
}
