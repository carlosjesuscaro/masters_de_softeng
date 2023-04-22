namespace OOP_Exercise;

internal class Teacher: Person
{
    public int salary { get; set; }
    public Teacher(string first, string last, int salary) : base(first, last)
    {
        this.salary = salary;
    }
}