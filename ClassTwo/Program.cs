// See https://aka.ms/new-console-template for more information

using ClassTwo;

Console.WriteLine("Hello, World!");
Square sqr = new Square();
Console.WriteLine("Square examples:");
Console.WriteLine("Area: " + sqr.ComputeArea());
Console.WriteLine("Perimeter: " + sqr.ComputePerimeter());

Console.WriteLine("\nRectangle examples:");
Rectangle rec = new Rectangle();
rec.A = 10;
rec.B = 20;
Console.WriteLine("Enter the name of the rectangle: ");
rec.Name = Console.ReadLine();
Console.WriteLine("Area: " + rec.ComputeArea());
Console.WriteLine("Perimeter: " + rec.ComputePerimeter());
Console.WriteLine("Rectangle name: " + rec.Name);