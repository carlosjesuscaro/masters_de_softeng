namespace Class_Three;

// Horizontal relationship: composition
internal class Head
{
    private Person attachedTo { get; }

    public Head(Person p)
    {
        this.attachedTo = p;
    }
}