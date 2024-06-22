namespace ShapesArea
{
    internal class Circle : Shape
    {
        #region Methods
        internal double CalculateArea()
        {
            Raduis = 5;
            double area = PI * (Math.Pow(Raduis, 2));
            return area;
        }
        internal void ShowResult()
        {

            Console.WriteLine($"Circle area = {CalculateArea()} cm.");
        }
        #endregion
    }
}
