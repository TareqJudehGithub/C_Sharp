namespace Triangle
{
    internal struct MyTriangle
    {
        #region Properties
        internal double Base { get; set; }
        internal double Height { get; set; }
        #endregion

        #region Constructors
        internal MyTriangle(double length, double height)
        {
            Base = length;
            Height = height;
        }
        #endregion

        internal double CalculateArea(double length, double height)
        {

            double area = ((double)1 / 2) * length * height;
            return area;
        }
        internal void ShowResult()
        {
            Console.WriteLine($"Base: {Base}, Height: {Height}");
            Console.WriteLine($"Triangle area = {CalculateArea(Base, Height)} cm");
        }
    }
}


