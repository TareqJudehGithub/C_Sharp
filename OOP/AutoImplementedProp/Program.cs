Console.WriteLine("Auto-implemented Properties\n");

#region Objects
Customer customer1 = new Customer(id: 1, name: "John Smith", address: "Yorkshire, England");
customer1.ShowCustomerDetails();

Customer customer2 = new Customer(id: 2, name: "Sarah Adams");
customer2.ShowCustomerDetails();

Console.ReadKey();
#endregion

public class Customer
{
    #region Fields
    private int _customerID;
    private string _customerName;
    private string _address;
    #endregion

    #region Properties
    public int CustomerID { get; set; }
    public string CustomerName { get; set; }
    private string Address { get; set; } = "Goldshire, Stormwind";
    #endregion

    #region Constructors

    public Customer(int id, string name)
    {
        CustomerID = id;
        CustomerName = name;
    }
    public Customer(int id, string name, string address)
    {
        CustomerID = id;
        CustomerName = name;
        Address = address;
    }
    #endregion

    #region Methods    
    public void ShowCustomerDetails()
    {
        Console.WriteLine($"Customers Details:" +
            $"ID: {CustomerID}\n" +
            $"Name: {CustomerName}\n" +
            $"Address: {Address}\n");
    }
    #endregion
}
