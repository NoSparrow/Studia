using System;

class Program
{
    static void Main()
    {
        int[,] tab1 = new int[4, 6];
        Random rand = new Random();

        // Wypełnienie tablicy losowymi liczbami z przedziału 100-999
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                tab1[i, j] = rand.Next(100, 1000);
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
    }
}
