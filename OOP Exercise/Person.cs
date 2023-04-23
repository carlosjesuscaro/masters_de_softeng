namespace OOP_Exercise;

internal abstract class Person
{
    public string first_name { get; set;  }
    public string last_name { get; set;  }

    public Person(string first, string last)
    {
        this.first_name = first;
        this.last_name = last;
    }

    public virtual void change (string choice)
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
            default:
                Console.WriteLine("Naranjas");
                break;
        }
    }
    

    public virtual string Showing()
    {
        return $"First name: {this.first_name} Last name: {this.last_name}";
    }
}