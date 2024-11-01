using System;
using System.Collections.Generic;

public class GenericClass<T>
{
    private List<T> items = new List<T>();

    // Додає елемент до списку
    public void Add(T item)
    {
        items.Add(item);
    }

    // Виводить усі елементи
    public void PrintAll()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}

class Program
{
    static void Main()
    {
        // Створення об'єкта GenericClass для зберігання цілих чисел
        GenericClass<int> intList = new GenericClass<int>();
        intList.Add(1);
        intList.Add(2);
        intList.Add(3);
        Console.WriteLine("Список цілих чисел:");
        intList.PrintAll();

        // Створення об'єкта GenericClass для зберігання рядків
        GenericClass<string> stringList = new GenericClass<string>();
        stringList.Add("Привіт");
        stringList.Add("Світ");
        Console.WriteLine("\nСписок рядків:");
        stringList.PrintAll();
    }
}
