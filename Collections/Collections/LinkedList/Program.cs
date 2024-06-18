// See https://aka.ms/new-console-template for more information
Console.WriteLine("Linked Lists\n");

LinkedList<int> linkedList = new LinkedList<int>();

for (int i = 0; i <= 10; i++)
{
    linkedList.AddLast(i);
}

foreach (int num in linkedList)
{
    Console.WriteLine(num);
}