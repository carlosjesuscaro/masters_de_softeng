namespace OOP_Exercise;

internal class Person
{
    public string first_name { get; set;  }
    public string last_name { get; set;  }

    public Person(string first, string last)
    {
        this.first_name = first;
        this.last_name = last;
    }

    public Person changeFirst (string first)
    {
        if (this.first_name != first)
        {
            this.first_name = first;
            Console.WriteLine("First name has been updated");
            return this;
        }
        else
        {
            Console.WriteLine("First name is the same");
            return this;
        }
    }

    public Person changeLast(string last)
    {
        if (this.last_name != last)
        {
            this.last_name = last;
            Console.WriteLine("Last name has been updated");
            return this;
        }
        else
        {
            Console.WriteLine("Last name is the same");
            return this;
        }
    }

    public virtual string Showing()
    {
        return $"First name: {this.first_name} Last name: {this.last_name}";
    }
}