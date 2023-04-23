namespace OOP_Exercise;

internal class Student: Person
{
    public int year { get; set; }
    public Student(string first, string last, int year) : base(first, last)
    {
        this.year = year;
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
                Console.WriteLine("Enter the new year");
                int year;
                try
                {
                    year = int.Parse(Console.ReadLine());
                    if (this.year != year)
                    {
                        this.year = year;
                        Console.WriteLine("Year has been updated");
                    }
                    else
                    {
                        Console.WriteLine("Year is the same");
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
        return $"{base.Showing()} Role: Student";
    }
}