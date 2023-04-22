namespace Class_Three;

// Horizontal relationship: composition
internal class Person
{
    private Head hd { get; }

    public Person()
    {
        this.hd = new Head(this);
    }
}