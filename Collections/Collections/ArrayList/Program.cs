// See https://aka.ms/new-console-template for more information
Console.WriteLine("Array Lists\n");

List<int> arrayList = new List<int>();

for (int i = 1; i <= 10; i++)
{
    arrayList.Add(i);
}

foreach (int num in arrayList)
{
    Console.WriteLine(num);
}

Console.WriteLine(arrayList[0]);