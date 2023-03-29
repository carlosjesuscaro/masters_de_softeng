// See https://aka.ms/new-console-template for more information

using DataStructures;

LinkedList<string> strLList = new LinkedList<string>();
LinkedList<Person> persList = new LinkedList<Person>();

persList.AddLast(new Person("Clement", "Ziane", "France"));
persList.AddFirst(new Person("Carlos", "Jesus", "Peru"));
persList.AddAfter(persList.First, new Person("Alyson", "Caro", "Sweden"));
persList.AddBefore(persList.First, new Person("Natalia", "Jesus Caro", "Canada"));

LinkedListNode<Person>? anchor = persList.First;

while (anchor != null)
{
    if (anchor.Value.Firstname == "Natalia")
    {
        break;
    }
    else
    {
        anchor = anchor.Next;
    }
}

persList.AddAfter(anchor, new Person("Lucas", "Jesus Caro", "Canada"));

foreach (Person person in persList)
{
    Console.WriteLine(person);
}


