namespace Class_Three;

internal class Car
{
    public Wheel[] wheels { get; } 
    
    public Car (int wheels)
    {
        this.wheels = new Wheel[wheels];
        for (int i = 0; i < wheels; i++)
        {
            this.wheels[i] = new Wheel();
            this.wheels[i].attach(this);
        }   
    }

    public Wheel unmount(int wh)
    {
        if (this.wheels[wh] != null)
        {
            this.wheels[wh].unmount();
            Wheel result = this.wheels[wh];
            this.wheels[wh] = null;
            return result;
        }
        return null;
    }
}