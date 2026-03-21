using System;
using System.IO;
using System.Xml.Serialization;


[Serializable]
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

internal static class XMLSerializationExample
{
    static void Main(string[] args)
    {
        Person person = new Person { Name = "Mohamed Ragheb", Age = 18};

        // Serialization
        XmlSerializer serializer = new XmlSerializer(typeof(Person));
        using (TextWriter writer = new StreamWriter("person.txt"))
        {
            serializer.Serialize(writer, person);
        }

        // Deserialization
        using (TextReader reader = new StreamReader("person.txt"))
        {
            Person deserializedPerson = (Person)serializer.Deserialize(reader);
            Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
        }
    }
}
