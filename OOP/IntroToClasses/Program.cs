// Creating instance of the Employee class
Employee employeeOne = new Employee();
employeeOne.firstName = "John";
employeeOne.lastName = "Smith";
employeeOne.salary = 20000;
employeeOne.yearsOfService = 5;

employeeOne.PrintFullName();

// Another way to create(instantiate) objects
Employee employeeNoTwo = new Employee()
{
    firstName = "Sarah",
    lastName = "Adams",
    salary = 10000,
    yearsOfService = 0
};
employeeNoTwo.PrintFullName();

Console.ReadKey();

#region Classes

public class Employee
{
    #region Fields
    public string firstName;
    public string lastName;
    public int salary;
    public int yearsOfService;
    #endregion

    #region Methods
    public void PrintFullName()
    {
        Console.WriteLine($"The full name is: {firstName} {lastName}.");
    }
    #endregion
}
#endregion

