namespace Homework8
{
    /// <summary>
    /// The frequent customer.
    /// </summary>
    public class FrequentCustomer : Customer
    {
        /// <summary>
        /// The discount rate.
        /// </summary>
        private double discountRate;

        /// <summary>
        /// Gets or sets the discount rate.
        /// </summary>
        public double DiscountRate
        {
            get => this.discountRate;
            set => this.discountRate = value;
        }
    }
}