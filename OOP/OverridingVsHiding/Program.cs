// See https://aka.ms/new-console-template for more information
Console.WriteLine("Method Overriding VS Method Hiding\n");

#region Objects
BaseClass baseClass = new DerivedClass();
baseClass.Print();
baseClass.WelcomeUser();
Console.WriteLine("");

DerivedClass derived = new DerivedClass();
derived.Print();
derived.WelcomeUser();
#endregion

Console.ReadKey();

public class BaseClass
{

    #region Methods
    public virtual void Print()
    {
        Console.WriteLine("This is the base class Print method.");
    }
    public void WelcomeUser()
    {
        Console.WriteLine("Hello world from the base class!");
    }
    #endregion
}

public class DerivedClass : BaseClass
{
    #region Methods
    // Method Override
    public override void Print()
    {
        Console.WriteLine("This is the derived class Print method.");
    }

    // Method Hiding
    public new void WelcomeUser()
    {
        //base.WelcomeUser();
        Console.WriteLine("Hello world from the derived class!");
    }
    #endregion
}

