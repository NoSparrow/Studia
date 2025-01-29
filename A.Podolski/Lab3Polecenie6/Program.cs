using System;

class Program
{
    static void Main()
    {
        int[,] tab1 = new int[10, 10];
        Random rand = new Random();

        // Wypełnienie tablicy losowymi liczbami z przedziału 0-999
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                tab1[i, j] = rand.Next(0, 1000);
            }
        }

        // Wyświetlenie tablicy z wyrównaniem kolumn
        Console.WriteLine("Tablica 10x10:");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(tab1[i, j].ToString().PadLeft(4) + " "); //Każda liczba ma zarezerwowane 4 znaki szerokości
            }
            Console.WriteLine();
        }
    }
}
