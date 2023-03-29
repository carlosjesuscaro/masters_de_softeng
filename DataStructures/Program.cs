﻿// See https://aka.ms/new-console-template for more information

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

