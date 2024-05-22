namespace Properties
{
    internal class Rectangle
    {
        #region Fields - Backing fields (does nothing)
        private int _width;
        #endregion

        #region Properties

        // Old School Setter/Getter
        internal int Width
        {
            set => _width = value;
            get => _width;
        }

        // Modern way
        internal int Height { get; private set; }


        #endregion

        #region Constructors
        public Rectangle(int width, int height)
        {
            Width = GetLengthOrDefault(length: width, nameof(Width));
            Height = GetLengthOrDefault(length: height, nameof(Height));
        }
        #endregion

        #region Methods
        public int CalculateCircumference() => (Width * 2) + (Height * 2);
        public int CalculateArea() => Width * Height;

        private int GetLengthOrDefault(int length, string name)
        {
            int defaultValueIfNotPositive = 1;

            if (length <= 0)
            {
                Console.WriteLine($"{name} must be a positive number.");
                return defaultValueIfNotPositive;
            }
            return length;
        }
        #endregion
    }
}

