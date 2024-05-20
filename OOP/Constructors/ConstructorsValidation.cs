namespace Constructors
{
    internal class Rectangle
    {
        #region Fields
        private int _width;
        private int _height;
        #endregion

        #region Constructors
        public Rectangle(int width, int height)
        {
            this._width = GetLengthOrDefault(length: width, nameof(_width));
            this._height = GetLengthOrDefault(length: height, nameof(_height));
        }
        #endregion

        #region Methods
        public int CalculateCircumference() => (_width * 2) + (_height * 2);
        public int CalculateArea() => _width * _height;

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
