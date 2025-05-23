using System;

class Program
{
    static void Main()
    {
        int score = 0;

        Console.WriteLine("1. Професор ліг спати о 8 годині, а встав о 9 годині. Скільки годин проспав професор?");
        if (Console.ReadLine() == "1") score++;

        Console.WriteLine("2. На двох руках десять пальців. Скільки пальців на 10?");
        if (Console.ReadLine() == "50") score++;

        Console.WriteLine("3. Скільки цифр у дюжині?");
        if (Console.ReadLine() == "12") score++;

        Console.WriteLine("4. Скільки потрібно зробити розпилів, щоб розпиляти колоду на 12 частин?");
        if (Console.ReadLine() == "11") score++;

        Console.WriteLine("5. Ліхтар зробив три уколи в інтервалі 30 хвилин. Скільки часу він витратив?");
        if (Console.ReadLine() == "20") score++;

        Console.WriteLine("6. Скільки буде 9 в результаті 1100?");
        if (Console.ReadLine() == "2") score++;

        Console.WriteLine("7. Птахи мали 30 очей. Усі, окрім однієї, розбіглися. Скільки очей лишилося?");
        if (Console.ReadLine() == "2") score++;

        // Виведення оцінки
        Console.Write("Результат: ");
        switch (score)
        {
            case 7:
                Console.WriteLine("Геній");
                break;
            case 6:
                Console.WriteLine("Ерудит");
                break;
            case 5:
                Console.WriteLine("Нормальний");
                break;
            case 4:
                Console.WriteLine("Здібності середні");
                break;
            case 3:
                Console.WriteLine("Здібності нижче середнього");
                break;
            default:
                Console.WriteLine("Вам треба відпочити");
                break;
        }
    }
}