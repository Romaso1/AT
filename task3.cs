using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        try
        {
            
            Console.Write("Введіть розмір першого масиву: ");
            int size1 = int.Parse(Console.ReadLine());
            int[] array1 = new int[size1];
            Console.WriteLine("Введіть елементи для першого масиву:");
            for (int i = 0; i < size1; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

           
            Console.Write("Введіть розмір другого масиву: ");
            int size2 = int.Parse(Console.ReadLine());
            int[] array2 = new int[size2];
            Console.WriteLine("Введіть елементи для другого масиву:");
            for (int i = 0; i < size2; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

            // перетнин
            HashSet<int> set1 = new HashSet<int>(array1);
            List<int> intersection = new List<int>();
            foreach (int num in array2)
            {
                if (set1.Contains(num))
                {
                    intersection.Add(num);
                }
            }

            
            Console.WriteLine("Перетин двох масивів:");
            foreach (int num in intersection)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < intersection.Count; i++)
            {
                map[i] = intersection[i];
            }

            //HashMap операції
            
            map.Add(100, 200);
            Console.WriteLine("Додано пару ключ-значення: 100 - 200");

           
            map.Remove(100);
            Console.WriteLine("Видалено пару ключ-значення з ключем 100");

            
            Console.Write("Введіть ключ для перевірки його наявності: ");
            int checkKey = int.Parse(Console.ReadLine());
            Console.WriteLine(map.ContainsKey(checkKey) ? "Ключ присутній" : "Ключ відсутній");

           
            Console.Write("Введіть ключ для пошуку значення: ");
            int findKey = int.Parse(Console.ReadLine());
            if (map.TryGetValue(findKey, out int value))
            {
                Console.WriteLine("Значення для ключа {0}: {1}", findKey, value);
            }
            else
            {
                Console.WriteLine("Ключ не знайдено.");
            }

            
            Console.WriteLine("Усі ключі та значення в мапі:");
            foreach (var pair in map)
            {
                Console.WriteLine("Ключ: {0}, Значення: {1}", pair.Key, pair.Value);
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Помилка формату! Будь ласка, введіть ціле число.");
        }
    }
}
