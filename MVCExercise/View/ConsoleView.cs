using MVCExercise.Model;

namespace MVCExercise.View;

internal class ConsoleView
{
    public void printChoice()
    {
        Console.WriteLine("What mwould you like to do?");
        Console.WriteLine("1 - Show details");
        Console.WriteLine("2 - Edit");
        Console.WriteLine("3 - Add a person");
        Console.WriteLine("4 - Remove a person");
        Console.WriteLine("5 - Exit");
    }

    public void printAddChoice()
    {
        Console.WriteLine("What do you want to create?");
        Console.WriteLine("1 - Teacher");
        Console.WriteLine("2 - Student");
    }

    public void printPersonDetails(Person p)
    {
        Console.WriteLine(p);
    }

    private void printSelectPerson(List<Person> all)
    {
        int index = 1;
        foreach (Person p in all)
        {
            string personType = p.GetType() == typeof(Student) ? "Student" : "Teacher";
            Console.WriteLine($"{index} - {p.first_name} {personType}");
        }
    }

    public void ViewDetailsChoice(List<Person> all)
    {
        Console.WriteLine("Who do you want to see?");
        this.printSelectPerson(all);
    }

    public void editChoice(List<Person> all)
    {
        Console.WriteLine("Who do you want to edit?");
        this.printSelectPerson(all);
    }

    public void deleteChoise(List<Person> all)
    {
        Console.WriteLine("Who do you want to delete?");
        this.printSelectPerson(all);
    }

    public string getInputString(string inputName)
    {
        Console.WriteLine($"{inputName} : ");
        return Console.ReadLine();
    }

    public int getInputInt(string inputName)
    {
        Console.WriteLine($"{inputName} : ");
        try
        {
            return int.Parse(Console.ReadLine());
        }
        catch
        {
            return -1;
        }
    }

    public char? getInputChar(string inputName)
    {
        Console.WriteLine($"{inputName} : ");
        string input = Console.ReadLine();
        return input.Length > 0 ? input[0] : null;
    }

}