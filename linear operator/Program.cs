using System;

class Program
{
    static void Main()
    {
        // 1. 
        Console.Write("1. Введіть перше число (день): ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("   Введіть друге число (місяць): ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        if (number1 >= 1 && number1 <= 31 && number2 >= 1 && number2 <= 12)
            Console.WriteLine("   Ці числа можуть бути днем та місяцем.");
        else
            Console.WriteLine("   Ці числа не можуть бути днем та місяцем.");

        // 2. 
        Console.Write("2. Введіть дійсне число: ");
        double number = Convert.ToDouble(Console.ReadLine());


        string numberAsString = number.ToString("F3");
        int firstDigit = int.Parse(numberAsString[2].ToString());
        int secondDigit = int.Parse(numberAsString[3].ToString());

        int sum = firstDigit + secondDigit;

        Console.WriteLine($"   Сума перших двох знаків після коми: {firstDigit} + {secondDigit} = {sum}");

        // 3. 
        Console.Write("3. Введіть ціле число (година): ");
        int h = Convert.ToInt32(Console.ReadLine());

        if (h >= 0 && h < 6)
            Console.WriteLine("   Доброї ночі!");
        else if (h >= 6 && h < 12)
            Console.WriteLine("   Доброго ранку!");
        else if (h >= 12 && h < 18)
            Console.WriteLine("   Добрий день!");
        else
            Console.WriteLine("   Добрий вечір!");

        // 4. 
        Console.Write("4. Введіть перше ціле число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("   Введіть друге ціле число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("   Введіть третє ціле число: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

        int max = Math.Max(Math.Max(num1, num2), num3);
        int min = Math.Min(Math.Min(num1, num2), num3);

        Console.WriteLine($"   Максимальне число: {max}");
        Console.WriteLine($"   Мінімальне число: {min}");

        // 5. 
        Console.Write("5. Введіть довжину прямокутника: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("   Введіть ширину прямокутника: ");
        double width = Convert.ToDouble(Console.ReadLine());

        double area = length * width;
        Console.WriteLine($"   Площа прямокутника: {area}");

        // 6
        Console.Write("6. Введіть ціле число: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
            Console.WriteLine($"   {num} є парним числом.");
        else
            Console.WriteLine($"   {num} є непарним числом.");

        // 7. 
        Console.Write("7. Введіть температуру в градусах Цельсія: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"   Температура в градусах Фаренгейта: {fahrenheit}");

        // 8.
        Console.Write("8. Введіть n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sumN = (n * (n + 1)) / 2;
        Console.WriteLine($"   Сума перших {n} натуральних чисел: {sumN}");
    }
}
