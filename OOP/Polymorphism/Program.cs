// See https://aka.ms/new-console-template for more information
Console.WriteLine("Polymorphism\n");


Employee[] employees = new Employee[4];
employees[0] = new Employee
{
    FirstName = "John",
    LastName = "Smith",
    Description = "Manager"
};
employees[1] = new PartTimeEmployee
{
    FirstName = "Sarah",
    LastName = "Adams",
    Description = "Part Time Employee"
};
employees[2] = new FullTimeEmployee
{
    FirstName = "Ali",
    LastName = "Ahmad",
    Description = "Full Time Employee"
};
employees[3] = new ContractorEmployee
{
    FirstName = "Reema",
    LastName = "Al Sayed",
    Description = "Contractor"
};

// Iterate over the employees array and display all items (employees in it)
foreach (var employee in employees)
{
    employee.PrintFullName();
    Console.WriteLine("");
}

public class Employee
{
    #region Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Description { get; set; }
    #endregion
    #region MyRegion

    #endregion


    #region Methods
    public virtual void PrintFullName()
    {
        Console.WriteLine($"Employee name: {FirstName} {LastName} - {Description}");
    }

    #endregion

}

public class FullTimeEmployee : Employee
{
    #region Methods
    public override void PrintFullName()
    {
        base.PrintFullName();
        Console.WriteLine("This is the derived method.\n");
    }
    #endregion
}

public class PartTimeEmployee : Employee
{
    #region Methods
    public override void PrintFullName()
    {
        base.PrintFullName();
        Console.WriteLine("This is the derived method.\n");
    }
    #endregion
}
public class ContractorEmployee : Employee
{
    #region Methods
    public override void PrintFullName()
    {
        base.PrintFullName();
        Console.WriteLine("This is the derived method.\n");
    }
    #endregion
}