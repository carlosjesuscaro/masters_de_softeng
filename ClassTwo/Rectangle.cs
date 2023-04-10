using System.Drawing;

namespace ClassTwo;

public class Rectangle
{
    // Attributes
    private int x;
    private int y;
    
    // Attribute Short version 
    public int A { get; set;  }
    public int B { get; set; }
    
    // Attribute   Long version
    private string name;
    public string Name
    {
        get { return name; }
        set { this.name = value; }
    }

    // Methods
    public int ComputeArea()
    {
        return this.A * this.B;
    }

    public int ComputePerimeter()
    {
        return 2 * (this.A + this.B);
    }

    // Constructor
    public Rectangle()
    {
        this.x = 0;
        this.y = 0;
    }

    public Rectangle ShallowCopy()
    {
        return (Rectangle)this.MemberwiseClone();
    }

}