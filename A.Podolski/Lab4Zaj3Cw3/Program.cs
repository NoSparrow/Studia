using System;

class Program
{
    static void Main()
    {
        // Poproszenie użytkownika o podanie liczby
        Console.Write("Podaj liczbę: ");
        int n = int.Parse(Console.ReadLine());

        // Zmienna do przechowywania wyniku silni
        long silnia = 1;

        // Obliczanie silni za pomocą pętli for
        for (int i = 1; i <= n; i++)
        {
            silnia *= i;
        }

        // Wyświetlanie wyniku
        Console.WriteLine($"Silnia z {n} wynosi: {silnia}");
    }
}
