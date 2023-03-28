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

// Working ith object methods (inherited methods that apply to all objects)

Square sq1 = new Square();
Square sq2 = new Square();
Square sq3 = new Square();
Rectangle rc1 = new Rectangle();

// Checking if the objects are the same
Console.WriteLine(sq1.Equals(sq2));
Console.WriteLine(Equals(sq1, sq2));
Console.WriteLine(ReferenceEquals(sq1, sq1));
// Checking the hash code of an object
Console.WriteLine("\nSquare hash: " + sqr.GetHashCode());
Console.WriteLine("Rectangle hash: " + rec.GetHashCode());
// Checking the type of an object
Console.WriteLine("sq1 type: " + sq1.GetType());
// Object to String
Console.WriteLine("String version of an object: " + sq3.ToString());
// Shallow copy of an object
Rectangle rc2 = rc1.ShallowCopy();

int x1 = 1;
int x2 = 1;
int x3 = 2;
Console.WriteLine("x1 and x2");
Console.WriteLine(Equals(x1, x2));
Console.WriteLine(ReferenceEquals(x1, x2));
Console.WriteLine(Equals(x1, x3));
Console.WriteLine(ReferenceEquals(x1, x3));
Console.WriteLine("sq1 and sq2");
Console.WriteLine(Equals(sq1, sq2));
Console.WriteLine(ReferenceEquals(sq1, sq2));
Console.WriteLine(sq1);
Console.WriteLine(sq1.ToString());