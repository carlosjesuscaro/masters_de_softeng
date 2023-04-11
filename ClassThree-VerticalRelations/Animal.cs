namespace ClassThree_VerticalRelations;

internal class Animal
{
    protected string name;
    protected int legs;

    public Animal(string name, int legs)
    {
        this.name = name;
        this.legs = legs;
    }

    public virtual void Move()
    // virtual so that it can be overwritten
    {
        Console.WriteLine("I am running");
    }

    public void Eat()
    {
        Console.WriteLine("I am eating");
    }
}