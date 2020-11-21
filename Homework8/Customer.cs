namespace Homework8
{
    /// <summary>
    /// The customer.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// The cust num.
        /// </summary>
        private int custNum;

        /// <summary>
        /// The cust balance.
        /// </summary>
        private double custBalance;

        /// <summary>
        /// Gets or sets the cust bal.
        /// </summary>
        public double CustBal
        {
            get => this.custBalance;
            set => this.custBalance = value;
        }

        /// <summary>
        /// Gets or sets the cust num.
        /// </summary>
        public int CustNum
        {
            get => this.custNum;
            set => this.custNum = value;
        }
    }
}