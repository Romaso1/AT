using System;
using System.Reflection;

public class CustomClass
{
    public int Number { get; set; }
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        // Створення об'єкта та заповнення даними
        CustomClass obj = new CustomClass { Number = 10, Name = "Тестове ім'я" };

        // Отримання полів і їх типів
        Console.WriteLine("Поля об'єкта:");
        Type type = obj.GetType();
        foreach (FieldInfo field in type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic))
        {
            Console.WriteLine($"{field.Name} - {field.FieldType}");
        }

        // Вибір конкретного поля та зміна його значення
        Console.WriteLine("\nОб'єкт перед зміною:");
        Console.WriteLine($"Number: {obj.Number}, Name: {obj.Name}");

        FieldInfo fieldToChange = type.GetField("<Number>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance);
        if (fieldToChange != null)
        {
            fieldToChange.SetValue(obj, 20);  // Зміна значення поля
        }

        Console.WriteLine("\nОб'єкт після зміни:");
        Console.WriteLine($"Number: {obj.Number}, Name: {obj.Name}");
    }
}
