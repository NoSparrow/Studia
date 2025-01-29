using System;

class Program
{
    static void Main()
    {
        int[] tab1 = new int[20];
        Random rand = new Random();

        // Wypełnienie tablicy losowymi liczbami z przedziału 0-9
        for (int i = 0; i < tab1.Length; i++)
        {
            tab1[i] = rand.Next(0, 10);
        }

        // Wyświetlenie tablicy na ekranie
        Console.WriteLine("Indeks | Wartość");
        Console.WriteLine("----------------");
        for (int i = 0; i < tab1.Length; i++) 
        {
            Console.WriteLine($"   {i}   |    {tab1[i]}");
        }
    }
}
