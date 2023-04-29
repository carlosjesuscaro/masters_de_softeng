using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace OOP_Exercise;
internal class  App
{
    public bool start { get; set; }
    private List<Person> people;

    public App()
    {
        this.people = new List<Person>();
        this.start = true;
    }

    public void Operation()
    {
        while (this.start)
        {
            Console.WriteLine("\nWelcome to the Student Management System");
            Console.WriteLine("\nPlease enter one of the following options:\n");
            
            Console.WriteLine("1. Show details");
            Console.WriteLine("2. Edit");
            Console.WriteLine("3. Add a person");
            Console.WriteLine("4. Exit");

            string answer = Console.ReadLine().ToLower();
            switch (answer)
            {
                case "1":
                    Console.WriteLine("Option selected: 'Show details'");
                    Show(this.people);
                    break;
                case "2":
                    Console.WriteLine("Option selected: 'Edit'");
                    Edit(this.people);
                    break;
                case "3":
                    Console.WriteLine("Option selected: 'Add a person'");
                    this.start = addPeople(this.people);
                    break;
                case "4":
                    Console.WriteLine("Good bye!");
                    this.start = false;
                    break;
                default:
                    Console.WriteLine("Incorrect entry, try again!");
                    break;
            }
        }
    }
    
    public bool addPeople(List<Person> people)
    {
        Console.WriteLine("Press (1) to add a teacher or (2) to add a student");
        string addAnswer = Console.ReadLine();
        string fname;
        string lname;
        
        if (addAnswer == "1" || addAnswer == "2")
        {
            Console.WriteLine("Enter first name: ");
            fname = Console.ReadLine().ToString();
            Console.WriteLine("Enter last name: ");
            lname = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Wrongn entry, good bye!");
            return false;
        }

        switch (addAnswer)
        {
            case "1":
                Console.WriteLine("Enter the salary:");
                try
                {
                    int salary = int.Parse(Console.ReadLine());
                    people.Add(new Teacher(first: fname, last: lname, salary:salary));
                    Console.WriteLine("New teacher has been added");
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong entry");
                    return false;
                }
            case "2":
                Console.WriteLine("Enter the year:");
                try
                {
                    int year = int.Parse(Console.ReadLine());
                    people.Add(new Student(first: fname, last: lname, year: year));
                    Console.WriteLine("New student has been added");
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong entry");
                    return false;
                }
            default:
                Console.WriteLine("Wrong entry, good bye!");
                return false;
        }
    }

    public void Show(List<Person> people)
    {
        int index = 0;
        foreach (var subject in people)
        {
            Console.WriteLine($"[{index}] {subject.Showing()}");
            index++;
        }
    }

    public void Edit(List<Person> people)
    {
        Console.WriteLine("Enter the index of the person to edit:");
        int choice;
        try
        {
            choice = int.Parse(Console.ReadLine());
            if (choice < people.Count())
            {
                changeMenu(people, choice);
            }
        }
        catch
        {
            Console.WriteLine("Invalid entry");
        }
        
    }

    public void changeMenu(List<Person> people, int index)
    {
        
        Console.WriteLine("Choose what you want to change:");
        string message = "(A) First name, (B) Last name or ";
        if (people[index] is Teacher)
        {
            message += "(C) Salary";
        } else if (people[index] is Student)
        {
            message += "(C) Year";
        }
        Console.WriteLine(message);

        string usr_choice = Console.ReadLine().ToLower();
        people[index].change(usr_choice);
    }
}