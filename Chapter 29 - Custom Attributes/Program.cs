using System;

// Custom Attributes
[AttributeUsage(
    AttributeTargets.Class |
    AttributeTargets.Constructor |
    AttributeTargets.Field |
    AttributeTargets.Method |
    AttributeTargets.Property,
    AllowMultiple = true)
]

public class DebugInfo : System.Attribute
{
    private int bugNo;
    private string developer;
    private string lastReview;
    public string message;

    public DebugInfo(int bg, string dev, string d)
    {
        this.bugNo = bg;
        this.developer = dev;
        this.lastReview = d;
    }

    public int BugNo { get; private set; }
    public string Developer { get; private set; }
    public string LastReview { get; private set; }
    public string Message { get; set; }
}

[DebugInfo(420, "Elon Musk", "28/06/1971", Message = "Return type mismatch")]
[DebugInfo(69, "Bart Simspon", "23/02/2012", Message = "Unused variable")]
class Rectangle
{
    protected double length;
    protected double width;

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    [DebugInfo(55, "Zara Ali", "19/10/2012", Message = "Return type mismatch")]
    public double GetArea()
    {
        return length * width;
    }

    [DebugInfo(56, "Zara Ali", "19/10/2012")]
    public void Display()
    {
        Console.WriteLine("Length: {0}", length);
        Console.WriteLine("Width: {0}", width);
        Console.WriteLine("Area: {0}", GetArea());
    }

    public static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(10, 20);
        rectangle.Display();
    }
}
// pg 239 - 242