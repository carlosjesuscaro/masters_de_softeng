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
}