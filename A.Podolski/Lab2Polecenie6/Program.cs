using System;

class Program
{
    static void Main()
    {
        int x = 1; // Początkowa wartość x

        // Pętla do...while
        do
        {
            int y = 2 * x + 1; // Obliczenie wartości funkcji y = 2x + 1
            Console.WriteLine($"Dla x = {x}, y = {y}");
            x++; // Zwiększenie wartości x
        }
        while (x <= 20); // Warunek zakończenia pętli (x zmienia się od 1 do 20)

        // Zgłoszenie zakończenia realizacji polecenia
        Console.WriteLine("Zakończenie realizacji polecenia.");
    }
}
