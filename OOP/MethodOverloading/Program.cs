// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("MethodOverloading\n");

        Program progObj = new Program();
        progObj.Add(10, 15);
        progObj.Add(10, 12, 24);
        progObj.Add(5.75D, 17.25D, 9.5D);

    }

    #region Methods
    public void Add(int firstNum, int secondNum)
    {
        Console.WriteLine($"Addition result = {firstNum + secondNum}");
    }

    // Method Overloading - different number of parameters
    public void Add(int firstNum, int secondNum, int thirdNumber)
    {
        Console.WriteLine($"Addition result = {firstNum + secondNum + thirdNumber}");
    }

    // Method Overloading - different type of parameters
    public void Add(double firstNum, double secondNum, double thirdNumber)
    {
        Console.WriteLine($"Addition result = {firstNum + secondNum + thirdNumber}");
    }
    #endregion


}


