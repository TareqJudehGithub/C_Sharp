Console.WriteLine("Static Classes and Static Methods\n");


// Objects
Calculator calculator = new Calculator();

Console.WriteLine($"10 + 5 = {calculator.Add(10, 5)}");
Console.WriteLine($"10 - 5 = {calculator.Subtract(10, 5)}");
Console.WriteLine($"10 * 5 = {calculator.Multiplie(10, 5)}");
Console.WriteLine($"10 / 5 = {calculator.Divide(10, 5)}");

internal class Calculator
{
    #region Backing Fields
    private int _a;
    private int _b;

    #endregion

    #region Properties
    public int A { get; set; }
    public int B { get; set; }

    #endregion

    #region Constructors

    #endregion

    #region Methods
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiplie(int a, int b) => a * b;
    public int Divide(int a, int b) => a / b;
    #endregion
}