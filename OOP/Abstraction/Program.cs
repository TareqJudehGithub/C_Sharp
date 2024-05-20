// See https://aka.ms/new-console-template for more information
Console.WriteLine("What is Abstration?\n");

#region Objects
Rectangle rectangle1 = new Rectangle(5, 10);
Rectangle rectangle2 = new Rectangle(10, 15);

DateTime time = new DateTime();

rectangle1.CalculateRectArea(5, 10);
rectangle2.CalculateRectArea(15, 25);
#endregion

Console.ReadKey();


// Data Hiding
class Rectangle
{
    #region Fields
    private int _width;
    private int _height;
    #endregion

    #region Constructors
    public Rectangle(int width, int height)
    {
        this._width = width;
        this._height = height;
    }
    #endregion

    #region Methods
    public void CalculateRectArea(int w, int h)
    {
        Console.WriteLine($"Rectangle Area with width {h}, and height {h} = {w * h}");
    }
    #endregion
}


