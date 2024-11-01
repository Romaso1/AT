using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        // JSON обробка
        JsonSerialization();

        // XML обробка
        XmlSerialization();

        // Робота зі Stream
        StreamOperations();
    }

    static void JsonSerialization()
    {
        // Читання JSON з файлу "input.json"
        string jsonInput = File.ReadAllText("input.json");
        Hobbyist hobbyist = JsonSerializer.Deserialize<Hobbyist>(jsonInput);

        // Зміна даних
        hobbyist.Name = "Alice";
        hobbyist.Hobbies.Add("swimming");

        // Збереження у "output.json"
        string jsonOutput = JsonSerializer.Serialize(hobbyist, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText("output.json", jsonOutput);

        Console.WriteLine("JSON обробка завершена: дані збережено до output.json");
    }

    static void XmlSerialization()
    {
        // XML обробка
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Hobbyist));
        Hobbyist hobbyist;

        // Читання з "input.xml"
        using (FileStream fs = new FileStream("input.xml", FileMode.Open))
        {
            hobbyist = (Hobbyist)xmlSerializer.Deserialize(fs);
        }

        // Зміна даних
        hobbyist.Name = "Alice";
        hobbyist.Hobbies.Add("swimming");

        // Збереження у "output.xml"
        using (FileStream fs = new FileStream("output.xml", FileMode.Create))
        {
            xmlSerializer.Serialize(fs, hobbyist);
        }

        Console.WriteLine("XML обробка завершена: дані збережено до output.xml");
    }

    static void StreamOperations()
    {
        // Генерація та обробка
        var random = new Random();
        List<Hobbyist> hobbyists = new List<Hobbyist>();
        for (int i = 0; i < 10; i++)
        {
            hobbyists.Add(new Hobbyist
            {
                Id = random.Next(1, 1000),
                Name = $"Hobbyist {i + 1}",
                Hobbies = new List<string> { "reading", "cooking", "hiking" }
            });
        }

        // Сортування
        var sortedHobbyists = hobbyists.OrderBy(h => h.Id).ThenBy(h => h.Name).ToList();
        Console.WriteLine("Сортування за Id та Name:");
        sortedHobbyists.ForEach(h => Console.WriteLine(h));

        // Фільтрація
        var filteredHobbyists = hobbyists.Where(h => h.Id > 500 && h.Hobbies.Contains("reading")).ToList();
        Console.WriteLine("\nФільтр Id > 500 та хобі 'reading':");
        filteredHobbyists.ForEach(h => Console.WriteLine(h));

        // Колекціонування
        var namesList = hobbyists.Select(h => h.Name).ToList();
        Console.WriteLine("\nІмена у списку:");
        namesList.ForEach(Console.WriteLine);
    }
}
