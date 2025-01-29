using System;

class Program
{
    static void Main()
    {
        int[] tab1 = new int[10];

        // Wypełnienie tablicy liczbami od 9 do 0
        for (int i = 0; i < tab1.Length; i++)
        {
            tab1[i] = 9 - i;
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
