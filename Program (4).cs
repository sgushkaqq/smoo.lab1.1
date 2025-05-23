using System;

class Program
{
    static void Main()
    {
        double distance = 2000;
        double[] weights = { 500, 1000, 1500, 2000 };
        double[] fuelRates = { 1, 4, 7, 10 }; 
        double fuelCapacity = 3000;

        for (int i = 0; i < weights.Length; i++)
        {
            double rate = fuelRates[i];
            double fuelNeeded = rate * distance;

            Console.WriteLine($"Вага вантажу: {weights[i]} кг");
            if (fuelNeeded <= fuelCapacity)
                Console.WriteLine($"Можливо перевезти напряму. Потрібно пального: {fuelNeeded} л");
            else
                Console.WriteLine("Неможливо перевезти вантаж за один раз з повним баком.");
            Console.WriteLine();
        }
    }
}