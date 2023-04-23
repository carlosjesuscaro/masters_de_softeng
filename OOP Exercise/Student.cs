namespace OOP_Exercise;

internal class Student: Person
{
    public int year { get; set; }
    public Student(string first, string last, int year) : base(first, last)
    {
        this.year = year;
    }
    
    public Student changeYear(int year)
    {
        if (this.year != year)
        {
            this.year = year;
            Console.WriteLine("Year has been updated");
            return this;
        }
        else
        {
            Console.WriteLine("Year is the same");
            return this;
        }
    }

    public override string Showing()
    {
        return $"{base.Showing()} Role: Student";
    }
}