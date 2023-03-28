namespace ClassTwo;

public class Square
{
    // Attributes
    private int x;
    private int y;
    private int size;

    public int Area
    {
        get { return this.size * this.size; }
    }
    
    public int Perimeter
    {
        get { return this.size * 4; }
    }
    
    // Another example on setting up getter and setter:
    // public int example { get; set; }
    
    // Getter
    public int getSize()
    {
        return this.size;
    }

    // Setter
    public void setSize(int size)
    {
        if (size > 0)
        {
            this.size = size;
        }
    }
    
    // Constructor
    public Square()
    {
        this.x = 0;
        this.y = 0;
        this.size = 1;
    }
    
    // Another example of constructor
    /*
    public Square(int x, int y, int size)
    {
        this.x = x;
        this.y = y;
        this.size = size;
    }
    */
    
    // Methods
    public void TranslateX(int tx)
    {
        x += tx;
    }
    
    public void TranslateY(int ty)
    {
        y += ty;
    }

    public void TranslateXY(int tx, int ty)
    {
        this.TranslateX(tx);
        this. TranslateY(ty);
    }

}