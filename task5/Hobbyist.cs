using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("hobbyist")]
public class Hobbyist
{
    [XmlElement("Id")]
    public int Id { get; set; }

    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlArray("Hobbies")]
    [XmlArrayItem("string")]
    public List<string> Hobbies { get; set; }

    public Hobbyist() { }

    public Hobbyist(int id, string name, List<string> hobbies)
    {
        Id = id;
        Name = name;
        Hobbies = hobbies;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Hobbies: {string.Join(", ", Hobbies)}";
    }
}
