namespace ClassThree_VerticalRelations;

internal class Cat: Animal
{
    public int Claws { get; set; }
    
    public Cat(string name, int legs, int claws) : base(name, legs)
    {
        this.Claws = claws;
        this.legs = 4;
    }

    public void Jump()
    {
        Console.WriteLine("Bump!");
    }
}