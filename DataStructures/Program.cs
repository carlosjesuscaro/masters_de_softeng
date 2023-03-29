// See https://aka.ms/new-console-template for more information

using DataStructures;

// LinkedList
// ==========
LinkedList<string> strLList = new LinkedList<string>();
LinkedList<Person> persList = new LinkedList<Person>();

persList.AddLast(new Person("Clement", "Ziane", "France"));
persList.AddFirst(new Person("Carlos", "Jesus", "Peru"));
persList.AddAfter(persList.First, new Person("Alyson", "Caro", "Sweden"));
persList.AddBefore(persList.First, new Person("Natalia", "Jesus Caro", "Canada"));

LinkedListNode<Person>? anchor = persList.First;

// Adding a new element after a specific element
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

// Listing all elements from the linkedlist
foreach (Person person in persList)
{
    Console.WriteLine(person);
}

// Getting one specific element
Person p = persList.ElementAt(1);
Console.WriteLine(p);

// List / ArrayList
// =================

List<Person> pallist = new List<Person>();
pallist.Add(new Person("Waldo", "Jesus Caro", "Peru"));
pallist.RemoveAt(0);
pallist.Add(new Person("Carlos", "Jesus Caro", "Peru"));
pallist.Add(new Person("Alyson", "Jesus Caro", "Finland"));
pallist.Add(new Person("Natalia", "Jesus Caro", "Canada"));
pallist.Add(new Person("Lucas", "Jesus Caro", "Canada"));

int length = pallist.Count();
Console.WriteLine($"\nThe list has {length} elements");

// Looping through the list
for (int i = 0; i < length; i++)
{
    Person person = pallist[i];
    Console.WriteLine($"\n{person}");
}

foreach (Person person in pallist)
{
    Console.WriteLine($"\n{person}");
}

// Stack
// ======

Stack<Person> stack = new Stack<Person>();
stack.Push(new Person("Carlos", "Jesus Caro", "Peru"));
stack.Push(new Person("Alyson", "Jesus Caro", "Finland"));
stack.Push(new Person("Natalia", "Jesus Caro", "Canada"));
stack.Push(new Person("Lucas", "Jesus Caro", "Canada"));

Console.WriteLine($"\nStack length: {stack.Count}");

// Looping options
foreach (Person peep in stack)
{
    Console.WriteLine(peep);
}

while (stack.Count > 0)
{
    Person perst = stack.Pop();
    Console.WriteLine(perst);
    Console.WriteLine($"Stack count within the loop: {stack.Count}");
}
Console.WriteLine($"Stack count: {stack.Count}");

// Dictionary
// ==========

Dictionary<string, Person> dictPers  = new Dictionary<string, Person>();
Person perstoinsert = new Person("Carlos", "Jesus Caro", "Peru");
dictPers[perstoinsert.Fullname] = perstoinsert;
perstoinsert = new Person("Alyson", "Jesus Caro", "Finland");
dictPers[perstoinsert.Fullname] = perstoinsert;
perstoinsert = new Person("Natalia", "Jesus Caro", "Canada");
dictPers[perstoinsert.Fullname] = perstoinsert;
perstoinsert = new Person("Lucas", "Jesus Caro", "Canada");
dictPers[perstoinsert.Fullname] = perstoinsert;
perstoinsert = new Person("Waldo", "Jesus Caro", "Haiti");
dictPers[perstoinsert.Fullname] = perstoinsert;

Person retrieve = dictPers["Carlos Jesus Caro"];
Console.WriteLine($"\n{retrieve}");

Console.WriteLine("\nLooping through keys");
foreach (string key in dictPers.Keys)
{
    Console.WriteLine(key);
}

Console.WriteLine("\nLooping through values");
foreach (Person value in dictPers.Values)
{
    Console.WriteLine(value);
}

dictPers.Remove("Waldo Jesus Caro");
int cnt = dictPers.Count;
Console.WriteLine($"\nThe length of the dictionary is {cnt}");
