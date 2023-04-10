namespace Class_Three;

internal class Head
{
    private Person attachedTo { get; }

    public Head(Person p)
    {
        this.attachedTo = p;
    }
}