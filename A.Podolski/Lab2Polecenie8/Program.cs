using System;

class Program
{
    static void Main()
    {
        int x = 1; // Początkowa wartość x

        // Pętla while
        while (x <= 20)
        {
            int y = 2 * x + 1; // Obliczenie wartości funkcji y = 2x + 1
            Console.WriteLine($"Dla x = {x}, y = {y}");
            x++; // Zwiększenie wartości x
        }

        // Zgłoszenie zakończenia realizacji polecenia
        Console.WriteLine("Zakończenie realizacji polecenia.");
    }
}
// W pentli WHILE najpierw jest sprawdzony warunek i dopiero zapada decyzja czy wykonywać program czy nie, a w pentli DO WHILE najpierw wykonywany jest kod, a później następuje sprawdzenie warunku, jeśli jest prawdziwy to kod wykonywany jest ponownie, zapewnia to że kod zostanie wykonany przynajmniej 1 raz nawet jeśli warunek nie jest spełniony 