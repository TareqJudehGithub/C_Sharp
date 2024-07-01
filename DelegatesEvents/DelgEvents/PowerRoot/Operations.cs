internal class Operations
{
    #region Properties
    internal static double FirstValue { get; set; }
    internal static double SecondValue { get; set; }
    #endregion

    #region Methods
    internal static double Power(double x, double y)
    {
        double toThePwrOf = Math.Pow(x, y);
        return toThePwrOf;
    }
    internal static double Root(double x, double y)
    {
        double rootOf = Math.Sqrt(x);
        return rootOf;
    }
    #endregion
}

