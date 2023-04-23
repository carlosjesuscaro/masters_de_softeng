namespace OOP_Exercise;

internal class Teacher: Person
{
    public int salary { get; set; }
    public Teacher(string first, string last, int salary) : base(first, last)
    {
        this.salary = salary;
    }
    
    public Teacher changeSalary(int salary)
    {
        if (this.salary != salary)
        {
            this.salary = salary;
            Console.WriteLine("Salary has been updated");
            return this;
        }
        else
        {
            Console.WriteLine("Salary is the same");
            return this;
        }
    }
    
    public override string Showing()
    {
        return $"{base.Showing()} Role: Teacher";
    }
}