namespace OOP_Exercise;

internal class Student: Person
{
    public int year { get; set; }
    public Student(string first, string last, int year) : base(first, last)
    {
        this.year = year;
    }
}