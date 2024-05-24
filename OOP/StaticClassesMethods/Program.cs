Console.WriteLine("Static Classes and Static Methods\n");


// Objects

Console.WriteLine($"10 + 5 = {Calculator.Add(10, 5)} on {Calculator.ShowDate()}");
Console.WriteLine($"10 - 5 = {Calculator.Subtract(10, 5)}");
Console.WriteLine($"10 * 5 = {Calculator.Multiplie(10, 5)}");
Console.WriteLine($"10 / 5 = {Calculator.Divide(10, 5)}");
Console.ReadKey();

internal static class Calculator
{
    #region Backing Fields
    // A static class contains no instance fields,properties, or contructors.
    private static DateTime _operationDate;
    #endregion

    #region Properties
    // A static class contains no instance fields,properties, or contructors.
    #endregion

    #region Constructors
    // A static class contains no instance fields,properties, or contructors.
    static Calculator()
    {
        _operationDate = DateTime.Now;
    }
    public static string ShowDate()
    {
        return _operationDate.ToShortDateString();
    }
    #endregion

    #region Methods
    public static int Add(int a, int b) => a + b;
    public static int Subtract(int a, int b) => a - b;
    public static int Multiplie(int a, int b) => a * b;
    public static int Divide(int a, int b) => a / b;
    #endregion
}