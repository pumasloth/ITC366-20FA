namespace Homework7
{
    class Car
    {
        private string color;
        private int price;
        public Car() : this(10000, "black")
        {
        }
        public Car(int price) : this()
        {
        }
        public Car(int price, string color)
        {
            Price = price;
            Color = color;
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
    }
}
