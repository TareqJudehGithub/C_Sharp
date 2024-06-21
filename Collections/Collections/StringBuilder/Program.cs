using System.Text;

Console.WriteLine("String Builder\n");

StringBuilder builder = new StringBuilder();

builder.Append("Hello");
Console.WriteLine(builder);

builder.Append(" world!");
Console.WriteLine(builder);


builder.Remove(11, 1);
Console.WriteLine(builder);

builder.Replace('w', 'W');
Console.WriteLine(builder);
