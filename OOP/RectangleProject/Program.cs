internal class Program
{
    static void Main(string[] args)
    {
        // Objects
        Rectangle rectangle = new Rectangle();
        AreaCalculator areaCalculator = new AreaCalculator();
        VolumeCalculator volumeCalculator = new VolumeCalculator();

        // User dimensions input:
        Console.Write("Enter width: ");
        int width = Convert.ToInt32(Console.ReadLine());
        rectangle.Width = width;

        Console.Write("Enter length: ");
        int length = Convert.ToInt32(Console.ReadLine());
        rectangle.Length = length;

        Console.Write("Enter height: ");
        int height = Convert.ToInt32(Console.ReadLine());
        volumeCalculator.Height = height;


        // Rectangle area
        int area = areaCalculator.CalculateArea(width: width, length: length);
        // Rectangle volume
        int volume = volumeCalculator.CalculateArea(length: length, width: width, height: height);

        // Output results of user inputs and calculations
        Console.Clear();
        Console.WriteLine($"Width: {width}\nLength: {length}\nHeight: {height}\nArea: {area}\nVolume: {volume}");
    }
}

internal class Rectangle
{
    #region Properties
    internal int Width { get; set; }
    internal int Length { get; set; }
    #endregion
}

internal class AreaCalculator : Rectangle
{
    internal int CalculateArea(int width, int length)
    {
        int area = width * length;
        return area;
    }
}

internal class VolumeCalculator : AreaCalculator
{
    #region Propeties
    internal int Height { get; set; }
    #endregion

    #region Methods
    internal int CalculateArea(int width, int length, int height)
    {
        int area = width * length * height;
        return area;
    }
    #endregion
}





