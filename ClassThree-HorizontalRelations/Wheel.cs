using System.Diagnostics;

namespace Class_Three;

internal class Wheel
{
    public Car attachedTo { get; set; }

    public void attach(Car attachedTo)
    {
        this.attachedTo = attachedTo;
    }

    public void unmount()
    {
        this.attachedTo = null;
    }
}