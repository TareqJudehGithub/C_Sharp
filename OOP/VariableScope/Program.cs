Console.WriteLine("Variable Scope\n");

public class MyClass
{
    private int _id;   // class-level variable
    public void GreeUser()
    {
        string userName;   // method-level variable
    }

    public void PrintMe() // Block-level scope
    {
        for (int i = 0; i < 3; i++)
        // i variable cannot be accessed outside outside this loop
        {
            Console.WriteLine(i);
        }
    }
}
