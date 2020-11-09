namespace Homework7
{
    /// <summary>
    /// The class for a sales transaction.
    /// </summary>
    public class SalesTransaction
    {
        /// <summary>
        /// The sales person name.
        /// </summary>
        public string salesPersonName;
        
        /// <summary>
        /// The sales amount.
        /// </summary>
        public double salesAmount;
        
        /// <summary>
        /// The commission amount.
        /// </summary>
        public double commission;

        /// <summary>
        /// The commission rate.
        /// </summary>
        public readonly double commissionRate;

        /// <summary>
        /// Constructor accepts values for the name, sales amount, and rate, and when the sales value is set,
        /// the constructor computes the commission as sales value times commission rate.
        /// </summary>
        /// <param name="name">The sales person name.</param>
        /// <param name="salesAmount">The amount from the sale.</param>
        /// <param name="rate">The commission rate.</param>
        public SalesTransaction(string name, double salesAmount, double rate)
        {
            this.salesPersonName = name;
            this.salesAmount = salesAmount;
            this.commissionRate = rate;
            this.commission = salesAmount * rate;
        }

        /// <summary>
        /// Constructor accepts a name and sales amount, but sets the commission rate to 0.
        /// </summary>
        /// <param name="name">The sales person name.</param>
        /// <param name="salesAmount">The amount from the sale.</param>
        public SalesTransaction(string name, double salesAmount)
        {
            this.salesPersonName = name;
            this.salesAmount = salesAmount;
            this.commissionRate = 0;
        }

        /// <summary>
        /// Constructor accepts a name and sets all the other fields to 0.
        /// </summary>
        /// <param name="name">The sales person name.</param>
        public SalesTransaction(string name)
        {
            this.salesPersonName = name;
            this.salesAmount = 0;
            this.commission = 0;
            this.commissionRate = 0;
        }

        /// <summary>
        /// The overloading + operator.
        /// </summary>
        /// <param name="st1">The first sales transaction to add.</param>
        /// <param name="st2">The second sales transaction to add.</param>
        /// <returns>A new totaled <see cref="SalesTransaction"/> sales transaction.</returns>
        public static SalesTransaction operator+(SalesTransaction st1, SalesTransaction st2)
        {
            string names;
            double totalSales = 0;

            names = $"{st1.salesPersonName} and {st2.salesPersonName}";
            totalSales += st1.salesAmount;
            totalSales += st2.salesAmount;

            return new SalesTransaction(names, totalSales);
        }
    }
}
