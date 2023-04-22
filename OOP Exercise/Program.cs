// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

static void Main()
{
    Console.WriteLine("\nWelcome to the Student Management System");
    Console.WriteLine("\nPlease enter one of the following options:\n");
    bool session = true;

    while (session)
    {
        session = Options(session);
    }
}

static bool Options(bool power)
{
    Console.WriteLine("1. Show details");
    Console.WriteLine("2. Edit");
    Console.WriteLine("3. Add a person");
    Console.WriteLine("4. Exit");

    string answer = Console.ReadLine().ToLower();
    switch (answer)
    {
        case "4":
            Console.WriteLine("Good bye!");
            power = false;
            break;
        case "1":
            Console.WriteLine("you chose 1");
            Thread.Sleep(2000);
            power = true;
            break;
        case "2":
            Console.WriteLine("you chose 2");
            power = true;
            break;
        case "3":
            Console.WriteLine("you chose 3");
            power = true;
            break;
        default: 
            Console.WriteLine("Incorrect entry, try again");
            power = true;
            break;
    }
    return power;
}

Main();