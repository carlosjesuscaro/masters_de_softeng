namespace ClassTwo;

public class Rectangle
{
    // Attributes
    private int x;
    private int y;
    public int a { get; set; }
    public int b { get; set; }

    // Methods
    public int ComputeArea()
    {
        return this.a * this.b;
    }

    public int ComputePerimeter()
    {
        return 2 * (this.a + this.b);
    }

    // Constructor
    public Rectangle()
    {
        this.x = 0;
        this.y = 0;
        this.a = 2;
        this.b = 4;
    }

}