using System;
using System.Text;

namespace ComprehensiveExample
{
    class Task2
    {
        static void Main(string[] args)
        {
            // V1
            int a = 10;
            int b = 5;
            Console.WriteLine("Додавання: " + (a + b));
            Console.WriteLine("Віднімання: " + (a - b));
            Console.WriteLine("Множення: " + (a * b));
            Console.WriteLine("Ділення: " + (a / b));

            // V2
            if (a > b)
            {
                Console.WriteLine("a більше ніж b");
            }
            else if (a < b)
            {
                Console.WriteLine("a менше ніж b");
            }
            else
            {
                Console.WriteLine("a дорівнює b");
            }

            // V3
            Console.WriteLine("Цикл for:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Цикл while:");
            int j = 1;
            while (j <= 10)
            {
                Console.WriteLine(j);
                j++;
            }

            // V4
            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Елементи масиву:");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            Console.WriteLine("Сума елементів масиву: " + sum);

            // V5
            string str = "Hello World";
            Console.WriteLine("Довжина: " + str.Length);
            Console.WriteLine("Підрядок (0-5): " + str.Substring(0, 5));
            Console.WriteLine("Індекс 'World': " + str.IndexOf("World"));
            Console.WriteLine("Верхній регістр: " + str.ToUpper());
            Console.WriteLine("Нижній регістр: " + str.ToLower());

            // V6
            string str1 = "Hello";
            string str2 = "World";
            string str3 = str1 + " " + str2;
            Console.WriteLine("Конкатенована строка: " + str3);

            // V7
            Console.WriteLine("Equals: " + str1.Equals(str2));
            Console.WriteLine("CompareTo: " + str1.CompareTo(str2));

            // V8
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append(" ");
            sb.Append("World");
            Console.WriteLine("StringBuilder результат: " + sb.ToString());

            // V9
            string tokensStr = "Hello World Java Programming";
            string[] tokens = tokensStr.Split(' ');
            foreach (string token in tokens)
            {
                Console.WriteLine(token);
            }

            // V10
            char ch = 'a';
            Console.WriteLine("Is Digit: " + Char.IsDigit(ch));
            Console.WriteLine("Is Letter: " + Char.IsLetter(ch));
            Console.WriteLine("To Uppercase: " + Char.ToUpper(ch));
            Console.WriteLine("To Lowercase: " + Char.ToLower(ch));

            // V11
            string name = "John";
            float salary = 5000.50f;
            string formattedString = String.Format("Ім'я працівника: {0}, Зарплата: {1:F2}", name, salary);
            Console.WriteLine(formattedString);

            // V12
            char[] charArray = { 'a', 'e', 'i', 'o', 'u', 'b', 'c' };
            Console.WriteLine("Елементи масиву символів:");
            foreach (char c in charArray)
            {
                Console.WriteLine(c);
            }

            int vowelCount = 0;
            foreach (char c in charArray)
            {
                if ("aeiou".IndexOf(c) != -1)
                {
                    vowelCount++;
                }
            }
            Console.WriteLine("Кількість голосних: " + vowelCount);

            // V13
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Елементи масиву цілих чисел:");
            foreach (int i in intArray)
            {
                Console.WriteLine(i);
            }

            int oddCount = 0;
            foreach (int i in intArray)
            {
                if (i % 2 != 0)
                {
                    oddCount++;
                }
            }
            Console.WriteLine("Кількість непарних чисел: " + oddCount);

            // V14
            int num = 100;
            string numString = num.ToString();
            int parsedNum = Int32.Parse(numString);
            Console.WriteLine("Ціле число до строк: " + numString);
            Console.WriteLine("Строка до цілого числа: " + parsedNum);

            // V15
            int x = 5;
            int y = 3;
            Console.WriteLine("AND: " + (x & y));
            Console.WriteLine("OR: " + (x | y));
            Console.WriteLine("XOR: " + (x ^ y));
            Console.WriteLine("NOT: " + (~x));
            Console.WriteLine("Зсув вліво: " + (x << 1));
            Console.WriteLine("Зсув вправо: " + (x >> 1));

            // V16
            DayOfWeek today = DayOfWeek.Monday;
            switch (today)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Це понеділок.");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Це вівторок.");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Це середа.");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Це четвер.");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Це п'ятниця.");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Це субота.");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Це неділя.");
                    break;
            }

            // V17
            Console.Write("Введіть ваше ім'я: ");
            string userName = Console.ReadLine();
            Console.Write("Введіть ваш вік: ");
            int userAge = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Привіт, " + userName + "! Вам " + userAge + " років.");

            // V18
            Console.Write("Введіть довжину прямокутника: ");
            double length = Double.Parse(Console.ReadLine());
            Console.Write("Введіть ширину прямокутника: ");
            double width = Double.Parse(Console.ReadLine());
            double area = length * width;
            double perimeter = 2 * (length + width);
            Console.WriteLine("Площа прямокутника: " + area);
            Console.WriteLine("Периметр прямокутника: " + perimeter);

            // ROI Calculation
            int manualTestingHours = 100;
            int automationTestingHours = 50;
            double hourlyRate = 50;
            double setupCosts = 5000;

            double manualTestingCost = manualTestingHours * hourlyRate;
            double automationTestingCost = (automationTestingHours * hourlyRate) + setupCosts;
            double netWorthAutomationTesting = automationTestingCost - manualTestingCost;
            double roi = (netWorthAutomationTesting / manualTestingCost) * 100;

            Console.WriteLine("Вартість ручного тестування: $" + manualTestingCost);
            Console.WriteLine("Вартість автоматизації тестування: $" + automationTestingCost);
            Console.WriteLine("Чиста вартість автоматизації тестування: $" + netWorthAutomationTesting);
            Console.WriteLine("ROI автоматизації тестування: " + roi + "%");
        }

        enum DayOfWeek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
    }
}
