namespace ClassThree_VerticalRelations;

internal class Dog: Animal
{
    public int Toys { get; set; }
    
    public Dog(string name, int legs, int toys) : base(name, legs)
    {
        this.Toys = toys;
        this.legs = 4;
    }

    public void Bite()
    {
        Console.WriteLine("GRRRR!");
    }
}