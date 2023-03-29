namespace DataStructures;

public class Person
{
    public string Firstname;
    public string Lastname;
    public string Country;
    public string Fullname
    {
        get { return $"{this.Firstname} {this.Lastname}"; }
    }

    public Person(string firstname, string lastname, string country)
    {
        this.Firstname = firstname;
        this.Lastname = lastname;
        this.Country = country;
    }

    public override string ToString()
    {
        return $"{this.Fullname} - {this.Country}";
    }

}