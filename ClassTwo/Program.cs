// See https://aka.ms/new-console-template for more information

using ClassTwo;

Console.WriteLine("Hello, World!");
Square sqr = new Square();
Console.WriteLine("Square examples:");
Console.WriteLine("Area: " + sqr.ComputeArea());
Console.WriteLine("Perimeter: " + sqr.ComputePerimeter());

Console.WriteLine("\nRectangle examples:");
Rectangle rec = new Rectangle();
Console.WriteLine("Area: " + rec.ComputeArea());
Console.WriteLine("Perimeter: " + rec.ComputePerimeter());