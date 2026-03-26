using System;
using System.IO;
using System.Runtime.Serialization.Json;

[Serializable]
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person() { }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

internal static class JsonSerializationExample
{
    static void Main(string[] args)
    {
        Person person = new Person("Mohamed", 18);

        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Person));

        // JSON Serialization
        using (MemoryStream stream = new MemoryStream())
        {
            // Serialize the person in JSON format and save in 'stream'
            serializer.WriteObject(stream, person);

            // Get the JSON string from 'stream' by converting it to binary and convert it again to string 
            string jsonString = System.Text.Encoding.UTF8.GetString(stream.ToArray());

            // Save the json string in a file (optional)
            File.WriteAllText("person.json", jsonString);
        }


        // JSON Deserialization
        using (FileStream stream = new FileStream("person.json", FileMode.Open))
        {
            // Deserialize the person
            Person deserializedPerson = (Person)serializer.ReadObject(stream);

            Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
        }
    }
}
