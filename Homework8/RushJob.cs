namespace Homework8
{
    /// <summary>
    /// The rush job.
    /// </summary>
    public class RushJob : Job
    {
        /// <summary>
        /// A RushJob has a $150.00 premium that is
        /// added to the normal price of the job.
        /// </summary>
        public const double PREMIUM = 150.00;

        /// <summary>
        /// Initializes a new instance of the <see cref="RushJob"/> class.
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
        public RushJob(int id, string customerName, string description, int hours)
            : base(id, customerName, description, hours)
        {
            this.Id = id;
            this.CustomerName = customerName;
            this.Description = description;
            this.Hours = hours;
        }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            return $"Rush Job {this.Id} {this.CustomerName} {this.Description} {this.Hours}" +
                $" hour(s) @{this.Price:C} per hour." +
                $" Rush job adds $150 premium." +
                $" Total price is {(this.Hours * this.Price) + PREMIUM:C}";
        }
    }
}
