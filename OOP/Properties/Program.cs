using Properties;

Console.WriteLine("Properties\n");

#region Objects
Employee emp1 = new Employee(id: 1, name: "John Smith");
emp1.ShowEmpDesc();
Console.WriteLine("");

Rectangle rectangle = new Rectangle(width: 10, height: 15);
int calcArea = rectangle.CalculateArea();
Console.WriteLine(calcArea);

Console.WriteLine(DateTime.Now.Year);
#endregion

/* 
 Rules:
- ID should not be negative
- Name cannot be set to NULL
- Salary should be read-only 
 */

public class Employee
{
    #region Fields
    private int _id;
    private string _name;
    private double _salary = 1000D;
    #endregion

    #region Properties
    // ID
    public int ID
    {
        set
        {
            if (value > 0)
            {
                this._id = value;
            }
            else
            {
                throw new Exception("ID cannot be less than 0");
            }
        }
        get
        {
            return this._id;
        }
    }
    // Name
    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name cannot be null.");
            }
            else
            {
                this._name = value;
            }
        }
        get
        {
            return this._name;
        }
    }
    // Salary
    public double Salary
    {
        get
        {
            return this._salary;
        }
    }

    #endregion

    #region Constructor
    public Employee(int id, string name)
    {
        ID = id;
        Name = name;
    }
    #endregion

    #region Methods
    public void ShowEmpDesc()
    {
        Console.WriteLine($"Employee Info:\nID: {ID}\nName: {Name}\nSalary: {Salary:C2}");
    }
    #endregion

}
