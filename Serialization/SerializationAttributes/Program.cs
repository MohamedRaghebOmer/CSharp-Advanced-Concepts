using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    //[NonSerialized]
    public string Address;

    public Person() { }

    public Person(string name, int age, string address)
    {
        Name = name;
        Age = age;
        Address = address;
    }
}

internal static class BinarySerializationExample
{
    static void Main(string[] args)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        // Binary Serialization
        using (FileStream stream = new FileStream("person.bin", FileMode.Create))
        {
            // Address is non-serializable, so it will be ignored
            formatter.Serialize(stream, new Person("Mohamed", 18, "Egypt"));
        }

        // Binary Deserialization
        using (FileStream stream = new FileStream("person.bin", FileMode.Open))
        {
            Person deserializedPerson = (Person)formatter.Deserialize(stream);
            Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}, Address: {deserializedPerson.Address}");
        }
    }
}