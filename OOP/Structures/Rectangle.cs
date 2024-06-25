namespace Structures
{
    internal struct RectangleStruc
    {
        #region Properties
        internal double Width { get; set; }
        internal double Height { get; set; }
        #endregion

        #region Constructors
        internal RectangleStruc(double width, double height)
        {
            Width = width;
            Height = height;
        }
        #endregion

        #region Methods
        internal double CalculateArea(double width, double height)
        {
            double area = width * height;
            return area;
        }

        internal void ShowResult()
        {
            Console.WriteLine($"Rectangle area = {CalculateArea(Width, Height)} cm");
        }
        #endregion
    }
}

