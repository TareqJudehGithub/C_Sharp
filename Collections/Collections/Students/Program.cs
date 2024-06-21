// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dictionaries\n");

// Create a new dictionary object
Dictionary<string, int> students = new Dictionary<string, int>();

students["John"] = 21;
students["Sarah"] = 19;
students["Ali"] = 18;

Dictionary<int, string> itemsCode = new Dictionary<int, string>
{
    {1, "Milk" },
    {2, "Bread" },
    {3, "Orange Juice" },
    {4, "Cereal" }
};

// Check if name (key) exists in students dictionary

Console.Write("Enter name: ");
string studentName = Console.ReadLine();

if (students.ContainsKey(studentName))
{
    Console.WriteLine($"{studentName} age is {students[studentName]}");
}
else
{
    Console.WriteLine("Student not found.");
}

