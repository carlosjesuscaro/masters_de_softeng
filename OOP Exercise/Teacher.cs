namespace OOP_Exercise;

internal class Teacher: Person
{
    public int salary { get; set; }
    public Teacher(string first, string last, int salary) : base(first, last)
    {
        this.salary = salary;
    }

    public override void change(string choice)
    {
        switch (choice)
        {
            case "a":
                Console.WriteLine("Enter the new first name!");
                string fname = Console.ReadLine();
                if (this.first_name != fname)
                {
                    this.first_name = fname;
                    Console.WriteLine("First name has been updated");
                }
                else
                {
                    Console.WriteLine("First name is the same");
                }
                break;
            case "b":
                Console.WriteLine("Enter the new last name!");
                string lname = Console.ReadLine();
                if (this.last_name != lname)
                {
                    this.last_name = lname;
                    Console.WriteLine("New name has been updated");
                }
                else
                {
                    Console.WriteLine("First name is the same");
                }
                break;
            case "c":
                Console.WriteLine("Enter the new salary");
                int salary;
                try
                {
                    salary = int.Parse(Console.ReadLine());
                    if (this.salary != salary)
                    {
                        this.salary = salary;
                        Console.WriteLine("Salary has been updated");
                    }
                    else
                    {
                        Console.WriteLine("Salary is the same");
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid entry");
                }
                break;
            default:
                Console.WriteLine("Something else was chosen ... ");
                break;
        }
    }
    
    public override string Showing()
    {
        return $"{base.Showing()} Role: Teacher";
    }
}