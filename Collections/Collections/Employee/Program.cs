using Employee;

Console.WriteLine("Employee records\n");

// Objects
Employees employee = new Employees();
Search search = new Search();

// Add new employees, and output them after finish adding them.
employee.AddEmployee();

employee.ShowEmployees();
search.SearchEmp(employee);








