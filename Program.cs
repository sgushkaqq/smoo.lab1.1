using System;
using System.IO;

class Program
{
    static void Main()
    {
        double xmin, xmax;
        int count, format;

        // Зчитування з LAB2.TXT
        using (StreamReader reader = new StreamReader("LAB2.TXT"))
        {
            xmin = double.Parse(reader.ReadLine());
            xmax = double.Parse(reader.ReadLine());
            count = int.Parse(reader.ReadLine());
            format = int.Parse(reader.ReadLine());
        }

        double step = (xmax - xmin) / (count - 1);

        double[] xValues = new double[count];
        double[] yValues = new double[count];

        for (int i = 0; i < count; i++)
        {
            double x = xmin + i * step;
            double y = Math.Sqrt(x + Math.Sqrt(3 * x));
            xValues[i] = x;
            yValues[i] = y;
        }

        using (StreamWriter writer = new StreamWriter("LAB2.RES"))
        {
            if (format == 2)
            {
                writer.WriteLine("Таблиця:");
                writer.WriteLine("*******************************");
                writer.WriteLine("*   X   *    Y                *");
                writer.WriteLine("*******************************");

                for (int i = 0; i < count; i++)
                {
                    writer.WriteLine($"* {xValues[i],5:F2} * {yValues[i],17:F3} *");
                }

                writer.WriteLine("*******************************");
                writer.WriteLine("Таблицю склав студент ФЕКІ: <П. І. ПБ>");
            }
            else
            {
                writer.WriteLine("Невідомий формат виводу.");
            }
        }

        Console.WriteLine("Готово. Результат записано у файл LAB2.RES.");
    }
}