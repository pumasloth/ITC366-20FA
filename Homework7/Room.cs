namespace Homework7
{
    /// <summary>
    /// The room class.
    /// </summary>
    public class Room
    {
        /// <summary>
        /// The length of the room.
        /// </summary>
        public readonly int length;

        /// <summary>
        /// The width of the room.
        /// </summary>
        public readonly int width;

        /// <summary>
        /// The height of the room.
        /// </summary>
        public readonly int height;

        /// <summary>
        /// The surface area.
        /// </summary>
        public int surfaceArea;

        /// <summary>
        /// The number of gallons needed.
        /// </summary>
        public int gallons;

        /// <summary>
        /// The room constructor.
        /// </summary>
        /// <param name="length">The length of the room.</param>
        /// <param name="width">The width of the room.</param>
        /// <param name="height">The height of the room.</param>
        public Room(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;

            GetSurfaceArea();
            GetNumberOfGallonsNeeded();
        }

        /// <summary>
        /// Calculate the surface area for a room.
        /// </summary>
        private void GetSurfaceArea()
        {
            surfaceArea = (length * height * 2) + (width * height * 2);
        }

        /// <summary>
        /// Calculate the number of gallons needed based on square footage.
        /// </summary>
        private void GetNumberOfGallonsNeeded()
        {
            // A room requires one gallon of paint for every 350 square feet.
            const int GALLONS_PER_SQUARE_FEET = 350;
            gallons = surfaceArea / GALLONS_PER_SQUARE_FEET;

            // Add an extra gallon for any square feet greater than 350.
            if (surfaceArea % GALLONS_PER_SQUARE_FEET != 0)
            {
                gallons++;
            }
        }
    }
}
