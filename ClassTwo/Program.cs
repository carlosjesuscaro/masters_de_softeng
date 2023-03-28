// See https://aka.ms/new-console-template for more information

using ClassTwo;

Console.WriteLine("Hello, World!");
Square sqr = new Square();
Console.WriteLine("Square examples:");
Console.WriteLine("Area: " + sqr.Area);
Console.WriteLine("Perimeter: " + sqr.Perimeter);

Console.WriteLine("\nRectangle examples:");
Rectangle rec = new Rectangle();
rec.A = 10;
rec.B = 20;
Console.WriteLine("Enter the name of the rectangle: ");
rec.Name = Console.ReadLine();
Console.WriteLine("Area: " + rec.ComputeArea());
Console.WriteLine("Perimeter: " + rec.ComputePerimeter());
Console.WriteLine("Rectangle name: " + rec.Name);

// Checking the hash code of an object
Console.WriteLine("\nSquare hash: " + sqr.GetHashCode());
Console.WriteLine("Rectangle hash: " + rec.GetHashCode());