using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;


[Serializable]
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person() { } // Serializer must find an empty constructor to be able to work

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

internal static class XMLSerializationExample
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>();

        for (int i = 1; i <= 100; i++)
        {
            people.Add(new Person($"Name{i}", i));
        }

        XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));

        // Serialization
        using (TextWriter writer = new StreamWriter("People.xml"))
        {
            serializer.Serialize(writer, people);
        }

        // Deserialization
        List<Person> loadedPeople;
        using (StreamReader reader = new StreamReader("People.xml"))
        {
            loadedPeople = (List<Person>)serializer.Deserialize(reader);
        }

        foreach (var p in loadedPeople)
        {
            Console.WriteLine($"Name: {p.Name}, Age: {p.Age}");
        }
    }
}
