// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercise: Animals\n");
/* Implement Animal (base class).
 * Implement Lion, Tiger, Duck, and Spider derived classes.
 * Inherit and override method NumberOfLegs(), changing the number of legs for each animal.
*/

// Objects
Exercise result = new Exercise();
//Console.WriteLine(result.GetcountsOfAnimalLegs().Count());
List<int> animalLegs = result.GetcountsOfAnimalLegs();

List<int> legsCount = new List<int>();
foreach (int leg in animalLegs)
{
    legsCount.Add(leg);
    Console.WriteLine(leg);
}

public class Exercise
{
    public List<int> GetcountsOfAnimalLegs()
    {
        var animals = new List<Animal>
        {
            new Lion(),
            new Tiger(),
            new Duck(),
            new Spider()
        };
        var result = new List<int>();
        foreach (var animal in animals)
        {
            result.Add(animal.NumberOfLegs());
        }
        return result;
    }
}
public class Animal
{
    public virtual int NumberOfLegs()
    {
        return 4;
    }
}

public class Lion : Animal
{
    public override int NumberOfLegs()
    {
        return base.NumberOfLegs();
    }
}

public class Tiger : Animal
{
    public override int NumberOfLegs()
    {
        return base.NumberOfLegs();
    }
}
public class Duck : Animal
{
    public override int NumberOfLegs()
    {
        return 2;
    }
}
public class Spider : Animal
{
    public override int NumberOfLegs()
    {
        return 8;
    }
}
