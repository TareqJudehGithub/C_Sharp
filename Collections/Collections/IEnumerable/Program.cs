Console.WriteLine("IEnumerable\n");

CustsomCollection customCollectoin = new CustsomCollection(
    new string[] { "aaa", "bbb", "ccc" }
    );

// Iterate over customCollection
foreach (var item in customCollectoin)
{
    Console.WriteLine(item);
}

Console.ReadKey();

public class CustsomCollection
{
    public string[] Words { get; }
    public CustsomCollection(string[] words)
    {
        Words = words;
    }
}
