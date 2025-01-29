using System;

class Program
{
    static void Main()
    {
        // Pętla for dla x zmieniającego się w przedziale od 1 do 20
        for (int x = 1; x <= 20; x++)   // wartość początkowa | warunek | inkrementacja (x = x + 1)
        {
            // Obliczanie wartości funkcji y = 2x + 1
            int y = 2 * x + 1;

            // Wyświetlanie wyniku
            Console.WriteLine($"Dla x = {x}, y = {y}");
        }

        // Zgłoszenie zakończenia realizacji polecenia
        Console.WriteLine("\nZakończenie realizacji polecenia.");
    }
}
