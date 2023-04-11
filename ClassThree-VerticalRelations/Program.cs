// See https://aka.ms/new-console-template for more information
using ClassThree_VerticalRelations;

Console.WriteLine("Hello, World!");

Dog mozo = new Dog("Mozo", 4, 2);
mozo.Eat();
mozo.Move();
mozo.Bite();

Duck donald = new Duck("Donald", 4, 2);
donald.Move();

LinkedList<Animal> farm = new LinkedList<Animal>();
farm.AddLast(mozo);
farm.AddLast(donald);

foreach (Animal castillo in farm)
{
    // it is not possible to call the name of the animal because it was
    // set as protected. It would be possible with public
    castillo.Eat();
    castillo.Move();
}

LinkedList<Flyable> airness = new LinkedList<Flyable>();
airness.AddLast(donald);
airness.AddLast(new Plane());

foreach (Flyable air in airness)
{
    air.Fly();
}

