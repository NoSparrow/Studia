using System;

class Program
{
    static void Main()
    {
        int[,] tab1 = new int[4, 6];
        Random rand = new Random();
        int sum = 0;
        int max = int.MinValue, min = int.MaxValue;
        int maxRow = 0, maxCol = 0, minRow = 0, minCol = 0;

        // Wypełnienie tablicy losowymi liczbami z przedziału 100-999
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                tab1[i, j] = rand.Next(100, 1000);
                sum += tab1[i, j];

                if (tab1[i, j] > max)
                {
                    max = tab1[i, j];
                    maxRow = i;
                    maxCol = j;
                }
                if (tab1[i, j] < min)
                {
                    min = tab1[i, j];
                    minRow = i;
                    minCol = j;
                }
            }
        }

        // Wyświetlenie tablicy na ekranie
        Console.WriteLine("Tablica 4x6:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.Write(tab1[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"\nSuma wszystkich elementów: {sum}");
        Console.WriteLine($"Maksymalna wartość: {max} (Indeksy: [{maxRow}, {maxCol}])");
        Console.WriteLine($"Minimalna wartość: {min} (Indeksy: [{minRow}, {minCol}])");

        // Transpozycja tablicy
        int[,] tab2 = new int[6, 4];
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                tab2[j, i] = tab1[i, j];
            }
        }

        // Wyświetlenie transponowanej tablicy
        Console.WriteLine("\nTablica transponowana (6x4):");
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(tab2[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
