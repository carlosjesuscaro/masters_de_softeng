namespace ClassThree_VerticalRelations;

internal class Duck: Animal, Flyable
{
    public int Wings { get; set; }

    public Duck(string name, int legs, int wings) : base(name, legs)
    {
        this.Wings = wings;
        this.legs = 2;
    }

    public override void Move()
    {
        this.Fly();
    }
    
    public void Fly()
    {
        Console.WriteLine("I am flying with polymorphism!");
    }
    
    
    
}