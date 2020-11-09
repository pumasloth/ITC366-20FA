namespace Homework_Template
{
    /// <summary>
    /// The boatlicense class.
    /// </summary>
    public class BoatLicense
    {
        /// <summary>
        /// The cutoff for determining the price of the license.
        /// </summary>
        public const int HP_CUT_OFF = 50;

        /// <summary>
        /// The fee for any engine under and including 50HP.
        /// </summary>
        public const double LOW_FEE = 25.00;
        
        /// <summary>
        /// The fee for any engine greater than 50HP.
        /// </summary>
        public const double HIGH_FEE = 38.00;

        /// <summary>
        /// The license number.
        /// </summary>
        public string LicenseNum { get; set; }

        /// <summary>
        /// The state the license is in.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The motor size in horse power.
        /// </summary>
        private int motorSizeInHP;

        /// <summary>
        /// The motor size in horse power.
        /// </summary>
        public int MotorSizeInHP
        {
            get
            {
                return motorSizeInHP;
            }

            set
            {
                motorSizeInHP = value;

                // The price of a licence is $25 if the boat motor is 50 HP or under
                // and $38 if the HP is over 50.
                if (MotorSizeInHP <= HP_CUT_OFF)
                {
                    Price = LOW_FEE;
                }
                else
                {
                    Price = HIGH_FEE;
                }
            }
        }

        /// <summary>
        /// The price for the license.
        /// </summary>
        public double Price { get; private set; }
    }
}