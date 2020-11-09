namespace Homework7
{
    /// <summary>
    /// The sale class.
    /// </summary>
    public class Sale
    {
        /// <summary>
        /// The inventory id.
        /// </summary>
        public int InventoryId { get; set; }
        
        /// <summary>
        /// The amount of the sale.
        /// </summary>
        public double SaleAmount { get; set; }
        
        /// <summary>
        /// The amount of tax owed.
        /// </summary>
        public readonly double TaxOwed = 0;

        /// <summary>
        /// Constructor for inventoryId and salesAmount.
        /// </summary>
        /// <param name="inventoryId">The inventory id.</param>
        /// <param name="saleAmount">The amount of the sale.</param>
        public Sale(int inventoryId, double saleAmount)
        {
            const double LOW_TAX_RATE = 0.06;
            const double HIGH_TAX_RATE = 0.08;
            const double AMOUNT_100_DOLLARS = 100.00;

            InventoryId = inventoryId;
            SaleAmount = saleAmount;

            // Assume that the tax rate is 8 percent for the first $100
            // and 6 percent for any amount greater than $100.
            if (SaleAmount <= AMOUNT_100_DOLLARS)
            {
                TaxOwed += CalculateSalesTax(saleAmount, HIGH_TAX_RATE);
            }
            else
            {
                // We are over 100, so calculate at 8% then add 6% for the remainder.
                TaxOwed += CalculateSalesTax(AMOUNT_100_DOLLARS, HIGH_TAX_RATE);
                double remainder = SaleAmount - AMOUNT_100_DOLLARS;
                TaxOwed += CalculateSalesTax(remainder, LOW_TAX_RATE);
            }
        }

        /// <summary>
        /// Calculate the sales tax for a sale.
        /// </summary>
        /// <param name="saleAmount">The amount of the sale.</param>
        /// <param name="taxPrecent">The percent of sales tax.</param>
        /// <returns>The tax amount owed from the sale.</returns>
        private static double CalculateSalesTax(double saleAmount, double taxPrecent)
        {
            return saleAmount * taxPrecent;
        }
    }
}
