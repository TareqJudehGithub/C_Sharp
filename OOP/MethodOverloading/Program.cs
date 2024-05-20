// See https://aka.ms/new-console-template for more information

using MethodOverloading;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("MethodOverloading\n");

        Program progObj = new Program();
        progObj.Add(10, 15);
        progObj.Add(10, 12, 24);
        progObj.Add(5.75D, 17.25D, 9.5D);

        Console.WriteLine("Medical Appointment\n");

        MedicalAppointment patient1 = new MedicalAppointment(
            patientName: "John Smith",
            date: DateTime.Now
            );

        patient1.ShowInfo();

        // Overwrite month and day
        patient1.Reschedule(1, 5);
        // Add a given number of months and days
        patient1.Reschedule(3, 2);



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


